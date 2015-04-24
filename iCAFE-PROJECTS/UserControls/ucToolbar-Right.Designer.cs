using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace iCafe.UserControls
{
    partial class ucToolbar_Right
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnRegistry = new DevExpress.XtraEditors.SimpleButton();
            this.btnBank = new DevExpress.XtraEditors.SimpleButton();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnFont = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(38, 41);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "16:54:13";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(24, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thời gian làm việc";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblTime);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(154, 82);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 82);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(154, 294);
            this.panelControl2.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnRegistry);
            this.panelControl4.Controls.Add(this.btnBank);
            this.panelControl4.Controls.Add(this.btnHide);
            this.panelControl4.Controls.Add(this.simpleButton7);
            this.panelControl4.Controls.Add(this.btnCustomer);
            this.panelControl4.Controls.Add(this.btnMenu);
            this.panelControl4.Controls.Add(this.btnFont);
            this.panelControl4.Controls.Add(this.btnMaterial);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(150, 206);
            this.panelControl4.TabIndex = 9;
            // 
            // btnRegistry
            // 
            this.btnRegistry.Location = new System.Drawing.Point(21, 10);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(88, 16);
            this.btnRegistry.TabIndex = 7;
            this.btnRegistry.Text = "Tạo Tài khoản";
            this.btnRegistry.Click += new System.EventHandler(this.btnRegistry_Click);
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(21, 33);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(88, 16);
            this.btnBank.TabIndex = 6;
            this.btnBank.Text = "Đổi Mật khẩu";
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(21, 177);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(88, 16);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "Thoát";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(21, 154);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(88, 16);
            this.simpleButton7.TabIndex = 7;
            this.simpleButton7.Text = "Tùy chỉnh";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(21, 56);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(88, 19);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(21, 128);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(88, 19);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Thêm nhóm món";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(21, 82);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(88, 16);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Font chữ";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(21, 105);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(88, 16);
            this.btnMaterial.TabIndex = 6;
            this.btnMaterial.Text = "Thêm nguyên liệu";
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 208);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(150, 84);
            this.panelControl3.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(37, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "imic.edu.vn";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(13, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "iCafe-Project";
            // 
            // ucToolbar_Right
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucToolbar_Right";
            this.Size = new System.Drawing.Size(154, 376);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl labelControl1;
        private LabelControl lblTime;
        private Timer timer1;
        private PanelControl panelControl1;
        private PanelControl panelControl2;
        private SimpleButton btnCustomer;
        private SimpleButton btnBank;
        private SimpleButton btnRegistry;
        private SimpleButton btnHide;
        private SimpleButton btnMenu;
        private SimpleButton btnMaterial;
        private SimpleButton simpleButton7;
        private SimpleButton btnFont;
        private PanelControl panelControl3;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private PanelControl panelControl4;
    }
}
