using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;

namespace iCafeLIB.Controller.Employee
{
    public class SalaryController
    {
        private const string SP_SALARY_PERMONTH = "SP_SALARY_PERMONTH";

        private SqlConnection mobjConnection;
        private SecurityContext mobjSecurity;
        private ModelsInfo mobjModelsInfo;

        public SalaryController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
        }

        /// <summary>
        /// Lấy thông tin lương
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            DataTable objTable;
            try
            {
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_SALARY_PERMONTH);
                Add_BonusPunishTo(objTable);
            }
            catch (Exception exception)
            {

                throw exception;
            }
            return objTable;
        }
        /// <summary>
        /// Tính thông tin thưởng phạt vào bảng lương
        /// </summary>
        /// <param name="objTable"></param>
        private void Add_BonusPunishTo(DataTable objTable)
        {
            try
            {
                objTable.Columns.Add("TotalBonusPunish", Type.GetType("System.Decimal"));
                objTable.Columns.Add("Total", Type.GetType("System.Decimal"));
                BonusPunishController bp=new BonusPunishController(mobjConnection,mobjSecurity);
                for (int i = 0; i < objTable.Rows.Count; i++)
                {
                    objTable.Rows[i]["TotalBonusPunish"] = bp.OfEmploy(objTable.Rows[i]["EmployID"].ToString());
                    objTable.Rows[i]["Total"] = (Decimal) objTable.Rows[i]["TotalBonusPunish"] +
                                                (Decimal) objTable.Rows[i]["Salary"];
                }
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }
    }
}
