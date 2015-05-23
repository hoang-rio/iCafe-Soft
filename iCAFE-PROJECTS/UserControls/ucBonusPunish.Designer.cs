namespace iCafe.UserControls
{
    partial class ucBonusPunish
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(770, 50);
            this.ucBaseController1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(770, 395);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FullName,
            this.Content,
            this.Value,
            this.Time});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FullName
            // 
            this.FullName.AppearanceCell.Options.UseTextOptions = true;
            this.FullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FullName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FullName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.FullName.AppearanceHeader.Options.UseTextOptions = true;
            this.FullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FullName.Caption = "Tên nhân viên";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 0;
            // 
            // Content
            // 
            this.Content.AppearanceCell.Options.UseTextOptions = true;
            this.Content.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Content.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Content.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Content.AppearanceHeader.Options.UseTextOptions = true;
            this.Content.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Content.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Content.Caption = "Nội dung";
            this.Content.FieldName = "Content";
            this.Content.Name = "Content";
            this.Content.Visible = true;
            this.Content.VisibleIndex = 1;
            // 
            // Value
            // 
            this.Value.AppearanceCell.Options.UseTextOptions = true;
            this.Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Value.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Value.Caption = "Giá trị (VNĐ)";
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 2;
            // 
            // Time
            // 
            this.Time.AppearanceCell.Options.UseTextOptions = true;
            this.Time.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Time.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Time.AppearanceHeader.Options.UseTextOptions = true;
            this.Time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Time.Caption = "Thời gian";
            this.Time.FieldName = "Time";
            this.Time.Name = "Time";
            this.Time.Visible = true;
            this.Time.VisibleIndex = 3;
            // 
            // ucBonusPunish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucBonusPunish";
            this.Size = new System.Drawing.Size(770, 445);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.ucBaseController ucBaseController1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Content;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
    }
}
