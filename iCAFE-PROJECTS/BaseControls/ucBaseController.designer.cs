namespace iCafe.BaseControl
{
    partial class ucBaseController
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
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemMoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnNapLai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnTroGiup = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnBaoCao = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bBITimKiem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemMoi,
            this.btnEdit,
            this.btnXoa,
            this.btnNapLai,
            this.btnTroGiup,
            this.btnBaoCao,
            this.btnDong,
            this.bBITimKiem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNapLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTroGiup),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBaoCao),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBITimKiem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Caption = "Thêm mới";
            this.btnThemMoi.Id = 0;
            this.btnThemMoi.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnThemMoi.LargeGlyph = global::iCafe.Properties.Resources._new;
            this.btnThemMoi.Name = "btnThemMoi";
            toolTipTitleItem1.Text = "Thêm mới (Ctrl + N)";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnThemMoi.SuperTip = superToolTip1;
            this.btnThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemMoi_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnEdit.LargeGlyph = global::iCafe.Properties.Resources.action_settings;
            this.btnEdit.MinSize = new System.Drawing.Size(80, 0);
            this.btnEdit.Name = "btnEdit";
            toolTipTitleItem2.Text = "Sửa (F2)";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnEdit.SuperTip = superToolTip2;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnXoa.LargeGlyph = global::iCafe.Properties.Resources.delete;
            this.btnXoa.MinSize = new System.Drawing.Size(60, 0);
            this.btnXoa.Name = "btnXoa";
            toolTipTitleItem3.Text = "Xóa (Delete)";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnXoa.SuperTip = superToolTip3;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnNapLai
            // 
            this.btnNapLai.Caption = "Nạp Lại";
            this.btnNapLai.Id = 3;
            this.btnNapLai.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnNapLai.LargeGlyph = global::iCafe.Properties.Resources.renew;
            this.btnNapLai.MinSize = new System.Drawing.Size(80, 0);
            this.btnNapLai.Name = "btnNapLai";
            toolTipTitleItem4.Text = "Nạp Lại (F5)";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.btnNapLai.SuperTip = superToolTip4;
            this.btnNapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNapLai_ItemClick);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Caption = "Trợ Giúp";
            this.btnTroGiup.Id = 4;
            this.btnTroGiup.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnTroGiup.LargeGlyph = global::iCafe.Properties.Resources.Help;
            this.btnTroGiup.MinSize = new System.Drawing.Size(80, 0);
            this.btnTroGiup.Name = "btnTroGiup";
            toolTipTitleItem5.Text = "Trợ Giúp (F1)";
            superToolTip5.Items.Add(toolTipTitleItem5);
            this.btnTroGiup.SuperTip = superToolTip5;
            this.btnTroGiup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroGiup_ItemClick);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Caption = "Báo Cáo";
            this.btnBaoCao.Id = 5;
            this.btnBaoCao.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.btnBaoCao.LargeGlyph = global::iCafe.Properties.Resources.book_edit;
            this.btnBaoCao.MinSize = new System.Drawing.Size(80, 0);
            this.btnBaoCao.Name = "btnBaoCao";
            toolTipTitleItem6.Text = "Báo Cáo(F12)";
            superToolTip6.Items.Add(toolTipTitleItem6);
            this.btnBaoCao.SuperTip = superToolTip6;
            this.btnBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCao_ItemClick);
            // 
            // bBITimKiem
            // 
            this.bBITimKiem.Caption = "Tìm Kiếm";
            this.bBITimKiem.Id = 7;
            this.bBITimKiem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.bBITimKiem.LargeGlyph = global::iCafe.Properties.Resources.search;
            this.bBITimKiem.Name = "bBITimKiem";
            this.bBITimKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBITimKiem_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnDong.LargeGlyph = global::iCafe.Properties.Resources.cancel;
            this.btnDong.MinSize = new System.Drawing.Size(80, 0);
            this.btnDong.Name = "btnDong";
            toolTipTitleItem7.Text = "Đóng (Alt+F4)";
            superToolTip7.Items.Add(toolTipTitleItem7);
            this.btnDong.SuperTip = superToolTip7;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(656, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 50);
            this.barDockControlBottom.Size = new System.Drawing.Size(656, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 8);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(656, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 8);
            // 
            // ucBaseController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucBaseController";
            this.Size = new System.Drawing.Size(656, 50);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarLargeButtonItem btnDong;
        public DevExpress.XtraBars.BarLargeButtonItem btnThemMoi;
        public DevExpress.XtraBars.BarLargeButtonItem btnEdit;
        public DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        public DevExpress.XtraBars.BarLargeButtonItem btnNapLai;
        public DevExpress.XtraBars.BarLargeButtonItem btnTroGiup;
        public DevExpress.XtraBars.BarLargeButtonItem btnBaoCao;
        public DevExpress.XtraBars.BarLargeButtonItem bBITimKiem;
    }
}
