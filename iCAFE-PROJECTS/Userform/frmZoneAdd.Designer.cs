using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmZoneAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.groupZone = new DevExpress.XtraEditors.GroupControl();
            this.picZoneImage = new DevExpress.XtraEditors.PictureEdit();
            this.groupTable = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TableID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRemoveTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTable = new DevExpress.XtraEditors.SimpleButton();
            this.txtTableName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnOpenIMG = new DevExpress.XtraEditors.SimpleButton();
            this.spinCost = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtZoneName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupZone)).BeginInit();
            this.groupZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoneImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTable)).BeginInit();
            this.groupTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoneName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(664, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // groupZone
            // 
            this.groupZone.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupZone.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupZone.AppearanceCaption.Options.UseFont = true;
            this.groupZone.AppearanceCaption.Options.UseForeColor = true;
            this.groupZone.Controls.Add(this.picZoneImage);
            this.groupZone.Controls.Add(this.groupTable);
            this.groupZone.Controls.Add(this.btnOpenIMG);
            this.groupZone.Controls.Add(this.spinCost);
            this.groupZone.Controls.Add(this.labelControl3);
            this.groupZone.Controls.Add(this.labelControl4);
            this.groupZone.Controls.Add(this.labelControl2);
            this.groupZone.Controls.Add(this.labelControl1);
            this.groupZone.Controls.Add(this.txtZoneName);
            this.groupZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupZone.Location = new System.Drawing.Point(0, 41);
            this.groupZone.Name = "groupZone";
            this.groupZone.Size = new System.Drawing.Size(664, 429);
            this.groupZone.TabIndex = 1;
            this.groupZone.Text = "Cập nhật khu vực";
            // 
            // picZoneImage
            // 
            this.picZoneImage.Location = new System.Drawing.Point(105, 132);
            this.picZoneImage.Name = "picZoneImage";
            this.picZoneImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picZoneImage.Properties.Click += new System.EventHandler(this.btnOpenIMG_Click);
            this.picZoneImage.Size = new System.Drawing.Size(151, 131);
            this.picZoneImage.TabIndex = 7;
            // 
            // groupTable
            // 
            this.groupTable.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupTable.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupTable.AppearanceCaption.Options.UseFont = true;
            this.groupTable.AppearanceCaption.Options.UseForeColor = true;
            this.groupTable.Controls.Add(this.gridControl1);
            this.groupTable.Controls.Add(this.btnRemoveTable);
            this.groupTable.Controls.Add(this.btnAddTable);
            this.groupTable.Controls.Add(this.txtTableName);
            this.groupTable.Controls.Add(this.labelControl5);
            this.groupTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupTable.Location = new System.Drawing.Point(283, 27);
            this.groupTable.Name = "groupTable";
            this.groupTable.Size = new System.Drawing.Size(379, 400);
            this.groupTable.TabIndex = 6;
            this.groupTable.Text = "Cập nhật bàn";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(2, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(375, 343);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TableID,
            this.TableName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TableID
            // 
            this.TableID.Caption = "Mã bàn";
            this.TableID.FieldName = "TableID";
            this.TableID.Name = "TableID";
            this.TableID.Visible = true;
            this.TableID.VisibleIndex = 0;
            // 
            // TableName
            // 
            this.TableName.Caption = "Tên bàn";
            this.TableName.FieldName = "TableName";
            this.TableName.Name = "TableName";
            this.TableName.Visible = true;
            this.TableName.VisibleIndex = 1;
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Image = global::iCafe.Properties.Resources.delete;
            this.btnRemoveTable.Location = new System.Drawing.Point(310, 29);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(64, 23);
            this.btnRemoveTable.TabIndex = 2;
            this.btnRemoveTable.Text = "Xóa";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Image = global::iCafe.Properties.Resources._new;
            this.btnAddTable.Location = new System.Drawing.Point(229, 29);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "Thêm bàn";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(70, 32);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(151, 20);
            this.txtTableName.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tên bàn";
            // 
            // btnOpenIMG
            // 
            this.btnOpenIMG.Image = global::iCafe.Properties.Resources.folder16;
            this.btnOpenIMG.Location = new System.Drawing.Point(133, 269);
            this.btnOpenIMG.Name = "btnOpenIMG";
            this.btnOpenIMG.Size = new System.Drawing.Size(90, 23);
            this.btnOpenIMG.TabIndex = 4;
            this.btnOpenIMG.Text = "Duyệt ảnh";
            this.btnOpenIMG.Click += new System.EventHandler(this.btnOpenIMG_Click);
            // 
            // spinCost
            // 
            this.spinCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCost.Location = new System.Drawing.Point(105, 83);
            this.spinCost.Name = "spinCost";
            this.spinCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinCost.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinCost.Size = new System.Drawing.Size(151, 20);
            this.spinCost.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ảnh đại diện bàn";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(262, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "%";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Giá khu vực";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên khu vực";
            // 
            // txtZoneName
            // 
            this.txtZoneName.Location = new System.Drawing.Point(105, 45);
            this.txtZoneName.Name = "txtZoneName";
            this.txtZoneName.Size = new System.Drawing.Size(151, 20);
            this.txtZoneName.TabIndex = 0;
            // 
            // frmZoneAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 470);
            this.ControlBox = false;
            this.Controls.Add(this.groupZone);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmZoneAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupZone)).EndInit();
            this.groupZone.ResumeLayout(false);
            this.groupZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoneImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTable)).EndInit();
            this.groupTable.ResumeLayout(false);
            this.groupTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoneName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupZone;
        private GroupControl groupTable;
        private SimpleButton btnOpenIMG;
        private SpinEdit spinCost;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit txtZoneName;
        private SimpleButton btnAddTable;
        private TextEdit txtTableName;
        private LabelControl labelControl5;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn TableID;
        private GridColumn TableName;
        private SimpleButton btnRemoveTable;
        private PictureEdit picZoneImage;

    }
}