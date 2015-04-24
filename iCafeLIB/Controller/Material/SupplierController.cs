using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Material
{
    public class SupplierController
    {
        private const string SP_SUPPLIER_LOAD = "SP_SUPPLIER_LOAD";
        private const string SP_SUPPLIER_ADD = "SP_SUPPLIER_ADD";
        private const string SP_SUPPLIER_DELETE = "SP_SUPPLIER_DELETE";
        private const string SP_SUPPLIER_UPDATE = "SP_SUPPLIER_UPDATE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        public SupplierController(SqlConnection objConnection, SecurityContext objSecurityContext)
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
                objTable = m_objModelInfo.ExecProcReturnTable(SP_SUPPLIER_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void AddNew(iCafeDataEn.iCafe_SupplierDataTable objBallotTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_SupplierRow) objBallotTable.Rows[0];
                var param = new SqlParameter[objBallotTable.Columns.Count];
                param[0] = new SqlParameter("@SupID", Row.SupID);
                param[1] = new SqlParameter("@SupName", Row.SupName);
                param[2] = new SqlParameter("@SupPhone", Row.SupPhone);
                param[3] = new SqlParameter("@SupAddress", Row.SupAddress);
                param[4] = new SqlParameter("@SupEmail", Row.SupEmail);
                m_objModelInfo.ExecProcNoReturn(SP_SUPPLIER_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_SupplierDataTable objBallotTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_SupplierRow) objBallotTable.Rows[0];
                var param = new SqlParameter[objBallotTable.Columns.Count];
                param[0] = new SqlParameter("@SupID", Row.SupID);
                param[1] = new SqlParameter("@SupName", Row.SupName);
                param[2] = new SqlParameter("@SupPhone", Row.SupPhone);
                param[3] = new SqlParameter("@SupAddress", Row.SupAddress);
                param[4] = new SqlParameter("@SupEmail", Row.SupEmail);
                m_objModelInfo.ExecProcNoReturn(SP_SUPPLIER_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(string SUPID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@SupID", SUPID);
                m_objModelInfo.ExecProcNoReturn(SP_SUPPLIER_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}