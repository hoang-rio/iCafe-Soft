using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Material
{
    public class BallotGoodsController
    {
        private const string SP_BALLOTGOODS_LOAD = "SP_BALLOTGOODS_LOAD";
        private const string SP_BALLOTGOODS_ADD = "SP_BALLOTGOODS_ADD";
        private const string SP_BALLOTGOODS_DELETE = "SP_BALLOTGOODS_DELETE";
        private const string SP_BALLOTGOODS_UPDATE = "SP_BALLOTGOODS_UPDATE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        public BallotGoodsController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelInfo = new ModelsInfo(m_objConnection);
        }

        public DataTable GetALL()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelInfo.ExecProcReturnTable(SP_BALLOTGOODS_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void AddNew(iCafeDataEn.iCafe_BallotGoodsDataTable objBallotTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_BallotGoodsRow) objBallotTable.Rows[0];
                var param = new SqlParameter[objBallotTable.Columns.Count];
                param[0] = new SqlParameter("@BGID", Row.BGID);
                param[1] = new SqlParameter("@CreatTime", Row.CreatTime);
                param[2] = new SqlParameter("@Value", Row.Value);
                param[3] = new SqlParameter("@SupID", Row.SupID);
                param[4] = new SqlParameter("@Status", Row.Status);
                m_objModelInfo.ExecProcNoReturn(SP_BALLOTGOODS_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_BallotGoodsDataTable objBallotTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_BallotGoodsRow) objBallotTable.Rows[0];
                var param = new SqlParameter[objBallotTable.Columns.Count];
                param[0] = new SqlParameter("@BGID", Row.BGID);
                param[1] = new SqlParameter("@CreatTime", Row.CreatTime);
                param[2] = new SqlParameter("@Value", Row.Value);
                param[3] = new SqlParameter("@SupID", Row.SupID);
                param[4] = new SqlParameter("@Status", Row.Status);
                m_objModelInfo.ExecProcNoReturn(SP_BALLOTGOODS_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(string BGID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@BGID", BGID);
                m_objModelInfo.ExecProcNoReturn(SP_BALLOTGOODS_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}