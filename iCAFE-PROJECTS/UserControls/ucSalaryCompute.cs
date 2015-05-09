using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucSalaryCompute : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        public ucSalaryCompute(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjSecurity = objSecurityContext;
            mobjConnection = objConnection;
            if (!mobjSecurity._fc_system)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
            InitializeComponent();
            btnToxlsx.ItemClick += SaveToXlsx;
            btnToxls.ItemClick += SaveToXls;
            btnClose.ItemClick += Close_Click;
            Compute_salary();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SaveToXlsx(object sender, EventArgs e)
        {
            try
            {
                var sv = new SaveFileDialog();
                sv.Filter = "Exel 2010/2013 (*.xlsx)|*.xlsx";
                sv.DefaultExt = "*.xlsx";
                sv.Title = "Chọn nơi lưu file";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    gridView1.ExportToXlsx(sv.FileName);
                    XtraMessageBox.Show("Đã lưu file");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void SaveToXls(object sender, EventArgs e)
        {
            try
            {
                var sv = new SaveFileDialog();
                sv.Filter = "Exel 2003-2007(*.xls)|*.xls";
                sv.DefaultExt = "*.xls";
                sv.Title = "Chọn nơi lưu file";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    gridView1.ExportToXls(sv.FileName);
                    XtraMessageBox.Show("Đã lưu file");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Compute_salary()
        {
            try
            {
                var sl = new SalaryController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = sl.GetAll();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}