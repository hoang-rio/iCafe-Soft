namespace iCafe.UserControls
{
    partial class ucBill
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateBill = new DevExpress.XtraEditors.DateEdit();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.cbbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labeldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyWord = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EventName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AfterDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXemChitiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ZoneCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBill.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateBill);
            this.groupControl1.Controls.Add(this.btndong);
            this.groupControl1.Controls.Add(this.cbbType);
            this.groupControl1.Controls.Add(this.labeldate);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtKeyWord);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(814, 72);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // dateBill
            // 
            this.dateBill.EditValue = null;
            this.dateBill.Location = new System.Drawing.Point(656, 35);
            this.dateBill.Name = "dateBill";
            this.dateBill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBill.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateBill.Size = new System.Drawing.Size(135, 20);
            this.dateBill.TabIndex = 4;
            this.dateBill.Visible = false;
            this.dateBill.EditValueChanged += new System.EventHandler(this.dateBill_EditValueChanged);
            // 
            // btndong
            // 
            this.btndong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndong.Image = global::iCafe.Properties.Resources.cancel;
            this.btndong.Location = new System.Drawing.Point(722, 32);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // cbbType
            // 
            this.cbbType.Location = new System.Drawing.Point(394, 35);
            this.cbbType.Name = "cbbType";
            this.cbbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbType.Properties.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Tên bàn",
            "Tên nhân viên",
            "Theo thời gian"});
            this.cbbType.Size = new System.Drawing.Size(160, 20);
            this.cbbType.TabIndex = 2;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(560, 38);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(90, 13);
            this.labeldate.TabIndex = 1;
            this.labeldate.Text = "Chọn ngày tháng";
            this.labeldate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(83, 35);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Properties.NullText = "Nhập từ khóa tìm kiếm vào đây...";
            this.txtKeyWord.Size = new System.Drawing.Size(212, 20);
            this.txtKeyWord.TabIndex = 0;
            this.txtKeyWord.EditValueChanged += new System.EventHandler(this.txtKeyWord_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetail});
            this.gridControl1.Size = new System.Drawing.Size(814, 356);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TableName,
            this.CusName,
            this.Value,
            this.TotalDiscount,
            this.EventName,
            this.BTime,
            this.Status,
            this.AfterDiscount,
            this.btnXemChitiet,
            this.ZoneCost,
            this.ZoneName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TableName
            // 
            this.TableName.AppearanceCell.Options.UseTextOptions = true;
            this.TableName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TableName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TableName.AppearanceHeader.Options.UseTextOptions = true;
            this.TableName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TableName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TableName.Caption = "Tên bàn";
            this.TableName.FieldName = "TableName";
            this.TableName.Name = "TableName";
            this.TableName.Visible = true;
            this.TableName.VisibleIndex = 0;
            // 
            // CusName
            // 
            this.CusName.AppearanceCell.Options.UseTextOptions = true;
            this.CusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CusName.AppearanceHeader.Options.UseTextOptions = true;
            this.CusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CusName.Caption = "Tên khách hàng";
            this.CusName.FieldName = "CusName";
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 2;
            // 
            // Value
            // 
            this.Value.AppearanceCell.Options.UseTextOptions = true;
            this.Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Value.Caption = "Giá trị";
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 5;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.TotalDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalDiscount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TotalDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalDiscount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TotalDiscount.Caption = "Tổng chiết khẩu (%)";
            this.TotalDiscount.FieldName = "TotalDiscount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.Visible = true;
            this.TotalDiscount.VisibleIndex = 6;
            // 
            // EventName
            // 
            this.EventName.AppearanceCell.Options.UseTextOptions = true;
            this.EventName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EventName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EventName.AppearanceHeader.Options.UseTextOptions = true;
            this.EventName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EventName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EventName.Caption = "Tên sự kiện";
            this.EventName.FieldName = "EventName";
            this.EventName.Name = "EventName";
            this.EventName.Visible = true;
            this.EventName.VisibleIndex = 1;
            // 
            // BTime
            // 
            this.BTime.AppearanceCell.Options.UseTextOptions = true;
            this.BTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BTime.AppearanceHeader.Options.UseTextOptions = true;
            this.BTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BTime.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BTime.Caption = "Thời gian";
            this.BTime.FieldName = "BTime";
            this.BTime.Name = "BTime";
            this.BTime.Visible = true;
            this.BTime.VisibleIndex = 8;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 9;
            // 
            // AfterDiscount
            // 
            this.AfterDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.AfterDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AfterDiscount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AfterDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.AfterDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AfterDiscount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.AfterDiscount.Caption = "Khách thanh toán";
            this.AfterDiscount.FieldName = "AfterDiscount";
            this.AfterDiscount.Name = "AfterDiscount";
            this.AfterDiscount.Visible = true;
            this.AfterDiscount.VisibleIndex = 7;
            // 
            // btnXemChitiet
            // 
            this.btnXemChitiet.AppearanceCell.Options.UseTextOptions = true;
            this.btnXemChitiet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnXemChitiet.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnXemChitiet.AppearanceHeader.Options.UseTextOptions = true;
            this.btnXemChitiet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnXemChitiet.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnXemChitiet.Caption = "Xem chi tiết";
            this.btnXemChitiet.ColumnEdit = this.btnDetail;
            this.btnXemChitiet.Name = "btnXemChitiet";
            this.btnXemChitiet.Visible = true;
            this.btnXemChitiet.VisibleIndex = 10;
            // 
            // btnDetail
            // 
            this.btnDetail.AutoHeight = false;
            this.btnDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.NullText = "Bấm để xem chi tiết";
            // 
            // ZoneCost
            // 
            this.ZoneCost.AppearanceCell.Options.UseTextOptions = true;
            this.ZoneCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneCost.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ZoneCost.AppearanceHeader.Options.UseTextOptions = true;
            this.ZoneCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ZoneCost.Caption = "Giá khu vực (%)";
            this.ZoneCost.FieldName = "ZoneCost";
            this.ZoneCost.Name = "ZoneCost";
            this.ZoneCost.Visible = true;
            this.ZoneCost.VisibleIndex = 4;
            // 
            // ZoneName
            // 
            this.ZoneName.AppearanceCell.Options.UseTextOptions = true;
            this.ZoneName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ZoneName.AppearanceHeader.Options.UseTextOptions = true;
            this.ZoneName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ZoneName.Caption = "Tên khu vực";
            this.ZoneName.FieldName = "ZoneName";
            this.ZoneName.Name = "ZoneName";
            this.ZoneName.Visible = true;
            this.ZoneName.VisibleIndex = 3;
            // 
            // ucBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucBill";
            this.Size = new System.Drawing.Size(814, 428);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBill.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKeyWord;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TableName;
        private DevExpress.XtraGrid.Columns.GridColumn CusName;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn EventName;
        private DevExpress.XtraGrid.Columns.GridColumn BTime;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn AfterDiscount;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraGrid.Columns.GridColumn btnXemChitiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetail;
        private DevExpress.XtraEditors.DateEdit dateBill;
        private System.Windows.Forms.Label labeldate;
        private DevExpress.XtraGrid.Columns.GridColumn ZoneCost;
        private DevExpress.XtraGrid.Columns.GridColumn ZoneName;

    }
}
