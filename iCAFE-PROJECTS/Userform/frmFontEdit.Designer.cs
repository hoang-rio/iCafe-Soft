using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmFontEdit
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbbSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.richPreview = new DevExpress.XtraRichEdit.RichEditControl();
            this.cbbfont = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbfont.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(479, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbfont);
            this.groupControl1.Controls.Add(this.richPreview);
            this.groupControl1.Controls.Add(this.cbbSize);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(479, 328);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thay đổi font chữ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn Font";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Chọn cỡ font";
            // 
            // cbbSize
            // 
            this.cbbSize.EditValue = "10";
            this.cbbSize.Location = new System.Drawing.Point(138, 77);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSize.Properties.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cbbSize.Size = new System.Drawing.Size(220, 20);
            this.cbbSize.TabIndex = 2;
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.cbbfont_SelectedIndexChanged);
            // 
            // richPreview
            // 
            this.richPreview.Location = new System.Drawing.Point(0, 103);
            this.richPreview.Name = "richPreview";
            this.richPreview.Size = new System.Drawing.Size(479, 225);
            this.richPreview.TabIndex = 3;
            this.richPreview.Text = "Xem trước";
            // 
            // cbbfont
            // 
            this.cbbfont.Location = new System.Drawing.Point(138, 27);
            this.cbbfont.Name = "cbbfont";
            this.cbbfont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbfont.Size = new System.Drawing.Size(220, 20);
            this.cbbfont.TabIndex = 4;
            this.cbbfont.SelectedIndexChanged += new System.EventHandler(this.cbbfont_SelectedIndexChanged);
            // 
            // frmFontEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 369);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmFontEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbfont.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private ComboBoxEdit cbbfont;
        private RichEditControl richPreview;
        private ComboBoxEdit cbbSize;
        private LabelControl labelControl2;
        private LabelControl labelControl1;

    }
}