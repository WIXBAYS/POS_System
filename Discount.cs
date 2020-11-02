using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    class Discount
    {
        public SqlDataReader GetDiscountForTotal()
        {
            String query = "SELECT   [AMOUNT_FROM] ,[AMOUNT_TO],[DISCOUNT_PERIOADICALLY] ,[DISCOUNT] ,[DISCOUNT_TYPE] ,[DISCOUNT_FROM] ,[DISCOUNT_TO],[DISCOUNT_ID] FROM  [dbo].[Discount_Type2]";
           
            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public SqlDataReader GetDiscountForTotal(Decimal TotalAmount)
        {
            String query = "SELECT  [DISCOUNT_PERIOADICALLY] ,[DISCOUNT] ,[DISCOUNT_TYPE] ,[DISCOUNT_FROM] ,[DISCOUNT_TO],[DISCOUNT_ID] FROM  [dbo].[Discount_Type2] WHERE [AMOUNT_FROM] <= @TotalAmount AND [AMOUNT_TO]>=@TotalAmount";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@TotalAmount", SqlDbType.Decimal),
            };
            sqlParams[0].Value = TotalAmount;
            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query,ref sqlParams);
        }

        public int DeleteDiscountForTotal()
        {
            String query = "delete FROM [dbo].[Discount_Type2]";

            DataDeleteManager ddm = new DataDeleteManager();
            return ddm.deleteRecord(query);
        }
        public int InsertDiscountForTotal(Decimal AMOUNT_FROM,Decimal AMOUNT_TO, Decimal DISCOUNT, String DISCOUNT_TYPE,Boolean DISCOUNT_PERIOADICALLY, DateTime DISCOUNT_FROM,DateTime DISCOUNT_TO)
        {
            String query = "INSERT INTO [dbo].[Discount_Type2]  ([AMOUNT_FROM]  ,[AMOUNT_TO] ,[DISCOUNT]  ,[DISCOUNT_TYPE]  ,[DISCOUNT_PERIOADICALLY]  ,[DISCOUNT_FROM] ,[DISCOUNT_TO])  VALUES (@AMOUNT_FROM  ,@AMOUNT_TO  ,@DISCOUNT  ,@DISCOUNT_TYPE ,@DISCOUNT_PERIOADICALLY ,@DISCOUNT_FROM,@DISCOUNT_TO)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@AMOUNT_FROM", SqlDbType.Decimal),
                                            new SqlParameter("@AMOUNT_TO", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_TYPE", SqlDbType.VarChar),
                                            new SqlParameter("@DISCOUNT_PERIOADICALLY", SqlDbType.Bit),
                                            new SqlParameter("@DISCOUNT_FROM", SqlDbType.DateTime),
                                            new SqlParameter("@DISCOUNT_TO", SqlDbType.DateTime),
                                       };

            sqlParams[0].Value = AMOUNT_FROM;
            sqlParams[1].Value = AMOUNT_TO;
            sqlParams[2].Value = DISCOUNT;
            sqlParams[3].Value = DISCOUNT_TYPE;
            sqlParams[4].Value = DISCOUNT_PERIOADICALLY;
            sqlParams[5].Value = DISCOUNT_FROM;
            sqlParams[6].Value = DISCOUNT_TO;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(query, ref sqlParams);
        }
    }
}
