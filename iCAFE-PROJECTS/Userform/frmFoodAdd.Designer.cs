using System.ComponentModel;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmFoodAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodAdd));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOpenIMG = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.lookFoodGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFoodName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.picFood = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFoodGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.picFood);
            this.groupControl1.Controls.Add(this.btnOpenIMG);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtUnit);
            this.groupControl1.Controls.Add(this.lookFoodGroup);
            this.groupControl1.Controls.Add(this.txtFoodName);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 240);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Cập nhật thông tin món ăn";
            // 
            // btnOpenIMG
            // 
            this.btnOpenIMG.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenIMG.Image")));
            this.btnOpenIMG.Location = new System.Drawing.Point(308, 199);
            this.btnOpenIMG.Name = "btnOpenIMG";
            this.btnOpenIMG.Size = new System.Drawing.Size(80, 23);
            this.btnOpenIMG.TabIndex = 5;
            this.btnOpenIMG.Text = "Duyệt ảnh";
            this.btnOpenIMG.Click += new System.EventHandler(this.btnOpenIMG_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl8.Location = new System.Drawing.Point(318, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Ảnh đại diện";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(91, 164);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Size = new System.Drawing.Size(177, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl1.Location = new System.Drawing.Point(20, 167);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Đơn giá";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(91, 126);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUnit.Properties.Appearance.Options.UseFont = true;
            this.txtUnit.Size = new System.Drawing.Size(177, 20);
            this.txtUnit.TabIndex = 3;
            // 
            // lookFoodGroup
            // 
            this.lookFoodGroup.EditValue = "";
            this.lookFoodGroup.Location = new System.Drawing.Point(91, 87);
            this.lookFoodGroup.Name = "lookFoodGroup";
            this.lookFoodGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFoodGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FGrName", "Nhóm món")});
            this.lookFoodGroup.Size = new System.Drawing.Size(177, 20);
            this.lookFoodGroup.TabIndex = 2;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(91, 50);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFoodName.Properties.Appearance.Options.UseFont = true;
            this.txtFoodName.Size = new System.Drawing.Size(177, 20);
            this.txtFoodName.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl5.Location = new System.Drawing.Point(20, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Tên món";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl7.Location = new System.Drawing.Point(20, 129);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Đơn vị";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl6.Location = new System.Drawing.Point(20, 90);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Nhóm món";
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(428, 50);
            this.ucUpdate1.TabIndex = 3;
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(286, 69);
            this.picFood.Name = "picFood";
            this.picFood.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picFood.Size = new System.Drawing.Size(120, 111);
            this.picFood.TabIndex = 23;
            this.picFood.Click += new System.EventHandler(this.btnOpenIMG_Click);
            // 
            // frmFoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 290);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmFoodAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            this.Load += new System.EventHandler(this.frmFoodAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFoodGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private LabelControl labelControl5;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private TextEdit txtPrice;
        private LabelControl labelControl1;
        private TextEdit txtUnit;
        private LookUpEdit lookFoodGroup;
        private TextEdit txtFoodName;
        private SimpleButton btnOpenIMG;
        private LabelControl labelControl8;
        private PictureEdit picFood;

    }
}