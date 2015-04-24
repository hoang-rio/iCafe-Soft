using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Sale
{
    public class SaleController
    {
        private const string SP_BILL_ADD = "SP_BILL_ADD";
        private const string SP_BILLDETAIL_ADD = "SP_BILLDETAIL_ADD";
        private const string SP_BILLPRICE_UPDATE = "SP_BILLPRICE_UPDATE ";
        private const string SP_BILL_GETBYTABLEID = "SP_BILL_GETBYTABLEID";
        private const string SP_BILL_UPDATESTATUS = "SP_BILL_UPDATESTATUS";
        private const string SP_SALEFROMTABLE_ID = "SP_SALEFROMTABLE_ID";
        private const string SP_BILL_GETDISCOUNT = "SP_BILL_GETDISCOUNT";
        private const string SP_BILL_LOAD = "SP_BILL_LOAD";
        private const string SP_BILLDETAIL_LOAD = "SP_BILLDETAIL_LOAD";
        private const string SP_GETZONECOST_BYTABLEID = "SP_GETZONECOST_BYTABLEID";
        private const string SP_BILLDETAIL_DELETE = "SP_BILLDETAIL_DELETE";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsInfo;
        private SecurityContext mobjSecurity;

        public SaleController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
        }

        public DataTable GetBillTable(Guid TableID)
        {
            DataTable objTable;
            var para = new SqlParameter[1];
            para[0] = new SqlParameter("@TableID", TableID);
            objTable = mobjModelsInfo.ExecProcReturnTable(SP_BILL_GETBYTABLEID, para);
            return objTable;
        }

        public DataTable GetZoneCOST(Guid TableID)
        {
            DataTable objTable;
            var para = new SqlParameter[1];
            para[0] = new SqlParameter("@TableID", TableID);
            objTable = mobjModelsInfo.ExecProcReturnTable(SP_GETZONECOST_BYTABLEID, para);
            return objTable;
        }

        public DataTable GetDiscount(Guid CusID, Guid EventID)
        {
            DataTable objTable;
            var para = new SqlParameter[2];
            para[0] = new SqlParameter("@CusID", CusID);
            para[1] = new SqlParameter("@EventID", EventID);
            objTable = mobjModelsInfo.ExecProcReturnTable(SP_BILL_GETDISCOUNT, para);
            return objTable;
        }

        public void UpdateStatusBill(iCafeDataEn.iCafe_BillDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BillRow) objTable.Rows[0];
                var para = new SqlParameter[2];
                para[0] = new SqlParameter("@Bill_ID", row.Bill_ID);
                para[1] = new SqlParameter("@BStatus", row.BStatus);
                mobjModelsInfo.ExecProcNoReturn(SP_BILL_UPDATESTATUS, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update_BillPrice(iCafeDataEn.iCafe_BillDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BillRow) objTable.Rows[0];
                var para = new SqlParameter[3];
                para[0] = new SqlParameter("@Bill_ID", row.Bill_ID);
                para[1] = new SqlParameter("@Value", row.Value);
                para[2] = new SqlParameter("@AfterDiscount", row.AfterDiscount);
                mobjModelsInfo.ExecProcNoReturn(SP_BILLPRICE_UPDATE, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SaleLoadFromTableID(Guid TableID)
        {
            DataTable objTable;
            var para = new SqlParameter[1];
            para[0] = new SqlParameter("@TableID", TableID);
            objTable = mobjModelsInfo.ExecProcReturnTable(SP_SALEFROMTABLE_ID, para);
            return objTable;
        }

        public void Bill_ADD(iCafeDataEn.iCafe_BillDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BillRow) objTable.Rows[0];
                var para = new SqlParameter[objTable.Columns.Count];
                para[0] = mobjModelsInfo.CreateParammeter("@Bill_ID", row.Bill_ID);
                para[1] = mobjModelsInfo.CreateParammeter("@TableID", row.TableID);
                para[2] = mobjModelsInfo.CreateParammeter("@EventID", row.EventID);
                para[3] = mobjModelsInfo.CreateParammeter("@CusID", row.CusID);
                para[4] = mobjModelsInfo.CreateParammeter("@EmployID", row.EmployID);
                para[5] = mobjModelsInfo.CreateParammeter("@BTableID", row.BTableID);
                para[6] = mobjModelsInfo.CreateParammeter("@Value", row.Value);
                para[7] = mobjModelsInfo.CreateParammeter("@TotalDiscount", row.TotalDiscount);
                para[8] = mobjModelsInfo.CreateParammeter("@AfterDiscount", row.AfterDiscount);
                para[9] = mobjModelsInfo.CreateParammeter("@BTime", row.BTime);
                para[10] = mobjModelsInfo.CreateParammeter("@BStatus", row.BStatus);
                mobjModelsInfo.ExecProcNoReturn(SP_BILL_ADD, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BillDetail_ADD(iCafeDataEn.iCafe_BillDetailDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_BillDetailRow) objTable.Rows[0];
                var para = new SqlParameter[objTable.Columns.Count];
                para[0] = mobjModelsInfo.CreateParammeter("@Bill_ID", row.Bill_ID);
                para[1] = mobjModelsInfo.CreateParammeter("@FoodID", row.FoodID);
                para[2] = mobjModelsInfo.CreateParammeter("@Quantity", row.Quantity);
                para[3] = mobjModelsInfo.CreateParammeter("@Price", row.Price);
                mobjModelsInfo.ExecProcNoReturn(SP_BILLDETAIL_ADD, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     Lấy chi tiết hóa đơn
        /// </summary>
        /// <param name="Bill_ID"></param>
        /// <returns></returns>
        public DataTable BillDetail_Load(string Bill_ID)
        {
            DataTable objTable;
            try
            {
                var para = new SqlParameter[1];
                para[0] = new SqlParameter("@Bill_ID", Bill_ID);
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_BILLDETAIL_LOAD, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void BillDetail_Delete(string Bill_ID, string FoodID)
        {
            try
            {
                var para = new SqlParameter[2];
                para[0] = new SqlParameter("@Bill_ID", Bill_ID);
                para[1] = new SqlParameter("@FoodID", FoodID);
                mobjModelsInfo.ExecProcNoReturn(SP_BILLDETAIL_DELETE, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_BILL_LOAD);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }
    }
}