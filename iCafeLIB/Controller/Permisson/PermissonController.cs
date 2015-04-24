using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Permisson
{
    public class PermissonController
    {
        private const string SP_PERMISSION_LOAD = "SP_PERMISSION_LOAD";
        private const string SP_PERMISSION_ADD = "SP_PERMISSION_ADD";
        private const string SP_PERMISSION_UPDATE = "SP_PERMISSION_UPDATE";
        private const string SP_PERMISSION_DELETE = "SP_PERMISSION_DELETE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelsInfo;
        private SecurityContext m_objSecurity;
        //private iCafeDataEn.iCafe_PermissionDataTable objPerTabe;

        public PermissonController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelsInfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Thêm quyền hạn mới
        /// </summary>
        /// <param name="objTable"></param>
        public void Addnew(iCafeDataEn.iCafe_PermissionDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_PermissionRow) objTable.Rows[0];
                var param = new SqlParameter[11];
                param[0] = new SqlParameter("@PerID", row.PerID);
                param[1] = new SqlParameter("@PerName", row.PerName);
                param[2] = new SqlParameter("@FullPermiss", row.FullPermiss);
                param[3] = new SqlParameter("@fc_customer", row.fc_customer);
                param[4] = new SqlParameter("@fc_event", row.fc_event);
                param[5] = new SqlParameter("@fc_revenue", row.fc_revenue);
                param[6] = new SqlParameter("@fc_sale", row.fc_sale);
                param[7] = new SqlParameter("@fc_system", row.fc_system);
                param[8] = new SqlParameter("@fc_table", row.fc_table);
                param[9] = new SqlParameter("@fc_warehouse", row.fc_warehouse);
                param[10] = new SqlParameter("@Descript", row.Descript);
                m_objModelsInfo.ExecProcNoReturn(SP_PERMISSION_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelsInfo.ExecProcReturnTable(SP_PERMISSION_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void Update(iCafeDataEn.iCafe_PermissionDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_PermissionRow) objTable.Rows[0];
                var param = new SqlParameter[11];
                param[0] = new SqlParameter("@PerID", row.PerID);
                param[1] = new SqlParameter("@PerName", row.PerName);
                param[2] = new SqlParameter("@FullPermiss", row.FullPermiss);
                param[3] = new SqlParameter("@fc_customer", row.fc_customer);
                param[4] = new SqlParameter("@fc_event", row.fc_event);
                param[5] = new SqlParameter("@fc_revenue", row.fc_revenue);
                param[6] = new SqlParameter("@fc_sale", row.fc_sale);
                param[7] = new SqlParameter("@fc_system", row.fc_system);
                param[8] = new SqlParameter("@fc_table", row.fc_table);
                param[9] = new SqlParameter("@fc_warehouse", row.fc_warehouse);
                param[10] = new SqlParameter("@Descript", row.Descript);
                m_objModelsInfo.ExecProcNoReturn(SP_PERMISSION_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(string PerID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@PerID", PerID);
                m_objModelsInfo.ExecProcNoReturn(SP_PERMISSION_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}