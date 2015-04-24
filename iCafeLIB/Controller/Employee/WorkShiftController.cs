using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Employee
{
    public class WorkShiftController
    {
        private const string SP_WORKSHIFT_LOAD = "SP_WORKSHIFT_LOAD";
        private const string SP_WORKSHIFT_ADD = "SP_WORKSHIFT_ADD";
        private const string SP_WORKSHIFT_DELETE = "SP_WORKSHIFT_DELETE";
        private const string SP_WORKSHIFT_UPDATE = "SP_WORKSHIFT_UPDATE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelsInfo;
        private SecurityContext m_objSecurity;

        public WorkShiftController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelsInfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Thêm ca trực mới
        /// </summary>
        /// <param name="objTable"></param>
        public void AddNew(iCafeDataEn.iCafe_WorkShiftDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_WorkShiftRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@WSID", row.WSID);
                param[1] = new SqlParameter("@WSName", row.WSName);
                param[2] = new SqlParameter("@StartTime", row.StartTime);
                param[3] = new SqlParameter("@EndTime", row.EndTime);
                param[4] = new SqlParameter("@WSNote", row.WSNote);
                param[5] = new SqlParameter("@Expense", row.Expense);
                m_objModelsInfo.ExecProcNoReturn(SP_WORKSHIFT_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Lấy thông tin ca trực
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelsInfo.ExecProcReturnTable(SP_WORKSHIFT_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        /// <summary>
        ///     Cập nhật thông tin ca trực
        /// </summary>
        /// <returns></returns>
        public void Update(iCafeDataEn.iCafe_WorkShiftDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_WorkShiftRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@WSID", row.WSID);
                param[1] = new SqlParameter("@WSName", row.WSName);
                param[2] = new SqlParameter("@StartTime", row.StartTime);
                param[3] = new SqlParameter("@EndTime", row.EndTime);
                param[4] = new SqlParameter("@WSNote", row.WSNote);
                param[5] = new SqlParameter("@Expense", row.Expense);
                m_objModelsInfo.ExecProcNoReturn(SP_WORKSHIFT_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(string WSID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@WSID", WSID);
                m_objModelsInfo.ExecProcNoReturn(SP_WORKSHIFT_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}