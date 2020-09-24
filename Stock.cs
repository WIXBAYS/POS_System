using System;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    class Stock
    {

        public int InsertTransaction(int INVOICE_NO,int ITEMCAT_ID,decimal CAT_QUANTITY, String TRANSACTION_TYPE,decimal BUYING_COST,  decimal SELLING_COST, decimal CURR_STOCK_BALANCE,decimal NEW_STOCK_BALANCE, string USER_NAME, DateTime EXPIERY_DATE,string VENDER)
        {
            String selectCommand = "INSERT INTO [dbo].[Transaction] ([INVOICE_NO] ,[ITEMCAT_ID],[CAT_QUANTITY],[TRANSACTION_TYPE] ,[BUYING_COST] ,[SELLING_COST],[CURR_STOCK_BALANCE],[NEW_STOCK_BALANCE] ,[USER_NAME] ,[ENTERED_DATE],[EXPIERY_DATE],[Vender/Customer]) VALUES(@INVOICE_NO,@ITEMCAT_ID,@CAT_QUANTITY,@TRANSACTION_TYPE ,@BUYING_COST,@SELLING_COST,@CURR_STOCK_BALANCE,@NEW_STOCK_BALANCE,@USER_NAME,GetDate(),@EXPIERY_DATE,@VENDER)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@INVOICE_NO", SqlDbType.Int),
                                            new SqlParameter("@ITEMCAT_ID", SqlDbType.Int),
                                            new SqlParameter("@CAT_QUANTITY", SqlDbType.Decimal),
                                            new SqlParameter("@TRANSACTION_TYPE", SqlDbType.Char),
                                            new SqlParameter("@BUYING_COST", SqlDbType.Decimal),
                                            new SqlParameter("@SELLING_COST", SqlDbType.Decimal),
                                            new SqlParameter("@CURR_STOCK_BALANCE", SqlDbType.Decimal),
                                            new SqlParameter("@NEW_STOCK_BALANCE", SqlDbType.Decimal),
                                            new SqlParameter("@USER_NAME", SqlDbType.Char),
                                            new SqlParameter("@EXPIERY_DATE", SqlDbType.DateTime),
                                            new SqlParameter("@VENDER", SqlDbType.Char),
                                       };

            sqlParams[0].Value = INVOICE_NO;
            sqlParams[1].Value = ITEMCAT_ID;
            sqlParams[2].Value = CAT_QUANTITY;
            sqlParams[3].Value = TRANSACTION_TYPE;
            sqlParams[4].Value = BUYING_COST;
            sqlParams[5].Value = SELLING_COST;
            sqlParams[6].Value = CURR_STOCK_BALANCE;
            sqlParams[7].Value = NEW_STOCK_BALANCE;
            sqlParams[8].Value = USER_NAME;
            sqlParams[9].Value = EXPIERY_DATE;
            sqlParams[10].Value = VENDER;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetStockBalance(int ITEMCAT_ID)
        {
            String query = "SELECT  [BALANCE]  FROM [POS].[dbo].[Stock_Balance] WHERE [ITEMCAT_ID]=@ITEMCAT_ID";
            SqlParameter sqlParam = new SqlParameter("@ITEMCAT_ID", SqlDbType.Int);
            sqlParam.Value = ITEMCAT_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public int UpdateStockBalance(int ITEMCAT_ID, decimal CAT_QUANTITY)
        {
            String selectCommand = "UPDATE [dbo].[Stock_Balance] SET  [BALANCE] = (BALANCE + @CAT_QUANTITY) WHERE [ITEMCAT_ID] =@ITEMCAT_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@ITEMCAT_ID", SqlDbType.Int),
                                            new SqlParameter("@CAT_QUANTITY", SqlDbType.Decimal),
                                       };

            sqlParams[0].Value = ITEMCAT_ID;
            sqlParams[1].Value = CAT_QUANTITY; 

            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetMaxInvoiceNo()
        {
            String query = "SELECT MAX([INVOICE_NO])  FROM [POS].[dbo].[Transaction]"; 

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public int InsertIvoice(int INVOICE_NO, decimal Amount, decimal Discount, decimal TaxAmount, DateTime EnterderDate)
        {
            String selectCommand = "INSERT INTO [dbo].[Invoice_Data]([INVOICE_ID],[INVOICE_TOTAL],[DISCOUNT_AMOUNT],[TAX_AMOUNT],[INVOICE_DATE])VALUES(@INVOICE_ID,@INVOICE_TOTAL,@DISCOUNT_AMOUNT,@TAX_AMOUNT,@INVOICE_DATE)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@INVOICE_ID", SqlDbType.Int),          
                                            new SqlParameter("@INVOICE_TOTAL", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_AMOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@TAX_AMOUNT", SqlDbType.Decimal),                             
                                            new SqlParameter("@INVOICE_DATE", SqlDbType.DateTime),                                      
                                       };

            sqlParams[0].Value = INVOICE_NO;
            sqlParams[1].Value = Amount;
            sqlParams[2].Value = Discount;
            sqlParams[3].Value = TaxAmount;   
            sqlParams[4].Value = EnterderDate;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }
    }
}
