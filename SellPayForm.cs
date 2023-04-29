using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleSystemApp
{
    public partial class SellPayForm : ParentForm
    {
        public SellPayForm(string total)
        {
            InitializeComponent();
            total_tb.TextBoxText = total;
            paied_tb.OnTextChange += Products_cost_tb_OnTextChange;
            discount_percent_tb.OnTextChange += Agel_percent_tb_OnTextChange;
            discount_value_tb.OnTextChange += Agel_value_tb_OnTextChange;
        }
        private void Agel_value_tb_OnTextChange(object sender, EventArgs e)
        {
            discount_percent_tb.TextBoxText = "0";
            SetTotalAmountValue();
        }

        void SetTotalAmountValue()
        {
            float total = float.Parse(total_tb.TextBoxText);
            float paied = float.Parse(paied_tb.TextBoxText);
            float discount_value = float.Parse(discount_value_tb.TextBoxText);
            float discount_percent = float.Parse(discount_percent_tb.TextBoxText.Replace("%", ""));
            float discount = 0;
            if (discount_percent > 0)
            {
                discount = (total - paied) * discount_percent / 100;
            }
            else
            {
                discount = discount_value;
            }
            float final_amount = total - paied - discount;
            final_amount_tb.TextBoxText = final_amount.ToString();
        }

        private void Agel_percent_tb_OnTextChange(object sender, EventArgs e)
        {
            discount_value_tb.TextBoxText = "0";
            SetTotalAmountValue();
        }

        private void Products_cost_tb_OnTextChange(object sender, EventArgs e)
        {
            SetTotalAmountValue();

        }
        public pay_class pay_class = null;
        private void is_cheque_cb_OnIndexChanged(object sender, EventArgs e)
        {
            my_group_uc1.Enabled = is_cheque_cb.SelectedIndex == 0 ? false : true;
        }
        public bool IsPrint = false;
        private void pay_btn_Click(object sender, EventArgs e)
        {
            pay_class = new pay_class
            {
                bank_name = bank_name_tb.TextBoxText,
                cheque_date = cheque_date_tb.TextBoxText,
                cheque_holder_name = cheque_holder_name_tb.TextBoxText,
                cheque_mobile = cheque_mobile_tb.TextBoxText,
                cheque_number = cheque_number_tb.TextBoxText,
                discount_percent = float.Parse(discount_percent_tb.TextBoxText),
                discount_value = float.Parse(discount_value_tb.TextBoxText),
                is_cheque = is_cheque_cb.SelectedIndex,
                paied = float.Parse(paied_tb.TextBoxText),
                total = total_tb.TextBoxText
            };

            Close();
        }

        private void pay_and_print_btn_Click(object sender, EventArgs e)
        {
            IsPrint = true;
            pay_class = new pay_class
            {
                bank_name = bank_name_tb.TextBoxText,
                cheque_date = cheque_date_tb.TextBoxText,
                cheque_holder_name = cheque_holder_name_tb.TextBoxText,
                cheque_mobile = cheque_mobile_tb.TextBoxText,
                cheque_number = cheque_number_tb.TextBoxText,
                discount_percent = float.Parse(discount_percent_tb.TextBoxText.Replace("%", "")),
                discount_value = float.Parse(discount_value_tb.TextBoxText),
                is_cheque = is_cheque_cb.SelectedIndex,
                paied = float.Parse(paied_tb.TextBoxText),
                total = total_tb.TextBoxText
            };

            Close();
        }
    }
}
