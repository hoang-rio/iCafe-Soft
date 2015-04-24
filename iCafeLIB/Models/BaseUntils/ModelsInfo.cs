using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace iCafeLIB.Models.BaseUntils
{
    public class ModelsInfo
    {
        private SqlDataAdapter m_objAdapter;
        private SqlCommand m_objCommand;
        private SqlParameter m_objParam;
        private SqlDataReader m_objReader;
        private DataTable m_objTable;

        /// <summary>
        ///     Contructors
        /// </summary>
        public ModelsInfo()
        {
        }

        public ModelsInfo(SqlConnection objConnection)
        {
            _getConnection = objConnection;
        }

        public ModelsInfo(string connectString)
        {
            _getConnection = new SqlConnection();
            if (_getConnection.State == ConnectionState.Closed)
            {
                SqlclientConnection(connectString);
            }
        }

        public SqlConnection _getConnection { get; set; }

        #region "1. Get Datatable"

        /// <summary>
        ///     Get Datatable
        /// </summary>
        /// <param name="strQuery">Chuoi truy van</param>
        /// <returns></returns>
        public DataTable GetDataTables(string strQuery)
        {
            m_objTable = new DataTable();
            try
            {
                m_objCommand = new SqlCommand(strQuery, _getConnection);
                m_objAdapter = new SqlDataAdapter(m_objCommand);
                m_objAdapter.Fill(m_objTable);
                m_objAdapter.Dispose(); //Giai phong
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return m_objTable;
        }

        #endregion

        #region "6. Get DataRow"

        /// <summary>
        ///     Get DataRow
        /// </summary>
        /// <param name="strStoreProc">Tên thủ tục</param>
        /// <param name="oParam">Mảng tập hợp tham sồ vaod</param>
        /// <returns></returns>
        public int GetRowsCount(string strStoreProc, SqlParameter[] oParam)
        {
            var iNumber = 0;
            try
            {
                m_objCommand = new SqlCommand(strStoreProc, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                for (var i = 0; i < oParam.Length; i++)
                {
                    m_objCommand.Parameters.Add(oParam[i]);
                }
                iNumber = (int) m_objCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return iNumber;
        }

        #endregion

        #region "7.Check Exist DataRow"

        /// <summary>
        ///     Check Exist DataRow
        /// </summary>
        /// <param name="strStoreProc"></param>
        /// <param name="oParam"></param>
        /// <returns></returns>
        public bool CheckExistRow(string strStoreProc, SqlParameter[] oParam)
        {
            try
            {
                m_objCommand = new SqlCommand(strStoreProc, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                for (var i = 0; i < oParam.Length; i++)
                {
                    m_objCommand.Parameters.Add(oParam[i]);
                }
                m_objReader = m_objCommand.ExecuteReader();
                if (m_objReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        #endregion

        #region "8. Get DataTable Into Dataset"

        /// <summary>
        ///     Get DataTable Into Dataset
        /// </summary>
        /// <param name="strStoreProc">Tên thủ tục</param>
        /// <param name="oParam">Mảng tham số đầu vào</param>
        /// <param name="strTableName">Tên bảng trên Dataset</param>
        /// <returns></returns>
        public DataSet GetDataTableToDataset(string strStoreProc, SqlParameter[] oParam, string strTableName)
        {
            var Entities = new DataSet();
            try
            {
                m_objCommand = new SqlCommand(strStoreProc, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                for (var i = 0; i < oParam.Length; i++)
                {
                    m_objCommand.Parameters.Add(oParam[i]);
                }
                m_objAdapter = new SqlDataAdapter(m_objCommand);
                m_objAdapter.Fill(Entities, strTableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return Entities;
        }

        #endregion

        #region "OpenConnections"

        //SQLClient
        public SqlConnection SqlclientConnection(string connectString)
        {
            //1. Khởi tạo đối tượng kết nối
            _getConnection = new SqlConnection(connectString);

            try
            {
                //2. Mở kết nối
                _getConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return _getConnection;
        }

        public SqlConnection SqlclientConnection(ConnectionObjects obj)
        {
            //1. Khởi tạo đối tượng kết nối
            //obj._SERVER = DecryptInfo(obj._SERVER);
            //obj._DATABASE = DecryptInfo(obj._DATABASE);
            //obj._USERNAME = DecryptInfo(obj._USERNAME);
            //obj._PASSWORD = DecryptInfo(obj._PASSWORD);

            var connString = String.Format("Server={0};Database={1};UId={2};PWD={3};",
                obj._SERVER, obj._DATABASE, obj._USERNAME, obj._PASSWORD);
            _getConnection = new SqlConnection(connString);

            try
            {
                //2. Mở kết nối
                _getConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return _getConnection;
        }

        //OleDb
        public OleDbConnection OleDbConnection(string connectString)
        {
            //1. Khởi tạo đối tượng kết nối
            var m_objConnection = new OleDbConnection(connectString);

            try
            {
                //2. Mở kết nối
                m_objConnection.Open();
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

        #endregion

        #region "2. Create Parammeter"

        /// <summary>
        ///     Create Parammeter
        /// </summary>
        /// <param name="strParammeter">Tên tham số</param>
        /// <param name="oSqlDbType">Kiểu giá trị của than số</param>
        /// <param name="oParameterValue">Giá trị của tham số</param>
        /// <returns></returns>
        public SqlParameter CreateParammeter(string strParammeter, SqlDbType oSqlDbType, object oParameterValue)
        {
            try
            {
                m_objParam = new SqlParameter();
                m_objParam.ParameterName = strParammeter;
                m_objParam.SqlDbType = oSqlDbType;
                m_objParam.SqlValue = oParameterValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return m_objParam;
        }

        /// <summary>
        ///     Create Parammeter
        /// </summary>
        /// <param name="strParammeter"></param>
        /// <param name="oParameterValue"></param>
        /// <returns></returns>
        public SqlParameter CreateParammeter(string strParammeter, object oParameterValue)
        {
            try
            {
                m_objParam = new SqlParameter();
                m_objParam.ParameterName = strParammeter;
                m_objParam.SqlValue = oParameterValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return m_objParam;
        }

        #endregion

        #region "3. ExecutedStoreProc return DataTable"

        /// <summary>
        ///     Executed StoreProc return DataTable
        /// </summary>
        /// <param name="strStoreProcName">Tên thủ tục</param>
        /// <param name="oParam">Mảng tập hợp các tham số đầu vào của thủ tục hiện tại</param>
        /// <returns></returns>
        public DataTable ExecProcReturnTable(string strStoreProcName, SqlParameter[] oParam)
        {
            m_objTable = new DataTable();
            try
            {
                m_objCommand = new SqlCommand(strStoreProcName, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                for (var i = 0; i < oParam.Length; i++)
                {
                    m_objCommand.Parameters.Add(oParam[i]);
                }
                m_objAdapter = new SqlDataAdapter(m_objCommand);
                m_objAdapter.Fill(m_objTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return m_objTable;
        }

        /// <summary>
        ///     Truy vấn Store Procedure trả về DataTable
        /// </summary>
        /// <param name="strProcName"></param>
        /// <returns></returns>
        public DataTable ExecProcReturnTable(string strProcName)
        {
            m_objTable = new DataTable();
            try
            {
                m_objCommand = new SqlCommand(strProcName, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                m_objAdapter = new SqlDataAdapter(m_objCommand);
                m_objAdapter.Fill(m_objTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return m_objTable;
        }

        #endregion

        #region "4. Executed StoreProc use Insert - Update - Delete"

        /// <summary>
        ///     Executed StoreProc use Insert - Update - Delete
        /// </summary>
        /// <param name="strParameterName">Tên thủ tục</param>
        /// <param name="oParam">Mảng tập hợp tham số đầu vào</param>
        public void ExecProcNoReturn(string strParameterName, SqlParameter[] oParam)
        {
            try
            {
                m_objCommand = new SqlCommand(strParameterName, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                for (var i = 0; i < oParam.Length; i++)
                {
                    m_objCommand.Parameters.Add(oParam[i]);
                }
                m_objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        /// <summary>
        ///     Executed StoreProc use Insert - Update - Delete
        /// </summary>
        /// <param name="strQuery"></param>
        public void ExecProcNoReturn(string strQuery)
        {
            try
            {
                m_objCommand = new SqlCommand(strQuery, _getConnection);
                m_objCommand.CommandType = CommandType.Text; //Default               
                m_objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        #endregion

        #region "5. ExecuteScalar use return one value"

        /// <summary>
        ///     ExecuteScalar use return one value object
        /// </summary>
        /// <param name="strStorePoc">Tên thủ tục</param>
        /// <returns></returns>
        public object ExecuteScalarObject(string strStorePoc)
        {
            object objValue = null;
            try
            {
                m_objCommand = new SqlCommand(strStorePoc, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                objValue = m_objCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return objValue;
        }

        /// <summary>
        ///     ExecuteScalarInt use return one value integer
        /// </summary>
        /// <param name="strStorePoc"></param>
        /// <returns></returns>
        public int ExecuteScalarInt(string strStorePoc)
        {
            var objValue = 0;
            try
            {
                m_objCommand = new SqlCommand(strStorePoc, _getConnection);
                m_objCommand.CommandType = CommandType.StoredProcedure;
                objValue = (int) m_objCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return objValue;
        }

        #endregion

        #region "9. Encrypt And Decrypt Information"

        private const string KEY = "imic.edu.vn, key provided by Doannv";
        private const string IV = "imiC+EDIFsA=";

        //Mã hóa thông tin
        public string EncryptInfo(string Input)
        {
            if (Input.Length == 0)
                return Input;
            var Code = Encoding.ASCII.GetBytes(Input);
            MD5 md5 = new MD5CryptoServiceProvider();
            var Key = md5.ComputeHash(Encoding.Unicode.GetBytes(KEY));
            var tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = Key;
            tripleDES.IV = Convert.FromBase64String(IV);
            return Convert.ToBase64String(tripleDES.CreateEncryptor().TransformFinalBlock(Code, 0, Code.Length));
        }

        //Giải mã thông tin
        public string DecryptInfo(string Input)
        {
            if (Input.Length == 0)
                return Input;
            var Code = Convert.FromBase64String(Input);
            MD5 md5 = new MD5CryptoServiceProvider();
            var Key = md5.ComputeHash(Encoding.Unicode.GetBytes(KEY));
            var tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = Key;
            tripleDES.IV = Convert.FromBase64String(IV);
            return Encoding.ASCII.GetString(tripleDES.CreateDecryptor().TransformFinalBlock(Code, 0, Code.Length));
        }

        #endregion
    }
}