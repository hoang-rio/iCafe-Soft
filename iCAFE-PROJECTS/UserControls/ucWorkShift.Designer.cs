using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.UserControls
{
    partial class ucWorkShift
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WSName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Expense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WSNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(692, 50);
            this.ucBaseController1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(692, 367);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WSName,
            this.StartTime,
            this.EndTime,
            this.Expense,
            this.WSNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // WSName
            // 
            this.WSName.AppearanceCell.Options.UseTextOptions = true;
            this.WSName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WSName.AppearanceHeader.Options.UseTextOptions = true;
            this.WSName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WSName.Caption = "Tên ca trực";
            this.WSName.FieldName = "WSName";
            this.WSName.Name = "WSName";
            this.WSName.Visible = true;
            this.WSName.VisibleIndex = 0;
            // 
            // StartTime
            // 
            this.StartTime.AppearanceCell.Options.UseTextOptions = true;
            this.StartTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StartTime.AppearanceHeader.Options.UseTextOptions = true;
            this.StartTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StartTime.Caption = "Thời gian bắt đầu";
            this.StartTime.DisplayFormat.FormatString = "{hh:mm}";
            this.StartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.StartTime.FieldName = "StartTime";
            this.StartTime.Name = "StartTime";
            this.StartTime.Visible = true;
            this.StartTime.VisibleIndex = 1;
            // 
            // EndTime
            // 
            this.EndTime.AppearanceCell.Options.UseTextOptions = true;
            this.EndTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndTime.AppearanceHeader.Options.UseTextOptions = true;
            this.EndTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndTime.Caption = "Thời gian kết thúc";
            this.EndTime.DisplayFormat.FormatString = "{hh:mm}";
            this.EndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.EndTime.FieldName = "EndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.Visible = true;
            this.EndTime.VisibleIndex = 2;
            // 
            // Expense
            // 
            this.Expense.AppearanceCell.Options.UseTextOptions = true;
            this.Expense.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Expense.AppearanceHeader.Options.UseTextOptions = true;
            this.Expense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Expense.Caption = "Phụ cấp";
            this.Expense.FieldName = "Expense";
            this.Expense.Name = "Expense";
            this.Expense.Visible = true;
            this.Expense.VisibleIndex = 3;
            // 
            // WSNote
            // 
            this.WSNote.AppearanceCell.Options.UseTextOptions = true;
            this.WSNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WSNote.AppearanceHeader.Options.UseTextOptions = true;
            this.WSNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WSNote.Caption = "Ghi chú";
            this.WSNote.FieldName = "WSNote";
            this.WSNote.Name = "WSNote";
            this.WSNote.Visible = true;
            this.WSNote.VisibleIndex = 4;
            // 
            // ucWorkShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucWorkShift";
            this.Size = new System.Drawing.Size(692, 417);
            this.Load += new System.EventHandler(this.ucWorkShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBaseController ucBaseController1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn WSName;
        private GridColumn StartTime;
        private GridColumn EndTime;
        private GridColumn Expense;
        private GridColumn WSNote;


    }
}
