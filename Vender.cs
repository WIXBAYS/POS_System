using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Vender
    {
        public SqlDataReader GetVenderDetails(String Vender_ID)
        {
            String query = "SELECT [VENDER_NAME],[ADDRES_LINE_1],[ADDRES_LINE_2],[ADDRES_LINE_3],[TELEPHONE_1],[TELEPHONE_2],[BUISSNESS_REG]FROM [dbo].[Vender_Details]where [VENDER_ID]=@VENDER_ID";
            SqlParameter sqlParam = new SqlParameter("@VENDER_ID", SqlDbType.Int);
            sqlParam.Value = Vender_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public Boolean CreateVender(String VENDER_Name, String ADDRES_LINE_1, String ADDRES_LINE_2, String ADDRES_LINE_3, String TELEPHONE_1, String TELEPHONE_2, String BUISSNESS_REG, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Vender_Details]([VENDER_NAME],[ADDRES_LINE_1],[ADDRES_LINE_2],[ADDRES_LINE_3],[TELEPHONE_1],[TELEPHONE_2],[BUISSNESS_REG])VALUES(@textBoxName,@textBoxLine1,@textBoxLine2,@textBoxLine3,@textBoxtel,@textBoxMob,@textBoxBusReg)", con);
            cmd.Parameters.AddWithValue("@textBoxName", VENDER_Name);
            cmd.Parameters.AddWithValue("@textBoxLine1", ADDRES_LINE_1);
            cmd.Parameters.AddWithValue("@textBoxLine2", ADDRES_LINE_2);
            cmd.Parameters.AddWithValue("@textBoxLine3", ADDRES_LINE_3);
            cmd.Parameters.AddWithValue("@textBoxtel", TELEPHONE_1);
            cmd.Parameters.AddWithValue("@textBoxMob", TELEPHONE_2);
            cmd.Parameters.AddWithValue("@textBoxBusReg", BUISSNESS_REG);

            try
            {
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean UpdateVender(String VENDER_ID, String VENDER_Name, String ADDRES_LINE_1, String ADDRES_LINE_2, String ADDRES_LINE_3, String TELEPHONE_1, String TELEPHONE_2, String BUISSNESS_REG, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Vender_Details] SET [VENDER_NAME] = @textBoxName ,[ADDRES_LINE_1] = @textBoxLine1 ,[ADDRES_LINE_2] = @textBoxLine2 ,[ADDRES_LINE_3] = @textBoxLine3 ,[TELEPHONE_1] = @textBoxtel ,[TELEPHONE_2] = @textBoxMob ,[BUISSNESS_REG] = @textBoxBusReg WHERE [VENDER_ID] = @textBoxID", con);
            cmd.Parameters.AddWithValue("@textBoxName", VENDER_Name);
            cmd.Parameters.AddWithValue("@textBoxLine1", ADDRES_LINE_1);
            cmd.Parameters.AddWithValue("@textBoxLine2", ADDRES_LINE_2);
            cmd.Parameters.AddWithValue("@textBoxLine3", ADDRES_LINE_3);
            cmd.Parameters.AddWithValue("@textBoxtel", TELEPHONE_1);
            cmd.Parameters.AddWithValue("@textBoxMob", TELEPHONE_2);
            cmd.Parameters.AddWithValue("@textBoxBusReg", BUISSNESS_REG);
            cmd.Parameters.AddWithValue("@textBoxID", VENDER_ID);

            try
            {
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
