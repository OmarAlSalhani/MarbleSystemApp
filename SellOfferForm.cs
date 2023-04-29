using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OmarControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleSystemApp
{
    public partial class SellOfferForm : ParentForm
    {
        public SellOfferForm()
        {
            InitializeComponent();
            my_date1.TheDate = DateTime.Now;
            thread_class thread = new thread_class(this, () => { loadCustomers(); });
            customer_lue.OnPlusClicked += Customer_lue_OnPlusClicked;
            customGridView11.CellValueChanged += CustomGridView11_CellValueChanged;
            customGridView11.RowCountChanged += CustomGridView11_RowCountChanged;
            connection_class db = new connection_class();
            DataTable table = db.select($"select id,the_name from product_table");

            repositoryItemLookUpEdit1.DataSource = table;
            repositoryItemLookUpEdit1.ValueMember = "id";
            repositoryItemLookUpEdit1.DisplayMember = "the_name";

            // Enable the "best-fit" functionality mode in which columns have proportional widths and the popup window is resized to fit all the columns.
            repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            // Specify the dropdown height.
            repositoryItemLookUpEdit1.DropDownRows = table.Rows.Count;
            repositoryItemLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            // Specify the column against which an incremental search is performed in SearchMode.AutoComplete and SearchMode.OnlyInPopup modes
            repositoryItemLookUpEdit1.AutoSearchColumnIndex = 1;
        }

        private void CustomGridView11_RowCountChanged(object sender, EventArgs e)
        {
            SetGridTotal();
        }

        private void CustomGridView11_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colprice || e.Column == colqty)
            {
                float qty = 1;
                float price = 0;
                if (customGridView11.GetFocusedRowCellValue(colqty) != null)
                {
                    qty = float.Parse(customGridView11.GetFocusedRowCellValue(colqty).ToString());
                }
                if (customGridView11.GetFocusedRowCellValue(colprice) != null)
                {
                    price = float.Parse(customGridView11.GetFocusedRowCellValue(colprice).ToString());
                }
                float total = qty * price;
                customGridView11.SetFocusedRowCellValue(coltotal, total);
            }
            SetGridTotal();
        }

        private void Customer_lue_OnPlusClicked(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();
            form.ShowDialog();
            thread_class thread = new thread_class(this, () => { loadCustomers(); });
        }

        void loadCustomers()
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"select id as N'الرقم',the_name as N'العميل' from customer_table");
            customer_lue.fill(table, "العميل", "الرقم");
        }
        bool isOk()
        {
            if (customer_lue.TextBoxText.Trim().Length == 0)
            {
                notifications_class.info("الرجاء أختيار العميل");
                return false;
            }
            if (customGridView11.RowCount == 0)
            {
                notifications_class.info("الرجاء أختيار الأصناف أولاً");
                return false;
            }
            return true;
        }

        public int id { get; set; }
        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            var id = lue.EditValue;
            connection_class db = new connection_class();
            DataTable table = db.select($"select the_size from product_Table where id={id}");
            customGridView11.SetFocusedRowCellValue(colsize, table.Rows[0][0]);
            customGridView11.SetFocusedRowCellValue(colprice, 0);
            customGridView11.SetFocusedRowCellValue(colqty, 1);
            customGridView11.SetFocusedRowCellValue(coltotal, 0);
            customGridView11.SetFocusedRowCellValue(colunit, "");
        }
        void SetGridTotal()
        {
            float total = 0;
            for (int i = 0; i < customGridView11.RowCount; i++)
            {
                total += float.Parse(customGridView11.GetRowCellValue(i, coltotal).ToString());
            }
            total_tb.TextBoxText = total.ToString();
        }
        // مشان رجع رقم عرض السعر بعد ما اعملها اضافة
        string getHeadId()
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"select max(id) from sell_offer_head_table");
            return table.Rows[0][0].ToString();
        }
        private void open_pay_form_btn_Click(object sender, EventArgs e)
        {
            if (isOk())
            {
                sell_offer_head head = new sell_offer_head
                {
                    customer_id = int.Parse(customer_lue.EditValue.ToString()),
                    notes = my_textbox1.TextBoxText,
                    the_date = my_date1.TextBoxText
                };
                head.Insert(head);
                string head_id = getHeadId();
                for (int i = 0; i < customGridView11.RowCount; i++)
                {
                    sell_offer_body body = new sell_offer_body
                    {
                        head_id = head_id,
                        price = float.Parse(customGridView11.GetRowCellValue(i, colprice).ToString()),
                        product_id = int.Parse(customGridView11.GetRowCellValue(i, colproduct).ToString()),
                        qty = float.Parse(customGridView11.GetRowCellValue(i, colqty).ToString()),
                        unit_name = customGridView11.GetRowCellValue(i, colunit).ToString(),
                    };
                    body.Insert(body);
                }
                SellReport report = new SellReport();
                report.Print(true, head_id,total_tb.TextBoxText);
                Close();
            }

        }

        private void customGrid11_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            customGridView11.DeleteRow(customGridView11.FocusedRowHandle);

        }
    }
    public class sell_offer_head
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public string the_date { get; set; }
        public string notes { get; set; }

        public void Insert(sell_offer_head model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);

            SqlCommand command = new SqlCommand("Insert_sell_offer_head", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@customer_id", model.customer_id);
            command.Parameters.AddWithValue("@the_date", model.the_date);
            command.Parameters.AddWithValue("@notes", model.notes);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(sell_offer_head model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);

            SqlCommand command = new SqlCommand("Update_sell_offer_head", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@customer_id", model.customer_id);
            command.Parameters.AddWithValue("@the_date", model.the_date);
            command.Parameters.AddWithValue("@notes", model.notes);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int id)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);

            SqlCommand command = new SqlCommand("Delete_sell_offer_head", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    public class sell_offer_body
    {
        public int id { get; set; }
        public string head_id { get; set; }
        public int product_id { get; set; }
        public string unit_name { get; set; }
        public float qty { get; set; }
        public float price { get; set; }

        public void Insert(sell_offer_body model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Insert_sell_offer_body", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@head_id", model.head_id);
            command.Parameters.AddWithValue("@product_id", model.product_id);
            command.Parameters.AddWithValue("@unit_name", model.unit_name);
            command.Parameters.AddWithValue("@qty", model.qty);
            command.Parameters.AddWithValue("@price", model.price);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(sell_offer_body model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);

            SqlCommand command = new SqlCommand("Update_sell_offer_body", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@head_id", model.head_id);
            command.Parameters.AddWithValue("@product_id", model.product_id);
            command.Parameters.AddWithValue("@unit_name", model.unit_name);
            command.Parameters.AddWithValue("@qty", model.qty);
            command.Parameters.AddWithValue("@price", model.price);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int id)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Delete_sell_offer_body", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}