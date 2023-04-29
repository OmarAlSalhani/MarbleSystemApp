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
    public partial class SellForm : ParentForm
    {
        public SellForm()
        {
            InitializeComponent();
            my_date1.TheDate = DateTime.Now;
            thread_class thread = new thread_class(this, () => { loadCustomers(); });
            customer_lue.OnPlusClicked += Customer_lue_OnPlusClicked;
            customGridView11.CellValueChanged += CustomGridView11_CellValueChanged;

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
        string GridTotal()
        {
            float total = 0;
            for (int i = 0; i < customGridView11.RowCount; i++)
            {
                total += float.Parse(customGridView11.GetRowCellValue(i, coltotal).ToString());
            }
            return total.ToString();
        }

        // مشان رجع رقم الفاتورة بعد ما اعملها اضافة
        string getHeadId()
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"select max(id) from sell_head_table");
            return table.Rows[0][0].ToString();
        }
        private void open_pay_form_btn_Click(object sender, EventArgs e)
        {
            if (isOk())
            {
                SellPayForm form = new SellPayForm(GridTotal());
                form.ShowDialog();
                if (form.pay_class != null)
                {
                    sell_head head = new sell_head
                    {
                        _pay = form.pay_class,
                        customer_id = int.Parse(customer_lue.EditValue.ToString()),
                        notes = my_textbox1.TextBoxText,
                        the_date = my_date1.TextBoxText
                    };
                    head.Insert(head);
                    string head_id = getHeadId();
                    for (int i = 0; i < customGridView11.RowCount; i++)
                    {
                        sell_body body = new sell_body
                        {
                            head_id = head_id,
                            price = customGridView11.GetRowCellValue(i, colprice).ToString(),
                            product = int.Parse(customGridView11.GetRowCellValue(i, colproduct).ToString()),
                            qty = customGridView11.GetRowCellValue(i, colqty).ToString(),
                            unit = customGridView11.GetRowCellValue(i, colunit).ToString(),
                        };
                        body.Insert(body);
                    }
                    if (form.IsPrint)
                    {
                        SellReport report = new SellReport();
                        report.Print(false,head_id,"");
                        Close();
                    }
                    else
                    {
                        notifications_class.success("تم الحفظ بنجاح");
                        Close();
                    }

                    // Save it
                }
            }

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            customGridView11.DeleteRow(customGridView11.FocusedRowHandle);
        }
    }
    public class sell_body
    {
        public int id { get; set; }
        public string head_id { get; set; }
        public int product { get; set; }
        public string size { get; set; }
        public string unit { get; set; }
        public string qty { get; set; }
        public string price { get; set; }
        public string total { get; set; }
        public void Insert(sell_body model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);

            SqlCommand command = new SqlCommand("Insert_sell_body", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@head_id", model.head_id);
            command.Parameters.AddWithValue("@product_id", model.product);
            command.Parameters.AddWithValue("@unit_name", model.unit);
            command.Parameters.AddWithValue("@qty", model.qty);
            command.Parameters.AddWithValue("@price", model.price);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(sell_body model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Update_sell_body", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@head_id", model.head_id);
            command.Parameters.AddWithValue("@product_id", model.product);
            command.Parameters.AddWithValue("@unit_name", model.unit);
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

            SqlCommand command = new SqlCommand("Delete_sell_body", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    public class pay_class
    {
        public string total { get; set; }
        public float paied { get; set; }
        public int is_cheque { get; set; }
        public float discount_percent { get; set; }
        public float discount_value { get; set; }
        public string bank_name { get; set; }
        public string cheque_holder_name { get; set; }
        public string cheque_date { get; set; }
        public string cheque_number { get; set; }
        public string cheque_mobile { get; set; }
    }
    public class sell_head
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public string the_date { get; set; }
        public string notes { get; set; }
        public pay_class _pay { get; set; }


        public void Insert(sell_head model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Insert_sell_head", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@customer_id", model.customer_id);
            command.Parameters.AddWithValue("@the_date", model.the_date);
            command.Parameters.AddWithValue("@notes", model.notes);
            command.Parameters.AddWithValue("@is_cheque", model._pay.is_cheque);
            command.Parameters.AddWithValue("@paied", model._pay.paied);
            command.Parameters.AddWithValue("@discount_percent", model._pay.discount_percent);
            command.Parameters.AddWithValue("@discount_value", model._pay.discount_value);
            command.Parameters.AddWithValue("@bank_name", model._pay.bank_name);
            command.Parameters.AddWithValue("@cheque_holder_name", model._pay.cheque_holder_name);
            command.Parameters.AddWithValue("@cheque_number", model._pay.cheque_number);
            command.Parameters.AddWithValue("@cheque_date", model._pay.cheque_date);
            command.Parameters.AddWithValue("@cheque_mobile", model._pay.cheque_mobile);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(sell_head model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Update_sell_head", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@customer_id", model.customer_id);
            command.Parameters.AddWithValue("@the_date", model.the_date);
            command.Parameters.AddWithValue("@notes", model.notes);
            command.Parameters.AddWithValue("@is_cheque", model._pay.is_cheque);
            command.Parameters.AddWithValue("@paied", model._pay.paied);
            command.Parameters.AddWithValue("@discount_percent", model._pay.discount_percent);
            command.Parameters.AddWithValue("@discount_value", model._pay.discount_value);
            command.Parameters.AddWithValue("@bank_name", model._pay.bank_name);
            command.Parameters.AddWithValue("@cheque_holder_name", model._pay.cheque_holder_name);
            command.Parameters.AddWithValue("@cheque_number", model._pay.cheque_number);
            command.Parameters.AddWithValue("@cheque_date", model._pay.cheque_date);
            command.Parameters.AddWithValue("@cheque_mobile", model._pay.cheque_mobile);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int id)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Delete_sell_head", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}