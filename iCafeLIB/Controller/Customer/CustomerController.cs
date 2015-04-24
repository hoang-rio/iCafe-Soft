using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Customer
{
    public class CustomerController
    {
        private const string SP_CUSTOMER_LOAD = "SP_CUSTOMER_LOAD";
        private const string SP_CUSTOMER_ADD = "SP_CUSTOMER_ADD";
        private const string SP_CUSTOMER_DELETE = "SP_CUSTOMER_DELETE";
        private const string SP_CUSTOMER_UPDATE = "SP_CUSTOMER_UPDATE";
        private const string SP_CUSTOMER_BYNAME = "SP_CUSTOMER_BYNAME";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelinfo;
        private SecurityContext m_objSecurity;
        private DataTable objTable;

        public CustomerController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelinfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy dữ liệu khách hàng
        /// </summary>
        /// <returns></returns>
        public DataTable GetALL()
        {
            try
            {
                objTable = m_objModelinfo.ExecProcReturnTable(SP_CUSTOMER_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objTable;
        }

        /// <summary>
        ///     Thêm khách hàng mới
        /// </summary>
        /// <param name="objCusTable"></param>
        public void AddNew(iCafeDataEn.iCafe_CustomerDataTable objCusTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_CustomerRow) objCusTable.Rows[0];
                var param = new SqlParameter[8];
                param[0] = new SqlParameter("@CusID", Row.CusID);
                param[1] = new SqlParameter("@CusName", Row.CusName);
                param[2] = new SqlParameter("@CusPhone", Row.CusPhone);
                param[3] = new SqlParameter("@CusAddress", Row.CusAddress);
                param[4] = new SqlParameter("@Company", Row.Company);
                param[5] = new SqlParameter("@Birthday", Row.Birthday);
                param[6] = new SqlParameter("@Discount", Row.Discount);
                param[7] = new SqlParameter("@CusSex", Row.CusSex);
                m_objModelinfo.ExecProcNoReturn(SP_CUSTOMER_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Xóa Khác hàng dựa vào ID
        /// </summary>
        /// <param name="CusID">CusID</param>
        public void Delete(string CusID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@CusID", CusID);
                m_objModelinfo.ExecProcNoReturn(SP_CUSTOMER_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_CustomerDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_CustomerRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@CusID", row.CusID);
                param[1] = new SqlParameter("@CusName", row.CusName);
                param[2] = new SqlParameter("@CusSex", row.CusSex);
                param[3] = new SqlParameter("@CusPhone", row.CusPhone);
                param[4] = new SqlParameter("@CusAddress", row.CusAddress);
                param[5] = new SqlParameter("@Company", row.Company);
                param[6] = new SqlParameter("@Birthday", row.Birthday);
                param[7] = new SqlParameter("@Discount", row.Discount);
                m_objModelinfo.ExecProcNoReturn(SP_CUSTOMER_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Tìm khách hàng theo tên
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public DataTable ByName(string Name)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@CusName", Name);
                objTable = m_objModelinfo.ExecProcReturnTable(SP_CUSTOMER_BYNAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }
    }
}