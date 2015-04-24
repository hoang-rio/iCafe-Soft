using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmEmployAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployAdd));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassW = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.cbDayoff = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bbtnEditCa = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowPass = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinOvertime = new DevExpress.XtraEditors.SpinEdit();
            this.dateNS = new DevExpress.XtraEditors.DateEdit();
            this.lookWorkShift = new DevExpress.XtraEditors.LookUpEdit();
            this.lookPermis = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmployPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtEmployAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtEmployName = new DevExpress.XtraEditors.TextEdit();
            this.picEmployee = new DevExpress.XtraEditors.PictureEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDayoff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOvertime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookWorkShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPermis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtPassW);
            this.groupControl1.Controls.Add(this.txtUserName);
            this.groupControl1.Controls.Add(this.cbDayoff);
            this.groupControl1.Controls.Add(this.bbtnEditCa);
            this.groupControl1.Controls.Add(this.btnShowPass);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.cbSex);
            this.groupControl1.Controls.Add(this.spinOvertime);
            this.groupControl1.Controls.Add(this.dateNS);
            this.groupControl1.Controls.Add(this.lookWorkShift);
            this.groupControl1.Controls.Add(this.lookPermis);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEmployPhone);
            this.groupControl1.Controls.Add(this.txtEmployAddress);
            this.groupControl1.Controls.Add(this.txtEmployName);
            this.groupControl1.Controls.Add(this.picEmployee);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(580, 462);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cập nhật thông tin Nhân viên";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl11.Location = new System.Drawing.Point(18, 121);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(58, 13);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Mật khẩu (*)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl12.Location = new System.Drawing.Point(18, 83);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(87, 13);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "Tên đăng nhập (*)";
            // 
            // txtPassW
            // 
            this.txtPassW.Location = new System.Drawing.Point(115, 118);
            this.txtPassW.Name = "txtPassW";
            this.txtPassW.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPassW.Properties.Appearance.Options.UseFont = true;
            this.txtPassW.Properties.PasswordChar = '*';
            this.txtPassW.Size = new System.Drawing.Size(177, 20);
            this.txtPassW.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(177, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // cbDayoff
            // 
            this.cbDayoff.EditValue = "";
            this.cbDayoff.Location = new System.Drawing.Point(115, 424);
            this.cbDayoff.Name = "cbDayoff";
            this.cbDayoff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDayoff.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thứ 2"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thứ 3"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thứ 4"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thứ 5"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thứ 6"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thứ 7"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Chủ Nhật")});
            this.cbDayoff.Size = new System.Drawing.Size(177, 20);
            this.cbDayoff.TabIndex = 11;
            // 
            // bbtnEditCa
            // 
            this.bbtnEditCa.Image = global::iCafe.Properties.Resources.action_settings;
            this.bbtnEditCa.Location = new System.Drawing.Point(299, 196);
            this.bbtnEditCa.Name = "bbtnEditCa";
            this.bbtnEditCa.Size = new System.Drawing.Size(22, 23);
            this.bbtnEditCa.TabIndex = 15;
            this.bbtnEditCa.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.bbtnEditCa.ToolTipTitle = "Sửa/Thêm ca làm việc";
            this.bbtnEditCa.Click += new System.EventHandler(this.bbtnEditCa_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.Image = global::iCafe.Properties.Resources.eye;
            this.btnShowPass.Location = new System.Drawing.Point(299, 117);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(22, 23);
            this.btnShowPass.TabIndex = 14;
            this.btnShowPass.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnShowPass.ToolTipTitle = "Sửa/Thêm chức vụ";
            this.btnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(405, 323);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Duyệt ảnh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl10.Location = new System.Drawing.Point(416, 45);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Ảnh đại diện";
            // 
            // cbSex
            // 
            this.cbSex.EditValue = "Lựa chọn giới tính";
            this.cbSex.Location = new System.Drawing.Point(115, 276);
            this.cbSex.Name = "cbSex";
            this.cbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSex.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Size = new System.Drawing.Size(177, 20);
            this.cbSex.TabIndex = 7;
            this.cbSex.ToolTip = "Không chọn là Gay";
            // 
            // spinOvertime
            // 
            this.spinOvertime.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinOvertime.Location = new System.Drawing.Point(115, 386);
            this.spinOvertime.Name = "spinOvertime";
            this.spinOvertime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.spinOvertime.Properties.Appearance.Options.UseFont = true;
            this.spinOvertime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinOvertime.Properties.Mask.EditMask = "n0";
            this.spinOvertime.Properties.MaxLength = 3;
            this.spinOvertime.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinOvertime.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinOvertime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spinOvertime.Size = new System.Drawing.Size(177, 20);
            this.spinOvertime.TabIndex = 10;
            // 
            // dateNS
            // 
            this.dateNS.EditValue = null;
            this.dateNS.Location = new System.Drawing.Point(115, 314);
            this.dateNS.Name = "dateNS";
            this.dateNS.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateNS.Properties.Appearance.Options.UseFont = true;
            this.dateNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNS.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNS.Size = new System.Drawing.Size(177, 20);
            this.dateNS.TabIndex = 8;
            // 
            // lookWorkShift
            // 
            this.lookWorkShift.EditValue = "";
            this.lookWorkShift.Location = new System.Drawing.Point(115, 199);
            this.lookWorkShift.Name = "lookWorkShift";
            this.lookWorkShift.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lookWorkShift.Properties.Appearance.Options.UseFont = true;
            this.lookWorkShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookWorkShift.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WSName", "Ca trực")});
            this.lookWorkShift.Size = new System.Drawing.Size(177, 20);
            this.lookWorkShift.TabIndex = 5;
            // 
            // lookPermis
            // 
            this.lookPermis.EditValue = "";
            this.lookPermis.Location = new System.Drawing.Point(115, 160);
            this.lookPermis.Name = "lookPermis";
            this.lookPermis.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lookPermis.Properties.Appearance.Options.UseFont = true;
            this.lookPermis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPermis.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PerName", "Chức vụ")});
            this.lookPermis.Size = new System.Drawing.Size(177, 20);
            this.lookPermis.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(18, 202);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Ca làm việc";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(18, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Chức vụ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl9.Location = new System.Drawing.Point(18, 279);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Giới tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(18, 240);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(18, 389);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Số giờ làm thêm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(18, 355);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl8.Location = new System.Drawing.Point(18, 427);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Sô ngày nghỉ ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl6.Location = new System.Drawing.Point(18, 317);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(18, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ Tên";
            // 
            // txtEmployPhone
            // 
            this.txtEmployPhone.Location = new System.Drawing.Point(115, 237);
            this.txtEmployPhone.Name = "txtEmployPhone";
            this.txtEmployPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmployPhone.Properties.Appearance.Options.UseFont = true;
            this.txtEmployPhone.Size = new System.Drawing.Size(177, 20);
            this.txtEmployPhone.TabIndex = 6;
            // 
            // txtEmployAddress
            // 
            this.txtEmployAddress.Location = new System.Drawing.Point(115, 352);
            this.txtEmployAddress.Name = "txtEmployAddress";
            this.txtEmployAddress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmployAddress.Properties.Appearance.Options.UseFont = true;
            this.txtEmployAddress.Size = new System.Drawing.Size(177, 20);
            this.txtEmployAddress.TabIndex = 9;
            // 
            // txtEmployName
            // 
            this.txtEmployName.Location = new System.Drawing.Point(115, 42);
            this.txtEmployName.Name = "txtEmployName";
            this.txtEmployName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmployName.Properties.Appearance.Options.UseFont = true;
            this.txtEmployName.Size = new System.Drawing.Size(177, 20);
            this.txtEmployName.TabIndex = 1;
            // 
            // picEmployee
            // 
            this.picEmployee.Location = new System.Drawing.Point(332, 71);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.picEmployee.Properties.Appearance.Options.UseFont = true;
            this.picEmployee.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEmployee.Size = new System.Drawing.Size(234, 234);
            this.picEmployee.TabIndex = 13;
            this.picEmployee.TabStop = true;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(580, 41);
            this.ucUpdate1.TabIndex = 2;
            // 
            // frmEmployAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 503);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmEmployAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            this.Load += new System.EventHandler(this.frmEmployAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDayoff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOvertime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookWorkShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPermis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit txtEmployPhone;
        private TextEdit txtEmployAddress;
        private TextEdit txtEmployName;
        private LookUpEdit lookWorkShift;
        private LookUpEdit lookPermis;
        private DateEdit dateNS;
        private LabelControl labelControl8;
        private LabelControl labelControl6;
        private SpinEdit spinOvertime;
        private LabelControl labelControl7;
        private LabelControl labelControl9;
        private ComboBoxEdit cbSex;
        private PictureEdit picEmployee;
        private LabelControl labelControl10;
        private SimpleButton simpleButton1;
        private SimpleButton bbtnEditCa;
        private OpenFileDialog openFileDialog1;
        private CheckedComboBoxEdit cbDayoff;
        private LabelControl labelControl11;
        private LabelControl labelControl12;
        private TextEdit txtPassW;
        private TextEdit txtUserName;
        private SimpleButton btnShowPass;
    }
}