using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace MarbleSystemApp
{
    public partial class SellReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SellReport()
        {
            InitializeComponent();
        }
        public void Print(bool isSellOffer, string id, string total)
        {
            SellReport report = new SellReport();
            report.header_lbl.Text = isSellOffer ? "عرض سعر" : "فاتورة مبيعات";
            report.DataSource = isSellOffer ? getSellOfferHead(id) : getSellInvoiceHead(id);
            report.DetailReport.DataSource = isSellOffer ? getSellOfferBody(id) : getSellInvoiceBody(id);
            report.total_tb.Text = total;
            report.sell_footer.Visible = !isSellOffer;
            report.total_table.Visible = isSellOffer;
            report.xrTableCell3.Text = isSellOffer ? "رقم العرض :" :"رقم الفاتورة :";
            report.ShowPreview();
        }
        DataTable getSellInvoiceHead(string id)
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"select * from sell_head_print_view where id={id}");
            return table;

        }
        DataTable getSellOfferHead(string id)
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"select * from sell_offer_head_print_view where id={id}");
            return table;

        }
        DataTable getSellInvoiceBody(string id)
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"SELECT ROW_NUMBER() OVER(ORDER BY head_id) AS row_num,
the_name,the_size,unit_name,qty,price,total
from sell_body_print_view
where head_id={id}");
            return table;
        }
        DataTable getSellOfferBody(string id)
        {
            connection_class db = new connection_class();
            DataTable table = db.select($@"SELECT ROW_NUMBER() OVER(ORDER BY head_id) AS row_num,
the_name,the_size,unit_name,qty,price,total
from sell_offer_body_print_view
where head_id={id}");
            return table;
        }
    }
}
