using System;
using System.Data;
using System.Data.SqlClient;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.BaseUntils;
using iCafeLIB.Models.DatasetEn;

namespace iCafeLIB.Controller.Material
{
    public class RawMaterialController
    {
        private const string SP_RAWMATERIAL_LOAD = "SP_RAWMATERIAL_LOAD";
        private const string SP_RAWMATERIAL_ADD = "SP_RAWMATERIAL_ADD";
        private const string SP_RAWMATERIAL_DELETE = "SP_RAWMATERIAL_DELETE";
        private const string SP_RAWMATERIAL_UPDATE = "SP_RAWMATERIAL_UPDATE";
        private readonly SqlConnection m_objConnection;
        private readonly ModelsInfo m_objModelInfo;
        private SecurityContext m_objSecurity;

        /// <summary>
        ///     Hàm tạo materialController
        /// </summary>
        /// <param name="objConnection">Sqlconnection</param>
        /// <param name="objSecurityContext">SecurityContext</param>
        public RawMaterialController(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            m_objModelInfo = new ModelsInfo(m_objConnection);
        }

        /// <summary>
        ///     Lấy dữ liệu nguyên liệu lên kho
        /// </summary>
        /// <returns></returns>
        public DataTable GetALL()
        {
            DataTable objTable;
            try
            {
                objTable = m_objModelInfo.ExecProcReturnTable(SP_RAWMATERIAL_LOAD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }

        public void AddNew(iCafeDataEn.iCafe_RawMaterialDataTable objMaterialTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_RawMaterialRow) objMaterialTable.Rows[0];
                var c = objMaterialTable.Columns.Count;
                var param = new SqlParameter[objMaterialTable.Columns.Count];
                param[0] = new SqlParameter("@RMID", Row.RMID);
                param[1] = new SqlParameter("@RMName", Row.RMName);
                param[2] = new SqlParameter("@Quantity", Row.Quantity);
                param[3] = new SqlParameter("@Unit", Row.Unit);
                param[4] = new SqlParameter("@Descript", Row.Descript);
                param[5] = new SqlParameter("@PicInfo", Row.PicInfo);
                param[6] = new SqlParameter("@RMPrice", Row.RMPrice);
                m_objModelInfo.ExecProcNoReturn(SP_RAWMATERIAL_ADD, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(iCafeDataEn.iCafe_RawMaterialDataTable objMaterialTable)
        {
            try
            {
                var Row = (iCafeDataEn.iCafe_RawMaterialRow) objMaterialTable.Rows[0];
                var param = new SqlParameter[objMaterialTable.Columns.Count];
                param[0] = new SqlParameter("@RMID", Row.RMID);
                param[1] = new SqlParameter("@RMName", Row.RMName);
                param[2] = new SqlParameter("@Quantity", Row.Quantity);
                param[3] = new SqlParameter("@Unit", Row.Unit);
                param[4] = new SqlParameter("@Descript", Row.Descript);
                param[5] = new SqlParameter("@PicInfo", Row.PicInfo);
                param[6] = new SqlParameter("@RMPrice", Row.RMPrice);
                m_objModelInfo.ExecProcNoReturn(SP_RAWMATERIAL_UPDATE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(string RMID)
        {
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@RMID", RMID);
                m_objModelInfo.ExecProcNoReturn(SP_RAWMATERIAL_DELETE, param);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}