using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Table
{
    public class BookTableController
    {
        private const string SP_BOOKTABLE_LOAD = "SP_BOOKTABLE_LOAD";
        private const string SP_BOOKTABLE_BYTABLEID = "SP_BOOKTABLE_BYTABLEID";
        private const string SP_BOOKTABLE_BYTABLENAME = "SP_BOOKTABLE_BYTABLENAME";
        private const string SP_BOOKTABLE_ADD = "SP_BOOKTABLE_ADD";
        private const string SP_BOOKTABLE_CHECK = "SP_BOOKTABLE_CHECK";
        private const string SP_BOOKTABLE_UPDATE = "SP_BOOKTABLE_UPDATE";
        private const string SP_BOOKTABLEDETAIL_ADD = "SP_BOOKTABLEDETAIL_ADD";
        private const string SP_BOOKTABLEDETAIL_DELETE = "SP_BOOKTABLEDETAIL_DELETE";
        private const string SP_BOOKTABLE_DELETE = "SP_BOOKTABLE_DELETE";
        private const string SP_BOOKTABLEDETAIL_BYBTABLEID = "SP_BOOKTABLEDETAIL_BYBTABLEID";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelsinfo;
        private SecurityContext m_objSecurity;

        public BookTableController(SqlConnection objSqlConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objSqlConnection;
            m_objSecurity = objSecurityContext;
            m_objModelsinfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy dữ liệu đặt bàn lên gridview
        /// </summary>
        /// <returns>Datatable BookTable</returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelsinfo.ExecProcReturnTable(SP_BOOKTABLE_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        private bool Check(iCafeDataEn.iCafe_BookTableDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BookTableRow) objTable.Rows[0];
                var param = new SqlParameter[3];
                param[0] = new SqlParameter("@TableID", row.TableID);
                param[1] = new SqlParameter("@BookTime", row.BookTime);
                param[2] = new SqlParameter("@BTableID", row.BTableID);
                var tbl = m_objModelsinfo.ExecProcReturnTable(SP_BOOKTABLE_CHECK, param);
                if (tbl.Rows.Count > 0) return false;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return true;
        }

        /// <summary>
        ///     Lấy thông tin đặt bàn theo TableID
        /// </summary>
        /// <param name="TableID"></param>
        /// <returns></returns>
        public DataTable GetByTableID(string TableID)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@TableID", TableID);
                objTable = m_objModelsinfo.ExecProcReturnTable(SP_BOOKTABLE_BYTABLEID, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Lấy thông tin đặt bàn theo tên bàn
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataTable GetByTableName(string TableName)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@TableName", TableName);
                objTable = m_objModelsinfo.ExecProcReturnTable(SP_BOOKTABLE_BYTABLENAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Thêm đặt bàn mới
        /// </summary>
        /// <param name="objBtTable"></param>
        public void AddNew(iCafeDataEn.iCafe_BookTableDataTable objBtTable,
            iCafeDataEn.iCafe_BookTableDetailDataTable objBTdtTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BookTableRow) objBtTable.Rows[0];
                var param = new SqlParameter[objBtTable.Columns.Count];
                param[0] = new SqlParameter("@BTaleID", row.BTableID);
                param[1] = new SqlParameter("@BookTime", row.BookTime);
                param[2] = new SqlParameter("@CusID", row.CusID);
                param[3] = new SqlParameter("@Deposit", row.Deposit);
                param[4] = new SqlParameter("@Descript", row.Descript);
                param[5] = new SqlParameter("@EndTime", row.EndTime);
                param[6] = new SqlParameter("@ZoneID", row.ZoneID);
                param[7] = new SqlParameter("@TableID", row.TableID);
                param[8] = new SqlParameter("@Status", row.Status);
                param[9] = new SqlParameter("@Numpeople", row.NumPeople);
                if (Check(objBtTable))
                {
                    m_objModelsinfo.ExecProcNoReturn(SP_BOOKTABLE_ADD, param);
                    AddNew_BtDetail(objBTdtTable);
                }
                else
                {
                    throw new Exception(
                        "Không thể đặt bàn do đã có người đặt vào thời gian này. Xin vui lòng chọn lại bàn hoặc thời gian khác");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Update bookTable
        /// </summary>
        /// <param name="objTable"></param>
        public void Update(iCafeDataEn.iCafe_BookTableDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BookTableRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@BTaleID", row.BTableID);
                param[1] = new SqlParameter("@BookTime", row.BookTime);
                param[2] = new SqlParameter("@CusID", row.CusID);
                param[3] = new SqlParameter("@Deposit", row.Deposit);
                param[4] = new SqlParameter("@Descript", row.Descript);
                param[5] = new SqlParameter("@EndTime", row.EndTime);
                param[6] = new SqlParameter("@ZoneID", row.ZoneID);
                param[7] = new SqlParameter("@TableID", row.TableID);
                param[8] = new SqlParameter("@Status", row.Status);
                param[9] = new SqlParameter("@Numpeople", row.NumPeople);
                if (Check(objTable))
                {
                    m_objModelsinfo.ExecProcNoReturn(SP_BOOKTABLE_UPDATE, param);
                }
                else
                {
                    throw new Exception(
                        "Không thể thay đổi đặt bàn do đã có người đặt vào thời gian này. Xin vui lòng chọn lại bàn hoặc thời gian khác");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Thêm btDetail theo detail
        /// </summary>
        /// <param name="objBTdtTable"></param>
        public void AddNew_BtDetail(iCafeDataEn.iCafe_BookTableDetailDataTable objBTdtTable)
        {
            try
            {
                var param = new SqlParameter[objBTdtTable.Columns.Count];
                foreach (var row in objBTdtTable)
                {
                    param[0] = new SqlParameter("@BTableID", row.BTableID);
                    param[1] = new SqlParameter("@FoodID", row.FoodID);
                    param[2] = new SqlParameter("@Quantity", row.Quantity);
                    param[3] = new SqlParameter("@TotalPrice", row.TotalPrice);
                    m_objModelsinfo.ExecProcNoReturn(SP_BOOKTABLEDETAIL_ADD, param);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Xóa đặt bàn
        /// </summary>
        /// <param name="BTableID"></param>
        public void Delete(string BTableID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@BTableID", BTableID);
                m_objModelsinfo.ExecProcNoReturn(SP_BOOKTABLE_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Lấy chi tiết đặt bàn
        /// </summary>
        /// <param name="BTableID"></param>
        /// <returns></returns>
        public DataTable GetDetail(string BTableID)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@BTableID", BTableID);
                objTable = m_objModelsinfo.ExecProcReturnTable(SP_BOOKTABLEDETAIL_BYBTABLEID, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Xóa chi tiết đặt bàn
        /// </summary>
        /// <param name="objTable"></param>
        public void Delete_Detail(iCafeDataEn.iCafe_BookTableDetailDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BookTableDetailRow) objTable.Rows[0];
                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@BTableID", row.BTableID);
                param[1] = new SqlParameter("@FoodID", row.FoodID);
                m_objModelsinfo.ExecProcNoReturn(SP_BOOKTABLEDETAIL_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}