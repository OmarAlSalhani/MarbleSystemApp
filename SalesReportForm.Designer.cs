namespace MarbleSystemApp
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.my_group_uc1 = new OmarControls.my_group_uc();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.my_from_to_date1 = new OmarControls.my_from_to_date();
            this.search_btn = new OmarControls.my_button();
            this.customGrid11 = new OmarControls.CustomGrid1();
            this.customGridView11 = new OmarControls.CustomGridView1();
            this.my_export_uc1 = new OmarControls.my_export_uc();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).BeginInit();
            this.my_group_uc1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.my_group_uc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customGrid11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.my_export_uc1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(979, 628);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // my_group_uc1
            // 
            this.my_group_uc1.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 10F);
            this.my_group_uc1.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.my_group_uc1.AppearanceCaption.Options.UseFont = true;
            this.my_group_uc1.AppearanceCaption.Options.UseForeColor = true;
            this.my_group_uc1.AppearanceCaption.Options.UseTextOptions = true;
            this.my_group_uc1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.my_group_uc1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.my_group_uc1.Controls.Add(this.tableLayoutPanel3);
            this.my_group_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_group_uc1.Location = new System.Drawing.Point(3, 3);
            this.my_group_uc1.Name = "my_group_uc1";
            this.my_group_uc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_group_uc1.Size = new System.Drawing.Size(973, 79);
            this.my_group_uc1.TabIndex = 1;
            this.my_group_uc1.Text = "خيارات البحث";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.my_from_to_date1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.search_btn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(969, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // my_from_to_date1
            // 
            this.my_from_to_date1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_from_to_date1.from_date = "0001-01-01";
            this.my_from_to_date1.Location = new System.Drawing.Point(622, 3);
            this.my_from_to_date1.Name = "my_from_to_date1";
            this.my_from_to_date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_from_to_date1.Size = new System.Drawing.Size(344, 40);
            this.my_from_to_date1.TabIndex = 0;
            this.my_from_to_date1.to_date = "0001-01-01";
            // 
            // search_btn
            // 
            this.search_btn.Appearance.Font = new System.Drawing.Font("Cairo", 10F);
            this.search_btn.Appearance.Options.UseFont = true;
            this.search_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.ImageOptions.Image")));
            this.search_btn.Location = new System.Drawing.Point(489, 3);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(127, 40);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "عرض البيانات";
            this.search_btn.the_font = new System.Drawing.Font("Cairo", 10F);
            this.search_btn.the_image = ((System.Drawing.Image)(resources.GetObject("search_btn.the_image")));
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // customGrid11
            // 
            this.customGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGrid11.Location = new System.Drawing.Point(3, 88);
            this.customGrid11.MainView = this.customGridView11;
            this.customGrid11.Name = "customGrid11";
            this.customGrid11.Size = new System.Drawing.Size(973, 456);
            this.customGrid11.TabIndex = 2;
            this.customGrid11.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView11});
            // 
            // customGridView11
            // 
            this.customGridView11.GridControl = this.customGrid11;
            this.customGridView11.IndicatorWidth = 30;
            this.customGridView11.Name = "customGridView11";
            this.customGridView11.OptionsBehavior.Editable = false;
            this.customGridView11.OptionsFind.HighlightFindResults = false;
            // 
            // my_export_uc1
            // 
            this.my_export_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_export_uc1.Grid = this.customGridView11;
            this.my_export_uc1.Location = new System.Drawing.Point(3, 550);
            this.my_export_uc1.Name = "my_export_uc1";
            this.my_export_uc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_export_uc1.Size = new System.Drawing.Size(973, 75);
            this.my_export_uc1.TabIndex = 3;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 671);
            this.Controls.Add(this.tableLayoutPanel2);
            this.header = "تقرير المبيعات";
            this.MinimumSize = new System.Drawing.Size(440, 526);
            this.Name = "SalesReportForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).EndInit();
            this.my_group_uc1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private OmarControls.my_group_uc my_group_uc1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private OmarControls.CustomGrid1 customGrid11;
        private OmarControls.CustomGridView1 customGridView11;
        private OmarControls.my_export_uc my_export_uc1;
        private OmarControls.my_from_to_date my_from_to_date1;
        private OmarControls.my_button search_btn;
    }
}