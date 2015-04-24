using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControl;

namespace iCafe.UserControls
{
    partial class ucCustomer
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
            DevExpress.XtraGrid.Columns.GridColumn CusPhone;
            this.ucBaseController1 = new iCafe.BaseControl.ucBaseController();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusSex = new DevExpress.XtraGrid.Columns.GridColumn();
            CusPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CusPhone
            // 
            CusPhone.AppearanceCell.Options.UseTextOptions = true;
            CusPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CusPhone.AppearanceHeader.Options.UseTextOptions = true;
            CusPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CusPhone.Caption = "Số điện thoại";
            CusPhone.FieldName = "CusPhone";
            CusPhone.Name = "CusPhone";
            CusPhone.Visible = true;
            CusPhone.VisibleIndex = 2;
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(729, 53);
            this.ucBaseController1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(729, 330);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.PressEdit);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CusName,
            CusPhone,
            this.CusAddress,
            this.CusCompany,
            this.CusBirthday,
            this.CusDiscount,
            this.CusSex});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CusName
            // 
            this.CusName.AppearanceCell.Options.UseTextOptions = true;
            this.CusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusName.AppearanceHeader.Options.UseTextOptions = true;
            this.CusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusName.Caption = "Tên khách hàng";
            this.CusName.FieldName = "CusName";
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 0;
            // 
            // CusAddress
            // 
            this.CusAddress.AppearanceCell.Options.UseTextOptions = true;
            this.CusAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.CusAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusAddress.Caption = "Địa chỉ";
            this.CusAddress.FieldName = "CusAddress";
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Visible = true;
            this.CusAddress.VisibleIndex = 3;
            // 
            // CusCompany
            // 
            this.CusCompany.AppearanceCell.Options.UseTextOptions = true;
            this.CusCompany.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusCompany.AppearanceHeader.Options.UseTextOptions = true;
            this.CusCompany.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusCompany.Caption = "Công ty";
            this.CusCompany.FieldName = "Company";
            this.CusCompany.Name = "CusCompany";
            this.CusCompany.Visible = true;
            this.CusCompany.VisibleIndex = 4;
            // 
            // CusBirthday
            // 
            this.CusBirthday.AppearanceCell.Options.UseTextOptions = true;
            this.CusBirthday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusBirthday.AppearanceHeader.Options.UseTextOptions = true;
            this.CusBirthday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusBirthday.Caption = "Ngày sinh";
            this.CusBirthday.FieldName = "Birthday";
            this.CusBirthday.Name = "CusBirthday";
            this.CusBirthday.Visible = true;
            this.CusBirthday.VisibleIndex = 5;
            // 
            // CusDiscount
            // 
            this.CusDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.CusDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.CusDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusDiscount.Caption = "Chiết Khấu (%)";
            this.CusDiscount.FieldName = "Discount";
            this.CusDiscount.Name = "CusDiscount";
            this.CusDiscount.Visible = true;
            this.CusDiscount.VisibleIndex = 6;
            // 
            // CusSex
            // 
            this.CusSex.AppearanceCell.Options.UseTextOptions = true;
            this.CusSex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusSex.AppearanceHeader.Options.UseTextOptions = true;
            this.CusSex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusSex.Caption = "Giới tính";
            this.CusSex.FieldName = "CusSex";
            this.CusSex.Name = "CusSex";
            this.CusSex.Visible = true;
            this.CusSex.VisibleIndex = 1;
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(729, 383);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBaseController ucBaseController1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn CusName;
        private GridColumn CusAddress;
        private GridColumn CusCompany;
        private GridColumn CusBirthday;
        private GridColumn CusDiscount;
        private GridColumn CusSex;
    }
}
