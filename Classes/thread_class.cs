using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarbleSystemApp
{
    class thread_class
    {
       public thread_class(Control form, MethodInvoker method)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    form.Invoke(method);
                }
                else method();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
