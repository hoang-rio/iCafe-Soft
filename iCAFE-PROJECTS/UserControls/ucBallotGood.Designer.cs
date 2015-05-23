using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;


namespace iCafe.UserControls
{
    partial class ucBallotGood
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
            this.ucBaseController1 = new iCafe.BaseControls.ucBaseController();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridBallotGood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CreatTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBallotGood)).BeginInit();
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
            this.gridControl1.MainView = this.gridBallotGood;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(669, 369);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBallotGood});
            // 
            // gridBallotGood
            // 
            this.gridBallotGood.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CreatTime,
            this.Value,
            this.SupName,
            this.Status});
            this.gridBallotGood.GridControl = this.gridControl1;
            this.gridBallotGood.Name = "gridBallotGood";
            this.gridBallotGood.OptionsView.ShowGroupPanel = false;
            // 
            // CreatTime
            // 
            this.CreatTime.AppearanceCell.Options.UseTextOptions = true;
            this.CreatTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreatTime.AppearanceHeader.Options.UseTextOptions = true;
            this.CreatTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreatTime.Caption = "Thời gian tạo";
            this.CreatTime.FieldName = "CreatTime";
            this.CreatTime.Name = "CreatTime";
            this.CreatTime.Visible = true;
            this.CreatTime.VisibleIndex = 0;
            // 
            // Value
            // 
            this.Value.AppearanceCell.Options.UseTextOptions = true;
            this.Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.Caption = "Giá trị";
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 1;
            // 
            // SupName
            // 
            this.SupName.AppearanceCell.Options.UseTextOptions = true;
            this.SupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupName.AppearanceHeader.Options.UseTextOptions = true;
            this.SupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupName.Caption = "Tên nhà cung cấp";
            this.SupName.FieldName = "SupName";
            this.SupName.Name = "SupName";
            this.SupName.Visible = true;
            this.SupName.VisibleIndex = 2;
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
            this.Status.VisibleIndex = 3;
            // 
            // ucBallotGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucBallotGood";
            this.Size = new System.Drawing.Size(669, 419);
            this.Load += new System.EventHandler(this.ucBallotGood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBallotGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.ucBaseController ucBaseController1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBallotGood;
        private DevExpress.XtraGrid.Columns.GridColumn CreatTime;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn SupName;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
    }
}
