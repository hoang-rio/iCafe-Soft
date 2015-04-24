namespace iCafe.UserControls
{
    partial class ucImportExport
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
            this.gridImportExport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IENote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportExport)).BeginInit();
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
            this.gridControl1.MainView = this.gridImportExport;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(669, 369);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridImportExport});
            // 
            // gridImportExport
            // 
            this.gridImportExport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Type,
            this.Status,
            this.Time,
            this.IENote,
            this.Cost});
            this.gridImportExport.GridControl = this.gridControl1;
            this.gridImportExport.Name = "gridImportExport";
            this.gridImportExport.OptionsView.ShowGroupPanel = false;
            // 
            // Time
            // 
            this.Time.AppearanceCell.Options.UseTextOptions = true;
            this.Time.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.AppearanceHeader.Options.UseTextOptions = true;
            this.Time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.Caption = "Thời gian";
            this.Time.FieldName = "Time";
            this.Time.Name = "Time";
            this.Time.Visible = true;
            this.Time.VisibleIndex = 2;
            // 
            // Cost
            // 
            this.Cost.AppearanceCell.Options.UseTextOptions = true;
            this.Cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cost.AppearanceHeader.Options.UseTextOptions = true;
            this.Cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cost.Caption = "Thành tiền";
            this.Cost.FieldName = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 4;
            // 
            // Type
            // 
            this.Type.AppearanceCell.Options.UseTextOptions = true;
            this.Type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Type.AppearanceHeader.Options.UseTextOptions = true;
            this.Type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Type.Caption = "Loại hàng";
            this.Type.FieldName = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = true;
            this.Type.VisibleIndex = 0;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 1;
            // 
            // IENote
            // 
            this.IENote.AppearanceCell.Options.UseTextOptions = true;
            this.IENote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IENote.AppearanceHeader.Options.UseTextOptions = true;
            this.IENote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IENote.Caption = "Ghi chú";
            this.IENote.FieldName = "IENote";
            this.IENote.Name = "IENote";
            this.IENote.Visible = true;
            this.IENote.VisibleIndex = 3;
            // 
            // ucImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucImportExport";
            this.Size = new System.Drawing.Size(669, 419);
            this.Load += new System.EventHandler(this.ucImportExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControl.ucBaseController ucBaseController1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridImportExport;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn IENote;
    }
}
