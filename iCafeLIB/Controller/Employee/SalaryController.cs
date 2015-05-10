using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.Utils.Drawing.Helpers;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;

namespace iCafeLIB.Controller.Employee
{
    public class SalaryController
    {
        private const string SP_SALARY_PERMONTH = "SP_SALARY_PERMONTH";
        private const string SP_SALARY_OVERTIME = "SP_SALARY_OVERTIME";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsInfo;
        private readonly SecurityContext mobjSecurity;

        public SalaryController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsInfo = new ModelsInfo(mobjConnection);
        }

        /// <summary>
        ///     Lấy thông tin lương
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll(int Month,int Year)
        {
            DataTable objTable;
            try
            {
                SqlParameter[] param=new SqlParameter[2];
                param[0]=new SqlParameter("@Month",Month);
                param[1]=new SqlParameter("@Year",Year);
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_SALARY_PERMONTH,param);
                Add_BonusPunishTo(objTable,Month,Year);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        private int Salary_OverTime(string EmployID,int Month, int Year)
        {
            var return_val = 0;
            DataTable objTable;
            try
            {
                var param = new SqlParameter[3];
                param[0] = new SqlParameter("@Month", Month);
                param[1] = new SqlParameter("@Year", Year);
                param[2] = new SqlParameter("@EmployID", EmployID);
                objTable = mobjModelsInfo.ExecProcReturnTable(SP_SALARY_OVERTIME, param);
                if (objTable.Rows.Count == 1)
                {
                    return_val = int.Parse(objTable.Rows[0]["SalaryOverTime"].ToString());
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return return_val;
        }
        /// <summary>
        ///     Tính thông tin thưởng phạt vào bảng lương
        /// </summary>
        /// <param name="objTable"></param>
        private void Add_BonusPunishTo(DataTable objTable,int Month,int Year)
        {
            Decimal sumSalary=0;
            Decimal sumSaryOverTime = 0;
            Decimal sumBonusPunish = 0;
            Decimal sumTotal=0;
            try
            {
                objTable.Columns.Add("TotalBonusPunish", Type.GetType("System.Decimal"));
                objTable.Columns.Add("Total", Type.GetType("System.Decimal"));
                objTable.Columns.Add("SalaryOverTime", Type.GetType("System.Decimal"));

                var bp = new BonusPunishController(mobjConnection, mobjSecurity);
                for (var i = 0; i < objTable.Rows.Count; i++)
                {
                    objTable.Rows[i]["TotalBonusPunish"] = bp.OfEmploy(objTable.Rows[i]["EmployID"].ToString(),Month,Year);
                    objTable.Rows[i]["SalaryOverTime"] = Salary_OverTime(objTable.Rows[i]["EmployID"].ToString(), Month,
                        Year);
                    objTable.Rows[i]["Total"] = (Decimal) objTable.Rows[i]["TotalBonusPunish"] +
                                                (Decimal) objTable.Rows[i]["Salary"]+(Decimal)objTable.Rows[i]["SalaryOverTime"];
                    sumSalary += (Decimal) objTable.Rows[i]["Salary"];
                    sumBonusPunish += (Decimal)objTable.Rows[i]["TotalBonusPunish"];
                    sumSaryOverTime += (Decimal)objTable.Rows[i]["SalaryOverTime"];
                    sumTotal += (Decimal)objTable.Rows[i]["Total"];
               }
                DataRow row = objTable.NewRow();
                row["EmployID"] = Guid.Empty;
                row["Fullname"] = "[TỔNG CỘNG]";
                row["Salary"] = sumSalary;
                row["TotalBonusPunish"] = sumBonusPunish;
                row["SalaryOverTime"] = sumSaryOverTime;
                row["Total"] = sumTotal;
                row["SalaryOfMonth"] = objTable.Rows[0]["SalaryOfMonth"];
                objTable.Rows.Add(row);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}