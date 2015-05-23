namespace iCafe.UserControls
{
    partial class ucFood
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ucBaseController1 = new iCafe.BaseControls.ucBaseController();
            this.FGrName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.ucBaseController1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(881, 493);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Món";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 71);
            this.gridControl2.MainView = this.gridFood;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridControl2.Size = new System.Drawing.Size(877, 420);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFood});
            // 
            // gridFood
            // 
            this.gridFood.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodName,
            this.FUnit,
            this.FPrice,
            this.FImage,
            this.FGrName});
            this.gridFood.GridControl = this.gridControl2;
            this.gridFood.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridFood.Name = "gridFood";
            this.gridFood.OptionsView.ShowGroupPanel = false;
            // 
            // FoodName
            // 
            this.FoodName.AppearanceCell.Options.UseTextOptions = true;
            this.FoodName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.AppearanceHeader.Options.UseTextOptions = true;
            this.FoodName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.Caption = "Tên món";
            this.FoodName.FieldName = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.Visible = true;
            this.FoodName.VisibleIndex = 0;
            // 
            // FUnit
            // 
            this.FUnit.AppearanceCell.Options.UseTextOptions = true;
            this.FUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.FUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FUnit.Caption = "Đơn vị tính";
            this.FUnit.FieldName = "FUnit";
            this.FUnit.Name = "FUnit";
            this.FUnit.Visible = true;
            this.FUnit.VisibleIndex = 2;
            // 
            // FPrice
            // 
            this.FPrice.AppearanceCell.Options.UseTextOptions = true;
            this.FPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.FPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FPrice.Caption = "Giá";
            this.FPrice.FieldName = "FPrice";
            this.FPrice.Name = "FPrice";
            this.FPrice.Visible = true;
            this.FPrice.VisibleIndex = 3;
            // 
            // FImage
            // 
            this.FImage.AppearanceCell.Options.UseTextOptions = true;
            this.FImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FImage.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FImage.AppearanceHeader.Options.UseTextOptions = true;
            this.FImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FImage.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FImage.Caption = "Ảnh";
            this.FImage.ColumnEdit = this.repositoryItemImageEdit1;
            this.FImage.FieldName = "FImage";
            this.FImage.Name = "FImage";
            this.FImage.Visible = true;
            this.FImage.VisibleIndex = 4;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(2, 21);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(877, 50);
            this.ucBaseController1.TabIndex = 7;
            // 
            // FGrName
            // 
            this.FGrName.AppearanceCell.Options.UseTextOptions = true;
            this.FGrName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FGrName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FGrName.AppearanceHeader.Options.UseTextOptions = true;
            this.FGrName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FGrName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FGrName.Caption = "Nhóm món";
            this.FGrName.FieldName = "FGrName";
            this.FGrName.Name = "FGrName";
            this.FGrName.Visible = true;
            this.FGrName.VisibleIndex = 1;
            // 
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Name = "ucFood";
            this.Size = new System.Drawing.Size(881, 493);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFood;
        private DevExpress.XtraGrid.Columns.GridColumn FoodName;
        private DevExpress.XtraGrid.Columns.GridColumn FUnit;
        private DevExpress.XtraGrid.Columns.GridColumn FPrice;
        private DevExpress.XtraGrid.Columns.GridColumn FImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private BaseControls.ucBaseController ucBaseController1;
        private DevExpress.XtraGrid.Columns.GridColumn FGrName;

    }
}
