using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Table
{
    public class TableController
    {
        private const string SP_TABLE_LOAD = "SP_TABLE_LOAD";
        private const string SP_TABLE_GETBY_ZONENAME = "SP_TABLE_GETBY_ZONENAME";
        private const string SP_GETTABLEIDBYNAME = "SP_GETTABLEIDBYNAME";
        private const string SP_TABLE_ADD = "SP_TABLE_ADD";
        private const string SP_TABLE_UPDATE = "SP_TABLE_UPDATE";
        private const string SP_TABLE_DELETE = "SP_TABLE_DELETE";
        private const string SP_TABLE_EMPTY = "SP_TABLE_EMPTY";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelinfos;
        private SecurityContext m_Security;

        public TableController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_Security = objSecurityContext;
            m_objModelinfos = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy toàn bộ dữ liệu bàn lên grid
        /// </summary>
        /// <returns>Datatable Bàn</returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelinfos.ExecProcReturnTable(SP_TABLE_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public DataTable GetTableID(string TableName)
        {
            DataTable objTableID;
            var param = new SqlParameter[1];
            param[0] = new SqlParameter("@TableName", TableName);
            try
            {
                objTableID = m_objModelinfos.ExecProcReturnTable(SP_GETTABLEIDBYNAME, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTableID;
        }

        /// <summary>
        ///     Lây thông tin bàn theo tên khu vực
        /// </summary>
        /// <param name="ZoneName">Tên khu vực</param>
        /// <returns></returns>
        public DataTable GetByZoneName(string ZoneName)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@ZoneName", ZoneName);
                objTable = m_objModelinfos.ExecProcReturnTable(SP_TABLE_GETBY_ZONENAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Thêm bàn mới
        /// </summary>
        /// <param name="objtTable"></param>
        public void AddNew(iCafeDataEn.iCafe_TableDataTable objtTable)
        {
            try
            {
                var param = new SqlParameter[objtTable.Columns.Count];
                foreach (var row in objtTable)
                {
                    param[0] = new SqlParameter("@TableID", row.TableID);
                    param[1] = new SqlParameter("@TableName", row.TableName);
                    param[2] = new SqlParameter("@ZoneID", row.ZoneID);
                    m_objModelinfos.ExecProcNoReturn(SP_TABLE_ADD, param);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Cập nhật thông tin bàn
        /// </summary>
        /// <param name="objTable"></param>
        public void Update(iCafeDataEn.iCafe_TableDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_TableRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@TableID", row.TableID);
                param[1] = new SqlParameter("@TableName", row.TableName);
                param[2] = new SqlParameter("@ZoneID", row.ZoneID);
                m_objModelinfos.ExecProcNoReturn(SP_TABLE_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Xóa bàn
        /// </summary>
        /// <param name="TableID"></param>
        public void Delete(string TableID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@TableID", TableID);
                m_objModelinfos.ExecProcNoReturn(SP_TABLE_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Bàn trống
        /// </summary>
        /// <returns></returns>
        public DataTable GEtTableEmpty()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelinfos.ExecProcReturnTable(SP_TABLE_EMPTY);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }
    }
}