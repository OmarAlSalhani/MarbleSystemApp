namespace MarbleSystemApp
{
    partial class SellPayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellPayForm));
            this.my_group_uc3 = new OmarControls.my_group_uc();
            this.final_amount_tb = new OmarControls.my_textbox();
            this.paied_tb = new OmarControls.my_textbox();
            this.discount_value_tb = new OmarControls.my_textbox();
            this.discount_percent_tb = new OmarControls.my_textbox();
            this.total_tb = new OmarControls.my_textbox();
            this.is_cheque_cb = new OmarControls.my_combobox();
            this.my_group_uc1 = new OmarControls.my_group_uc();
            this.cheque_number_tb = new OmarControls.my_textbox();
            this.cheque_mobile_tb = new OmarControls.my_textbox();
            this.cheque_holder_name_tb = new OmarControls.my_textbox();
            this.cheque_date_tb = new OmarControls.my_date();
            this.bank_name_tb = new OmarControls.my_textbox();
            this.my_group_uc2 = new OmarControls.my_group_uc();
            this.pay_and_print_btn = new OmarControls.my_button();
            this.pay_btn = new OmarControls.my_button();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc3)).BeginInit();
            this.my_group_uc3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).BeginInit();
            this.my_group_uc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc2)).BeginInit();
            this.my_group_uc2.SuspendLayout();
            this.SuspendLayout();
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
            this.my_group_uc3.Controls.Add(this.final_amount_tb);
            this.my_group_uc3.Controls.Add(this.paied_tb);
            this.my_group_uc3.Controls.Add(this.discount_value_tb);
            this.my_group_uc3.Controls.Add(this.discount_percent_tb);
            this.my_group_uc3.Controls.Add(this.total_tb);
            this.my_group_uc3.Controls.Add(this.is_cheque_cb);
            this.my_group_uc3.Location = new System.Drawing.Point(2, 45);
            this.my_group_uc3.Name = "my_group_uc3";
            this.my_group_uc3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_group_uc3.Size = new System.Drawing.Size(276, 306);
            this.my_group_uc3.TabIndex = 6;
            this.my_group_uc3.Text = "الدفع";
            // 
            // final_amount_tb
            // 
            this.final_amount_tb.CellWidth = 100F;
            this.final_amount_tb.IsEnabled = true;
            this.final_amount_tb.IsReadOnly = true;
            this.final_amount_tb.IsRequired = false;
            this.final_amount_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.final_amount_tb.LabelText = "المتبقي :";
            this.final_amount_tb.Location = new System.Drawing.Point(4, 259);
            this.final_amount_tb.MaskType = OmarControls.my_textbox.TheMaskType.Double;
            this.final_amount_tb.MaxLength = 0;
            this.final_amount_tb.Name = "final_amount_tb";
            this.final_amount_tb.NullText = "";
            this.final_amount_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.final_amount_tb.showPlus = false;
            this.final_amount_tb.Size = new System.Drawing.Size(268, 39);
            this.final_amount_tb.TabIndex = 12;
            this.final_amount_tb.TextBoxText = "0.00";
            // 
            // paied_tb
            // 
            this.paied_tb.CellWidth = 100F;
            this.paied_tb.IsEnabled = true;
            this.paied_tb.IsReadOnly = false;
            this.paied_tb.IsRequired = false;
            this.paied_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paied_tb.LabelText = "المدفوع :";
            this.paied_tb.Location = new System.Drawing.Point(4, 214);
            this.paied_tb.MaskType = OmarControls.my_textbox.TheMaskType.Double;
            this.paied_tb.MaxLength = 0;
            this.paied_tb.Name = "paied_tb";
            this.paied_tb.NullText = "";
            this.paied_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paied_tb.showPlus = false;
            this.paied_tb.Size = new System.Drawing.Size(268, 39);
            this.paied_tb.TabIndex = 11;
            this.paied_tb.TextBoxText = "0.00";
            // 
            // discount_value_tb
            // 
            this.discount_value_tb.CellWidth = 100F;
            this.discount_value_tb.IsEnabled = true;
            this.discount_value_tb.IsReadOnly = false;
            this.discount_value_tb.IsRequired = false;
            this.discount_value_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discount_value_tb.LabelText = "قيمة الخصم :";
            this.discount_value_tb.Location = new System.Drawing.Point(4, 169);
            this.discount_value_tb.MaskType = OmarControls.my_textbox.TheMaskType.Double;
            this.discount_value_tb.MaxLength = 0;
            this.discount_value_tb.Name = "discount_value_tb";
            this.discount_value_tb.NullText = "";
            this.discount_value_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discount_value_tb.showPlus = false;
            this.discount_value_tb.Size = new System.Drawing.Size(268, 39);
            this.discount_value_tb.TabIndex = 10;
            this.discount_value_tb.TextBoxText = "0.00";
            // 
            // discount_percent_tb
            // 
            this.discount_percent_tb.CellWidth = 100F;
            this.discount_percent_tb.IsEnabled = true;
            this.discount_percent_tb.IsReadOnly = false;
            this.discount_percent_tb.IsRequired = false;
            this.discount_percent_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discount_percent_tb.LabelText = "نسبة الخصم :";
            this.discount_percent_tb.Location = new System.Drawing.Point(4, 124);
            this.discount_percent_tb.MaskType = OmarControls.my_textbox.TheMaskType.Percent;
            this.discount_percent_tb.MaxLength = 0;
            this.discount_percent_tb.Name = "discount_percent_tb";
            this.discount_percent_tb.NullText = "";
            this.discount_percent_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discount_percent_tb.showPlus = false;
            this.discount_percent_tb.Size = new System.Drawing.Size(268, 39);
            this.discount_percent_tb.TabIndex = 9;
            this.discount_percent_tb.TextBoxText = "0.00%";
            // 
            // total_tb
            // 
            this.total_tb.CellWidth = 100F;
            this.total_tb.IsEnabled = true;
            this.total_tb.IsReadOnly = true;
            this.total_tb.IsRequired = false;
            this.total_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_tb.LabelText = "الأجمالي :";
            this.total_tb.Location = new System.Drawing.Point(4, 79);
            this.total_tb.MaskType = OmarControls.my_textbox.TheMaskType.Double;
            this.total_tb.MaxLength = 0;
            this.total_tb.Name = "total_tb";
            this.total_tb.NullText = "";
            this.total_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_tb.showPlus = false;
            this.total_tb.Size = new System.Drawing.Size(268, 39);
            this.total_tb.TabIndex = 8;
            this.total_tb.TextBoxText = "0.00";
            // 
            // is_cheque_cb
            // 
            this.is_cheque_cb.BackColor = System.Drawing.Color.Transparent;
            this.is_cheque_cb.CellWidth = 100F;
            this.is_cheque_cb.Items.AddRange(new object[] {
            "كاش",
            "شيك بنكي"});
            this.is_cheque_cb.LabelText = "طريقة الدفع :";
            this.is_cheque_cb.Location = new System.Drawing.Point(4, 34);
            this.is_cheque_cb.Name = "is_cheque_cb";
            this.is_cheque_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.is_cheque_cb.SelectedIndex = 0;
            this.is_cheque_cb.showPlus = false;
            this.is_cheque_cb.Size = new System.Drawing.Size(268, 39);
            this.is_cheque_cb.TabIndex = 0;
            this.is_cheque_cb.TextBoxText = "كاش";
            this.is_cheque_cb.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.is_cheque_cb.OnIndexChanged += new OmarControls.my_combobox.IndexChanged(this.is_cheque_cb_OnIndexChanged);
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
            this.my_group_uc1.Controls.Add(this.cheque_number_tb);
            this.my_group_uc1.Controls.Add(this.cheque_mobile_tb);
            this.my_group_uc1.Controls.Add(this.cheque_holder_name_tb);
            this.my_group_uc1.Controls.Add(this.cheque_date_tb);
            this.my_group_uc1.Controls.Add(this.bank_name_tb);
            this.my_group_uc1.Enabled = false;
            this.my_group_uc1.Location = new System.Drawing.Point(280, 45);
            this.my_group_uc1.Name = "my_group_uc1";
            this.my_group_uc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_group_uc1.Size = new System.Drawing.Size(367, 306);
            this.my_group_uc1.TabIndex = 7;
            this.my_group_uc1.Text = "بيانات الشيك";
            // 
            // cheque_number_tb
            // 
            this.cheque_number_tb.CellWidth = 100F;
            this.cheque_number_tb.IsEnabled = true;
            this.cheque_number_tb.IsReadOnly = false;
            this.cheque_number_tb.IsRequired = false;
            this.cheque_number_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_number_tb.LabelText = "رقم الشيك :";
            this.cheque_number_tb.Location = new System.Drawing.Point(11, 214);
            this.cheque_number_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.cheque_number_tb.MaxLength = 0;
            this.cheque_number_tb.Name = "cheque_number_tb";
            this.cheque_number_tb.NullText = "";
            this.cheque_number_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_number_tb.showPlus = false;
            this.cheque_number_tb.Size = new System.Drawing.Size(352, 39);
            this.cheque_number_tb.TabIndex = 11;
            this.cheque_number_tb.TextBoxText = "";
            // 
            // cheque_mobile_tb
            // 
            this.cheque_mobile_tb.CellWidth = 100F;
            this.cheque_mobile_tb.IsEnabled = true;
            this.cheque_mobile_tb.IsReadOnly = false;
            this.cheque_mobile_tb.IsRequired = false;
            this.cheque_mobile_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_mobile_tb.LabelText = "رقم الموبايل :";
            this.cheque_mobile_tb.Location = new System.Drawing.Point(11, 169);
            this.cheque_mobile_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.cheque_mobile_tb.MaxLength = 0;
            this.cheque_mobile_tb.Name = "cheque_mobile_tb";
            this.cheque_mobile_tb.NullText = "";
            this.cheque_mobile_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_mobile_tb.showPlus = false;
            this.cheque_mobile_tb.Size = new System.Drawing.Size(352, 39);
            this.cheque_mobile_tb.TabIndex = 10;
            this.cheque_mobile_tb.TextBoxText = "";
            // 
            // cheque_holder_name_tb
            // 
            this.cheque_holder_name_tb.CellWidth = 100F;
            this.cheque_holder_name_tb.IsEnabled = true;
            this.cheque_holder_name_tb.IsReadOnly = false;
            this.cheque_holder_name_tb.IsRequired = false;
            this.cheque_holder_name_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_holder_name_tb.LabelText = "صاحب الشيك :";
            this.cheque_holder_name_tb.Location = new System.Drawing.Point(10, 79);
            this.cheque_holder_name_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.cheque_holder_name_tb.MaxLength = 0;
            this.cheque_holder_name_tb.Name = "cheque_holder_name_tb";
            this.cheque_holder_name_tb.NullText = "";
            this.cheque_holder_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_holder_name_tb.showPlus = false;
            this.cheque_holder_name_tb.Size = new System.Drawing.Size(352, 39);
            this.cheque_holder_name_tb.TabIndex = 9;
            this.cheque_holder_name_tb.TextBoxText = "";
            // 
            // cheque_date_tb
            // 
            this.cheque_date_tb.BackColor = System.Drawing.Color.Transparent;
            this.cheque_date_tb.CellWidth = 88F;
            this.cheque_date_tb.IsReadOnly = false;
            this.cheque_date_tb.LabelText = "تاريخ الشيك :";
            this.cheque_date_tb.Location = new System.Drawing.Point(10, 124);
            this.cheque_date_tb.Name = "cheque_date_tb";
            this.cheque_date_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cheque_date_tb.Size = new System.Drawing.Size(341, 39);
            this.cheque_date_tb.TabIndex = 8;
            this.cheque_date_tb.TextBoxText = "0001-01-01";
            this.cheque_date_tb.TheDate = new System.DateTime(((long)(0)));
            // 
            // bank_name_tb
            // 
            this.bank_name_tb.CellWidth = 100F;
            this.bank_name_tb.IsEnabled = true;
            this.bank_name_tb.IsReadOnly = false;
            this.bank_name_tb.IsRequired = false;
            this.bank_name_tb.IsRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bank_name_tb.LabelText = "أسم البنك :";
            this.bank_name_tb.Location = new System.Drawing.Point(10, 34);
            this.bank_name_tb.MaskType = OmarControls.my_textbox.TheMaskType.None;
            this.bank_name_tb.MaxLength = 0;
            this.bank_name_tb.Name = "bank_name_tb";
            this.bank_name_tb.NullText = "";
            this.bank_name_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bank_name_tb.showPlus = false;
            this.bank_name_tb.Size = new System.Drawing.Size(352, 39);
            this.bank_name_tb.TabIndex = 7;
            this.bank_name_tb.TextBoxText = "";
            // 
            // my_group_uc2
            // 
            this.my_group_uc2.AppearanceCaption.Font = new System.Drawing.Font("Cairo", 10F);
            this.my_group_uc2.AppearanceCaption.ForeColor = System.Drawing.Color.RoyalBlue;
            this.my_group_uc2.AppearanceCaption.Options.UseFont = true;
            this.my_group_uc2.AppearanceCaption.Options.UseForeColor = true;
            this.my_group_uc2.AppearanceCaption.Options.UseTextOptions = true;
            this.my_group_uc2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.my_group_uc2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.my_group_uc2.Controls.Add(this.pay_and_print_btn);
            this.my_group_uc2.Controls.Add(this.pay_btn);
            this.my_group_uc2.Location = new System.Drawing.Point(2, 353);
            this.my_group_uc2.Name = "my_group_uc2";
            this.my_group_uc2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.my_group_uc2.Size = new System.Drawing.Size(645, 80);
            this.my_group_uc2.TabIndex = 8;
            this.my_group_uc2.Text = "التسديد";
            // 
            // pay_and_print_btn
            // 
            this.pay_and_print_btn.Appearance.Font = new System.Drawing.Font("Cairo", 10F);
            this.pay_and_print_btn.Appearance.Options.UseFont = true;
            this.pay_and_print_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("my_button2.ImageOptions.Image")));
            this.pay_and_print_btn.Location = new System.Drawing.Point(382, 37);
            this.pay_and_print_btn.Name = "pay_and_print_btn";
            this.pay_and_print_btn.Size = new System.Drawing.Size(124, 38);
            this.pay_and_print_btn.TabIndex = 1;
            this.pay_and_print_btn.Text = "تسديد وطباعة";
            this.pay_and_print_btn.the_font = new System.Drawing.Font("Cairo", 10F);
            this.pay_and_print_btn.the_image = ((System.Drawing.Image)(resources.GetObject("pay_and_print_btn.the_image")));
            this.pay_and_print_btn.Click += new System.EventHandler(this.pay_and_print_btn_Click);
            // 
            // pay_btn
            // 
            this.pay_btn.Appearance.Font = new System.Drawing.Font("Cairo", 10F);
            this.pay_btn.Appearance.Options.UseFont = true;
            this.pay_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("my_button1.ImageOptions.Image")));
            this.pay_btn.Location = new System.Drawing.Point(512, 36);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(124, 38);
            this.pay_btn.TabIndex = 0;
            this.pay_btn.Text = "تسديد";
            this.pay_btn.the_font = new System.Drawing.Font("Cairo", 10F);
            this.pay_btn.the_image = ((System.Drawing.Image)(resources.GetObject("pay_btn.the_image")));
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // SellPayForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 435);
            this.Controls.Add(this.my_group_uc2);
            this.Controls.Add(this.my_group_uc1);
            this.Controls.Add(this.my_group_uc3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.header = "تسديد الفاتورة";
            this.MaximizeBox = false;
            this.Name = "SellPayForm";
            this.Text = "SellPayForm";
            this.Controls.SetChildIndex(this.my_group_uc3, 0);
            this.Controls.SetChildIndex(this.my_group_uc1, 0);
            this.Controls.SetChildIndex(this.my_group_uc2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc3)).EndInit();
            this.my_group_uc3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc1)).EndInit();
            this.my_group_uc1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_group_uc2)).EndInit();
            this.my_group_uc2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private OmarControls.my_group_uc my_group_uc3;
        private OmarControls.my_group_uc my_group_uc1;
        private OmarControls.my_group_uc my_group_uc2;
        private OmarControls.my_textbox bank_name_tb;
        private OmarControls.my_combobox is_cheque_cb;
        private OmarControls.my_textbox discount_percent_tb;
        private OmarControls.my_textbox total_tb;
        private OmarControls.my_textbox cheque_number_tb;
        private OmarControls.my_textbox cheque_mobile_tb;
        private OmarControls.my_textbox cheque_holder_name_tb;
        private OmarControls.my_date cheque_date_tb;
        private OmarControls.my_textbox discount_value_tb;
        private OmarControls.my_textbox final_amount_tb;
        private OmarControls.my_textbox paied_tb;
        private OmarControls.my_button pay_and_print_btn;
        private OmarControls.my_button pay_btn;
    }
}