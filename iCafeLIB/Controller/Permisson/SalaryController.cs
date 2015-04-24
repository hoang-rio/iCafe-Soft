using System;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Permisson
{
    public class SalaryController
    {
        private const string SP_SALARY_UPDATE = "SP_SALARY_UPDATE";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsInfo;
        private SecurityContext mobjSecurity;

        public SalaryController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
        }

        /// <summary>
        ///     Cập nhật lương
        /// </summary>
        /// <param name="objTable"></param>
        public void Update(iCafeDataEn.iCafe_PermissionDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_PermissionRow) objTable.Rows[0];
                var param = new SqlParameter[3];
                param[0] = new SqlParameter("@PerID", row.PerID);
                param[1] = new SqlParameter("@SalaryValue", row.SalaryValue);
                param[2] = new SqlParameter("@SalaryOverTime", row.SalaryOverTime);
                mobjModelsInfo.ExecProcNoReturn(SP_SALARY_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}