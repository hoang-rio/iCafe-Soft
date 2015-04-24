using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Material
{
    public class BallotDetailController
    {
        private const string SP_BALLOTDETAIL_BYBGID = "SP_BALLOTDETAIL_BYBGID";
        private const string SP_BALLOTDETAIL_ADD = "SP_BALLOTDETAIL_ADD";
        private const string SP_BALLOTDETAIL_DELETE = "SP_BALLOTDETAIL_DELETE";
        private const string SP_BALLOTDETAIL_UPDATE = "SP_BALLOTDETAIL_UPDATE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        public BallotDetailController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelInfo = new ModelsInfo(m_objConnection);
        }

        public DataTable GetByBGID(string BGID)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@BGID", BGID);
                objTable = m_objModelInfo.ExecProcReturnTable(SP_BALLOTDETAIL_BYBGID, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void Delete(string BGID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@BGID", BGID);
                m_objModelInfo.ExecProcNoReturn(SP_BALLOTDETAIL_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void AddNew(iCafeDataEn.iCafe_BallotDetailDataTable objDetailTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_BallotDetailRow) objDetailTable.Rows[0];
                var param = new SqlParameter[objDetailTable.Columns.Count];
                param[0] = new SqlParameter("@BGID", Row.BGID);
                param[1] = new SqlParameter("@FoodID", Row.FoodID);
                param[2] = new SqlParameter("@Quantity", Row.Quantity);
                m_objModelInfo.ExecProcNoReturn(SP_BALLOTDETAIL_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}