using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Event
{
    public class EventController
    {
        private const string SP_EVENT_LOAD = "SP_EVENT_LOAD";
        private const string SP_EVENT_ADD = "SP_EVENT_ADD";
        private const string SP_EVENT_UPDATE = "SP_EVENT_UPDATE";
        private const string SP_EVENT_NOW = "SP_EVENT_NOW";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModalsInfo;
        private SecurityContext m_objSecurity;

        public EventController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModalsInfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy dữ liệu Event lên gridView
        /// </summary>
        /// <returns>DataTable Event</returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModalsInfo.ExecProcReturnTable(SP_EVENT_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public DataTable GetEventNow()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModalsInfo.ExecProcReturnTable(SP_EVENT_NOW);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void Add_new(iCafeDataEn.iCafe_EventDataTable objTable)
        {
            var row = (iCafeDataEn.iCafe_EventRow) objTable.Rows[0];
            try
            {
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@EventID", row.EventID);
                param[1] = new SqlParameter("@EventName", row.EventName);
                param[2] = new SqlParameter("@CreateDate", row.CreateDate);
                param[3] = new SqlParameter("@Descript", row.Descript);
                param[4] = new SqlParameter("@Discount", row.Discount);
                param[5] = new SqlParameter("@EndDate", row.EndDate);
                param[6] = new SqlParameter("@StartDate", row.StartDate);
                param[7] = new SqlParameter("@Status", row.Status);
                m_objModalsInfo.ExecProcNoReturn(SP_EVENT_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_EventDataTable objTable)
        {
            var row = (iCafeDataEn.iCafe_EventRow) objTable.Rows[0];
            try
            {
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@EventID", row.EventID);
                param[1] = new SqlParameter("@EventName", row.EventName);
                param[2] = new SqlParameter("@Descript", row.Descript);
                param[3] = new SqlParameter("@Discount", row.Discount);
                param[4] = new SqlParameter("@EndDate", row.EndDate);
                param[5] = new SqlParameter("@StartDate", row.StartDate);
                param[6] = new SqlParameter("@Status", row.Status);
                param[7] = new SqlParameter("@CreateDate", row.CreateDate);
                m_objModalsInfo.ExecProcNoReturn(SP_EVENT_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}