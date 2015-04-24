using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmBonusPunishAdd
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
            this.groupKH = new DevExpress.XtraEditors.GroupControl();
            this.txtContent = new DevExpress.XtraEditors.TextEdit();
            this.lookEmploy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).BeginInit();
            this.groupKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookEmploy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupKH
            // 
            this.groupKH.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupKH.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupKH.AppearanceCaption.Options.UseFont = true;
            this.groupKH.AppearanceCaption.Options.UseForeColor = true;
            this.groupKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupKH.Controls.Add(this.txtContent);
            this.groupKH.Controls.Add(this.lookEmploy);
            this.groupKH.Controls.Add(this.txtValue);
            this.groupKH.Controls.Add(this.labelControl3);
            this.groupKH.Controls.Add(this.labelControl8);
            this.groupKH.Controls.Add(this.labelControl2);
            this.groupKH.Controls.Add(this.labelControl1);
            this.groupKH.Controls.Add(this.cbType);
            this.groupKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKH.Location = new System.Drawing.Point(0, 50);
            this.groupKH.Name = "groupKH";
            this.groupKH.Size = new System.Drawing.Size(323, 218);
            this.groupKH.TabIndex = 7;
            this.groupKH.Text = "Cập nhật thưởng phạt";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(110, 174);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.MaxLength = 20;
            this.txtContent.Size = new System.Drawing.Size(177, 20);
            this.txtContent.TabIndex = 11;
            // 
            // lookEmploy
            // 
            this.lookEmploy.Location = new System.Drawing.Point(110, 48);
            this.lookEmploy.Name = "lookEmploy";
            this.lookEmploy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookEmploy.Properties.NullText = "Chọn nhân viên";
            this.lookEmploy.Properties.View = this.searchLookUpEdit1View;
            this.lookEmploy.Size = new System.Drawing.Size(177, 20);
            this.lookEmploy.TabIndex = 10;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FullName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FullName
            // 
            this.FullName.Caption = "Tên nhân viên";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(110, 131);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtValue.Properties.Appearance.Options.UseFont = true;
            this.txtValue.Size = new System.Drawing.Size(177, 20);
            this.txtValue.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(34, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Nội dung";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Location = new System.Drawing.Point(34, 134);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(27, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Giá trị";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(34, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(34, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Loại";
            // 
            // cbType
            // 
            this.cbType.Location = new System.Drawing.Point(110, 94);
            this.cbType.Name = "cbType";
            this.cbType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbType.Properties.Appearance.Options.UseFont = true;
            this.cbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbType.Properties.Items.AddRange(new object[] {
            "Thưởng",
            "Phạt"});
            this.cbType.Size = new System.Drawing.Size(177, 20);
            this.cbType.TabIndex = 1;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(323, 50);
            this.ucUpdate1.TabIndex = 6;
            // 
            // frmBonusPunishAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 268);
            this.ControlBox = false;
            this.Controls.Add(this.groupKH);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmBonusPunishAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupKH)).EndInit();
            this.groupKH.ResumeLayout(false);
            this.groupKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookEmploy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupKH;
        private TextEdit txtValue;
        private LabelControl labelControl8;
        private LabelControl labelControl1;
        private ucUpdate ucUpdate1;
        private ComboBoxEdit cbType;
        private SearchLookUpEdit lookEmploy;
        private GridView searchLookUpEdit1View;
        private LabelControl labelControl2;
        private TextEdit txtContent;
        private LabelControl labelControl3;
        private GridColumn FullName;
    }
}