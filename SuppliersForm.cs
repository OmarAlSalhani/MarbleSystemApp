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
    public partial class SuppliersForm : ParentForm
    {
        public SuppliersForm()
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
            customGrid11.DataSource = db.select("select * from suppliers_view order by الرقم desc");
        }
        string ColumnValue(DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e, int column_index)
        {
            return customGridView11.GetRowCellValue(e.RowHandle, customGridView11.Columns[column_index].FieldName).ToString();
        }
        private void CustomGridView11_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            id = int.Parse(ColumnValue(e, 0));
            the_name_tb.TextBoxText = ColumnValue(e, 1);
            mobile_tb.TextBoxText = ColumnValue(e, 2);
            notes_tb.TextBoxText = ColumnValue(e, 3);
            my_actions_uc1.EditMode();
        }

        private void My_actions_uc1_OnDeleteClick(object sender, EventArgs e)
        {
            if (notifications_class.yes_no() == OmarMessageBox.Enums.MessageResult.YES)
            {
                supplier model = new supplier();
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
                    supplier model = new supplier();
                    model.Update(supplier());
                    my_actions_uc1.new_btn.PerformClick();
                }
            }
        }

        private void My_actions_uc1_OnSaveClick(object sender, EventArgs e)
        {
            if (validate_class.validateTextBoxes(tableLayoutPanel3))
            {
                supplier model = new supplier();
                model.Insert(supplier());
                my_actions_uc1.new_btn.PerformClick();
            }
        }

        private void My_actions_uc1_OnNewClick(object sender, EventArgs e)
        {
            clear_class.clearAll(tableLayoutPanel3);
            thread_class thread = new thread_class(this, () => { loadData(); });

        }

        public int id { get; set; }
        supplier supplier()
        {
            return new supplier
            {
                id = id,
                the_name = the_name_tb.TextBoxText,
                mobile = mobile_tb.TextBoxText,
                notes = notes_tb.TextBoxText
            };
        }
    }
    public class supplier
    {
        public int id { get; set; }
        public string the_name { get; set; }
        public string mobile { get; set; }
        public string notes { get; set; }


        public void Insert(supplier model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Insert_supplier", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@the_name", model.the_name);
            command.Parameters.AddWithValue("@notes", model.notes);
            command.Parameters.AddWithValue("@mobile", model.mobile);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تمت الإضافة بنجاح");
        }
        public void Update(supplier model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Update_supplier", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@the_name", model.the_name);
            command.Parameters.AddWithValue("@notes", model.notes);
            command.Parameters.AddWithValue("@mobile", model.mobile);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تم التعديل بنجاح");
        }
        public void Delete(int id)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Delete_supplier", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close(); notifications_class.success("تم الحذف بنجاح");
        }
    }
}