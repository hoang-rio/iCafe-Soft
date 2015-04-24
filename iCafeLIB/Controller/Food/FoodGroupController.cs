using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Food
{
    public class FoodGroupController
    {
        private const string SP_FOODGROUP_LOAD = "SP_FOODGROUP_LOAD";
        private const string SP_FOODGROUP_ADD = "SP_FOODGROUP_ADD";
        private const string SP_FOODGROUP_DELETE_BYID = "SP_FOODGROUP_DELETE_BYID";
        private const string SP_FOODGROUP_UPDATE = "SP_FOODGROUP_UPDATE";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsInfo;
        private SecurityContext mobjSecurity;

        public FoodGroupController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
            mobjSecurity = objSecurityContext;
        }

        /// <summary>
        ///     Lấy dữ liệu food Group
        /// </summary>
        /// <returns>Datatable FoodGroup</returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_FOODGROUP_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        /// <summary>
        ///     Thêm nhóm món mới
        /// </summary>
        /// <param name="objTable"></param>
        public void AddNew(DataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_FoodGroupRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@FGroupID", row.FGroupID);
                param[1] = new SqlParameter("@FGrName", row.FGrName);
                param[2] = new SqlParameter("@FGDescript", row.FGDescript);
                param[3] = new SqlParameter("@FGImage", row.FGImage);
                mobjModelsInfo.ExecProcNoReturn(SP_FOODGROUP_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Xóa FoodGroup
        /// </summary>
        /// <param name="FGroupID"></param>
        public void Delete(string FGroupID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@FGroupID", FGroupID);
                mobjModelsInfo.ExecProcNoReturn(SP_FOODGROUP_DELETE_BYID, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Cập nhật dữ liệu nhóm món
        /// </summary>
        /// <param name="objTable"></param>
        public void Update(iCafeDataEn.iCafe_FoodGroupDataTable objFgTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_FoodGroupRow) objFgTable.Rows[0];
                var param = new SqlParameter[objFgTable.Columns.Count];
                param[0] = new SqlParameter("@FGroupID", row.FGroupID);
                param[1] = new SqlParameter("@FGrName", row.FGrName);
                param[2] = new SqlParameter("@FGDescript", row.FGDescript);
                param[3] = new SqlParameter("@FGImage", row.FGImage);
                mobjModelsInfo.ExecProcNoReturn(SP_FOODGROUP_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}