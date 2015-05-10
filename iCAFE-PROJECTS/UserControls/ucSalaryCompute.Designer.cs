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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalBonusPunish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalaryOfMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalaryOverTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnToxlsx = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnToxls = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblthang = new System.Windows.Forms.Label();
            this.cbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.PerName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(859, 472);
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
            this.Total,
            this.SalaryOverTime,
            this.PerName});
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
            this.Salary.Caption = "Lương";
            this.Salary.DisplayFormat.FormatString = "c";
            this.Salary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Salary.FieldName = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Visible = true;
            this.Salary.VisibleIndex = 2;
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
            this.TotalBonusPunish.DisplayFormat.FormatString = "c";
            this.TotalBonusPunish.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalBonusPunish.FieldName = "TotalBonusPunish";
            this.TotalBonusPunish.Name = "TotalBonusPunish";
            this.TotalBonusPunish.Visible = true;
            this.TotalBonusPunish.VisibleIndex = 4;
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
            this.SalaryOfMonth.DisplayFormat.FormatString = "c";
            this.SalaryOfMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalaryOfMonth.FieldName = "SalaryOfMonth";
            this.SalaryOfMonth.Name = "SalaryOfMonth";
            this.SalaryOfMonth.Visible = true;
            this.SalaryOfMonth.VisibleIndex = 6;
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
            this.Total.DisplayFormat.FormatString = "c";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 5;
            // 
            // SalaryOverTime
            // 
            this.SalaryOverTime.AppearanceCell.Options.UseTextOptions = true;
            this.SalaryOverTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalaryOverTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SalaryOverTime.AppearanceHeader.Options.UseTextOptions = true;
            this.SalaryOverTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalaryOverTime.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SalaryOverTime.Caption = "Lương ngoài giờ";
            this.SalaryOverTime.DisplayFormat.FormatString = "c";
            this.SalaryOverTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalaryOverTime.FieldName = "SalaryOverTime";
            this.SalaryOverTime.Name = "SalaryOverTime";
            this.SalaryOverTime.Visible = true;
            this.SalaryOverTime.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnToxlsx,
            this.btnToxls,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 3;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.LargeGlyph = global::iCafe.Properties.Resources.cancel;
            this.btnClose.MinSize = new System.Drawing.Size(80, 0);
            this.btnClose.Name = "btnClose";
            toolTipTitleItem3.Appearance.Image = global::iCafe.Properties.Resources.cancel;
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = global::iCafe.Properties.Resources.cancel;
            toolTipTitleItem3.Text = "Đóng (Alt+F4)";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnClose.SuperTip = superToolTip3;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
            this.barDockControlBottom.Size = new System.Drawing.Size(859, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 472);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(859, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 472);
            // 
            // lblthang
            // 
            this.lblthang.AutoSize = true;
            this.lblthang.Location = new System.Drawing.Point(446, 23);
            this.lblthang.Name = "lblthang";
            this.lblthang.Size = new System.Drawing.Size(37, 13);
            this.lblthang.TabIndex = 9;
            this.lblthang.Text = "Tháng";
            // 
            // cbMonth
            // 
            this.cbMonth.Location = new System.Drawing.Point(490, 21);
            this.cbMonth.MenuManager = this.barManager1;
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMonth.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Size = new System.Drawing.Size(132, 20);
            this.cbMonth.TabIndex = 10;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbYear
            // 
            this.cbYear.Location = new System.Drawing.Point(681, 20);
            this.cbYear.MenuManager = this.barManager1;
            this.cbYear.Name = "cbYear";
            this.cbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbYear.Properties.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016"});
            this.cbYear.Size = new System.Drawing.Size(132, 20);
            this.cbYear.TabIndex = 12;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Năm";
            // 
            // PerName
            // 
            this.PerName.AppearanceCell.Options.UseTextOptions = true;
            this.PerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PerName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PerName.AppearanceHeader.Options.UseTextOptions = true;
            this.PerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PerName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PerName.Caption = "Chức vụ";
            this.PerName.FieldName = "PerName";
            this.PerName.Name = "PerName";
            this.PerName.Visible = true;
            this.PerName.VisibleIndex = 1;
            // 
            // ucSalaryCompute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lblthang);
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
            ((System.ComponentModel.ISupportInitialize)(this.cbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn SalaryOverTime;
        private DevExpress.XtraEditors.ComboBoxEdit cbYear;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbMonth;
        private System.Windows.Forms.Label lblthang;
        private DevExpress.XtraGrid.Columns.GridColumn PerName;

    }
}
