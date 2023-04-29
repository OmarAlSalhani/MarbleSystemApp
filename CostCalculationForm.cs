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
    public partial class CostCalculationForm : ParentForm
    {
        public CostCalculationForm()
        {
            InitializeComponent();
            my_actions_uc1.OnNewClick += My_actions_uc1_OnNewClick;
            my_actions_uc1.OnSaveClick += My_actions_uc1_OnSaveClick;
            my_actions_uc1.OnUpdateClick += My_actions_uc1_OnUpdateClick;
            my_actions_uc1.OnDeleteClick += My_actions_uc1_OnDeleteClick;
            thread_class thread = new thread_class(this, () => { loadCustomers(); });
            customer_lue.OnPlusClicked += Customer_lue_OnPlusClicked;
            products_cost_tb.OnTextChange += Products_cost_tb_OnTextChange;
            tools_cost_tb.OnTextChange += Products_cost_tb_OnTextChange;
            agel_percent_tb.OnTextChange += Agel_percent_tb_OnTextChange;
            agel_value_tb.OnTextChange += Agel_value_tb_OnTextChange;
        }

        private void Agel_value_tb_OnTextChange(object sender, EventArgs e)
        {
            agel_percent_tb.TextBoxText = "0";
            SetTotalAmountValue();
        }
        void SetTotalAmountValue()
        {
            float products_cost = float.Parse(products_cost_tb.TextBoxText);
            float tools_cost = float.Parse(tools_cost_tb.TextBoxText);
            float agel_value = float.Parse(agel_value_tb.TextBoxText);
            float agel_percent = float.Parse(agel_percent_tb.TextBoxText.Replace("%", ""));
            float agel = 0;
            if (agel_percent > 0)
            {
                agel = (products_cost + tools_cost) * agel_percent / 100;
            }
            else
            {
                agel = agel_value;
            }
            float total = products_cost + tools_cost + agel;
            total_tb.TextBoxText = total.ToString();
        }

        private void Agel_percent_tb_OnTextChange(object sender, EventArgs e)
        {
            agel_value_tb.TextBoxText = "0";
            SetTotalAmountValue();
        }

        private void Products_cost_tb_OnTextChange(object sender, EventArgs e)
        {
            SetTotalAmountValue();

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
        private void My_actions_uc1_OnDeleteClick(object sender, EventArgs e)
        {
            if (notifications_class.yes_no() == OmarMessageBox.Enums.MessageResult.YES)
            {
                cost_calculation model = new cost_calculation();
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
                    cost_calculation model = new cost_calculation();
                    model.Update(cost_calculation());
                    my_actions_uc1.new_btn.PerformClick();
                }
            }
        }
        bool isOk()
        {
            if (customer_lue.TextBoxText.Trim().Length == 0)
            {
                notifications_class.info("الرجاء أختيار العميل");
                return false;
            }
            if (subject_tb.TextBoxText.Trim().Length == 0)
            {
                notifications_class.info("الرجاء أدخال الموضوع");
                return false;
            }
            return true;
        }
        private void My_actions_uc1_OnSaveClick(object sender, EventArgs e)
        {
            if (isOk())
            {
                cost_calculation model = new cost_calculation();
                model.Insert(cost_calculation());
                my_actions_uc1.new_btn.PerformClick();
            }
        }

        private void My_actions_uc1_OnNewClick(object sender, EventArgs e)
        {
            clear_class.clearAll(tableLayoutPanel3);

        }

        public int id { get; set; }
        cost_calculation cost_calculation()
        {
            return new cost_calculation
            {
                id = id,
                customer_id = customer_lue.EditValue.ToString(),
                subject = subject_tb.TextBoxText,
                products_description = products_description_tb.TextBoxText,
                products_cost = products_cost_tb.TextBoxText,
                tools_description = tools_description_tb.TextBoxText,
                tools_cost = tools_cost_tb.TextBoxText,
                agel_value = agel_value_tb.TextBoxText,
                agel_percent = agel_percent_tb.TextBoxText
            };
        }
    }
    public class cost_calculation
    {
        public int id { get; set; }
        public string customer_id { get; set; }
        public string subject { get; set; }
        public string products_description { get; set; }
        public string products_cost { get; set; }
        public string tools_description { get; set; }
        public string tools_cost { get; set; }
        public string agel_percent { get; set; }
        public string agel_value { get; set; }


        public void Insert(cost_calculation model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Insert_cost_calculation", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@customer_id", model.customer_id);
            command.Parameters.AddWithValue("@subject", model.subject);
            command.Parameters.AddWithValue("@products_description", model.products_description);
            command.Parameters.AddWithValue("@products_cost", model.products_cost.Replace(",", ""));
            command.Parameters.AddWithValue("@tools_description", model.tools_description);
            command.Parameters.AddWithValue("@tools_cost", model.tools_cost.Replace(",", ""));
            command.Parameters.AddWithValue("@agel_percent", model.agel_percent.Replace("%", ""));
            command.Parameters.AddWithValue("@agel_value", model.agel_value.Replace(",", ""));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تمت الإضافة بنجاح");
        }
        public void Update(cost_calculation model)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Update_cost_calculation", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@customer_id", model.customer_id);
            command.Parameters.AddWithValue("@subject", model.subject);
            command.Parameters.AddWithValue("@products_description", model.products_description);
            command.Parameters.AddWithValue("@products_cost", model.products_cost.Replace(",", ""));
            command.Parameters.AddWithValue("@tools_description", model.tools_description);
            command.Parameters.AddWithValue("@tools_cost", model.tools_cost.Replace(",", ""));
            command.Parameters.AddWithValue("@agel_percent", model.agel_percent.Replace("%", ""));
            command.Parameters.AddWithValue("@agel_value", model.agel_value.Replace(",", ""));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تم التعديل بنجاح");
        }
        public void Delete(int id)
        {
            connection_class db = new connection_class();
            SqlConnection connection = new SqlConnection(db._connectionString);
            SqlCommand command = new SqlCommand("Delete_cost_calculation", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            notifications_class.success("تم الحذف بنجاح");
        }
    }
}