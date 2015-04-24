namespace iCafe.BaseControls
{
    partial class ucUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barUpdate = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnFCapNhat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnFNapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnFTroGiup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnFDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnXoa.MinSize = new System.Drawing.Size(60, 0);
            this.btnXoa.Name = "btnXoa";
            toolTipTitleItem1.Text = "Xóa (Delete)";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnXoa.SuperTip = superToolTip1;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barUpdate
            // 
            this.barUpdate.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barUpdate.DockControls.Add(this.barDockControlTop);
            this.barUpdate.DockControls.Add(this.barDockControlBottom);
            this.barUpdate.DockControls.Add(this.barDockControlLeft);
            this.barUpdate.DockControls.Add(this.barDockControlRight);
            this.barUpdate.Form = this;
            this.barUpdate.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnFCapNhat,
            this.btnFNapLai,
            this.btnFTroGiup,
            this.btnFDong});
            this.barUpdate.MainMenu = this.bar2;
            this.barUpdate.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFCapNhat, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFNapLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFTroGiup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFDong)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnFCapNhat
            // 
            this.btnFCapNhat.Caption = "Cập Nhật";
            this.btnFCapNhat.Id = 0;
            this.btnFCapNhat.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnFCapNhat.LargeGlyph = global::iCafe.Properties.Resources.save;
            this.btnFCapNhat.MinSize = new System.Drawing.Size(80, 0);
            this.btnFCapNhat.Name = "btnFCapNhat";
            toolTipTitleItem2.Text = "Cập Nhật (Ctrl+S)";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnFCapNhat.SuperTip = superToolTip2;
            this.btnFCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFCapNhat_ItemClick);
            // 
            // btnFNapLai
            // 
            this.btnFNapLai.Caption = "Nạp Lại";
            this.btnFNapLai.Id = 1;
            this.btnFNapLai.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnFNapLai.LargeGlyph = global::iCafe.Properties.Resources.renew;
            this.btnFNapLai.MinSize = new System.Drawing.Size(80, 0);
            this.btnFNapLai.Name = "btnFNapLai";
            toolTipTitleItem3.Text = "Nạp Lại(F5)";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnFNapLai.SuperTip = superToolTip3;
            this.btnFNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFNapLai_ItemClick);
            // 
            // btnFTroGiup
            // 
            this.btnFTroGiup.Caption = "Trợ Giúp";
            this.btnFTroGiup.Id = 2;
            this.btnFTroGiup.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnFTroGiup.LargeGlyph = global::iCafe.Properties.Resources.Help;
            this.btnFTroGiup.MinSize = new System.Drawing.Size(80, 0);
            this.btnFTroGiup.Name = "btnFTroGiup";
            toolTipTitleItem4.Text = "Trợ Giúp (F1)";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.btnFTroGiup.SuperTip = superToolTip4;
            this.btnFTroGiup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFTroGiup_ItemClick);
            // 
            // btnFDong
            // 
            this.btnFDong.Caption = "Đóng";
            this.btnFDong.Id = 3;
            this.btnFDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnFDong.LargeGlyph = global::iCafe.Properties.Resources.cancel;
            this.btnFDong.MinSize = new System.Drawing.Size(80, 0);
            this.btnFDong.Name = "btnFDong";
            toolTipTitleItem5.Text = "Đóng(Alt+F4)";
            superToolTip5.Items.Add(toolTipTitleItem5);
            this.btnFDong.SuperTip = superToolTip5;
            this.btnFDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(356, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 41);
            this.barDockControlBottom.Size = new System.Drawing.Size(356, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(356, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // ucUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucUpdate";
            this.Size = new System.Drawing.Size(356, 41);
            ((System.ComponentModel.ISupportInitialize)(this.barUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.Bar bar2;
        public DevExpress.XtraBars.BarLargeButtonItem btnFCapNhat;
        public DevExpress.XtraBars.BarLargeButtonItem btnFNapLai;
        public DevExpress.XtraBars.BarLargeButtonItem btnFTroGiup;
        public DevExpress.XtraBars.BarLargeButtonItem btnFDong;
        public DevExpress.XtraBars.BarManager barUpdate;
    }
}
