using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControl;

namespace iCafe.UserControls
{
    partial class ucEvent
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
            this.ucBaseController1 = new iCafe.BaseControl.ucBaseController();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridEvent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EventName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descript = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(709, 50);
            this.ucBaseController1.TabIndex = 0;
            this.ucBaseController1.Load += new System.EventHandler(this.ucBaseController1_Load);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gridEvent;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(709, 302);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEvent});
            // 
            // gridEvent
            // 
            this.gridEvent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EventName,
            this.Discount,
            this.StartDate,
            this.EndDate,
            this.CreateDate,
            this.Status,
            this.Descript});
            this.gridEvent.GridControl = this.gridControl1;
            this.gridEvent.Name = "gridEvent";
            this.gridEvent.OptionsView.ShowGroupPanel = false;
            // 
            // EventName
            // 
            this.EventName.AppearanceCell.Options.UseTextOptions = true;
            this.EventName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EventName.AppearanceHeader.Options.UseTextOptions = true;
            this.EventName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EventName.Caption = "Tên sự kiện";
            this.EventName.FieldName = "EventName";
            this.EventName.Name = "EventName";
            this.EventName.Visible = true;
            this.EventName.VisibleIndex = 0;
            // 
            // Discount
            // 
            this.Discount.AppearanceCell.Options.UseTextOptions = true;
            this.Discount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Discount.AppearanceHeader.Options.UseTextOptions = true;
            this.Discount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Discount.Caption = "Chiết khấu(%)";
            this.Discount.FieldName = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 1;
            // 
            // StartDate
            // 
            this.StartDate.AppearanceCell.Options.UseTextOptions = true;
            this.StartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StartDate.AppearanceHeader.Options.UseTextOptions = true;
            this.StartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StartDate.Caption = "Từ ngày";
            this.StartDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.StartDate.FieldName = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 2;
            // 
            // EndDate
            // 
            this.EndDate.AppearanceCell.Options.UseTextOptions = true;
            this.EndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.EndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndDate.Caption = "Đến ngày";
            this.EndDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.EndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EndDate.FieldName = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.Visible = true;
            this.EndDate.VisibleIndex = 3;
            // 
            // CreateDate
            // 
            this.CreateDate.AppearanceCell.Options.UseTextOptions = true;
            this.CreateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.CreateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreateDate.Caption = "Ngày tạo";
            this.CreateDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 4;
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
            this.Status.VisibleIndex = 6;
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
            this.Descript.VisibleIndex = 5;
            // 
            // ucEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucEvent";
            this.Size = new System.Drawing.Size(709, 352);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBaseController ucBaseController1;
        private GridControl gridControl1;
        private GridView gridEvent;
        private GridColumn EventName;
        private GridColumn Discount;
        private GridColumn StartDate;
        private GridColumn EndDate;
        private GridColumn CreateDate;
        private GridColumn Status;
        private GridColumn Descript;
    }
}
