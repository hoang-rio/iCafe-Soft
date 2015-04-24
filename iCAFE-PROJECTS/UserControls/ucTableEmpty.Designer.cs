namespace iCafe.UserControls
{
    partial class ucTableEmpty
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZoneCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZoneImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.TableName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButton1.Image = global::iCafe.Properties.Resources.cancel;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(805, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Đóng";
            this.simpleButton1.Click += new System.EventHandler(this.Close_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridControl1.Size = new System.Drawing.Size(805, 431);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ZoneName,
            this.ZoneCost,
            this.ZoneImage,
            this.TableName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.ZoneName.VisibleIndex = 1;
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
            this.ZoneCost.VisibleIndex = 2;
            // 
            // ZoneImage
            // 
            this.ZoneImage.AppearanceCell.Options.UseTextOptions = true;
            this.ZoneImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneImage.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ZoneImage.AppearanceHeader.Options.UseTextOptions = true;
            this.ZoneImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneImage.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ZoneImage.Caption = "Ảnh đại diện";
            this.ZoneImage.ColumnEdit = this.repositoryItemImageEdit1;
            this.ZoneImage.FieldName = "ZoneImage";
            this.ZoneImage.Name = "ZoneImage";
            this.ZoneImage.Visible = true;
            this.ZoneImage.VisibleIndex = 3;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
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
            // ucTableEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "ucTableEmpty";
            this.Size = new System.Drawing.Size(805, 454);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ZoneName;
        private DevExpress.XtraGrid.Columns.GridColumn ZoneCost;
        private DevExpress.XtraGrid.Columns.GridColumn ZoneImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn TableName;

    }
}
