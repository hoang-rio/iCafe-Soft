using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControl;

namespace iCafe.UserControls
{
    partial class ucSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSales));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabZone2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.tabZone1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.srchCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookEvent = new DevExpress.XtraEditors.LookUpEdit();
            this.btnaddMon = new DevExpress.XtraEditors.CheckButton();
            this.rtbRunevt = new System.Windows.Forms.RichTextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.gridCDaban = new DevExpress.XtraGrid.GridControl();
            this.gridVDadat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZoneCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbltenmon = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.btnBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnInBep = new DevExpress.XtraEditors.SimpleButton();
            this.btnThutien = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnApgia = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.imgListFood = new DevExpress.XtraEditors.ImageListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listFGroup = new DevExpress.XtraEditors.ImageListBoxControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabZone2)).BeginInit();
            this.tabZone2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabZone1)).BeginInit();
            this.tabZone1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookEvent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCDaban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVDadat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgListFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(874, 525);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.tabZone2);
            this.panelControl2.Controls.Add(this.tabZone1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(403, 525);
            this.panelControl2.TabIndex = 2;
            // 
            // tabZone2
            // 
            this.tabZone2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabZone2.Location = new System.Drawing.Point(2, 302);
            this.tabZone2.Name = "tabZone2";
            this.tabZone2.SelectedTabPage = this.xtraTabPage3;
            this.tabZone2.Size = new System.Drawing.Size(399, 221);
            this.tabZone2.TabIndex = 1;
            this.tabZone2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(393, 193);
            this.xtraTabPage3.Text = "xtraTabPage3";
            // 
            // tabZone1
            // 
            this.tabZone1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabZone1.Location = new System.Drawing.Point(2, 2);
            this.tabZone1.Name = "tabZone1";
            this.tabZone1.SelectedTabPage = this.xtraTabPage1;
            this.tabZone1.Size = new System.Drawing.Size(399, 300);
            this.tabZone1.TabIndex = 0;
            this.tabZone1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.Color.Transparent;
            this.xtraTabPage1.Appearance.PageClient.ForeColor = System.Drawing.Color.Transparent;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.PageClient.Options.UseForeColor = true;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(393, 272);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.groupControl2);
            this.panelControl3.Controls.Add(this.groupControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(874, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(392, 525);
            this.panelControl3.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.srchCustomer);
            this.groupControl2.Controls.Add(this.lookEvent);
            this.groupControl2.Controls.Add(this.btnaddMon);
            this.groupControl2.Controls.Add(this.rtbRunevt);
            this.groupControl2.Controls.Add(this.txtPrice);
            this.groupControl2.Controls.Add(this.gridCDaban);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.numQuantity);
            this.groupControl2.Controls.Add(this.lbltenmon);
            this.groupControl2.Controls.Add(this.lblMoney);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(388, 401);
            this.groupControl2.TabIndex = 23;
            this.groupControl2.Text = "Bán hàng";
            // 
            // srchCustomer
            // 
            this.srchCustomer.Location = new System.Drawing.Point(120, 158);
            this.srchCustomer.Name = "srchCustomer";
            this.srchCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srchCustomer.Properties.View = this.searchCustomer;
            this.srchCustomer.Size = new System.Drawing.Size(250, 20);
            this.srchCustomer.TabIndex = 67;
            this.srchCustomer.TextChanged += new System.EventHandler(this.srchCustomer_TextChanged);
            // 
            // searchCustomer
            // 
            this.searchCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CusName});
            this.searchCustomer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // CusName
            // 
            this.CusName.Caption = "Tên khách hàng";
            this.CusName.FieldName = "CusName";
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 0;
            // 
            // lookEvent
            // 
            this.lookEvent.EditValue = "Chọn sự kiện";
            this.lookEvent.Location = new System.Drawing.Point(120, 24);
            this.lookEvent.Name = "lookEvent";
            this.lookEvent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookEvent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EventName", "Sự kiện")});
            this.lookEvent.Size = new System.Drawing.Size(178, 20);
            this.lookEvent.TabIndex = 66;
            this.lookEvent.TextChanged += new System.EventHandler(this.lookEvent_TabIndexChanged);
            // 
            // btnaddMon
            // 
            this.btnaddMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddMon.Image = ((System.Drawing.Image)(resources.GetObject("btnaddMon.Image")));
            this.btnaddMon.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnaddMon.Location = new System.Drawing.Point(337, 184);
            this.btnaddMon.Name = "btnaddMon";
            this.btnaddMon.Size = new System.Drawing.Size(33, 24);
            this.btnaddMon.TabIndex = 64;
            this.btnaddMon.CheckedChanged += new System.EventHandler(this.btnaddMon_CheckedChanged);
            // 
            // rtbRunevt
            // 
            this.rtbRunevt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRunevt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRunevt.Enabled = false;
            this.rtbRunevt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbRunevt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbRunevt.Location = new System.Drawing.Point(23, 53);
            this.rtbRunevt.Name = "rtbRunevt";
            this.rtbRunevt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbRunevt.Size = new System.Drawing.Size(347, 99);
            this.rtbRunevt.TabIndex = 65;
            this.rtbRunevt.Text = "Sự kiện diễn ra ở đây.\nNếu gặp dòng này chứng tỏ hôm nay không có sự kiện\nHay luô" +
    "n theo dõi chúng tôi để sớm cập nhật mọi sự kiện\nmới nhất!\nDEV TEAM!";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(184, 187);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 21);
            this.txtPrice.TabIndex = 63;
            // 
            // gridCDaban
            // 
            this.gridCDaban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCDaban.Location = new System.Drawing.Point(2, 215);
            this.gridCDaban.MainView = this.gridVDadat;
            this.gridCDaban.Name = "gridCDaban";
            this.gridCDaban.Size = new System.Drawing.Size(382, 147);
            this.gridCDaban.TabIndex = 54;
            this.gridCDaban.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVDadat});
            // 
            // gridVDadat
            // 
            this.gridVDadat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodName,
            this.Quantity,
            this.FPrice,
            this.TotalDiscount,
            this.TotalPrice,
            this.ZoneCost});
            this.gridVDadat.GridControl = this.gridCDaban;
            this.gridVDadat.Name = "gridVDadat";
            this.gridVDadat.OptionsView.ShowGroupPanel = false;
            // 
            // FoodName
            // 
            this.FoodName.AppearanceCell.Options.UseTextOptions = true;
            this.FoodName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.AppearanceHeader.Options.UseTextOptions = true;
            this.FoodName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.Caption = "Món";
            this.FoodName.FieldName = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.Visible = true;
            this.FoodName.VisibleIndex = 0;
            this.FoodName.Width = 132;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Số lượng";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 1;
            this.Quantity.Width = 94;
            // 
            // FPrice
            // 
            this.FPrice.AppearanceCell.Options.UseTextOptions = true;
            this.FPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.FPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FPrice.Caption = "Đơn giá";
            this.FPrice.FieldName = "FPrice";
            this.FPrice.Name = "FPrice";
            this.FPrice.Visible = true;
            this.FPrice.VisibleIndex = 2;
            this.FPrice.Width = 119;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.TotalDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalDiscount.Caption = "% CK";
            this.TotalDiscount.FieldName = "TotalDiscount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.Visible = true;
            this.TotalDiscount.VisibleIndex = 4;
            this.TotalDiscount.Width = 59;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.TotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalPrice.Caption = "Thành tiền";
            this.TotalPrice.FieldName = "Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 5;
            this.TotalPrice.Width = 105;
            // 
            // ZoneCost
            // 
            this.ZoneCost.AppearanceCell.Options.UseTextOptions = true;
            this.ZoneCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneCost.AppearanceHeader.Options.UseTextOptions = true;
            this.ZoneCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneCost.Caption = "Giá %KV";
            this.ZoneCost.FieldName = "ZoneCost";
            this.ZoneCost.Name = "ZoneCost";
            this.ZoneCost.Visible = true;
            this.ZoneCost.VisibleIndex = 3;
            this.ZoneCost.Width = 94;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Sự kiện";
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantity.Location = new System.Drawing.Point(120, 187);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(36, 21);
            this.numQuantity.TabIndex = 62;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbltenmon
            // 
            this.lbltenmon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltenmon.AutoSize = true;
            this.lbltenmon.BackColor = System.Drawing.Color.Transparent;
            this.lbltenmon.Location = new System.Drawing.Point(20, 190);
            this.lbltenmon.Name = "lbltenmon";
            this.lbltenmon.Size = new System.Drawing.Size(0, 13);
            this.lbltenmon.TabIndex = 61;
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(120, 374);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(250, 18);
            this.lblMoney.TabIndex = 57;
            this.lblMoney.Text = "0 VNĐ";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "Thanh toán";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Khách hàng";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnexit);
            this.groupControl4.Controls.Add(this.btnBill);
            this.groupControl4.Controls.Add(this.btnInBep);
            this.groupControl4.Controls.Add(this.btnThutien);
            this.groupControl4.Controls.Add(this.btnInPhieu);
            this.groupControl4.Controls.Add(this.btnApgia);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(2, 403);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(388, 120);
            this.groupControl4.TabIndex = 24;
            this.groupControl4.Text = "Control";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(274, 70);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 34);
            this.btnexit.TabIndex = 51;
            this.btnexit.Text = "Đóng";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnBill
            // 
            this.btnBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.Location = new System.Drawing.Point(155, 70);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(85, 34);
            this.btnBill.TabIndex = 53;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnInBep
            // 
            this.btnInBep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInBep.Image = ((System.Drawing.Image)(resources.GetObject("btnInBep.Image")));
            this.btnInBep.Location = new System.Drawing.Point(43, 70);
            this.btnInBep.Name = "btnInBep";
            this.btnInBep.Size = new System.Drawing.Size(78, 34);
            this.btnInBep.TabIndex = 48;
            this.btnInBep.Text = "In bếp";
            // 
            // btnThutien
            // 
            this.btnThutien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThutien.Image = ((System.Drawing.Image)(resources.GetObject("btnThutien.Image")));
            this.btnThutien.Location = new System.Drawing.Point(155, 24);
            this.btnThutien.Name = "btnThutien";
            this.btnThutien.Size = new System.Drawing.Size(85, 34);
            this.btnThutien.TabIndex = 52;
            this.btnThutien.Text = "Thu tiền";
            this.btnThutien.Click += new System.EventHandler(this.btnThutien_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.Image")));
            this.btnInPhieu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnInPhieu.Location = new System.Drawing.Point(274, 24);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(85, 34);
            this.btnInPhieu.TabIndex = 50;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click_1);
            // 
            // btnApgia
            // 
            this.btnApgia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApgia.Image = ((System.Drawing.Image)(resources.GetObject("btnApgia.Image")));
            this.btnApgia.Location = new System.Drawing.Point(43, 24);
            this.btnApgia.Name = "btnApgia";
            this.btnApgia.Size = new System.Drawing.Size(78, 34);
            this.btnApgia.TabIndex = 49;
            this.btnApgia.Text = "Áp giá";
            this.btnApgia.Click += new System.EventHandler(this.btnApgia_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.imgListFood);
            this.panelControl4.Controls.Add(this.groupControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(403, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(471, 525);
            this.panelControl4.TabIndex = 17;
            // 
            // imgListFood
            // 
            this.imgListFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgListFood.Location = new System.Drawing.Point(2, 288);
            this.imgListFood.Name = "imgListFood";
            this.imgListFood.Size = new System.Drawing.Size(467, 235);
            this.imgListFood.TabIndex = 23;
            this.imgListFood.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.imgListFood_DrawItem);
            this.imgListFood.Click += new System.EventHandler(this.imgListFood_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listFGroup);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.txtsearch);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(467, 286);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Danh mục Món";
            // 
            // listFGroup
            // 
            this.listFGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.listFGroup.Location = new System.Drawing.Point(2, 21);
            this.listFGroup.Name = "listFGroup";
            this.listFGroup.Size = new System.Drawing.Size(463, 229);
            this.listFGroup.TabIndex = 22;
            this.listFGroup.SelectedIndexChanged += new System.EventHandler(this.listFGroup_SelectedIndexChanged);
            this.listFGroup.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.listFGroup_DrawItem);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Location = new System.Drawing.Point(51, 259);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(411, 21);
            this.txtsearch.TabIndex = 20;
            // 
            // ucSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(1266, 525);
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabZone2)).EndInit();
            this.tabZone2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabZone1)).EndInit();
            this.tabZone1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookEvent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCDaban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVDadat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgListFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.RichTextBox rtbRunevt;
        private DevExpress.XtraEditors.CheckButton btnaddMon;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lbltenmon;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnInBep;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnBill;
        private DevExpress.XtraEditors.SimpleButton btnApgia;
        private DevExpress.XtraGrid.GridControl gridCDaban;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVDadat;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnThutien;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private DevExpress.XtraEditors.ImageListBoxControl listFGroup;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private GroupControl groupControl2;
        private GroupControl groupControl4;
        private DevExpress.XtraTab.XtraTabControl tabZone2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl tabZone1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ImageListBoxControl imgListFood;
        private LookUpEdit lookEvent;
        private DevExpress.XtraGrid.Columns.GridColumn FoodName;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn FPrice;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private SearchLookUpEdit srchCustomer;
        private GridView searchCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn CusName;
        private Label lblMoney;
        private Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ZoneCost;

    }
}