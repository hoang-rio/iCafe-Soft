using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.UserControls
{
    partial class ucEmployee
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
            this.ucBaseController1 = new iCafe.BaseControls.ucBaseController();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridEmploy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Permission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Overtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dayoff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PicInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IMEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmploy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(669, 49);
            this.ucBaseController1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridEmploy;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.IMEdit});
            this.gridControl1.Size = new System.Drawing.Size(669, 370);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEmploy});
            // 
            // gridEmploy
            // 
            this.gridEmploy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployName,
            this.Address,
            this.Phone,
            this.Birthday,
            this.Permission,
            this.WorkShift,
            this.Overtime,
            this.Dayoff,
            this.EmSex,
            this.PicInfo});
            this.gridEmploy.GridControl = this.gridControl1;
            this.gridEmploy.Name = "gridEmploy";
            this.gridEmploy.OptionsView.ShowGroupPanel = false;
            // 
            // EmployName
            // 
            this.EmployName.AppearanceCell.Options.UseTextOptions = true;
            this.EmployName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EmployName.AppearanceHeader.Options.UseTextOptions = true;
            this.EmployName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EmployName.Caption = "Họ tên";
            this.EmployName.FieldName = "FullName";
            this.EmployName.Name = "EmployName";
            this.EmployName.Visible = true;
            this.EmployName.VisibleIndex = 0;
            // 
            // Address
            // 
            this.Address.AppearanceCell.Options.UseTextOptions = true;
            this.Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Address.Caption = "Địa chỉ";
            this.Address.FieldName = "EmAddress";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 1;
            // 
            // Phone
            // 
            this.Phone.AppearanceCell.Options.UseTextOptions = true;
            this.Phone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Phone.AppearanceHeader.Options.UseTextOptions = true;
            this.Phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Phone.Caption = "Số điện thoại";
            this.Phone.FieldName = "EmPhone";
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 2;
            // 
            // Birthday
            // 
            this.Birthday.AppearanceCell.Options.UseTextOptions = true;
            this.Birthday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Birthday.AppearanceHeader.Options.UseTextOptions = true;
            this.Birthday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Birthday.Caption = "Ngày sinh";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 4;
            // 
            // Permission
            // 
            this.Permission.AppearanceCell.Options.UseTextOptions = true;
            this.Permission.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Permission.AppearanceHeader.Options.UseTextOptions = true;
            this.Permission.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Permission.Caption = "Chức vụ";
            this.Permission.FieldName = "PerName";
            this.Permission.Name = "Permission";
            this.Permission.Visible = true;
            this.Permission.VisibleIndex = 5;
            // 
            // WorkShift
            // 
            this.WorkShift.AppearanceCell.Options.UseTextOptions = true;
            this.WorkShift.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkShift.AppearanceHeader.Options.UseTextOptions = true;
            this.WorkShift.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkShift.Caption = "Ca trực";
            this.WorkShift.FieldName = "WSName";
            this.WorkShift.Name = "WorkShift";
            this.WorkShift.Visible = true;
            this.WorkShift.VisibleIndex = 6;
            // 
            // Overtime
            // 
            this.Overtime.AppearanceCell.Options.UseTextOptions = true;
            this.Overtime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Overtime.AppearanceHeader.Options.UseTextOptions = true;
            this.Overtime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Overtime.Caption = "Số giờ làm ngoài";
            this.Overtime.FieldName = "NumOvertime";
            this.Overtime.Name = "Overtime";
            this.Overtime.Visible = true;
            this.Overtime.VisibleIndex = 7;
            // 
            // Dayoff
            // 
            this.Dayoff.AppearanceCell.Options.UseTextOptions = true;
            this.Dayoff.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dayoff.AppearanceHeader.Options.UseTextOptions = true;
            this.Dayoff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dayoff.Caption = "Ngày nghỉ";
            this.Dayoff.FieldName = "Dayoff";
            this.Dayoff.Name = "Dayoff";
            this.Dayoff.Visible = true;
            this.Dayoff.VisibleIndex = 8;
            // 
            // EmSex
            // 
            this.EmSex.AppearanceCell.Options.UseTextOptions = true;
            this.EmSex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EmSex.AppearanceHeader.Options.UseTextOptions = true;
            this.EmSex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EmSex.Caption = "Giới tính";
            this.EmSex.FieldName = "Sex";
            this.EmSex.Name = "EmSex";
            this.EmSex.Visible = true;
            this.EmSex.VisibleIndex = 3;
            // 
            // PicInfo
            // 
            this.PicInfo.AppearanceCell.Options.UseTextOptions = true;
            this.PicInfo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PicInfo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PicInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.PicInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PicInfo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PicInfo.Caption = "Ảnh";
            this.PicInfo.ColumnEdit = this.IMEdit;
            this.PicInfo.FieldName = "PicInfo";
            this.PicInfo.Name = "PicInfo";
            this.PicInfo.Visible = true;
            this.PicInfo.VisibleIndex = 9;
            // 
            // IMEdit
            // 
            this.IMEdit.AutoHeight = false;
            this.IMEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IMEdit.Name = "IMEdit";
            this.IMEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(669, 419);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmploy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBaseController ucBaseController1;
        private GridControl gridControl1;
        private GridView gridEmploy;
        private GridColumn EmployName;
        private GridColumn Address;
        private GridColumn Phone;
        private GridColumn Birthday;
        private GridColumn Permission;
        private GridColumn WorkShift;
        private GridColumn Overtime;
        private GridColumn Dayoff;
        private GridColumn EmSex;
        private GridColumn PicInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit IMEdit;
    }
}