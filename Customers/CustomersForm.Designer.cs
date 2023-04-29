namespace MarbleSystemApp
{
    partial class CustomersForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.my_actions_uc1 = new OmarControls.my_actions_uc();
            this.my_group_uc1 = new OmarControls.my_group_uc();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.address_tb = new OmarControls.my_textbox();
            this.notes_tb = new OmarControls.my_textbox();
            this.the_name_tb = new OmarControls.my_textbox();
            this.mobile_tb = new OmarControls.my_textbox();
            this.customGrid11 = new OmarControls.CustomGrid1();
            this.customGridView11 = new OmarControls.CustomGridView1();
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
            this.tableLayoutPanel2.Controls.Add(this.my_actions_uc1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.my_group_uc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customGrid11, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(979, 628);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // my_actions_uc1
            // 
            this.my_actions_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_actions_uc1.isEnglish = false;
            this.my_actions_uc1.Location = new System.Drawing.Point(3, 550);
            this.my_actions_uc1.Name = "my_actions_uc1";
            this.my_actions_uc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_actions_uc1.Size = new System.Drawing.Size(973, 75);
            this.my_actions_uc1.TabIndex = 0;
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
            this.my_group_uc1.Size = new System.Drawing.Size(973, 126);
            this.my_group_uc1.TabIndex = 1;
            this.my_group_uc1.Text = "بيانات العميل";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.address_tb, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.notes_tb, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.the_name_tb, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mobile_tb, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(969, 93);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // address_tb
            // 
            this.address_tb.CellWidth = 95F;
            this.address_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address_tb.IsEnabled = true;
            this.address_tb.IsReadOnly = false;
            this.address_tb.IsRequired = false;
            this.address_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address_tb.LabelText = "العنوان :";
            this.address_tb.Location = new System.Drawing.Point(488, 49);
            this.address_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.address_tb.MaxLength = 0;
            this.address_tb.Name = "address_tb";
            this.address_tb.NullText = "";
            this.address_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address_tb.showPlus = false;
            this.address_tb.Size = new System.Drawing.Size(478, 41);
            this.address_tb.TabIndex = 4;
            this.address_tb.TextBoxText = "";
            // 
            // notes_tb
            // 
            this.notes_tb.CellWidth = 98F;
            this.notes_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes_tb.IsEnabled = true;
            this.notes_tb.IsReadOnly = false;
            this.notes_tb.IsRequired = false;
            this.notes_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_tb.LabelText = "الملاحظات :";
            this.notes_tb.Location = new System.Drawing.Point(3, 49);
            this.notes_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.notes_tb.MaxLength = 0;
            this.notes_tb.Name = "notes_tb";
            this.notes_tb.NullText = "";
            this.notes_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notes_tb.showPlus = false;
            this.notes_tb.Size = new System.Drawing.Size(479, 41);
            this.notes_tb.TabIndex = 3;
            this.notes_tb.TextBoxText = "";
            // 
            // the_name_tb
            // 
            this.the_name_tb.CellWidth = 95F;
            this.the_name_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.the_name_tb.IsEnabled = true;
            this.the_name_tb.IsReadOnly = false;
            this.the_name_tb.IsRequired = true;
            this.the_name_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.the_name_tb.LabelText = "أسم العميل :";
            this.the_name_tb.Location = new System.Drawing.Point(488, 3);
            this.the_name_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.the_name_tb.MaxLength = 0;
            this.the_name_tb.Name = "the_name_tb";
            this.the_name_tb.NullText = "";
            this.the_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.the_name_tb.showPlus = false;
            this.the_name_tb.Size = new System.Drawing.Size(478, 40);
            this.the_name_tb.TabIndex = 1;
            this.the_name_tb.TextBoxText = "";
            // 
            // mobile_tb
            // 
            this.mobile_tb.CellWidth = 98F;
            this.mobile_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mobile_tb.IsEnabled = true;
            this.mobile_tb.IsReadOnly = false;
            this.mobile_tb.IsRequired = false;
            this.mobile_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobile_tb.LabelText = "رقم الموبايل :";
            this.mobile_tb.Location = new System.Drawing.Point(3, 3);
            this.mobile_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.mobile_tb.MaxLength = 0;
            this.mobile_tb.Name = "mobile_tb";
            this.mobile_tb.NullText = "";
            this.mobile_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobile_tb.showPlus = false;
            this.mobile_tb.Size = new System.Drawing.Size(479, 40);
            this.mobile_tb.TabIndex = 2;
            this.mobile_tb.TextBoxText = "";
            // 
            // customGrid11
            // 
            this.customGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGrid11.Location = new System.Drawing.Point(3, 135);
            this.customGrid11.MainView = this.customGridView11;
            this.customGrid11.Name = "customGrid11";
            this.customGrid11.Size = new System.Drawing.Size(973, 409);
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
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 671);
            this.Controls.Add(this.tableLayoutPanel2);
            this.header = "العملاء";
            this.MinimumSize = new System.Drawing.Size(440, 526);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private OmarControls.my_actions_uc my_actions_uc1;
        private OmarControls.my_group_uc my_group_uc1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private OmarControls.my_textbox address_tb;
        private OmarControls.my_textbox notes_tb;
        private OmarControls.my_textbox the_name_tb;
        private OmarControls.my_textbox mobile_tb;
        private OmarControls.CustomGrid1 customGrid11;
        private OmarControls.CustomGridView1 customGridView11;
    }
}