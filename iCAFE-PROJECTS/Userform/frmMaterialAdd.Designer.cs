

using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmMaterialAdd
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
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.picMaterial = new DevExpress.XtraEditors.PictureEdit();
            this.btnOpenIMG = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtRMName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescript = new DevExpress.XtraEditors.MemoEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtRMPrice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRMName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRMPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(533, 50);
            this.ucUpdate1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.picMaterial);
            this.groupControl1.Controls.Add(this.btnOpenIMG);
            this.groupControl1.Controls.Add(this.txtRMPrice);
            this.groupControl1.Controls.Add(this.txtUnit);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtQuantity);
            this.groupControl1.Controls.Add(this.txtRMName);
            this.groupControl1.Controls.Add(this.txtDescript);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(533, 374);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cập nhật thông tin Nguyên liệu";
            // 
            // picMaterial
            // 
            this.picMaterial.Location = new System.Drawing.Point(333, 57);
            this.picMaterial.Name = "picMaterial";
            this.picMaterial.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picMaterial.Size = new System.Drawing.Size(113, 113);
            this.picMaterial.TabIndex = 8;
            // 
            // btnOpenIMG
            // 
            this.btnOpenIMG.Image = global::iCafe.Properties.Resources.folder16;
            this.btnOpenIMG.Location = new System.Drawing.Point(348, 196);
            this.btnOpenIMG.Name = "btnOpenIMG";
            this.btnOpenIMG.Size = new System.Drawing.Size(80, 23);
            this.btnOpenIMG.TabIndex = 7;
            this.btnOpenIMG.Text = "Duyệt ảnh";
            this.btnOpenIMG.Click += new System.EventHandler(this.btnOpenIMG_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(116, 123);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUnit.Properties.Appearance.Options.UseFont = true;
            this.txtUnit.Size = new System.Drawing.Size(177, 20);
            this.txtUnit.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl8.Location = new System.Drawing.Point(358, 38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Ảnh đại diện";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(20, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Đơn vị tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(20, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(20, 245);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mô tả bổ sung";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(20, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Nguyên Liệu";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(116, 85);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Size = new System.Drawing.Size(177, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtRMName
            // 
            this.txtRMName.Location = new System.Drawing.Point(116, 47);
            this.txtRMName.Name = "txtRMName";
            this.txtRMName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRMName.Properties.Appearance.Options.UseFont = true;
            this.txtRMName.Size = new System.Drawing.Size(177, 20);
            this.txtRMName.TabIndex = 1;
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(116, 184);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescript.Properties.Appearance.Options.UseFont = true;
            this.txtDescript.Size = new System.Drawing.Size(177, 165);
            this.txtDescript.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(20, 152);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Giá";
            // 
            // txtRMPrice
            // 
            this.txtRMPrice.Location = new System.Drawing.Point(116, 149);
            this.txtRMPrice.Name = "txtRMPrice";
            this.txtRMPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRMPrice.Properties.Appearance.Options.UseFont = true;
            this.txtRMPrice.Size = new System.Drawing.Size(177, 20);
            this.txtRMPrice.TabIndex = 3;
            // 
            // frmMaterialAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 424);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmMaterialAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRMName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRMPrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit txtQuantity;
        private TextEdit txtRMName;
        private LabelControl labelControl8;
        private MemoEdit txtDescript;
        private OpenFileDialog openFileDialog1;
        private TextEdit txtUnit;
        private SimpleButton btnOpenIMG;
        private PictureEdit picMaterial;
        private TextEdit txtRMPrice;
        private LabelControl labelControl5;
    }
}