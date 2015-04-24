using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Employee
{
    public class EmployeeController
    {
        private const string SP_EMPLOYEE_LOAD = "SP_EMPLOYEE_LOAD";
        private const string SP_EMPLOYEE_ADD = "SP_EMPLOYEE_ADD";
        private const string SP_CHECK_LOGIN = "SP_CHECK_LOGIN";
        private const string SP_EMPLOYEE_CHANGEPW = "SP_EMPLOYEE_CHANGEPW";
        //private const string SP_PERMISS_GETID_BYNAME = "SP_PERMISS_GETID_BYNAME";
        private const string SP_PERMISSION_LOAD = "SP_PERMISSION_LOAD";
        private const string SP_WORKSHIFT_LOAD = "SP_WORKSHIFT_LOAD";
        private const string SP_EMPLOYEE_DELETE = "SP_EMPLOYEE_DELETE";
        private const string SP_EMPLOYEE_UPDATE = "SP_EMPLOYEE_UPDATE";
        private const string SP_EMPLOYEE_BYFULLNAME = "SP_EMPLOYEE_BYFULLNAME";
        private const string SP_EMPLOYEE_BYWSID = "SP_EMPLOYEE_BYWSID";
        private const string SP_EMPLOYEE_WORKING = "SP_EMPLOYEE_WORKING";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        /// <summary>
        ///     Khởi tạo Employee Controler
        /// </summary>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public EmployeeController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelInfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy toàn bộ dữ liệu nhân viên lên gridview
        /// </summary>
        /// <returns>Datatable nhân viên</returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelInfo.ExecProcReturnTable(SP_EMPLOYEE_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void AddNew(iCafeDataEn.iCafe_EmployeeDataTable objEmTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_EmployeeRow) objEmTable.Rows[0];
                var c = objEmTable.Columns.Count;
                var param = new SqlParameter[objEmTable.Columns.Count];
                param[0] = new SqlParameter("@EmployID", Row.EmployID);
                param[1] = new SqlParameter("@FullName", Row.FullName);
                param[2] = new SqlParameter("@EmPhone", Row.EmPhone);
                param[3] = new SqlParameter("@EmAddress", Row.EmAddress);
                param[4] = new SqlParameter("@Sex", Row.Sex);
                param[5] = new SqlParameter("@Birthday", Row.Birthday);
                param[6] = new SqlParameter("@PerID", Row.PerID);
                param[7] = new SqlParameter("@WSID", Row.WSID);
                param[8] = new SqlParameter("@NumOvertime", Row.NumOvertime);
                param[9] = new SqlParameter("@Dayoff", Row.Dayoff);
                param[10] = new SqlParameter("@PicInfo", Row.PicInfo);
                param[11] = new SqlParameter("@UserName", Row.UserName);
                param[12] = new SqlParameter("PassW", Row.PassW);
                m_objModelInfo.ExecProcNoReturn(SP_EMPLOYEE_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Đổi mật khẩu
        /// </summary>
        /// <param name="objEmTable"></param>
        public void Changepw(iCafeDataEn.iCafe_EmployeeDataTable objEmTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_EmployeeRow) objEmTable.Rows[0];
                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@USERNAME", row.UserName);
                param[1] = new SqlParameter("@PASSWORD", row.PassW);
                m_objModelInfo.ExecProcNoReturn(SP_EMPLOYEE_CHANGEPW, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Checkpw(iCafeDataEn.iCafe_EmployeeDataTable objEmTable)
        {
            DataTable objTable;
            var Authed = false;
            try
            {
                var row = (iCafeDataEn.iCafe_EmployeeRow) objEmTable.Rows[0];
                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@USERNAME", row.UserName);
                param[1] = new SqlParameter("@PASSWORD", row.PassW);
                objTable = m_objModelInfo.ExecProcReturnTable(SP_CHECK_LOGIN, param);
                if (objTable.Rows.Count == 1)
                {
                    Authed = true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return Authed;
        }

        /// <summary>
        ///     Xóa nhân viên dựa vào ID
        /// </summary>
        /// <param name="EmployID">EmployID</param>
        public void Delete(string EmployID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmployID", EmployID);
                m_objModelInfo.ExecProcNoReturn(SP_EMPLOYEE_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_EmployeeDataTable objTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_EmployeeRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@EmployID", Row.EmployID);
                param[1] = new SqlParameter("@FullName", Row.FullName);
                param[2] = new SqlParameter("@EmPhone", Row.EmPhone);
                param[3] = new SqlParameter("@EmAddress", Row.EmAddress);
                param[4] = new SqlParameter("@Sex", Row.Sex);
                param[5] = new SqlParameter("@Birthday", Row.Birthday);
                param[6] = new SqlParameter("@PerID", Row.PerID);
                param[7] = new SqlParameter("@WSID", Row.WSID);
                param[8] = new SqlParameter("@NumOvertime", Row.NumOvertime);
                param[9] = new SqlParameter("@Dayoff", Row.Dayoff);
                param[10] = new SqlParameter("@PicInfo", Row.PicInfo);
                param[11] = new SqlParameter("@UserName", Row.UserName);
                param[12] = new SqlParameter("@PassW", Row.PassW);
                m_objModelInfo.ExecProcNoReturn(SP_EMPLOYEE_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Tìm kiếm nhân viên theo tên
        /// </summary>
        /// <param name="FullName">Tên đầy đủ</param>
        /// <returns></returns>
        public DataTable GetByFullName(string FullName)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@FullName", FullName);
                objTable = m_objModelInfo.ExecProcReturnTable(SP_EMPLOYEE_BYFULLNAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Tìm kiếm theo mã ca trực
        /// </summary>
        /// <param name="WSID">Mã ca trực</param>
        /// <returns></returns>
        public DataTable GetByWorkShift(string WSID)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@WSID", WSID);
                objTable = m_objModelInfo.ExecProcReturnTable(SP_EMPLOYEE_BYWSID, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        public DataTable GetWorking()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelInfo.ExecProcReturnTable(SP_EMPLOYEE_WORKING);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }
    }
}