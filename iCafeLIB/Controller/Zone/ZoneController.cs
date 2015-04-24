using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Zone
{
    public class ZoneController
    {
        private const string SP_ZONE_LOAD = "SP_ZONE_LOAD";
        private const string SP_ZONE_ADD = "SP_ZONE_ADD";
        private const string SP_ZONE_UPDATE = "SP_ZONE_UPDATE";
        private const string SP_ZONE_DELETE = "SP_ZONE_DELETE";
        private readonly ModelsInfo m_Modelinfo;
        private readonly SqlConnection m_objConnection;
        private SecurityContext m_Security;

        public ZoneController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_Security = objSecurityContext;
            m_Modelinfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy toàn bộ dữ liệu khu vực đưa vào datatable
        /// </summary>
        /// <returns>Datatable Khu vực</returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_Modelinfo.ExecProcReturnTable(SP_ZONE_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        /// <summary>
        ///     Thêm mới
        /// </summary>
        /// <param name="objZTable"></param>
        public void AddNew(iCafeDataEn.iCafe_ZoneDataTable objZTable)
        {
            try
            {
                var param = new SqlParameter[objZTable.Columns.Count];
                foreach (iCafeDataEn.iCafe_ZoneRow zoneRow in objZTable.Rows)
                {
                    param[0] = new SqlParameter("@ZoneID", zoneRow.ZoneID);
                    param[1] = new SqlParameter("@ZoneName", zoneRow.ZoneName);
                    param[2] = new SqlParameter("@ZoneCost", zoneRow.ZoneCost);
                    param[3] = new SqlParameter("@ZoneImage", zoneRow.ZoneImage);
                    m_Modelinfo.ExecProcNoReturn(SP_ZONE_ADD, param);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_ZoneDataTable objZTable)
        {
            try
            {
                var param = new SqlParameter[objZTable.Columns.Count];
                foreach (iCafeDataEn.iCafe_ZoneRow zoneRow in objZTable.Rows)
                {
                    param[0] = new SqlParameter("@ZoneID", zoneRow.ZoneID);
                    param[1] = new SqlParameter("@ZoneName", zoneRow.ZoneName);
                    param[2] = new SqlParameter("@ZoneCost", zoneRow.ZoneCost);
                    param[3] = new SqlParameter("@ZoneImage", zoneRow.ZoneImage);
                    m_Modelinfo.ExecProcNoReturn(SP_ZONE_UPDATE, param);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Xóa khu vực
        /// </summary>
        /// <param name="ZoneID"></param>
        public void Delete(string ZoneID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@ZoneID", ZoneID);
                m_Modelinfo.ExecProcNoReturn(SP_ZONE_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}