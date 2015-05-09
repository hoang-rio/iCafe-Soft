using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;
using iCafe.Commons;
using iCafe.Properties;
using iCafe.UserControls;
using iCafe.Userform;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Users;
using iCafeLIB.Models.BaseUntils;

namespace iCafe
{
    public partial class frmMain : RibbonForm
    {
        private SqlConnection m_objConnection;
        private ModelsInfo m_objControllers;
        private SecurityContext m_objSecurity;
        private Services m_objServices;
        private userController m_objUserController;
        private bool NightMode;

        public frmMain()
        {
            InitializeComponent();
            m_objServices = new Services();
            m_objConnection = new SqlConnection();
            InitSkinGallery();
            InitMain();
        }

        private void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rbgiSkins, true);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND: //preventing the form from being moved by the mouse.
                    var command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
                //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private void InitMain()
        {
            try
            {
                m_objServices = new Services();
                m_objConnection = m_objServices.getConnection();
                m_objControllers = new ModelsInfo(m_objConnection);
                m_objSecurity = new SecurityContext();
                m_objUserController = new userController(m_objConnection, m_objSecurity);
            }
            catch (SqlException exception)
            {
                var check = XtraMessageBox.Show("Chi tiết: " + exception.Message, "Lỗi kết nối. Hãy thử lại sau",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                if (check != DialogResult.Retry)
                {
                    Application.Exit();
                }
                else
                {
                    if (File.Exists(Application.StartupPath + "\\iCafe.exe"))
                    {
                        Process.Start(Application.StartupPath + "\\iCafe.exe");
                    }
                    Application.Exit();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetFont();
            DockLeft.Options.ShowCloseButton = false;
            DockLeft.Options.ShowAutoHideButton = false;
            var frm = new frmUserlogin(m_objConnection, m_objSecurity);
            frm.ShowDialog();
            InitLogin();
            var ucc = new ucSalesMain(PanelMain, m_objConnection, m_objSecurity);
            PanelMain.Controls.Clear();
            ucc.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(ucc);
            var ucToolbar = new ucToolbar_Right(m_objConnection, m_objSecurity);
            DockRight.Controls.Add(ucToolbar);
        }

        private void SetFont()
        {
            var f = new Font(ConfigurationSettings.AppSettings.Get("font"),
                int.Parse(ConfigurationSettings.AppSettings.Get("fontsize")), FontStyle.Regular);
            BarAndDockingController.Default.AppearancesRibbon.PageHeader.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.PageCategory.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.PageGroupCaption.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.Item.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.ItemHovered.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.ItemPressed.Font = f;
        }

        private void InitLogin()
        {
            if (m_objSecurity._LoginSuccess)
            {
                Text = "iCafe - Xin chào: " + m_objSecurity._FullName + " (" + m_objSecurity._UserName + ")";
            }
            else
            {
                Text = "iCafe - Xin chào: Guest";
                PanelMain.Controls.Clear();
            }
        }

        private void navIBH_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var sale = new ucSales(m_objConnection, m_objSecurity);
                PanelMain.Controls.Clear();
                sale.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(sale);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void dockManager1_StartDocking(object sender, DockPanelCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void navKH_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var cus = new ucCustomer(m_objConnection, m_objSecurity);
                cus.Dock = DockStyle.Fill;
                cus.Show();
                PanelMain.Controls.Add(cus);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void navBookTable_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var table = new ucBookTable(m_objConnection, m_objSecurity);
                table.Dock = DockStyle.Fill;
                table.Show();
                PanelMain.Controls.Add(table);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFoodGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var mn = new ucMenu(m_objConnection, m_objSecurity);
                mn.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(mn);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnRMList_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var material = new ucMaterial(m_objConnection, m_objSecurity);
                material.Dock = DockStyle.Fill;
                material.Show();
                PanelMain.Controls.Add(material);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void navNV_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                EmployMana();
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        ///     Hiện ucEmployee
        /// </summary>
        private void EmployMana()
        {
            try
            {
                PanelMain.Controls.Clear();
                var employee = new ucEmployee(m_objConnection, m_objSecurity);
                employee.Dock = DockStyle.Fill;
                employee.Show();
                PanelMain.Controls.Add(employee);
            }
            catch (Exception)
            {
            }
        }

        private void bbtnTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var table = new ucTable(m_objConnection, m_objSecurity);
                table.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(table);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnDarkMode_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                if (NightMode)
                {
                    UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
                    NightMode = false;
                    bbtnDarkMode.Caption = "Chế độ ban đêm";
                    bbtnDarkMode.LargeGlyph = Resources.weather_clear_night;
                }
                else
                {
                    UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");
                    NightMode = true;
                    bbtnDarkMode.Caption = "Chế độ ban ngày";
                    bbtnDarkMode.LargeGlyph = Resources.DayMode;
                }
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtExistEvt_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var Evt = new ucEvent(m_objConnection, m_objSecurity);
                Evt.Dock = DockStyle.Fill;
                Evt.Show();
                PanelMain.Controls.Add(Evt);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void navThucdon_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var mn = new ucMenu(m_objConnection, m_objSecurity);
                mn.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(mn);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void navEvt_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var eve = new ucEvent(m_objConnection, m_objSecurity);
                eve.Dock = DockStyle.Fill;
                eve.Show();
                PanelMain.Controls.Add(eve);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void navBKho_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var mat = new ucMaterial(m_objConnection, m_objSecurity);
                mat.Dock = DockStyle.Fill;
                mat.Show();
                PanelMain.Controls.Add(mat);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
        }

        private void bbtnlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._LoginSuccess)
                {
                    if (
                        XtraMessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        m_objSecurity = new SecurityContext();
                        InitLogin();
                        bbtnlogout.LargeGlyph = Resources.login_icon;
                        bbtnlogout.Caption = "Đăng nhập";
                    }
                }
                else
                {
                    var frm = new frmUserlogin(m_objConnection, m_objSecurity);
                    frm.ShowDialog();
                    InitLogin();
                    bbtnlogout.LargeGlyph = Resources.onebit_24;
                    bbtnlogout.Caption = "Đăng xuất";
                }
            }
            catch (Exception)
            {
            }
        }

        private void bbtnchangepw_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var changePass = new frmChangePass(m_objConnection, m_objSecurity);
                if (!changePass.IsDisposed)
                    changePass.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnQLNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                EmployMana();
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnPer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var PerStr = @"- Toàn quyền: " + m_objSecurity._FullPermiss +
                         "\n\r- Khách hàng: " + m_objSecurity._fc_Customer +
                         "\n\r- Sự kiện: " + m_objSecurity._fc_event +
                         "\n\r- Doanh thu: " + m_objSecurity._fc_revenue +
                         "\n\r- Bán hàng: " + m_objSecurity._fc_sale +
                         "\n\r- Hệ thống: " + m_objSecurity._fc_system +
                         "\n\r- Bàn và khu vực: " + m_objSecurity._fc_table +
                         "\n\r- Kho: " + m_objSecurity._fc_warehouse;
            XtraMessageBox.Show(PerStr, "Quyền hạn của bạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bbtnUserinfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var AccInfo = "Tên tài khoản: " + m_objSecurity._UserName
                              + "\nTên nhân viên: " + m_objSecurity._FullName;
                XtraMessageBox.Show(AccInfo, "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
            }
        }

        private void bbtnWS_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var ws = new ucWorkShift(m_objConnection, m_objSecurity);
                PanelMain.Controls.Clear();
                ws.Dock = DockStyle.Fill;
                ws.Show();
                PanelMain.Controls.Add(ws);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnChucvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var per = new ucPermission(m_objConnection, m_objSecurity);
                PanelMain.Controls.Clear();
                per.Dock = DockStyle.Fill;
                per.Show();
                PanelMain.Controls.Add(per);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnHomepage_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("http://imic.edu.vn");
        }

        private void bbtnCallSuport_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Số điện thoại hỗ trợ: 04333920909", "Gọi hỗ trợ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void bbtnRemoteSuport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Application.StartupPath + "\\QS.exe");
        }

        private void bbtnChangeCusDiscount_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var cDiscount = new frmChangDiscount(m_objConnection, m_objSecurity);
                cDiscount.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var ucFood = new ucFood(m_objConnection, m_objSecurity);
                ucFood.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucFood);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnChangePer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var frmChangePer = new frmChangePer(m_objConnection, m_objSecurity);
                if (!frmChangePer.IsDisposed)
                {
                    frmChangePer.ShowDialog();
                }
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFontconfig_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var font = new frmFontEdit();
                font.ShowDialog();
                SetFont();
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnphancong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var Ws = new frmChangeWS(m_objConnection, m_objSecurity);
                Ws.ShowDialog();
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._fc_system)
                {
                    SplashScreenManager.ShowForm(typeof (frmwait));
                    PanelMain.Controls.Clear();
                    var frm = new frmBonusPunishAdd(m_objConnection, m_objSecurity, true);
                    frm.ShowDialog();
                    var bp = new ucBonusPunish(m_objConnection, m_objSecurity);
                    bp.Dock = DockStyle.Fill;
                    PanelMain.Controls.Add(bp);
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                }
            }
            catch (Exception)
            {
            }
        }

        private void bbtnPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._fc_system)
                {
                    SplashScreenManager.ShowForm(typeof (frmwait));
                    PanelMain.Controls.Clear();
                    var frm = new frmBonusPunishAdd(m_objConnection, m_objSecurity, false);
                    frm.ShowDialog();
                    var bp = new ucBonusPunish(m_objConnection, m_objSecurity);
                    bp.Dock = DockStyle.Fill;
                    PanelMain.Controls.Add(bp);
                    SplashScreenManager.CloseForm();
                }
            }
            catch (Exception)
            {
            }
        }

        private void bbtnnoiquy_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\Noiquy.xlsx");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Không tìm thấy file Noiquy.xlsx trong thư mục chương trình");
            }
        }

        private void bbtnZone_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var z = new ucZone(m_objConnection, m_objSecurity);
                z.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(z);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnDT_Table_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void bbtnTimBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var et = new ucTableEmpty(m_objConnection, m_objSecurity);
                et.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(et);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnBookTable_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var bt = new ucBookTable(m_objConnection, m_objSecurity);
                bt.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(bt);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnRunningEvt_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));

                PanelMain.Controls.Clear();
                var evt = new ucEvent(true, m_objConnection, m_objSecurity);
                evt.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(evt);

                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFBillEmploy_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var Bill = new ucBill(2, m_objConnection, m_objSecurity);
                Bill.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(Bill);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFBillCusName_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var Bill = new ucBill(0, m_objConnection, m_objSecurity);
                Bill.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(Bill);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFBillDate_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var Bill = new ucBill(3, m_objConnection, m_objSecurity);
                Bill.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(Bill);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnaddSp_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm((typeof (frmwait)));
                PanelMain.Controls.Clear();
                var ballot = new ucBallotGood(m_objConnection, m_objSecurity);
                ballot.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ballot);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm((typeof (frmwait)));
                var sl = new frmSalary(m_objConnection, m_objSecurity);
                sl.ShowDialog();
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFEmployName_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._fc_system)
                {
                    PanelMain.Controls.Clear();
                    SplashScreenManager.ShowForm((typeof (frmwait)));
                    var EmS = new frmSearchBox(0, m_objConnection, m_objSecurity);
                    SplashScreenManager.CloseForm();
                    EmS.ShowDialog();
                    if (!EmS.IsDisposed)
                    {
                        SplashScreenManager.ShowForm((typeof (frmwait)));
                        var uce = new ucEmployee(0, EmS.txtkeyWord.Text, m_objConnection, m_objSecurity);
                        uce.Dock = DockStyle.Fill;
                        PanelMain.Controls.Add(uce);
                        SplashScreenManager.CloseForm();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                }
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFEmployCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._fc_system)
                {
                    PanelMain.Controls.Clear();
                    var EmS = new frmSearchBox(1, m_objConnection, m_objSecurity);
                    EmS.ShowDialog();
                    if (!EmS.IsDisposed)
                    {
                        SplashScreenManager.ShowForm((typeof (frmwait)));
                        var uce = new ucEmployee(1,
                            ((DataRowView) EmS.lookWS.Properties.GetDataSourceRowByKeyValue(EmS.lookWS.EditValue))[
                                "WSID"]
                                .ToString(), m_objConnection, m_objSecurity);
                        uce.Dock = DockStyle.Fill;
                        PanelMain.Controls.Add(uce);
                        SplashScreenManager.CloseForm();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                }
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFEmployNow_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._fc_system)
                {
                    PanelMain.Controls.Clear();
                    SplashScreenManager.ShowForm(typeof (frmwait));
                    var uce = new ucEmployee(2, "Null", m_objConnection, m_objSecurity);
                    uce.Dock = DockStyle.Fill;
                    PanelMain.Controls.Add(uce);
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                }
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFTableZone_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                PanelMain.Controls.Clear();
                SplashScreenManager.ShowForm(typeof (frmwait));
                var tZ = new ucTableByZone(m_objConnection, m_objSecurity);
                tZ.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(tZ);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnFCusName_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (m_objSecurity._fc_system)
                {
                    PanelMain.Controls.Clear();
                    var EmS = new frmSearchBox(0, m_objConnection, m_objSecurity);
                    EmS.ShowDialog();
                    if (!EmS.IsDisposed)
                    {
                        SplashScreenManager.ShowForm((typeof (frmwait)));
                        var ucCus = new ucCustomer(EmS.txtkeyWord.Text, m_objConnection, m_objSecurity);
                        ucCus.Dock = DockStyle.Fill;
                        PanelMain.Controls.Add(ucCus);
                        SplashScreenManager.CloseForm();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                }
            }
            catch (Exception)
            {
            }
        }

        private void ribbon_ApplicationButtonClick(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var ucSM = new ucSalesMain(PanelMain, m_objConnection, m_objSecurity);
                ucSM.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucSM);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnRMImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm((typeof (frmwait)));
                PanelMain.Controls.Clear();
                var importExport = new ucImportExport(1, m_objConnection, m_objSecurity);
                importExport.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(importExport);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnRMExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm((typeof (frmwait)));
                PanelMain.Controls.Clear();
                var importExport = new ucImportExport(0, m_objConnection, m_objSecurity);
                importExport.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(importExport);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
            }
        }

        private void bbtnQLKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                navKH_LinkClicked(sender, null);
            }
            catch (Exception)
            {
            }
        }

        private void btnComputeSalary_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(frmwait));
                PanelMain.Controls.Clear();
                var ucSl = new ucSalaryCompute(m_objConnection, m_objSecurity);
                ucSl.Dock=DockStyle.Fill;
                PanelMain.Controls.Add(ucSl);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
                
            }
        }
    }
}