using System;
using System.Data.SqlClient;
using System.Configuration;

namespace POS
{
    public class ConnectionManager
    {
        String strConnection;
        SqlConnection con;

        public ConnectionManager()
        {

            strConnection = ConfigurationManager.ConnectionStrings["POS.Properties.Settings.POSCS"].ConnectionString;

            try
            {
                con = new SqlConnection(strConnection);
            }
            catch
            {
                //write to the error log
                con = null;
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
