using System.ComponentModel;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmFoodGroupAdd
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ptbImage = new DevExpress.XtraEditors.PictureEdit();
            this.btnOpenIMG = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFGrName = new DevExpress.XtraEditors.TextEdit();
            this.txtFGrDescript = new DevExpress.XtraEditors.MemoEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFGrName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFGrDescript.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ptbImage);
            this.groupControl1.Controls.Add(this.btnOpenIMG);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtFGrName);
            this.groupControl1.Controls.Add(this.txtFGrDescript);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(461, 247);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thêm Nhóm món";
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(317, 73);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ptbImage.Size = new System.Drawing.Size(132, 126);
            this.ptbImage.TabIndex = 13;
            this.ptbImage.Click += new System.EventHandler(this.bbtnOpenImg_Click);
            // 
            // btnOpenIMG
            // 
            this.btnOpenIMG.Image = global::iCafe.Properties.Resources.folder16;
            this.btnOpenIMG.Location = new System.Drawing.Point(343, 205);
            this.btnOpenIMG.Name = "btnOpenIMG";
            this.btnOpenIMG.Size = new System.Drawing.Size(80, 23);
            this.btnOpenIMG.TabIndex = 3;
            this.btnOpenIMG.Text = "Duyệt ảnh";
            this.btnOpenIMG.Click += new System.EventHandler(this.bbtnOpenImg_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl8.Location = new System.Drawing.Point(353, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Ảnh đại diện";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(66, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mô tả";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Nhóm món";
            // 
            // txtFGrName
            // 
            this.txtFGrName.Location = new System.Drawing.Point(114, 34);
            this.txtFGrName.Name = "txtFGrName";
            this.txtFGrName.Size = new System.Drawing.Size(177, 20);
            this.txtFGrName.TabIndex = 1;
            // 
            // txtFGrDescript
            // 
            this.txtFGrDescript.Location = new System.Drawing.Point(114, 71);
            this.txtFGrDescript.Name = "txtFGrDescript";
            this.txtFGrDescript.Size = new System.Drawing.Size(177, 135);
            this.txtFGrDescript.TabIndex = 2;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(461, 52);
            this.ucUpdate1.TabIndex = 0;
            // 
            // frmFoodGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmFoodGroupAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFGrName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFGrDescript.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private LabelControl labelControl1;
        private TextEdit txtFGrName;
        private LabelControl labelControl2;
        private MemoEdit txtFGrDescript;
        private SimpleButton btnOpenIMG;
        private LabelControl labelControl8;
        private PictureEdit ptbImage;
    }
}