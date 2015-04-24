using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmPermissionAdd
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPerName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEvent = new DevExpress.XtraEditors.CheckEdit();
            this.checkSystem = new DevExpress.XtraEditors.CheckEdit();
            this.checkRevenue = new DevExpress.XtraEditors.CheckEdit();
            this.checkSale = new DevExpress.XtraEditors.CheckEdit();
            this.checkCustomer = new DevExpress.XtraEditors.CheckEdit();
            this.checkWareHouse = new DevExpress.XtraEditors.CheckEdit();
            this.checkFullPermis = new DevExpress.XtraEditors.CheckEdit();
            this.checkTable = new DevExpress.XtraEditors.CheckEdit();
            this.txtDescript = new DevExpress.XtraEditors.MemoEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEvent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSystem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRevenue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFullPermis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(46, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mô tả";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(12, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên chức vụ";
            // 
            // txtPerName
            // 
            this.txtPerName.Location = new System.Drawing.Point(88, 50);
            this.txtPerName.Name = "txtPerName";
            this.txtPerName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPerName.Properties.Appearance.Options.UseFont = true;
            this.txtPerName.Size = new System.Drawing.Size(225, 20);
            this.txtPerName.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtPerName);
            this.groupControl1.Controls.Add(this.txtDescript);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(326, 337);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Cập nhật thông tin chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEvent);
            this.groupBox1.Controls.Add(this.checkSystem);
            this.groupBox1.Controls.Add(this.checkRevenue);
            this.groupBox1.Controls.Add(this.checkSale);
            this.groupBox1.Controls.Add(this.checkCustomer);
            this.groupBox1.Controls.Add(this.checkWareHouse);
            this.groupBox1.Controls.Add(this.checkFullPermis);
            this.groupBox1.Controls.Add(this.checkTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân quyền hạn";
            // 
            // checkEvent
            // 
            this.checkEvent.Location = new System.Drawing.Point(15, 95);
            this.checkEvent.Name = "checkEvent";
            this.checkEvent.Properties.Caption = "Quản lý sự kiện";
            this.checkEvent.Size = new System.Drawing.Size(124, 19);
            this.checkEvent.TabIndex = 6;
            // 
            // checkSystem
            // 
            this.checkSystem.Location = new System.Drawing.Point(15, 45);
            this.checkSystem.Name = "checkSystem";
            this.checkSystem.Properties.Caption = "Quản lý hệ thống";
            this.checkSystem.Size = new System.Drawing.Size(124, 19);
            this.checkSystem.TabIndex = 4;
            // 
            // checkRevenue
            // 
            this.checkRevenue.Location = new System.Drawing.Point(15, 70);
            this.checkRevenue.Name = "checkRevenue";
            this.checkRevenue.Properties.Caption = "Quản lý doanh thu";
            this.checkRevenue.Size = new System.Drawing.Size(124, 19);
            this.checkRevenue.TabIndex = 5;
            // 
            // checkSale
            // 
            this.checkSale.Location = new System.Drawing.Point(145, 20);
            this.checkSale.Name = "checkSale";
            this.checkSale.Properties.Caption = "Quản lý bán hàng";
            this.checkSale.Size = new System.Drawing.Size(124, 19);
            this.checkSale.TabIndex = 7;
            // 
            // checkCustomer
            // 
            this.checkCustomer.Location = new System.Drawing.Point(145, 70);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Properties.Caption = "Quản lý khách hàng";
            this.checkCustomer.Size = new System.Drawing.Size(124, 19);
            this.checkCustomer.TabIndex = 9;
            // 
            // checkWareHouse
            // 
            this.checkWareHouse.Location = new System.Drawing.Point(145, 95);
            this.checkWareHouse.Name = "checkWareHouse";
            this.checkWareHouse.Properties.Caption = "Quản lý kho";
            this.checkWareHouse.Size = new System.Drawing.Size(124, 19);
            this.checkWareHouse.TabIndex = 10;
            // 
            // checkFullPermis
            // 
            this.checkFullPermis.Location = new System.Drawing.Point(15, 20);
            this.checkFullPermis.Name = "checkFullPermis";
            this.checkFullPermis.Properties.Caption = "Toàn quyền";
            this.checkFullPermis.Size = new System.Drawing.Size(84, 19);
            this.checkFullPermis.TabIndex = 3;
            this.checkFullPermis.CheckedChanged += new System.EventHandler(this.checkFullPermis_CheckedChanged);
            // 
            // checkTable
            // 
            this.checkTable.Location = new System.Drawing.Point(145, 45);
            this.checkTable.Name = "checkTable";
            this.checkTable.Properties.Caption = "Quản lý bàn";
            this.checkTable.Size = new System.Drawing.Size(124, 19);
            this.checkTable.TabIndex = 8;
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(88, 87);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescript.Properties.Appearance.Options.UseFont = true;
            this.txtDescript.Size = new System.Drawing.Size(225, 97);
            this.txtDescript.TabIndex = 2;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(326, 50);
            this.ucUpdate1.TabIndex = 2;
            // 
            // frmPermissionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 387);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmPermissionAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.txtPerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEvent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSystem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRevenue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFullPermis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl labelControl3;
        private LabelControl labelControl1;
        private TextEdit txtPerName;
        private GroupControl groupControl1;
        private ucUpdate ucUpdate1;
        private CheckEdit checkFullPermis;
        private MemoEdit txtDescript;
        private GroupBox groupBox1;
        private CheckEdit checkEvent;
        private CheckEdit checkSystem;
        private CheckEdit checkRevenue;
        private CheckEdit checkSale;
        private CheckEdit checkCustomer;
        private CheckEdit checkWareHouse;
        private CheckEdit checkTable;
    }
}