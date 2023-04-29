namespace MarbleSystemApp
{
    partial class ProductsForm
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
            this.my_group_uc1 = new OmarControls.my_group_uc();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.the_name_tb = new OmarControls.my_textbox();
            this.size_tb = new OmarControls.my_textbox();
            this.customGrid11 = new OmarControls.CustomGrid1();
            this.customGridView11 = new OmarControls.CustomGridView1();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.my_actions_uc1 = new OmarControls.my_actions_uc();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).BeginInit();
            this.my_group_uc1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView11)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.my_group_uc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customGrid11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(885, 628);
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
            this.my_group_uc1.Size = new System.Drawing.Size(879, 78);
            this.my_group_uc1.TabIndex = 1;
            this.my_group_uc1.Text = "بيانات الأصناف";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.the_name_tb, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.size_tb, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(875, 45);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // the_name_tb
            // 
            this.the_name_tb.CellWidth = 95F;
            this.the_name_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.the_name_tb.IsEnabled = true;
            this.the_name_tb.IsReadOnly = false;
            this.the_name_tb.IsRequired = true;
            this.the_name_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.the_name_tb.LabelText = "اسم الصنف :";
            this.the_name_tb.Location = new System.Drawing.Point(441, 3);
            this.the_name_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.the_name_tb.MaxLength = 0;
            this.the_name_tb.Name = "the_name_tb";
            this.the_name_tb.NullText = "";
            this.the_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.the_name_tb.showPlus = false;
            this.the_name_tb.Size = new System.Drawing.Size(431, 39);
            this.the_name_tb.TabIndex = 1;
            this.the_name_tb.TextBoxText = "";
            // 
            // size_tb
            // 
            this.size_tb.CellWidth = 70F;
            this.size_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.size_tb.IsEnabled = true;
            this.size_tb.IsReadOnly = false;
            this.size_tb.IsRequired = false;
            this.size_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.size_tb.LabelText = "المقاس :";
            this.size_tb.Location = new System.Drawing.Point(3, 3);
            this.size_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.size_tb.MaxLength = 0;
            this.size_tb.Name = "size_tb";
            this.size_tb.NullText = "";
            this.size_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.size_tb.showPlus = false;
            this.size_tb.Size = new System.Drawing.Size(432, 39);
            this.size_tb.TabIndex = 2;
            this.size_tb.TextBoxText = "";
            // 
            // customGrid11
            // 
            this.customGrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGrid11.Location = new System.Drawing.Point(3, 87);
            this.customGrid11.MainView = this.customGridView11;
            this.customGrid11.Name = "customGrid11";
            this.customGrid11.Size = new System.Drawing.Size(879, 449);
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.my_actions_uc1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 542);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(879, 83);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // my_actions_uc1
            // 
            this.my_actions_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_actions_uc1.isEnglish = false;
            this.my_actions_uc1.Location = new System.Drawing.Point(3, 3);
            this.my_actions_uc1.Name = "my_actions_uc1";
            this.my_actions_uc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_actions_uc1.Size = new System.Drawing.Size(873, 77);
            this.my_actions_uc1.TabIndex = 0;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 671);
            this.Controls.Add(this.tableLayoutPanel2);
            this.header = "الأصناف";
            this.MinimumSize = new System.Drawing.Size(440, 526);
            this.Name = "ProductsForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).EndInit();
            this.my_group_uc1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView11)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private OmarControls.my_actions_uc my_actions_uc1;
        private OmarControls.my_group_uc my_group_uc1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private OmarControls.my_textbox the_name_tb;
        private OmarControls.my_textbox size_tb;
        private OmarControls.CustomGrid1 customGrid11;
        private OmarControls.CustomGridView1 customGridView11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}