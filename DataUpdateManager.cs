using System;
using System.Data.SqlClient;

namespace POS
{
    class DataUpdateManager
    {
        SqlConnection con;

        public DataUpdateManager()
        {
            //get connection
            ConnectionManager cm = new ConnectionManager();
            con = cm.getConnection();
        }

        //Desc:- update a record from a table according to a supplied query string
        public int updateRecord(String query)
        {
            if (con != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    int x = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    return x;
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }





        //Desc:- update a record from a table according to a supplied query string and a parameter
        public int updateRecord(String query, ref SqlParameter sqlParam)
        {
            if (con != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(sqlParam);
                    int x = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    return x;
                }
                catch
                {
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }


        //Desc:- update a record from a table according to a supplied query string and array of parameters
        public int updateRecord(String query, ref SqlParameter[] sqlParams)
        {
            if (con != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddRange(sqlParams);
                    int x = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    return x;
                }
                catch(Exception e)
                {
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }

    }
}