using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmChangDiscount
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.spinDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.lookCus = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.spinDiscount);
            this.groupControl1.Controls.Add(this.lookCus);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(337, 141);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chiết khấu khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chiết khấu";
            // 
            // spinDiscount
            // 
            this.spinDiscount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDiscount.Location = new System.Drawing.Point(97, 83);
            this.spinDiscount.Name = "spinDiscount";
            this.spinDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinDiscount.Properties.Mask.EditMask = "n0";
            this.spinDiscount.Properties.MaxLength = 3;
            this.spinDiscount.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinDiscount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDiscount.Size = new System.Drawing.Size(222, 20);
            this.spinDiscount.TabIndex = 23;
            // 
            // lookCus
            // 
            this.lookCus.Location = new System.Drawing.Point(97, 37);
            this.lookCus.Name = "lookCus";
            this.lookCus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCus.Properties.NullText = "Chọn khách hàng";
            this.lookCus.Properties.View = this.searchLookUpEdit1View;
            this.lookCus.Size = new System.Drawing.Size(222, 20);
            this.lookCus.TabIndex = 22;
            this.lookCus.EditValueChanged += new System.EventHandler(this.lookCus_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CusName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Location = new System.Drawing.Point(17, 40);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Khách hàng";
            // 
            // CusName
            // 
            this.CusName.Caption = "Tên khách hàng";
            this.CusName.FieldName = "CusName";
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 0;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(337, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // frmChangDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 182);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmChangDiscount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private SearchLookUpEdit lookCus;
        private GridView searchLookUpEdit1View;
        private GridColumn CusName;
        private LabelControl labelControl9;
        private Label label2;
        private SpinEdit spinDiscount;

    }
}