using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmWorkShiftAdd
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtWSName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.spinStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.spinEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtWSNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtExpense = new DevExpress.XtraEditors.TextEdit();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.txtWSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWSNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpense.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl7.Location = new System.Drawing.Point(25, 126);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Thời gian kết thúc";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl6.Location = new System.Drawing.Point(25, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Thời gian bắt đầu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(25, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên ca trực";
            // 
            // txtWSName
            // 
            this.txtWSName.Location = new System.Drawing.Point(129, 45);
            this.txtWSName.Name = "txtWSName";
            this.txtWSName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtWSName.Properties.Appearance.Options.UseFont = true;
            this.txtWSName.Size = new System.Drawing.Size(177, 20);
            this.txtWSName.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.spinStartTime);
            this.groupControl1.Controls.Add(this.spinEndTime);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtWSNote);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtExpense);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtWSName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 312);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Cập nhật thông tin ca trực";
            // 
            // spinStartTime
            // 
            this.spinStartTime.EditValue = null;
            this.spinStartTime.Location = new System.Drawing.Point(129, 84);
            this.spinStartTime.Name = "spinStartTime";
            this.spinStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinStartTime.Properties.DisplayFormat.FormatString = "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d";
            this.spinStartTime.Properties.EditFormat.FormatString = "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d";
            this.spinStartTime.Properties.Mask.EditMask = "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d";
            this.spinStartTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.spinStartTime.Properties.Mask.PlaceHolder = ' ';
            this.spinStartTime.Properties.Mask.ShowPlaceHolders = false;
            this.spinStartTime.Size = new System.Drawing.Size(177, 20);
            this.spinStartTime.TabIndex = 2;
            // 
            // spinEndTime
            // 
            this.spinEndTime.EditValue = null;
            this.spinEndTime.Location = new System.Drawing.Point(129, 123);
            this.spinEndTime.Name = "spinEndTime";
            this.spinEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEndTime.Properties.Mask.EditMask = "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d";
            this.spinEndTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.spinEndTime.Properties.Mask.PlaceHolder = ' ';
            this.spinEndTime.Properties.Mask.ShowPlaceHolders = false;
            this.spinEndTime.Size = new System.Drawing.Size(177, 20);
            this.spinEndTime.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(25, 203);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Ghi chú";
            // 
            // txtWSNote
            // 
            this.txtWSNote.Location = new System.Drawing.Point(129, 197);
            this.txtWSNote.Name = "txtWSNote";
            this.txtWSNote.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtWSNote.Properties.Appearance.Options.UseFont = true;
            this.txtWSNote.Size = new System.Drawing.Size(177, 96);
            this.txtWSNote.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(25, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Bồi dưỡng";
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(129, 159);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtExpense.Properties.Appearance.Options.UseFont = true;
            this.txtExpense.Size = new System.Drawing.Size(177, 20);
            this.txtExpense.TabIndex = 4;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(327, 50);
            this.ucUpdate1.TabIndex = 2;
            // 
            // frmWorkShiftAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 362);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmWorkShiftAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.txtWSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWSNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpense.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private LabelControl labelControl1;
        private TextEdit txtWSName;
        private GroupControl groupControl1;
        private ucUpdate ucUpdate1;
        private LabelControl labelControl2;
        private TextEdit txtExpense;
        private LabelControl labelControl3;
        private MemoEdit txtWSNote;
        private TimeEdit spinEndTime;
        private TimeEdit spinStartTime;
    }
}