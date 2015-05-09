namespace iCafe.UserControls
{
    partial class ucSalaryCompute
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalBonusPunish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalaryOfMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnToxlsx = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnToxls = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSetDate = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(859, 449);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fullname,
            this.Salary,
            this.TotalBonusPunish,
            this.SalaryOfMonth,
            this.Total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Fullname
            // 
            this.Fullname.AppearanceCell.Options.UseTextOptions = true;
            this.Fullname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Fullname.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Fullname.AppearanceHeader.Options.UseTextOptions = true;
            this.Fullname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Fullname.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Fullname.Caption = "Tên nhân viên";
            this.Fullname.FieldName = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.Visible = true;
            this.Fullname.VisibleIndex = 0;
            // 
            // Salary
            // 
            this.Salary.AppearanceCell.Options.UseTextOptions = true;
            this.Salary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Salary.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Salary.AppearanceHeader.Options.UseTextOptions = true;
            this.Salary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Salary.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Salary.Caption = "Lương + Lương Ngoài Giờ";
            this.Salary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Salary.FieldName = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Visible = true;
            this.Salary.VisibleIndex = 1;
            // 
            // TotalBonusPunish
            // 
            this.TotalBonusPunish.AppearanceCell.Options.UseTextOptions = true;
            this.TotalBonusPunish.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalBonusPunish.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TotalBonusPunish.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalBonusPunish.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalBonusPunish.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TotalBonusPunish.Caption = "Tổng thưởng phạt";
            this.TotalBonusPunish.FieldName = "TotalBonusPunish";
            this.TotalBonusPunish.Name = "TotalBonusPunish";
            this.TotalBonusPunish.Visible = true;
            this.TotalBonusPunish.VisibleIndex = 2;
            // 
            // SalaryOfMonth
            // 
            this.SalaryOfMonth.AppearanceCell.Options.UseTextOptions = true;
            this.SalaryOfMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalaryOfMonth.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SalaryOfMonth.AppearanceHeader.Options.UseTextOptions = true;
            this.SalaryOfMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalaryOfMonth.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SalaryOfMonth.Caption = "Lương tháng";
            this.SalaryOfMonth.FieldName = "SalaryOfMonth";
            this.SalaryOfMonth.Name = "SalaryOfMonth";
            this.SalaryOfMonth.Visible = true;
            this.SalaryOfMonth.VisibleIndex = 4;
            // 
            // Total
            // 
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Total.Caption = "Tổng cộng";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnToxlsx,
            this.btnToxls,
            this.btnSetDate,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnToxlsx, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnToxls, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSetDate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.AllowRename = true;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnToxlsx
            // 
            this.btnToxlsx.Caption = "Xuất ra Exel (xlsx)";
            this.btnToxlsx.Glyph = global::iCafe.Properties.Resources.xlsx1;
            this.btnToxlsx.Id = 0;
            this.btnToxlsx.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnToxlsx.MinSize = new System.Drawing.Size(80, 0);
            this.btnToxlsx.Name = "btnToxlsx";
            toolTipTitleItem1.Appearance.Image = global::iCafe.Properties.Resources.xlsx1;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = global::iCafe.Properties.Resources.xlsx1;
            toolTipTitleItem1.Text = "Xuất ra Exel (xlsx) (Ctrl+E)";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnToxlsx.SuperTip = superToolTip1;
            // 
            // btnToxls
            // 
            this.btnToxls.Caption = "Xuất ra Exel (xls)";
            this.btnToxls.Id = 1;
            this.btnToxls.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.E));
            this.btnToxls.LargeGlyph = global::iCafe.Properties.Resources.xls;
            this.btnToxls.MinSize = new System.Drawing.Size(80, 0);
            this.btnToxls.Name = "btnToxls";
            toolTipTitleItem2.Appearance.Image = global::iCafe.Properties.Resources.xls;
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = global::iCafe.Properties.Resources.xls;
            toolTipTitleItem2.Text = "Xuất ra Exel (xls) (Ctrl+Shift+E)";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnToxls.SuperTip = superToolTip2;
            // 
            // btnSetDate
            // 
            this.btnSetDate.Caption = "Đặt ngày tính lương";
            this.btnSetDate.Id = 2;
            this.btnSetDate.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnSetDate.LargeGlyph = global::iCafe.Properties.Resources.setdate;
            this.btnSetDate.MinSize = new System.Drawing.Size(80, 0);
            this.btnSetDate.Name = "btnSetDate";
            toolTipTitleItem3.Appearance.Image = global::iCafe.Properties.Resources.setdate;
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = global::iCafe.Properties.Resources.setdate;
            toolTipTitleItem3.Text = "Đặt ngày tính lương (Ctrl+D)";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnSetDate.SuperTip = superToolTip3;
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 3;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.LargeGlyph = global::iCafe.Properties.Resources.cancel;
            this.btnClose.MinSize = new System.Drawing.Size(80, 0);
            this.btnClose.Name = "btnClose";
            toolTipTitleItem4.Appearance.Image = global::iCafe.Properties.Resources.cancel;
            toolTipTitleItem4.Appearance.Options.UseImage = true;
            toolTipTitleItem4.Image = global::iCafe.Properties.Resources.cancel;
            toolTipTitleItem4.Text = "Đóng (Alt+F4)";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.btnClose.SuperTip = superToolTip4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(859, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Size = new System.Drawing.Size(859, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 449);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(859, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 449);
            // 
            // ucSalaryCompute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucSalaryCompute";
            this.Size = new System.Drawing.Size(859, 514);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Fullname;
        private DevExpress.XtraGrid.Columns.GridColumn Salary;
        private DevExpress.XtraGrid.Columns.GridColumn TotalBonusPunish;
        private DevExpress.XtraGrid.Columns.GridColumn SalaryOfMonth;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnToxlsx;
        private DevExpress.XtraBars.BarLargeButtonItem btnToxls;
        private DevExpress.XtraBars.BarLargeButtonItem btnSetDate;
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;

    }
}
