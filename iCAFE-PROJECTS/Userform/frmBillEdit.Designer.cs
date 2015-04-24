using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace iCafe.Userform
{
    partial class frmBillEdit
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.txtTable = new DevExpress.XtraEditors.TextEdit();
            this.txtEvent = new DevExpress.XtraEditors.TextEdit();
            this.txtCus = new DevExpress.XtraEditors.TextEdit();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtZoneCost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtZoneName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).BeginInit();
            this.groupKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoneCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoneName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupKH
            // 
            this.groupKH.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupKH.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupKH.AppearanceCaption.Options.UseFont = true;
            this.groupKH.AppearanceCaption.Options.UseForeColor = true;
            this.groupKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupKH.Controls.Add(this.groupControl1);
            this.groupKH.Controls.Add(this.dateTime);
            this.groupKH.Controls.Add(this.labelControl5);
            this.groupKH.Controls.Add(this.labelControl7);
            this.groupKH.Controls.Add(this.txtAfterDiscount);
            this.groupKH.Controls.Add(this.labelControl12);
            this.groupKH.Controls.Add(this.labelControl13);
            this.groupKH.Controls.Add(this.spinTotalDiscount);
            this.groupKH.Controls.Add(this.txtZoneName);
            this.groupKH.Controls.Add(this.txtZoneCost);
            this.groupKH.Controls.Add(this.txtTable);
            this.groupKH.Controls.Add(this.txtEvent);
            this.groupKH.Controls.Add(this.txtCus);
            this.groupKH.Controls.Add(this.txtValue);
            this.groupKH.Controls.Add(this.labelControl9);
            this.groupKH.Controls.Add(this.labelControl3);
            this.groupKH.Controls.Add(this.labelControl2);
            this.groupKH.Controls.Add(this.labelControl8);
            this.groupKH.Controls.Add(this.labelControl6);
            this.groupKH.Controls.Add(this.labelControl1);
            this.groupKH.Controls.Add(this.cbStatus);
            this.groupKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKH.Location = new System.Drawing.Point(0, 0);
            this.groupKH.Name = "groupKH";
            this.groupKH.Size = new System.Drawing.Size(715, 427);
            this.groupKH.TabIndex = 7;
            this.groupKH.Text = "Cập nhật thông tin hóa đơn";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(290, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(423, 397);
            this.groupControl1.TabIndex = 47;
            this.groupControl1.Text = "Chi tiết hóa đơn";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(419, 369);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodName,
            this.Quantity,
            this.Price});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FoodName
            // 
            this.FoodName.AppearanceCell.Options.UseTextOptions = true;
            this.FoodName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FoodName.AppearanceHeader.Options.UseTextOptions = true;
            this.FoodName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FoodName.Caption = "Tên món";
            this.FoodName.FieldName = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.Visible = true;
            this.FoodName.VisibleIndex = 0;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Quantity.Caption = "Số lượng";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 1;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Options.UseTextOptions = true;
            this.Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Price.Caption = "Giá trị";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.EditValue = null;
            this.dateTime.Location = new System.Drawing.Point(100, 385);
            this.dateTime.Name = "dateTime";
            this.dateTime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTime.Properties.Appearance.Options.UseFont = true;
            this.dateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTime.Size = new System.Drawing.Size(177, 20);
            this.dateTime.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(26, 388);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Thời gian";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(26, 351);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Thanh toán";
            // 
            // txtAfterDiscount
            // 
            this.txtAfterDiscount.Location = new System.Drawing.Point(100, 348);
            this.txtAfterDiscount.Name = "txtAfterDiscount";
            this.txtAfterDiscount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAfterDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtAfterDiscount.Size = new System.Drawing.Size(177, 20);
            this.txtAfterDiscount.TabIndex = 7;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl12.Location = new System.Drawing.Point(26, 311);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(51, 13);
            this.labelControl12.TabIndex = 39;
            this.labelControl12.Text = "Chiết khấu";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl13.Location = new System.Drawing.Point(26, 278);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(27, 13);
            this.labelControl13.TabIndex = 38;
            this.labelControl13.Text = "Giá trị";
            // 
            // spinTotalDiscount
            // 
            this.spinTotalDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalDiscount.Location = new System.Drawing.Point(100, 308);
            this.spinTotalDiscount.Name = "spinTotalDiscount";
            this.spinTotalDiscount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.spinTotalDiscount.Properties.Appearance.Options.UseFont = true;
            this.spinTotalDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinTotalDiscount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinTotalDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinTotalDiscount.Size = new System.Drawing.Size(177, 20);
            this.spinTotalDiscount.TabIndex = 6;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(100, 162);
            this.txtTable.Name = "txtTable";
            this.txtTable.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTable.Properties.Appearance.Options.UseFont = true;
            this.txtTable.Size = new System.Drawing.Size(177, 20);
            this.txtTable.TabIndex = 5;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(100, 201);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEvent.Properties.Appearance.Options.UseFont = true;
            this.txtEvent.Size = new System.Drawing.Size(177, 20);
            this.txtEvent.TabIndex = 5;
            // 
            // txtCus
            // 
            this.txtCus.Location = new System.Drawing.Point(100, 239);
            this.txtCus.Name = "txtCus";
            this.txtCus.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCus.Properties.Appearance.Options.UseFont = true;
            this.txtCus.Size = new System.Drawing.Size(177, 20);
            this.txtCus.TabIndex = 5;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(100, 275);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtValue.Properties.Appearance.Options.UseFont = true;
            this.txtValue.Size = new System.Drawing.Size(177, 20);
            this.txtValue.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Location = new System.Drawing.Point(26, 242);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Khách hàng";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Location = new System.Drawing.Point(26, 204);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Sự kiện";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Location = new System.Drawing.Point(26, 165);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(19, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Bàn";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(26, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Trạng thái";
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "";
            this.cbStatus.Location = new System.Drawing.Point(100, 48);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán",
            "Đã in phiếu"});
            this.cbStatus.Properties.NullText = "[EditValue is null]";
            this.cbStatus.Properties.PopupSizeable = true;
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(177, 20);
            this.cbStatus.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(26, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Giá khu vực(%)";
            // 
            // txtZoneCost
            // 
            this.txtZoneCost.Location = new System.Drawing.Point(100, 126);
            this.txtZoneCost.Name = "txtZoneCost";
            this.txtZoneCost.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtZoneCost.Properties.Appearance.Options.UseFont = true;
            this.txtZoneCost.Size = new System.Drawing.Size(177, 20);
            this.txtZoneCost.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(26, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Khu vực";
            // 
            // txtZoneName
            // 
            this.txtZoneName.Location = new System.Drawing.Point(100, 89);
            this.txtZoneName.Name = "txtZoneName";
            this.txtZoneName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtZoneName.Properties.Appearance.Options.UseFont = true;
            this.txtZoneName.Size = new System.Drawing.Size(177, 20);
            this.txtZoneName.TabIndex = 5;
            // 
            // frmBillEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 427);
            this.Controls.Add(this.groupKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBillEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).EndInit();
            this.groupKH.ResumeLayout(false);
            this.groupKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAfterDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoneCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoneName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupKH;
        private LabelControl labelControl9;
        private LabelControl labelControl8;
        private LabelControl labelControl6;
        private LabelControl labelControl1;
        private LabelControl labelControl5;
        private LabelControl labelControl7;
        private TextEdit txtAfterDiscount;
        private LabelControl labelControl12;
        private LabelControl labelControl13;
        private SpinEdit spinTotalDiscount;
        private TextEdit txtValue;
        private ComboBoxEdit cbStatus;
        private DateEdit dateTime;
        private GroupControl groupControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn FoodName;
        private GridColumn Quantity;
        private GridColumn Price;
        private TextEdit txtTable;
        private TextEdit txtEvent;
        private TextEdit txtCus;
        private TextEdit txtZoneCost;
        private LabelControl labelControl2;
        private TextEdit txtZoneName;
        private LabelControl labelControl3;
    }
}