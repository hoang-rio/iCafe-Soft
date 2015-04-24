namespace iCafe.UserControls
{
    partial class ucSupplier
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
            this.gridSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(669, 50);
            this.ucBaseController1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gridSupplier;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(669, 369);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSupplier});
            // 
            // gridSupplier
            // 
            this.gridSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SupName,
            this.SupPhone,
            this.SupAddress,
            this.SupEmail});
            this.gridSupplier.GridControl = this.gridControl1;
            this.gridSupplier.Name = "gridSupplier";
            this.gridSupplier.OptionsView.ShowGroupPanel = false;
            // 
            // SupName
            // 
            this.SupName.AppearanceCell.Options.UseTextOptions = true;
            this.SupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupName.AppearanceHeader.Options.UseTextOptions = true;
            this.SupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupName.Caption = "Nhà cung cấp";
            this.SupName.FieldName = "SupName";
            this.SupName.Name = "SupName";
            this.SupName.Visible = true;
            this.SupName.VisibleIndex = 0;
            // 
            // SupPhone
            // 
            this.SupPhone.AppearanceCell.Options.UseTextOptions = true;
            this.SupPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.SupPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupPhone.Caption = "Điện thoại";
            this.SupPhone.FieldName = "SupPhone";
            this.SupPhone.Name = "SupPhone";
            this.SupPhone.Visible = true;
            this.SupPhone.VisibleIndex = 1;
            // 
            // SupAddress
            // 
            this.SupAddress.AppearanceCell.Options.UseTextOptions = true;
            this.SupAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.SupAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupAddress.Caption = "Địa chỉ";
            this.SupAddress.FieldName = "SupAddress";
            this.SupAddress.Name = "SupAddress";
            this.SupAddress.Visible = true;
            this.SupAddress.VisibleIndex = 2;
            // 
            // SupEmail
            // 
            this.SupEmail.AppearanceCell.Options.UseTextOptions = true;
            this.SupEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.SupEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupEmail.Caption = "Địa chỉ";
            this.SupEmail.FieldName = "SupEmail";
            this.SupEmail.Name = "SupEmail";
            this.SupEmail.Visible = true;
            this.SupEmail.VisibleIndex = 3;
            // 
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucSupplier";
            this.Load += new System.EventHandler(this.ucSupplier_Load);
            this.Size = new System.Drawing.Size(669, 419);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControl.ucBaseController ucBaseController1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn SupName;
        private DevExpress.XtraGrid.Columns.GridColumn SupPhone;
        private DevExpress.XtraGrid.Columns.GridColumn SupAddress;
        private DevExpress.XtraGrid.Columns.GridColumn SupEmail;
    }
}
