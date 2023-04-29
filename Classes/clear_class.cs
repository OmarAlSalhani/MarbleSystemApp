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
    class clear_class
    {
        /// <summary>
        /// لتفريغ كافة التكست بوكس
        /// </summary>
        /// <param name="groupControl"></param>
        public static void clearAll(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is my_textbox)
                {
                    my_textbox textBox = control.Controls[i] as my_textbox;
                    textBox.TextBoxText = string.Empty;
                    continue;
                }
                if (control.Controls[i] is my_combobox)
                {
                    my_combobox textBox = control.Controls[i] as my_combobox;
                    textBox.SelectedIndex = 0;
                    continue;
                }
                if (control.Controls[i] is my_memo)
                {
                    my_memo textBox = control.Controls[i] as my_memo;
                    textBox.TextBoxText = string.Empty;
                    continue;
                }
                if (control.Controls[i] is my_lookup)
                {
                    my_lookup textBox = control.Controls[i] as my_lookup;
                    textBox.EditValue = -1;
                    continue;
                }
                if (control.Controls[i] is my_date)
                {
                    my_date textBox = control.Controls[i] as my_date;
                    textBox.TheDate = DateTime.Now;
                    continue;
                }
                if (control.Controls[i] is PictureEdit)
                {
                    PictureEdit textBox = control.Controls[i] as PictureEdit;
                    textBox.Image = null;
                    continue;
                }
            }
        }
    }
}
