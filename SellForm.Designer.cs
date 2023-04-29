namespace MarbleSystemApp
{
    partial class SellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.my_group_uc1 = new OmarControls.my_group_uc();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.customer_lue = new OmarControls.my_lookup();
            this.my_date1 = new OmarControls.my_date();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.my_group_uc3 = new OmarControls.my_group_uc();
            this.open_pay_form_btn = new OmarControls.my_button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.my_textbox1 = new OmarControls.my_textbox();
            this.customGrid11 = new OmarControls.CustomGrid1();
            this.sellbodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customGridView11 = new OmarControls.CustomGridView1();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colsize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).BeginInit();
            this.my_group_uc1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc3)).BeginInit();
            this.my_group_uc3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellbodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.my_group_uc1.Size = new System.Drawing.Size(982, 78);
            this.my_group_uc1.TabIndex = 1;
            this.my_group_uc1.Text = "بيانات العميل";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.28835F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71166F));
            this.tableLayoutPanel3.Controls.Add(this.customer_lue, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.my_date1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 45);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // customer_lue
            // 
            this.customer_lue.BackColor = System.Drawing.Color.Transparent;
            this.customer_lue.CellWidth = 75F;
            this.customer_lue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_lue.EditValue = -1;
            this.customer_lue.LabelText = "العميل :";
            this.customer_lue.Location = new System.Drawing.Point(187, 3);
            this.customer_lue.Name = "customer_lue";
            this.customer_lue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customer_lue.showPlus = true;
            this.customer_lue.Size = new System.Drawing.Size(788, 39);
            this.customer_lue.TabIndex = 5;
            this.customer_lue.TextBoxText = "";
            this.customer_lue.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // my_date1
            // 
            this.my_date1.BackColor = System.Drawing.Color.Transparent;
            this.my_date1.CellWidth = 60F;
            this.my_date1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_date1.IsReadOnly = false;
            this.my_date1.LabelText = "التاريخ :";
            this.my_date1.Location = new System.Drawing.Point(0, 0);
            this.my_date1.Margin = new System.Windows.Forms.Padding(0);
            this.my_date1.Name = "my_date1";
            this.my_date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_date1.Size = new System.Drawing.Size(184, 45);
            this.my_date1.TabIndex = 6;
            this.my_date1.TextBoxText = "0001-01-01";
            this.my_date1.TheDate = new System.DateTime(((long)(0)));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.my_group_uc3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.my_group_uc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 551);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // my_group_uc3
            // 
            this.my_group_uc3.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 10F);
            this.my_group_uc3.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.my_group_uc3.AppearanceCaption.Options.UseFont = true;
            this.my_group_uc3.AppearanceCaption.Options.UseForeColor = true;
            this.my_group_uc3.AppearanceCaption.Options.UseTextOptions = true;
            this.my_group_uc3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.my_group_uc3.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.my_group_uc3.Controls.Add(this.open_pay_form_btn);
            this.my_group_uc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_group_uc3.Location = new System.Drawing.Point(3, 473);
            this.my_group_uc3.Name = "my_group_uc3";
            this.my_group_uc3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_group_uc3.Size = new System.Drawing.Size(982, 75);
            this.my_group_uc3.TabIndex = 9;
            this.my_group_uc3.Text = "التسديد";
            // 
            // open_pay_form_btn
            // 
            this.open_pay_form_btn.Appearance.Font = new System.Drawing.Font("Cairo", 10F);
            this.open_pay_form_btn.Appearance.Options.UseFont = true;
            this.open_pay_form_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("open_pay_form_btn.ImageOptions.Image")));
            this.open_pay_form_btn.Location = new System.Drawing.Point(864, 32);
            this.open_pay_form_btn.Name = "open_pay_form_btn";
            this.open_pay_form_btn.Size = new System.Drawing.Size(112, 40);
            this.open_pay_form_btn.TabIndex = 0;
            this.open_pay_form_btn.Text = "تسديد";
            this.open_pay_form_btn.the_font = new System.Drawing.Font("Cairo", 10F);
            this.open_pay_form_btn.the_image = ((System.Drawing.Image)(resources.GetObject("open_pay_form_btn.the_image")));
            this.open_pay_form_btn.Click += new System.EventHandler(this.open_pay_form_btn_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.my_textbox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.customGrid11, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(982, 380);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // my_textbox1
            // 
            this.my_textbox1.CellWidth = 88F;
            this.my_textbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_textbox1.IsEnabled = true;
            this.my_textbox1.IsReadOnly = false;
            this.my_textbox1.IsRequired = false;
            this.my_textbox1.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_textbox1.LabelText = "الملاحظات :";
            this.my_textbox1.Location = new System.Drawing.Point(3, 337);
            this.my_textbox1.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.my_textbox1.MaxLength = 0;
            this.my_textbox1.Name = "my_textbox1";
            this.my_textbox1.NullText = "";
            this.my_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_textbox1.showPlus = false;
            this.my_textbox1.Size = new System.Drawing.Size(976, 40);
            this.my_textbox1.TabIndex = 7;
            this.my_textbox1.TextBoxText = "";
            // 
            // customGrid11
            // 
            this.customGrid11.DataSource = this.sellbodyBindingSource;
            this.customGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGrid11.Location = new System.Drawing.Point(3, 3);
            this.customGrid11.MainView = this.customGridView11;
            this.customGrid11.Name = "customGrid11";
            this.customGrid11.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemButtonEdit1});
            this.customGrid11.Size = new System.Drawing.Size(976, 328);
            this.customGrid11.TabIndex = 5;
            this.customGrid11.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView11});
            // 
            // sellbodyBindingSource
            // 
            this.sellbodyBindingSource.DataSource = typeof(MarbleSystemApp.sell_body);
            // 
            // customGridView11
            // 
            this.customGridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colproduct,
            this.colsize,
            this.colunit,
            this.colqty,
            this.colprice,
            this.coltotal,
            this.coldelete});
            this.customGridView11.GridControl = this.customGrid11;
            this.customGridView11.IndicatorWidth = 30;
            this.customGridView11.Name = "customGridView11";
            this.customGridView11.OptionsNavigation.AutoFocusNewRow = true;
            this.customGridView11.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colproduct
            // 
            this.colproduct.Caption = "الصنف";
            this.colproduct.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colproduct.FieldName = "product";
            this.colproduct.Name = "colproduct";
            this.colproduct.Visible = true;
            this.colproduct.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEdit1_EditValueChanged);
            // 
            // colsize
            // 
            this.colsize.Caption = "المقاس";
            this.colsize.FieldName = "size";
            this.colsize.Name = "colsize";
            this.colsize.OptionsColumn.AllowEdit = false;
            this.colsize.Visible = true;
            this.colsize.VisibleIndex = 1;
            // 
            // colunit
            // 
            this.colunit.Caption = "الوحدة";
            this.colunit.FieldName = "unit";
            this.colunit.Name = "colunit";
            this.colunit.Visible = true;
            this.colunit.VisibleIndex = 2;
            // 
            // colqty
            // 
            this.colqty.Caption = "الكمية";
            this.colqty.FieldName = "qty";
            this.colqty.Name = "colqty";
            this.colqty.Visible = true;
            this.colqty.VisibleIndex = 3;
            // 
            // colprice
            // 
            this.colprice.Caption = "السعر";
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 4;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "الأجمالي";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 5;
            // 
            // coldelete
            // 
            this.coldelete.Caption = "حذف";
            this.coldelete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.coldelete.Name = "coldelete";
            this.coldelete.Visible = true;
            this.coldelete.VisibleIndex = 6;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.tableLayoutPanel2);
            this.header = "فاتورة مبيعات";
            this.MinimumSize = new System.Drawing.Size(778, 526);
            this.Name = "SellForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).EndInit();
            this.my_group_uc1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc3)).EndInit();
            this.my_group_uc3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellbodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OmarControls.my_group_uc my_group_uc1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private OmarControls.my_lookup customer_lue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private OmarControls.my_date my_date1;
        private System.Windows.Forms.BindingSource sellbodyBindingSource;
        private OmarControls.my_group_uc my_group_uc3;
        private OmarControls.my_button open_pay_form_btn;
        private OmarControls.CustomGrid1 customGrid11;
        private OmarControls.CustomGridView1 customGridView11;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colsize;
        private DevExpress.XtraGrid.Columns.GridColumn colunit;
        private DevExpress.XtraGrid.Columns.GridColumn colqty;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private OmarControls.my_textbox my_textbox1;
    }
}