using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Food
{
    public class FoodController
    {
        private const string SP_FOOD_LOAD = "SP_FOOD_LOAD";
        private const string SP_FOOD_ADD = "SP_FOOD_ADD";
        private const string SP_FOOD_BY_FGRNAME = "SP_FOOD_BY_FGRNAME";
        private const string SP_FOOD_DELETE = "SP_FOOD_DELETE";
        private const string SP_FOOD_UPDATE = "SP_FOOD_UPDATE";
        private const string SP_FOOD_BYBOOKTABLE = "SP_FOOD_BYBOOKTABLE";
        private const string SP_FOODPRICE_BYNAMEF = "SP_FOODPRICE_BYNAMEF";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsInfo;
        private SecurityContext mobjSecurity;

        /// <summary>
        ///     Hàm tạo foodController
        /// </summary>
        /// <param name="objConnection">Sqlconnection</param>
        /// <param name="objSecurityContext">SecurityContext</param>
        public FoodController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
        }

        /// <summary>
        ///     Lấy dữ liệu lên Food lên thực đơn
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_FOOD_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public DataTable GetPriceByFName(string FoodName)
        {
            DataTable objFoodPrice;
            var param = new SqlParameter[1];
            param[0] = new SqlParameter("@FoodName", FoodName);
            try
            {
                objFoodPrice = mobjModelsInfo.ExecProcReturnTable(SP_FOODPRICE_BYNAMEF, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objFoodPrice;
        }

        /// <summary>
        ///     Lấy danh sách món theo tên nhóm món
        /// </summary>
        /// <param name="FGrName">Tên nhóm món</param>
        /// <returns>Datatable danh sách món</returns>
        public DataTable GetFoodByFGrName(string FGrName)
        {
            DataTable objTable;
            var param = new SqlParameter[1];
            param[0] = new SqlParameter("@FGrName", FGrName);
            try
            {
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_FOOD_BY_FGRNAME, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        /// <summary>
        ///     Thêm món mới
        /// </summary>
        /// <param name="objTable"></param>
        public void AddNew(iCafeDataEn.iCafe_FoodDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_FoodRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@FoodID", row.FoodID);
                param[1] = new SqlParameter("@FoodName", row.FoodName);
                param[2] = new SqlParameter("@FUnit", row.FUnit);
                param[3] = new SqlParameter("@FPrice", row.FPrice);
                param[4] = new SqlParameter("@FGroupID", row.FGroupID);
                param[5] = new SqlParameter("@FImage", row.FImage);
                mobjModelsInfo.ExecProcNoReturn(SP_FOOD_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Xóa món
        /// </summary>
        /// <param name="FoodID"></param>
        public void Delete(string FoodID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@FoodID", FoodID);
                mobjModelsInfo.ExecProcNoReturn(SP_FOOD_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Cập nhật thông tin món
        /// </summary>
        /// <param name="objFTable"></param>
        public void Update(iCafeDataEn.iCafe_FoodDataTable objFTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_FoodRow) objFTable.Rows[0];
                var param = new SqlParameter[objFTable.Columns.Count];
                param[0] = new SqlParameter("@FoodID", row.FoodID);
                param[1] = new SqlParameter("@FoodName", row.FoodName);
                param[2] = new SqlParameter("@FGroupID", row.FGroupID);
                param[3] = new SqlParameter("@FImage", row.FImage);
                param[4] = new SqlParameter("@FPrice", row.FPrice);
                param[5] = new SqlParameter("@FUnit", row.FUnit);
                mobjModelsInfo.ExecProcNoReturn(SP_FOOD_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Lấy món đã đặt theo bàn đặt
        /// </summary>
        /// <param name="BTableID"></param>
        /// <returns></returns>
        public DataTable GetFoodByBookTableID(string BTableID)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@BTableID", BTableID);
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_FOOD_BYBOOKTABLE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }
    }
}