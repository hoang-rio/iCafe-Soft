using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmSupplierAdd
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSupEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSupAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupName = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.txtSupEmail);
            this.groupControl1.Controls.Add(this.txtSupAddress);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSupPhone);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSupName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 198);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Cập nhật thông tin nhà cung cấp";
            // 
            // txtSupEmail
            // 
            this.txtSupEmail.Location = new System.Drawing.Point(126, 158);
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSupEmail.Properties.Appearance.Options.UseFont = true;
            this.txtSupEmail.Size = new System.Drawing.Size(177, 20);
            this.txtSupEmail.TabIndex = 4;
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.Location = new System.Drawing.Point(126, 120);
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSupAddress.Properties.Appearance.Options.UseFont = true;
            this.txtSupAddress.Size = new System.Drawing.Size(177, 20);
            this.txtSupAddress.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl2.Location = new System.Drawing.Point(22, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Email";
            // 
            // txtSupPhone
            // 
            this.txtSupPhone.Location = new System.Drawing.Point(126, 81);
            this.txtSupPhone.Name = "txtSupPhone";
            this.txtSupPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSupPhone.Properties.Appearance.Options.UseFont = true;
            this.txtSupPhone.Size = new System.Drawing.Size(177, 20);
            this.txtSupPhone.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl7.Location = new System.Drawing.Point(22, 123);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Địa chỉ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl6.Location = new System.Drawing.Point(22, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Điện thoại";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(22, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên nhà cung cấp";
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(126, 44);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSupName.Properties.Appearance.Options.UseFont = true;
            this.txtSupName.Size = new System.Drawing.Size(177, 20);
            this.txtSupName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(325, 50);
            this.ucUpdate1.TabIndex = 4;
            // 
            // frmSupplierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 248);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmSupplierAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControl1;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private LabelControl labelControl1;
        private TextEdit txtSupName;
        private OpenFileDialog openFileDialog1;
        private ImageList imageList1;
        private ucUpdate ucUpdate1;
        private TextEdit txtSupAddress;
        private TextEdit txtSupPhone;
        private TextEdit txtSupEmail;
        private LabelControl labelControl2;
    }
}