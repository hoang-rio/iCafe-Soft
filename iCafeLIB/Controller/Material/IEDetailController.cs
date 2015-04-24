using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Material
{
    public class IEDetailController
    {
        private const string SP_IEDETAIL_BYIEID = "SP_IEDETAIL_BYIEID";
        private const string SP_IEDETAIL_ADD = "SP_IEDETAIL_ADD";
        private const string SP_IEDETAIL_DELETE = "SP_IEDETAIL_DELETE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        public IEDetailController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelInfo = new ModelsInfo(m_objConnection);
        }

        public DataTable GetByIEID(string IEID)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@IEID", IEID);
                objTable = m_objModelInfo.ExecProcReturnTable(SP_IEDETAIL_BYIEID, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void Delete(string IEID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@IEID", IEID);
                m_objModelInfo.ExecProcNoReturn(SP_IEDETAIL_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void AddNew(iCafeDataEn.iCafe_IEDetailDataTable objDetailTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_IEDetailRow) objDetailTable.Rows[0];
                var param = new SqlParameter[objDetailTable.Columns.Count];
                param[0] = new SqlParameter("@IEID", Row.IEID);
                param[1] = new SqlParameter("@RMID", Row.RMID);
                param[2] = new SqlParameter("@Quantity", Row.Quantity);
                param[3] = new SqlParameter("@ImportDate", Row.ImportDate);
                param[4] = new SqlParameter("@ExpireDate", Row.ExpireDate);
                param[5] = new SqlParameter("@DetailNote", Row.DetailNote);
                m_objModelInfo.ExecProcNoReturn(SP_IEDETAIL_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}