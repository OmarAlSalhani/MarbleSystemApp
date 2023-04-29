using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
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
    public partial class HomeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomeForm()
        {
            InitializeComponent();
            this.FormClosing += HomeForm_FormClosing;
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style", Properties.Settings.Default.PaletteName);
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = Properties.Settings.Default;
            settings.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
            settings.Save();
        }

        private void customers_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomersForm form = new CustomersForm();
            form.ShowDialog();
        }

        private void cost_calculation_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            CostCalculationForm form = new CostCalculationForm();
            form.ShowDialog();
        }

        private void products_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void sell_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SellForm form = new SellForm();
            form.ShowDialog();
        }

        private void suppliers_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SuppliersForm form = new SuppliersForm();
            form.ShowDialog();
        }

        private void price_offer_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SellOfferForm form = new SellOfferForm();
            form.ShowDialog();
        }

        private void sales_report_btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalesReportForm form = new SalesReportForm();
            form.ShowDialog();  
        }
    }
}