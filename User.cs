using System;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    public class User
    {
        public SqlDataReader GetUserDetails(String NIC)
        {
            String query = "SELECT [USER_NAME] ,[STATUS] ,[USER_TYPE]  ,[FIRST_NAME] ,[LAST_NAME]  ,[CONTACT_NO] ,[ADDRESS_NO] ,[STREET]  ,[CITY] ,[DISTRICT] ,[STORE_ID]  FROM [POS].[dbo].[User_Details] WHERE NIC=@NIC";
            SqlParameter sqlParam = new SqlParameter("@NIC", SqlDbType.Char);
            sqlParam.Value = NIC;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
    }
    
}
