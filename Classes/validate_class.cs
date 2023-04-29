using DevExpress.XtraEditors;
using OmarControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleSystemApp
{
    class validate_class
    {
        /// <summary>
        ///  لمعرفة هل تم أدخال قيمة في التكست بوكس بحال كانت القيمة مطلوبة
        ///
        /// </summary>
        /// <returns>
        /// True : تم أدخال القيمة
        /// False : لم يتم أدخال القيمة
        /// </returns>
        public static bool validateTextBoxes(Control groupControl)
        {
            List<bool> list = new List<bool>();
            for (int i = 0; i < groupControl.Controls.Count; i++)
            {
                if (groupControl.Controls[i] is my_textbox)
                {
                    my_textbox textBox = groupControl.Controls[i] as my_textbox;
                    if (textBox.IsRequired)
                        list.Add(textBox.DoValidate());
                }
                if (groupControl.Controls[i] is my_memo)
                {
                    my_memo textBox = groupControl.Controls[i] as my_memo;
                    if (textBox.IsRequired)
                        list.Add(textBox.DoValidate());
                }
            }
            return list.Contains(false) ? false : true;
        }
    }
}
