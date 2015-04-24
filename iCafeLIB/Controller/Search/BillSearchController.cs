using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;

namespace iCafeLIB.Controller.Search
{
    public class BillSearchController
    {
        private const string SP_BILL_BYCUSNAME = "SP_BILL_BYCUSNAME";
        private const string SP_BILL_BYTABLENAME = "SP_BILL_BYTABLENAME";
        private const string SP_BILL_BYEMPLOYNAME = "SP_BILL_BYEMPLOYNAME";
        private const string SP_BILL_BYDATE = "SP_BILL_BYDATE";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsInfo;
        private SecurityContext mobjSecurity;

        public BillSearchController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
        }

        /// <summary>
        ///     Tìm kiếm hóa đơn theo tên khách hàng
        /// </summary>
        /// <param name="CusName"></param>
        /// <returns></returns>
        public DataTable SearchByCusName(string CusName)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@CusName", CusName);
                objTable = Base(SP_BILL_BYCUSNAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Tìm hóa đơn theo tên bàn
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataTable SearchByTableName(string TableName)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@TableName", TableName);
                objTable = Base(SP_BILL_BYTABLENAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Tìm kiếm theo thời gian
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public DataTable SearchByDate(DateTime dateTime)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@Date", dateTime);
                objTable = Base(SP_BILL_BYDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Tìm kiếm theo tên nhân viên
        /// </summary>
        /// <param name="EmployName"></param>
        /// <returns></returns>
        public DataTable SearchByEmployName(string EmployName)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmployName", EmployName);
                objTable = Base(SP_BILL_BYEMPLOYNAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        private DataTable Base(string SP_NAME, SqlParameter[] param)
        {
            DataTable objTable;
            try
            {
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_NAME, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }
    }
}