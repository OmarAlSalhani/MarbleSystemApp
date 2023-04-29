using DevExpress.XtraEditors;
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
    public partial class ProductsForm : ParentForm
    {
        public ProductsForm()
        {
            InitializeComponent();
            my_actions_uc1.OnNewClick += My_actions_uc1_OnNewClick;
            my_actions_uc1.OnSaveClick += My_actions_uc1_OnSaveClick;
            my_actions_uc1.OnUpdateClick += My_actions_uc1_OnUpdateClick;
            my_actions_uc1.OnDeleteClick += My_actions_uc1_OnDeleteClick;
            customGridView11.RowCellClick += CustomGridView11_RowCellClick;


            thread_class thread = new thread_class(this, () => { loadData(); });
        }

        void loadData()
        {
            connection_class db = new connection_class();
            customGrid11.DataSource = db.select("select * from products_view order by الرقم desc");
        }
        string ColumnValue(DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e, int column_index)
        {
            return customGridView11.GetRowCellValue(e.RowHandle, customGridView11.Columns[column_index].FieldName).ToString();
        }
        private void CustomGridView11_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            id = int.Parse(ColumnValue(e, 0));
            the_name_tb.TextBoxText = ColumnValue(e, 1);
            size_tb.TextBoxText = ColumnValue(e, 2);
            my_actions_uc1.EditMode();
        }

        private void My_actions_uc1_OnDeleteClick(object sender, EventArgs e)
        {
            if (notifications_class.yes_no() == OmarMessageBox.Enums.MessageResult.YES)
            {
                product model = new product();
                model.Delete(id);
                my_actions_uc1.new_btn.PerformClick();
            }

        }

        private void My_actions_uc1_OnUpdateClick(object sender, EventArgs e)
        {
            if (validate_class.validateTextBoxes(tableLayoutPanel3))
            {
                if (notifications_class.yes_no() == OmarMessageBox.Enums.MessageResult.YES)
                {
                    product model = new product();
                    model.Update(product());
                    my_actions_uc1.new_btn.PerformClick();
                }
            }
        }

        private void My_actions_uc1_OnSaveClick(object sender, EventArgs e)
        {
            if (validate_class.validateTextBoxes(tableLayoutPanel3))
            {
                product model = new product();
                model.Insert(product());
                my_actions_uc1.new_btn.PerformClick();
            }
        }

        private void My_actions_uc1_OnNewClick(object sender, EventArgs e)
        {
            clear_class.clearAll(tableLayoutPanel3);
            thread_class thread = new thread_class(this, () => { loadData(); });

        }

        public int id { get; set; }
        product product()
        {
            return new product
            {
                id = id,
                the_name = the_name_tb.TextBoxText,
                the_size = size_tb.TextBoxText
            };
        }
    }
    public class product
    {
        public int id { get; set; }
        public string the_name { get; set; }
        public string the_size { get; set; }
        public void Insert(product model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Insert_product", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@the_name", model.the_name);
            command.Parameters.AddWithValue("@the_size", model.the_size);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تمت الإضافة بنجاح");
        }
        public void Update(product model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Update_product", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@the_name", model.the_name);
            command.Parameters.AddWithValue("@the_size", model.the_size);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تم التعديل بنجاح");
        }
        public void Delete(int id)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Delete_product", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close(); notifications_class.success("تم الحذف بنجاح");
        }
    }
}