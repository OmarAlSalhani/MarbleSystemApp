using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarbleSystemApp
{
    public static class open_form_class
    {
       


        public static void open(XtraForm form)
        {
            if(form.IsDisposed) return;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        public static void open(XtraForm form, bool maximize = false)
        {
            if (form.IsDisposed) return;
            form.WindowState = maximize ? System.Windows.Forms.FormWindowState.Maximized : System.Windows.Forms.FormWindowState.Normal;
            form.FormBorderStyle =maximize?System.Windows.Forms.FormBorderStyle.Sizable: System.Windows.Forms.FormBorderStyle.FixedDialog;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
