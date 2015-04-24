namespace iCafe.UserControls
{
    partial class ucPermission
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
            this.ucBaseController1 = new iCafe.BaseControl.ucBaseController();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descript = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullPermiss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_warehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_table = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_revenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_system = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fc_event = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(692, 50);
            this.ucBaseController1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.GridPermission;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(692, 367);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridPermission});
            // 
            // GridPermission
            // 
            this.GridPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PerName,
            this.Descript,
            this.FullPermiss,
            this.fc_customer,
            this.fc_warehouse,
            this.fc_table,
            this.fc_sale,
            this.fc_revenue,
            this.fc_system,
            this.fc_event});
            this.GridPermission.GridControl = this.gridControl1;
            this.GridPermission.Name = "GridPermission";
            this.GridPermission.OptionsView.ShowGroupPanel = false;
            // 
            // PerName
            // 
            this.PerName.AppearanceCell.Options.UseTextOptions = true;
            this.PerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PerName.AppearanceHeader.Options.UseTextOptions = true;
            this.PerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PerName.Caption = "Tên chức vụ";
            this.PerName.FieldName = "PerName";
            this.PerName.Name = "PerName";
            this.PerName.Visible = true;
            this.PerName.VisibleIndex = 0;
            // 
            // Descript
            // 
            this.Descript.AppearanceCell.Options.UseTextOptions = true;
            this.Descript.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descript.AppearanceHeader.Options.UseTextOptions = true;
            this.Descript.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descript.Caption = "Mô tả";
            this.Descript.FieldName = "Descript";
            this.Descript.Name = "Descript";
            this.Descript.Visible = true;
            this.Descript.VisibleIndex = 1;
            // 
            // FullPermiss
            // 
            this.FullPermiss.AppearanceCell.Options.UseTextOptions = true;
            this.FullPermiss.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FullPermiss.AppearanceHeader.Options.UseTextOptions = true;
            this.FullPermiss.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FullPermiss.Caption = "Toàn quyền";
            this.FullPermiss.FieldName = "FullPermiss";
            this.FullPermiss.Name = "FullPermiss";
            this.FullPermiss.Visible = true;
            this.FullPermiss.VisibleIndex = 2;
            // 
            // fc_customer
            // 
            this.fc_customer.AppearanceCell.Options.UseTextOptions = true;
            this.fc_customer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_customer.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_customer.Caption = "Khách hàng";
            this.fc_customer.FieldName = "fc_customer";
            this.fc_customer.Name = "fc_customer";
            this.fc_customer.Visible = true;
            this.fc_customer.VisibleIndex = 8;
            // 
            // fc_warehouse
            // 
            this.fc_warehouse.AppearanceCell.Options.UseTextOptions = true;
            this.fc_warehouse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_warehouse.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_warehouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_warehouse.Caption = "Kho";
            this.fc_warehouse.FieldName = "fc_warehouse";
            this.fc_warehouse.Name = "fc_warehouse";
            this.fc_warehouse.Visible = true;
            this.fc_warehouse.VisibleIndex = 9;
            // 
            // fc_table
            // 
            this.fc_table.AppearanceCell.Options.UseTextOptions = true;
            this.fc_table.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_table.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_table.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_table.Caption = "Bàn";
            this.fc_table.FieldName = "fc_table";
            this.fc_table.Name = "fc_table";
            this.fc_table.Visible = true;
            this.fc_table.VisibleIndex = 7;
            // 
            // fc_sale
            // 
            this.fc_sale.AppearanceCell.Options.UseTextOptions = true;
            this.fc_sale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_sale.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_sale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_sale.Caption = "Bán hàng";
            this.fc_sale.FieldName = "fc_sale";
            this.fc_sale.Name = "fc_sale";
            this.fc_sale.Visible = true;
            this.fc_sale.VisibleIndex = 6;
            // 
            // fc_revenue
            // 
            this.fc_revenue.AppearanceCell.Options.UseTextOptions = true;
            this.fc_revenue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_revenue.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_revenue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_revenue.Caption = "Doanh thu";
            this.fc_revenue.FieldName = "fc_revenue";
            this.fc_revenue.Name = "fc_revenue";
            this.fc_revenue.Visible = true;
            this.fc_revenue.VisibleIndex = 4;
            // 
            // fc_system
            // 
            this.fc_system.AppearanceCell.Options.UseTextOptions = true;
            this.fc_system.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_system.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_system.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_system.Caption = "Hệ thống";
            this.fc_system.FieldName = "fc_system";
            this.fc_system.Name = "fc_system";
            this.fc_system.Visible = true;
            this.fc_system.VisibleIndex = 3;
            // 
            // fc_event
            // 
            this.fc_event.AppearanceCell.Options.UseTextOptions = true;
            this.fc_event.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_event.AppearanceHeader.Options.UseTextOptions = true;
            this.fc_event.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fc_event.Caption = "Sự kiện";
            this.fc_event.FieldName = "fc_event";
            this.fc_event.Name = "fc_event";
            this.fc_event.Visible = true;
            this.fc_event.VisibleIndex = 5;
            // 
            // ucPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucPermission";
            this.Size = new System.Drawing.Size(692, 417);
            this.Load += new System.EventHandler(this.ucPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControl.ucBaseController ucBaseController1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridPermission;
        private DevExpress.XtraGrid.Columns.GridColumn PerName;
        private DevExpress.XtraGrid.Columns.GridColumn Descript;
        private DevExpress.XtraGrid.Columns.GridColumn FullPermiss;
        private DevExpress.XtraGrid.Columns.GridColumn fc_customer;
        private DevExpress.XtraGrid.Columns.GridColumn fc_warehouse;
        private DevExpress.XtraGrid.Columns.GridColumn fc_table;
        private DevExpress.XtraGrid.Columns.GridColumn fc_sale;
        private DevExpress.XtraGrid.Columns.GridColumn fc_revenue;
        private DevExpress.XtraGrid.Columns.GridColumn fc_system;
        private DevExpress.XtraGrid.Columns.GridColumn fc_event;
    }
}
