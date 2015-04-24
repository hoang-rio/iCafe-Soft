using System.ComponentModel;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmCustomerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dateCusNS = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCusAddress = new DevExpress.XtraEditors.TextEdit();
            this.groupKH = new DevExpress.XtraEditors.GroupControl();
            this.txtCusName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.spinCK = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompany = new DevExpress.XtraEditors.TextEdit();
            this.txtCusPhone = new DevExpress.XtraEditors.TextEdit();
            this.cbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.dateCusNS.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCusNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).BeginInit();
            this.groupKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateCusNS
            // 
            this.dateCusNS.EditValue = null;
            this.dateCusNS.Location = new System.Drawing.Point(113, 211);
            this.dateCusNS.Name = "dateCusNS";
            this.dateCusNS.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateCusNS.Properties.Appearance.Options.UseFont = true;
            this.dateCusNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCusNS.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateCusNS.Size = new System.Drawing.Size(177, 20);
            this.dateCusNS.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(27, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(30, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Location = new System.Drawing.Point(27, 214);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(27, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ Tên";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(113, 135);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCusAddress.Properties.Appearance.Options.UseFont = true;
            this.txtCusAddress.Size = new System.Drawing.Size(177, 20);
            this.txtCusAddress.TabIndex = 3;
            // 
            // groupKH
            // 
            this.groupKH.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupKH.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupKH.AppearanceCaption.Options.UseFont = true;
            this.groupKH.AppearanceCaption.Options.UseForeColor = true;
            this.groupKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupKH.Controls.Add(this.txtCusName);
            this.groupKH.Controls.Add(this.labelControl7);
            this.groupKH.Controls.Add(this.spinCK);
            this.groupKH.Controls.Add(this.dateCusNS);
            this.groupKH.Controls.Add(this.labelControl4);
            this.groupKH.Controls.Add(this.labelControl3);
            this.groupKH.Controls.Add(this.labelControl5);
            this.groupKH.Controls.Add(this.labelControl2);
            this.groupKH.Controls.Add(this.labelControl6);
            this.groupKH.Controls.Add(this.labelControl1);
            this.groupKH.Controls.Add(this.txtCompany);
            this.groupKH.Controls.Add(this.txtCusPhone);
            this.groupKH.Controls.Add(this.txtCusAddress);
            this.groupKH.Controls.Add(this.cbSex);
            this.groupKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKH.Location = new System.Drawing.Point(0, 50);
            this.groupKH.Name = "groupKH";
            this.groupKH.Size = new System.Drawing.Size(327, 335);
            this.groupKH.TabIndex = 3;
            this.groupKH.Text = "Cập nhật thông tin Khách hàng";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(113, 59);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCusName.Properties.Appearance.Options.UseFont = true;
            this.txtCusName.Size = new System.Drawing.Size(177, 20);
            this.txtCusName.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(27, 99);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Giới tính";
            // 
            // spinCK
            // 
            this.spinCK.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCK.Location = new System.Drawing.Point(113, 287);
            this.spinCK.Name = "spinCK";
            this.spinCK.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.spinCK.Properties.Appearance.Options.UseFont = true;
            this.spinCK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCK.Properties.MaxLength = 2;
            this.spinCK.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinCK.Size = new System.Drawing.Size(177, 20);
            this.spinCK.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(27, 251);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Công ty";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(27, 290);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Chiết khấu (%)";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(113, 248);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCompany.Properties.Appearance.Options.UseFont = true;
            this.txtCompany.Size = new System.Drawing.Size(177, 20);
            this.txtCompany.TabIndex = 6;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(113, 173);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCusPhone.Properties.Appearance.Options.UseFont = true;
            this.txtCusPhone.Properties.Mask.EditMask = "nnnnnnnnnnnnn";
            this.txtCusPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCusPhone.Properties.MaxLength = 11;
            this.txtCusPhone.Properties.NullText = "Nhập số điện thoại";
            this.txtCusPhone.Size = new System.Drawing.Size(177, 20);
            this.txtCusPhone.TabIndex = 4;
            // 
            // cbSex
            // 
            this.cbSex.EditValue = "Lựa chọn giới tính";
            this.cbSex.Location = new System.Drawing.Point(113, 96);
            this.cbSex.Name = "cbSex";
            this.cbSex.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSex.Properties.Appearance.Options.UseFont = true;
            this.cbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSex.Properties.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbSex.Size = new System.Drawing.Size(177, 20);
            this.cbSex.TabIndex = 2;
            this.cbSex.ToolTip = "Không chọn là Gay/Les";
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(327, 50);
            this.ucUpdate1.TabIndex = 2;
            // 
            // frmCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 385);
            this.ControlBox = false;
            this.Controls.Add(this.groupKH);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmCustomerAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.dateCusNS.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCusNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).EndInit();
            this.groupKH.ResumeLayout(false);
            this.groupKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateEdit dateCusNS;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl6;
        private LabelControl labelControl1;
        private TextEdit txtCusAddress;
        private GroupControl groupKH;
        private TextEdit txtCusPhone;
        private ucUpdate ucUpdate1;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private TextEdit txtCompany;
        private SpinEdit spinCK;
        private TextEdit txtCusName;
        private LabelControl labelControl7;
        private ComboBoxEdit cbSex;
    }
}