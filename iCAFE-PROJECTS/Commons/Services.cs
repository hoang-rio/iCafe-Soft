using System;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Word;
using iCafeLIB.Models.BaseUntils;

namespace iCafe.Commons
{
    public class Services
    {
        private SqlConnection m_objConnection;

        public SqlConnection getConnection()
        {
            try
            {
                var obj = new ConnectionObjects();
                obj._SERVER = ConfigurationManager.AppSettings["SERVER"];
                obj._DATABASE = ConfigurationManager.AppSettings["DATABASE"];
                obj._USERNAME = ConfigurationManager.AppSettings["USERNAME"];
                obj._PASSWORD = ConfigurationManager.AppSettings["PASSWORD"];

                m_objConnection = (new ModelsInfo()).SqlclientConnection(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return m_objConnection;
        }
    }
}