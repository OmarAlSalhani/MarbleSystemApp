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
    public partial class SalesReportForm : ParentForm
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }
        void loadData()
        {
            connection_class db = new connection_class();
            customGrid11.DataSource = db.select($@"select * from sell_report_view where
[التاريخ] between
('{my_from_to_date1.from_date}') and ('{my_from_to_date1.to_date}')
order by [رقم الفاتورة] desc");
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            thread_class thread = new thread_class(this, () => { loadData(); });

        }
    }
}