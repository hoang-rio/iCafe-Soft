using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucSalaryCompute : DevExpress.XtraEditors.XtraUserControl
    {
        private SqlConnection mobjConnection;
        private SecurityContext mobjSecurity;
        public ucSalaryCompute(SqlConnection objConnection,SecurityContext objSecurityContext)
        {
            mobjSecurity = objSecurityContext;
            mobjConnection = objConnection;
            if (!mobjSecurity._fc_system)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                this.Dispose();
            }
            InitializeComponent();
            btnToxlsx.ItemClick += SaveToXlsx;
            btnToxls.ItemClick += SaveToXls;
            btnClose.ItemClick += Close_Click;
            Compute_salary();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void SaveToXlsx(object sender,EventArgs e)
        {
            try
            {
               SaveFileDialog sv=new SaveFileDialog();
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
                SaveFileDialog sv = new SaveFileDialog();
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
                SalaryController sl=new SalaryController(mobjConnection,mobjSecurity);
                gridControl1.DataSource = sl.GetAll();
            }
            catch (Exception exception)
            {

                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}
