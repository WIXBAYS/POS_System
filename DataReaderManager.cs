using System;
using System.Data;
using System.Data.SqlClient;

namespace POS
{
    public class DataReaderManager
    {
        SqlConnection con;

        public DataReaderManager()
        {
            //get connection
            ConnectionManager cm = new ConnectionManager();
            con = cm.getConnection();
        }

        //Desc:- return a SqlDataReader according to supplied query string and a parameter
        public SqlDataReader getDataReader(String query, ref SqlParameter sqlParam)
        {
            if (con != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(sqlParam);
                    SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (sdr.HasRows)
                    {
                        return sdr;
                    }
                    else
                    {
                        sdr.Dispose();
                        sdr.Close();
                        return null;
                    }
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }


        //Desc:- return a SqlDataReader according to supplied query string and array of parameters
        public SqlDataReader getDataReader(String query, ref SqlParameter[] sqlParams)
        {
            if (con != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddRange(sqlParams);
                    SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (sdr.HasRows)
                    {
                        return sdr;
                    }
                    else
                    {
                        sdr.Dispose();
                        sdr.Close();
                        return null;
                    }

                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }


        //Desc:- return a SqlDataReader according to supplied query string 
        public SqlDataReader getDataReader(String query)
        {
            if (con != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (sdr.HasRows)
                    {
                        return sdr;
                    }
                    else
                    {
                        sdr.Dispose();
                        sdr.Close();
                        return null;
                    }
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
