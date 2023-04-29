using DevExpress.XtraEditors;
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
    public partial class ParentForm : DevExpress.XtraEditors.XtraForm
    {
        public ParentForm()
        {
            InitializeComponent();
        }
        public string header { get => labelControl1.Text; set => labelControl1.Text = value; }
    }
}