using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Material
{
    public class ImportExportController
    {
        private const string SP_IMPORTEXPORT_LOAD = "SP_IMPORTEXPORT_LOAD";
        private const string SP_IMPORTEXPORT_ADD = "SP_IMPORTEXPORT_ADD";
        private const string SP_IMPORTEXPORT_DELETE = "SP_IMPORTEXPORT_DELETE";
        private const string SP_IMPORTEXPORT_UPDATE = "SP_IMPORTEXPORT_UPDATE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        public ImportExportController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelInfo = new ModelsInfo(m_objConnection);
        }

        public DataTable LoadALL(string Type)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@Type", Type);
                objTable = m_objModelInfo.ExecProcReturnTable(SP_IMPORTEXPORT_LOAD, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void AddNew(iCafeDataEn.iCafe_ImportExportDataTable objIETable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_ImportExportRow) objIETable.Rows[0];
                var param = new SqlParameter[objIETable.Columns.Count];
                param[0] = new SqlParameter("@IEID", Row.IEID);
                param[1] = new SqlParameter("@Time", Row.Time);
                param[2] = new SqlParameter("@Cost", Row.Cost);
                param[3] = new SqlParameter("@Type", Row.Type);
                param[4] = new SqlParameter("@Status", Row.Status);
                param[5] = new SqlParameter("@IENote", Row.IENote);
                m_objModelInfo.ExecProcNoReturn(SP_IMPORTEXPORT_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_ImportExportDataTable objIETable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_ImportExportRow) objIETable.Rows[0];
                var param = new SqlParameter[objIETable.Columns.Count];
                param[0] = new SqlParameter("@IEID", Row.IEID);
                param[1] = new SqlParameter("@Time", Row.Time);
                param[2] = new SqlParameter("@Cost", Row.Cost);
                param[3] = new SqlParameter("@Type", Row.Type);
                param[4] = new SqlParameter("@Status", Row.Status);
                param[5] = new SqlParameter("@IENote", Row.IENote);
                m_objModelInfo.ExecProcNoReturn(SP_IMPORTEXPORT_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(string IEID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@IEID", IEID);
                m_objModelInfo.ExecProcNoReturn(SP_IMPORTEXPORT_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}