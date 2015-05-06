using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmBookTableAdd
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
            this.groupKH = new DevExpress.XtraEditors.GroupControl();
            this.lookTable = new DevExpress.XtraEditors.LookUpEdit();
            this.lookZone = new DevExpress.XtraEditors.LookUpEdit();
            this.lookCus = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucSimpleControl1 = new iCafe.BaseControls.ucSimpleControl();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEndTime = new DevExpress.XtraEditors.DateEdit();
            this.dateBookTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescript = new DevExpress.XtraEditors.MemoEdit();
            this.spinNumPeople = new DevExpress.XtraEditors.SpinEdit();
            this.txtDeposit = new DevExpress.XtraEditors.TextEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.btnaddCus = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).BeginInit();
            this.groupKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookZone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBookTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBookTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumPeople.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupKH
            // 
            this.groupKH.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupKH.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupKH.AppearanceCaption.Options.UseFont = true;
            this.groupKH.AppearanceCaption.Options.UseForeColor = true;
            this.groupKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupKH.Controls.Add(this.btnaddCus);
            this.groupKH.Controls.Add(this.lookTable);
            this.groupKH.Controls.Add(this.lookZone);
            this.groupKH.Controls.Add(this.lookCus);
            this.groupKH.Controls.Add(this.groupControl1);
            this.groupKH.Controls.Add(this.cbStatus);
            this.groupKH.Controls.Add(this.dateEndTime);
            this.groupKH.Controls.Add(this.dateBookTime);
            this.groupKH.Controls.Add(this.labelControl11);
            this.groupKH.Controls.Add(this.labelControl10);
            this.groupKH.Controls.Add(this.labelControl9);
            this.groupKH.Controls.Add(this.labelControl8);
            this.groupKH.Controls.Add(this.labelControl4);
            this.groupKH.Controls.Add(this.labelControl3);
            this.groupKH.Controls.Add(this.labelControl2);
            this.groupKH.Controls.Add(this.labelControl6);
            this.groupKH.Controls.Add(this.labelControl1);
            this.groupKH.Controls.Add(this.txtDescript);
            this.groupKH.Controls.Add(this.spinNumPeople);
            this.groupKH.Controls.Add(this.txtDeposit);
            this.groupKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKH.Location = new System.Drawing.Point(0, 50);
            this.groupKH.Name = "groupKH";
            this.groupKH.Size = new System.Drawing.Size(672, 449);
            this.groupKH.TabIndex = 5;
            this.groupKH.Text = "Cập nhật thông tin đặt bàn";
            // 
            // lookTable
            // 
            this.lookTable.Location = new System.Drawing.Point(111, 161);
            this.lookTable.Name = "lookTable";
            this.lookTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookTable.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableName", "Tên bàn")});
            this.lookTable.Properties.NullText = "Chọn bàn";
            this.lookTable.Size = new System.Drawing.Size(177, 20);
            this.lookTable.TabIndex = 19;
            // 
            // lookZone
            // 
            this.lookZone.Location = new System.Drawing.Point(111, 126);
            this.lookZone.Name = "lookZone";
            this.lookZone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookZone.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ZoneName", "Khu vực")});
            this.lookZone.Properties.NullText = "Chọn khu vực";
            this.lookZone.Size = new System.Drawing.Size(177, 20);
            this.lookZone.TabIndex = 19;
            this.lookZone.EditValueChanged += new System.EventHandler(this.lookZone_EditValueChanged);
            // 
            // lookCus
            // 
            this.lookCus.Location = new System.Drawing.Point(111, 235);
            this.lookCus.Name = "lookCus";
            this.lookCus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCus.Properties.NullText = "Chọn khách hàng";
            this.lookCus.Properties.View = this.searchLookUpEdit1View;
            this.lookCus.Size = new System.Drawing.Size(177, 20);
            this.lookCus.TabIndex = 18;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CusName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // CusName
            // 
            this.CusName.Caption = "Tên khách hàng";
            this.CusName.FieldName = "CusName";
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.ucSimpleControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(319, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(351, 419);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Đặt món";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(347, 354);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodName,
            this.Quantity,
            this.FUnit,
            this.TotalPrice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FoodName
            // 
            this.FoodName.Caption = "Tên món";
            this.FoodName.FieldName = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.OptionsColumn.AllowEdit = false;
            this.FoodName.Visible = true;
            this.FoodName.VisibleIndex = 0;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Số lượng";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 1;
            // 
            // FUnit
            // 
            this.FUnit.Caption = "Đơn vị tính";
            this.FUnit.FieldName = "FUnit";
            this.FUnit.Name = "FUnit";
            this.FUnit.OptionsColumn.AllowEdit = false;
            this.FUnit.Visible = true;
            this.FUnit.VisibleIndex = 2;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "Tổng giá trị";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.OptionsColumn.AllowEdit = false;
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 3;
            // 
            // ucSimpleControl1
            // 
            this.ucSimpleControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSimpleControl1.Location = new System.Drawing.Point(2, 21);
            this.ucSimpleControl1.Name = "ucSimpleControl1";
            this.ucSimpleControl1.Size = new System.Drawing.Size(347, 42);
            this.ucSimpleControl1.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(111, 48);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Đang chờ",
            "Đã kết thúc"});
            this.cbStatus.Size = new System.Drawing.Size(177, 20);
            this.cbStatus.TabIndex = 1;
            // 
            // dateEndTime
            // 
            this.dateEndTime.EditValue = null;
            this.dateEndTime.Location = new System.Drawing.Point(111, 197);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateEndTime.Properties.Appearance.Options.UseFont = true;
            this.dateEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEndTime.Properties.Mask.EditMask = "G";
            this.dateEndTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEndTime.Size = new System.Drawing.Size(177, 20);
            this.dateEndTime.TabIndex = 3;
            // 
            // dateBookTime
            // 
            this.dateBookTime.EditValue = null;
            this.dateBookTime.Location = new System.Drawing.Point(111, 85);
            this.dateBookTime.Name = "dateBookTime";
            this.dateBookTime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateBookTime.Properties.Appearance.Options.UseFont = true;
            this.dateBookTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBookTime.Properties.Mask.EditMask = "G";
            this.dateBookTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateBookTime.Size = new System.Drawing.Size(177, 20);
            this.dateBookTime.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl11.Location = new System.Drawing.Point(31, 313);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "Số người";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl10.Location = new System.Drawing.Point(31, 276);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 13);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Đặt cọc";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Location = new System.Drawing.Point(31, 238);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Khách hàng";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Location = new System.Drawing.Point(31, 200);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Hết hạn";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(31, 352);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Ghi chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(31, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Bàn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(31, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Khu vực";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Location = new System.Drawing.Point(31, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Thời gian đặt";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(31, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Trạng thái";
            // 
            // txtDescript
            // 
            this.txtDescript.EditValue = "";
            this.txtDescript.Location = new System.Drawing.Point(111, 349);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDescript.Properties.Appearance.Options.UseFont = true;
            this.txtDescript.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtDescript.Size = new System.Drawing.Size(177, 96);
            this.txtDescript.TabIndex = 7;
            // 
            // spinNumPeople
            // 
            this.spinNumPeople.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumPeople.Location = new System.Drawing.Point(111, 310);
            this.spinNumPeople.Name = "spinNumPeople";
            this.spinNumPeople.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.spinNumPeople.Properties.Appearance.Options.UseFont = true;
            this.spinNumPeople.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinNumPeople.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinNumPeople.Properties.Mask.EditMask = "n0";
            this.spinNumPeople.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinNumPeople.Properties.MaxLength = 3;
            this.spinNumPeople.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinNumPeople.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumPeople.Size = new System.Drawing.Size(177, 20);
            this.spinNumPeople.TabIndex = 6;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(111, 273);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDeposit.Properties.Appearance.Options.UseFont = true;
            this.txtDeposit.Size = new System.Drawing.Size(177, 20);
            this.txtDeposit.TabIndex = 5;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(672, 50);
            this.ucUpdate1.TabIndex = 4;
            // 
            // btnaddCus
            // 
            this.btnaddCus.Image = global::iCafe.Properties.Resources._new;
            this.btnaddCus.Location = new System.Drawing.Point(290, 233);
            this.btnaddCus.Name = "btnaddCus";
            this.btnaddCus.Size = new System.Drawing.Size(23, 23);
            this.btnaddCus.TabIndex = 20;
            this.btnaddCus.Click += new System.EventHandler(this.btnaddCus_Click);
            // 
            // frmBookTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 499);
            this.ControlBox = false;
            this.Controls.Add(this.groupKH);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmBookTableAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            this.Load += new System.EventHandler(this.frmBookTableAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).EndInit();
            this.groupKH.ResumeLayout(false);
            this.groupKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookZone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBookTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBookTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescript.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumPeople.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupKH;
        private LabelControl labelControl4;
        private LabelControl labelControl6;
        private LabelControl labelControl1;
        private ucUpdate ucUpdate1;
        private LabelControl labelControl11;
        private LabelControl labelControl10;
        private LabelControl labelControl9;
        private LabelControl labelControl8;
        private DateEdit dateEndTime;
        private DateEdit dateBookTime;
        private MemoEdit txtDescript;
        private ComboBoxEdit cbStatus;
        private SpinEdit spinNumPeople;
        private TextEdit txtDeposit;
        private GroupControl groupControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private ucSimpleControl ucSimpleControl1;
        private GridColumn FoodName;
        private GridColumn Quantity;
        private GridColumn FUnit;
        private GridColumn TotalPrice;
        private SearchLookUpEdit lookCus;
        private GridView searchLookUpEdit1View;
        private GridColumn CusName;
        private LookUpEdit lookTable;
        private LookUpEdit lookZone;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private SimpleButton btnaddCus;
    }
}