using System;
using System.Data.SqlClient;

namespace POS
{
    class DataInsertManager
    {
        SqlConnection con;
        public DataInsertManager()
        {
            //get connection
            ConnectionManager cm = new ConnectionManager();
            con = cm.getConnection();
        }

        public int insertRecord(String query1, ref SqlParameter[] sqlParam1, String query2, ref SqlParameter[] sqlParam2)
        {
            if (con != null)
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddRange(sqlParam1);
                    cmd1.Transaction = transaction;
                    int x1 = cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddRange(sqlParam2);
                    cmd2.Transaction = transaction;
                    int x2 = cmd2.ExecuteNonQuery();
                    transaction.Commit();
                    cmd1.Dispose();
                    cmd2.Dispose();
                    con.Close();
                    return 1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    con.Close();
                    return -1;
                }
            }
            else
            {
                return -2;

            }
        }

        //Desc:- insert a new record to a table according to a supplied query string and a parameter
        public int insertRecord(String query, ref SqlParameter sqlParam)
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

        //Desc:- insert a new record to a table according to a supplied query string and array of parameters
        public int insertRecord(String query, ref SqlParameter[] sqlParams)
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
