using System.ComponentModel;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmImportExportAdd
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridIEDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RMName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DetailNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Memo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.RMPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RichText = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.ucSimpleControl1 = new iCafe.BaseControls.ucSimpleControl();
            this.txtIENote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCost = new DevExpress.XtraEditors.TextEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).BeginInit();
            this.groupKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIEDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RichText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIENote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupKH
            // 
            this.groupKH.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupKH.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupKH.AppearanceCaption.Options.UseFont = true;
            this.groupKH.AppearanceCaption.Options.UseForeColor = true;
            this.groupKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupKH.Controls.Add(this.panelControl1);
            this.groupKH.Controls.Add(this.txtIENote);
            this.groupKH.Controls.Add(this.labelControl3);
            this.groupKH.Controls.Add(this.cbStatus);
            this.groupKH.Controls.Add(this.labelControl2);
            this.groupKH.Controls.Add(this.cbType);
            this.groupKH.Controls.Add(this.dateTime);
            this.groupKH.Controls.Add(this.labelControl8);
            this.groupKH.Controls.Add(this.labelControl6);
            this.groupKH.Controls.Add(this.labelControl1);
            this.groupKH.Controls.Add(this.txtCost);
            this.groupKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKH.Location = new System.Drawing.Point(0, 50);
            this.groupKH.Name = "groupKH";
            this.groupKH.Size = new System.Drawing.Size(783, 380);
            this.groupKH.TabIndex = 7;
            this.groupKH.Text = "Cập nhật thông tin giá nhập";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.ucSimpleControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(270, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(511, 350);
            this.panelControl1.TabIndex = 19;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridIEDetail;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RichText,
            this.repositoryItemMemoEdit1,
            this.Memo});
            this.gridControl1.Size = new System.Drawing.Size(511, 308);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIEDetail});
            // 
            // gridIEDetail
            // 
            this.gridIEDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RMName,
            this.Unit,
            this.DetailNote,
            this.RMPrice,
            this.Quantity,
            this.TotalPrice,
            this.ImportDate,
            this.ExpireDate});
            this.gridIEDetail.GridControl = this.gridControl1;
            this.gridIEDetail.Name = "gridIEDetail";
            this.gridIEDetail.OptionsView.ShowGroupPanel = false;
            // 
            // RMName
            // 
            this.RMName.AppearanceCell.Options.UseTextOptions = true;
            this.RMName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMName.AppearanceHeader.Options.UseTextOptions = true;
            this.RMName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMName.Caption = "Tên nguyên liệu";
            this.RMName.FieldName = "RMName";
            this.RMName.Name = "RMName";
            this.RMName.Visible = true;
            this.RMName.VisibleIndex = 0;
            // 
            // Unit
            // 
            this.Unit.AppearanceCell.Options.UseTextOptions = true;
            this.Unit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Unit.AppearanceHeader.Options.UseTextOptions = true;
            this.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Unit.Caption = "Đơn vị";
            this.Unit.FieldName = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Visible = true;
            this.Unit.VisibleIndex = 1;
            // 
            // DetailNote
            // 
            this.DetailNote.AppearanceCell.Options.UseTextOptions = true;
            this.DetailNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DetailNote.AppearanceHeader.Options.UseTextOptions = true;
            this.DetailNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DetailNote.Caption = "Ghi chú";
            this.DetailNote.ColumnEdit = this.Memo;
            this.DetailNote.FieldName = "DetailNote";
            this.DetailNote.Name = "DetailNote";
            this.DetailNote.Visible = true;
            this.DetailNote.VisibleIndex = 7;
            // 
            // Memo
            // 
            this.Memo.AutoHeight = false;
            this.Memo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Memo.Name = "Memo";
            // 
            // RMPrice
            // 
            this.RMPrice.AppearanceCell.Options.UseTextOptions = true;
            this.RMPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.RMPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMPrice.Caption = "Đơn giá";
            this.RMPrice.FieldName = "RMPrice";
            this.RMPrice.Name = "RMPrice";
            this.RMPrice.Visible = true;
            this.RMPrice.VisibleIndex = 2;
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
            this.Quantity.VisibleIndex = 3;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.TotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalPrice.Caption = "Tổng giá trị";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 4;
            // 
            // ImportDate
            // 
            this.ImportDate.Caption = "Ngày nhập";
            this.ImportDate.FieldName = "ImportDate";
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.Visible = true;
            this.ImportDate.VisibleIndex = 5;
            // 
            // ExpireDate
            // 
            this.ExpireDate.Caption = "Ngày hết hạn";
            this.ExpireDate.FieldName = "ExpireDate";
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Visible = true;
            this.ExpireDate.VisibleIndex = 6;
            // 
            // RichText
            // 
            this.RichText.Name = "RichText";
            this.RichText.ShowCaretInReadOnly = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // ucSimpleControl1
            // 
            this.ucSimpleControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSimpleControl1.Location = new System.Drawing.Point(0, 0);
            this.ucSimpleControl1.Name = "ucSimpleControl1";
            this.ucSimpleControl1.Size = new System.Drawing.Size(511, 42);
            this.ucSimpleControl1.TabIndex = 0;
            // 
            // txtIENote
            // 
            this.txtIENote.Location = new System.Drawing.Point(75, 188);
            this.txtIENote.Name = "txtIENote";
            this.txtIENote.Size = new System.Drawing.Size(177, 96);
            this.txtIENote.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(15, 191);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Ghi chú";
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(75, 38);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbStatus.Size = new System.Drawing.Size(177, 20);
            this.cbStatus.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(16, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Trạng thái";
            // 
            // cbType
            // 
            this.cbType.Location = new System.Drawing.Point(75, 75);
            this.cbType.Name = "cbType";
            this.cbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbType.Properties.Items.AddRange(new object[] {
            "Hàng xuất",
            "Hàng nhập"});
            this.cbType.Properties.ReadOnly = true;
            this.cbType.Size = new System.Drawing.Size(177, 20);
            this.cbType.TabIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.EditValue = null;
            this.dateTime.Location = new System.Drawing.Point(75, 114);
            this.dateTime.Name = "dateTime";
            this.dateTime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTime.Properties.Appearance.Options.UseFont = true;
            this.dateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTime.Size = new System.Drawing.Size(177, 20);
            this.dateTime.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Location = new System.Drawing.Point(16, 152);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Tổng tiền";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Location = new System.Drawing.Point(16, 115);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Thời gian";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(16, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Loại";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(75, 149);
            this.txtCost.Name = "txtCost";
            this.txtCost.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCost.Properties.Appearance.Options.UseFont = true;
            this.txtCost.Properties.Mask.EditMask = "d";
            this.txtCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtCost.Size = new System.Drawing.Size(177, 20);
            this.txtCost.TabIndex = 3;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(783, 50);
            this.ucUpdate1.TabIndex = 6;
            // 
            // frmImportExportAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 430);
            this.ControlBox = false;
            this.Controls.Add(this.groupKH);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmImportExportAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            this.Load += new System.EventHandler(this.frmImportExportAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).EndInit();
            this.groupKH.ResumeLayout(false);
            this.groupKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIEDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RichText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIENote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupKH;
        private ComboBoxEdit cbType;
        private DateEdit dateTime;
        private LabelControl labelControl8;
        private LabelControl labelControl6;
        private LabelControl labelControl1;
        private ucUpdate ucUpdate1;
        private TextEdit txtCost;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIEDetail;
        private DevExpress.XtraGrid.Columns.GridColumn RMName;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private DevExpress.XtraGrid.Columns.GridColumn RMPrice;
        private DevExpress.XtraGrid.Columns.GridColumn DetailNote;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private ucSimpleControl ucSimpleControl1;
        private MemoEdit txtIENote;
        private LabelControl labelControl3;
        private ComboBoxEdit cbStatus;
        private LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ImportDate;
        private DevExpress.XtraGrid.Columns.GridColumn ExpireDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit RichText;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit Memo;
    }
}