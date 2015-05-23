using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;

namespace iCafeLIB.Controller.Users
{
    public class UserController
    {
        private const string SP_CHECK_LOGIN = "SP_CHECK_LOGIN";
        private readonly ModelsInfo m_objModelinfo;
        private readonly SecurityContext m_objSecurity;
        private SqlConnection m_objConnection;

        public UserController(SqlConnection objConnection, SecurityContext objSecurity)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurity;
            m_objModelinfo = new ModelsInfo(objConnection);
        }

        public UserController(SqlConnection objConnection)
        {
            m_objConnection = objConnection;
            m_objModelinfo = new ModelsInfo(objConnection);
        }

        public DataTable Checklogin(string Username, string Password)
        {
            DataTable objTable;
            try
            {
                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@username", Username);
                param[1] = new SqlParameter("@password", Password);
                objTable = new DataTable();
                objTable = m_objModelinfo.ExecProcReturnTable(SP_CHECK_LOGIN, param);
                if (objTable.Rows.Count > 0)
                {
                    var row = objTable.Rows[0];
                    m_objSecurity._LoginSuccess = true;
                    m_objSecurity._id = (Guid) row["EmployID"];
                    m_objSecurity._UserName = Username;
                    m_objSecurity._Password = row["PassW"].ToString();
                    m_objSecurity._FullName = row["Fullname"].ToString();
                    m_objSecurity._FullPermiss = (bool) row["FullPermiss"];
                    m_objSecurity._fc_Customer = (bool) row["fc_Customer"];
                    m_objSecurity._fc_warehouse = (bool) row["fc_warehouse"];
                    m_objSecurity._fc_table = (bool) row["fc_table"];
                    m_objSecurity._fc_sale = (bool) row["fc_sale"];
                    m_objSecurity._fc_system = (bool) row["fc_system"];
                    m_objSecurity._fc_revenue = (bool) row["fc_revenue"];
                    m_objSecurity._fc_event = (bool) row["fc_event"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }
    }
}