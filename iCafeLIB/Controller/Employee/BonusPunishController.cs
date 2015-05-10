using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Employee
{
    public class BonusPunishController
    {
        private const string SP_BONUSPUNISH_LOAD = "SP_BONUSPUNISH_LOAD";
        private const string SP_BONUS_LOAD = "SP_BONUS_LOAD";
        private const string SP_PUNISH_LOAD = "SP_PUNISH_LOAD";
        private const string SP_BONUSPUNISH_ADD = "SP_BONUSPUNISH_ADD";
        private const string SP_BONUS_PUNISH_OFEMPLOY = "SP_BONUS_PUNISH_OFEMPLOY";
        private readonly SqlConnection mobjConnection;
        private readonly ModelsInfo mobjModelsinfo;
        private SecurityContext mobjSecurity;

        public BonusPunishController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjModelsinfo = new ModelsInfo(mobjConnection);
        }

        private DataTable Base(string SP_NAME)
        {
            DataTable objTable;
            try
            {
                objTable = mobjModelsinfo.ExecProcReturnTable(SP_NAME);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return objTable;
        }

        /// <summary>
        ///     Lấy toàn bộ thưởng phạt
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            return Base(SP_BONUSPUNISH_LOAD);
        }

        /// <summary>
        ///     Lấy thưởng
        /// </summary>
        /// <returns></returns>
        public DataTable GetBonus()
        {
            return Base(SP_BONUS_LOAD);
        }

        /// <summary>
        ///     Lấy phạt
        /// </summary>
        /// <returns></returns>
        public DataTable GetPunish()
        {
            return Base(SP_PUNISH_LOAD);
        }

        /// <summary>
        ///     Thêm thưởng phạt mới
        /// </summary>
        /// <param name="objTable"></param>
        public void AddNew(iCafeDataEn.iCafe_Bonus_PunishDataTable objTable)
        {
            try
            {
                var row = (iCafeDataEn.iCafe_Bonus_PunishRow) objTable.Rows[0];
                var param = new SqlParameter[objTable.Columns.Count];
                param[0] = new SqlParameter("@EmployID", row.EmployID);
                param[1] = new SqlParameter("@Content", row.Content);
                param[2] = new SqlParameter("@Value", row.Value);
                param[3] = new SqlParameter("@Time", row.Time);
                mobjModelsinfo.ExecProcNoReturn(SP_BONUSPUNISH_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///     Tổng thưởng phạt theo tháng của 1 nhân viên
        /// </summary>
        /// <param name="EmployID">Mã nhân viên</param>
        /// <returns></returns>
        public int OfEmploy(string EmployID,int Month,int Year)
        {
            var return_val = 0;
            DataTable objTable;
            try
            {
                var param = new SqlParameter[3];
                param[0] = new SqlParameter("@Month", Month);
                param[1] = new SqlParameter("@Year", Year);
                param[2] = new SqlParameter("@EmployID", EmployID);
                objTable = mobjModelsinfo.ExecProcReturnTable(SP_BONUS_PUNISH_OFEMPLOY, param);
                if (objTable.Rows.Count == 1)
                {
                    return_val = int.Parse(objTable.Rows[0]["TotalBonusPunish"].ToString());
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return return_val;
        }
    }
}