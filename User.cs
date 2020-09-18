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

        public int insertUser(String USER_NAME, String PASSWORD, String NIC,String USER_TYPE,String FIRST_NAME,String LAST_NAME, String CONTACT_NO, String ADDRESS_NO, String STREET, String CITY, String DISTRICT, int STORE_ID)
        {
            String selectCommand = "INSERT INTO [dbo].[User_Details] ([USER_NAME] ,[PASSWORD],[NIC],[STATUS] ,[USER_TYPE] ,[FIRST_NAME],[LAST_NAME],[CONTACT_NO],[ADDRESS_NO] ,[STREET],[CITY],[DISTRICT] ,[STORE_ID])VALUES (@USER_NAME ,@PASSWORD ,@NIC ,1,@USER_TYPE,@FIRST_NAME,@LAST_NAME,@CONTACT_NO,@ADDRESS_NO ,@STREET,@CITY,@DISTRICT,@STORE_ID)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@USER_NAME", SqlDbType.Char),
                                            new SqlParameter("@PASSWORD", SqlDbType.Char),
                                            new SqlParameter("@NIC", SqlDbType.Char),
                                            new SqlParameter("@USER_TYPE", SqlDbType.Char),
                                            new SqlParameter("@FIRST_NAME", SqlDbType.Char),
                                            new SqlParameter("@LAST_NAME", SqlDbType.Char),
                                            new SqlParameter("@CONTACT_NO", SqlDbType.Char),
                                            new SqlParameter("@ADDRESS_NO", SqlDbType.Char),
                                            new SqlParameter("@STREET", SqlDbType.Char),
                                            new SqlParameter("@CITY", SqlDbType.Char),
                                            new SqlParameter("@DISTRICT", SqlDbType.Char),
                                            new SqlParameter("@STORE_ID", SqlDbType.Int),
                                       };

            sqlParams[0].Value = USER_NAME;
            sqlParams[1].Value = PASSWORD;
            sqlParams[2].Value = NIC;
            sqlParams[3].Value = USER_TYPE;
            sqlParams[4].Value = FIRST_NAME;
            sqlParams[5].Value = LAST_NAME;
            sqlParams[6].Value = CONTACT_NO;
            sqlParams[7].Value = ADDRESS_NO;
            sqlParams[8].Value = STREET;
            sqlParams[9].Value = CITY;
            sqlParams[10].Value = DISTRICT;
            sqlParams[11].Value = STORE_ID;



            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }


        public int updatetUser(String NIC, Boolean STATUS, String FIRST_NAME, String LAST_NAME, String CONTACT_NO, String ADDRESS_NO, String STREET, String CITY, String DISTRICT, int STORE_ID)
        {
            String selectCommand = "UPDATE [dbo].[User_Details] SET  [STATUS] = @STATUS ,[FIRST_NAME] = @FIRST_NAME  ,[LAST_NAME] = @LAST_NAME ,[CONTACT_NO] = @CONTACT_NO  ,[ADDRESS_NO] = @ADDRESS_NO ,[STREET] = @STREET ,[CITY] = @CITY  ,[DISTRICT] = @DISTRICT ,[STORE_ID] = @STORE_ID WHERE [NIC]=@NIC";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@NIC", SqlDbType.Char),
                                            new SqlParameter("@STATUS", SqlDbType.Bit),
                                            new SqlParameter("@FIRST_NAME", SqlDbType.Char),
                                            new SqlParameter("@LAST_NAME", SqlDbType.Char),
                                            new SqlParameter("@CONTACT_NO", SqlDbType.Char),
                                            new SqlParameter("@ADDRESS_NO", SqlDbType.Char),
                                            new SqlParameter("@STREET", SqlDbType.Char),
                                            new SqlParameter("@CITY", SqlDbType.Char),
                                            new SqlParameter("@DISTRICT", SqlDbType.Char),
                                            new SqlParameter("@STORE_ID", SqlDbType.Int),
                                       };

            sqlParams[0].Value = NIC;
            sqlParams[1].Value = STATUS;
            sqlParams[2].Value = FIRST_NAME;
            sqlParams[3].Value = LAST_NAME;
            sqlParams[4].Value = CONTACT_NO;
            sqlParams[5].Value = ADDRESS_NO;
            sqlParams[6].Value = STREET;
            sqlParams[7].Value = CITY;
            sqlParams[8].Value = DISTRICT;
            sqlParams[9].Value = STORE_ID;



            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }

        public int updatetPassword(String PASSWORD, String USER_NAME, String USER_TYPE)
        {
            String selectCommand = "UPDATE [dbo].[User_Details] SET  [PASSWORD] = @PASSWORD, [USER_TYPE]=@USER_TYPE  WHERE [USER_NAME]=@USER_NAME";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@PASSWORD", SqlDbType.Char),
                                            new SqlParameter("@USER_NAME", SqlDbType.Char),
                                            new SqlParameter("@USER_TYPE", SqlDbType.Char),
                                       };

            sqlParams[0].Value = PASSWORD;
            sqlParams[1].Value = USER_NAME;
            sqlParams[2].Value = USER_TYPE;


            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }
    }
    
}
