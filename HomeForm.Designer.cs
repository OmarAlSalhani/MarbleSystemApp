namespace MarbleSystemApp
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.customers_btn = new DevExpress.XtraBars.BarButtonItem();
            this.cost_calculation_btn = new DevExpress.XtraBars.BarButtonItem();
            this.products_btn = new DevExpress.XtraBars.BarButtonItem();
            this.sell_btn = new DevExpress.XtraBars.BarButtonItem();
            this.suppliers_btn = new DevExpress.XtraBars.BarButtonItem();
            this.price_offer_btn = new DevExpress.XtraBars.BarButtonItem();
            this.sales_report_btn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.customers_btn,
            this.cost_calculation_btn,
            this.products_btn,
            this.sell_btn,
            this.suppliers_btn,
            this.price_offer_btn,
            this.sales_report_btn,
            this.skinPaletteDropDownButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(991, 232);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // customers_btn
            // 
            this.customers_btn.Caption = "العملاء";
            this.customers_btn.Id = 1;
            this.customers_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("customers_btn.ImageOptions.SvgImage")));
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.customers_btn_ItemClick);
            // 
            // cost_calculation_btn
            // 
            this.cost_calculation_btn.Caption = "حساب التكلفة";
            this.cost_calculation_btn.Id = 2;
            this.cost_calculation_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cost_calculation_btn.ImageOptions.SvgImage")));
            this.cost_calculation_btn.Name = "cost_calculation_btn";
            this.cost_calculation_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cost_calculation_btn_ItemClick);
            // 
            // products_btn
            // 
            this.products_btn.Caption = "الأصناف";
            this.products_btn.Id = 3;
            this.products_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("products_btn.ImageOptions.SvgImage")));
            this.products_btn.Name = "products_btn";
            this.products_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.products_btn_ItemClick);
            // 
            // sell_btn
            // 
            this.sell_btn.Caption = "فاتورة مبيعات";
            this.sell_btn.Id = 4;
            this.sell_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sell_btn.ImageOptions.SvgImage")));
            this.sell_btn.Name = "sell_btn";
            this.sell_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sell_btn_ItemClick);
            // 
            // suppliers_btn
            // 
            this.suppliers_btn.Caption = "الموردين";
            this.suppliers_btn.Id = 5;
            this.suppliers_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("suppliers_btn.ImageOptions.SvgImage")));
            this.suppliers_btn.Name = "suppliers_btn";
            this.suppliers_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.suppliers_btn_ItemClick);
            // 
            // price_offer_btn
            // 
            this.price_offer_btn.Caption = "عرض سعر";
            this.price_offer_btn.Id = 6;
            this.price_offer_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("price_offer_btn.ImageOptions.SvgImage")));
            this.price_offer_btn.Name = "price_offer_btn";
            this.price_offer_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.price_offer_btn_ItemClick);
            // 
            // sales_report_btn
            // 
            this.sales_report_btn.Caption = "تقرير المبيعات";
            this.sales_report_btn.Id = 7;
            this.sales_report_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sales_report_btn.ImageOptions.SvgImage")));
            this.sales_report_btn.Name = "sales_report_btn";
            this.sales_report_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sales_report_btn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "الرئيسية";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.customers_btn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.cost_calculation_btn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.products_btn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.sell_btn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.suppliers_btn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.price_offer_btn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.sales_report_btn);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 565);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(991, 45);
            // 
            // defaultBarAndDockingController1
            // 
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.Item.Font = new System.Drawing.Font("Cairo", 10F);
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.Item.Options.UseFont = true;
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageCategory.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageCategory.Options.UseFont = true;
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageGroupCaption.Font = new System.Drawing.Font("Tahoma", 1F);
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageGroupCaption.Options.UseFont = true;
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageHeader.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageHeader.Options.UseFont = true;
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageHeaderHovered.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageHeaderHovered.Options.UseFont = true;
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageHeaderSelected.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.defaultBarAndDockingController1.Controller.AppearancesRibbon.PageHeaderSelected.Options.UseFont = true;
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 8;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 610);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "HomeForm";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem customers_btn;
        private DevExpress.XtraBars.BarButtonItem cost_calculation_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem products_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem sell_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem suppliers_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem price_offer_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private DevExpress.XtraBars.BarButtonItem sales_report_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
    }
}