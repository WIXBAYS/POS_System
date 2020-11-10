using System;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    class Stock
    {

        public int InsertTransaction(int INVOICE_NO,int ITEMCAT_ID,decimal CAT_QUANTITY, String TRANSACTION_TYPE,decimal BUYING_COST,  decimal SELLING_COST,decimal DISCOUNT_AMOUNT,decimal NET_AMOUNT, decimal CURR_STOCK_BALANCE,decimal NEW_STOCK_BALANCE, string USER_NAME, DateTime EXPIERY_DATE,string VENDER)
        {
            String selectCommand = "INSERT INTO [dbo].[Transaction] ([INVOICE_NO] ,[ITEMCAT_ID],[CAT_QUANTITY],[TRANSACTION_TYPE] ,[BUYING_COST] ,[SELLING_COST],[DISCOUNT_AMOUNT],[NET_AMOUNT],[CURR_STOCK_BALANCE],[NEW_STOCK_BALANCE] ,[USER_NAME] ,[ENTERED_DATE],[EXPIERY_DATE],[Vender/Customer]) VALUES(@INVOICE_NO,@ITEMCAT_ID,@CAT_QUANTITY,@TRANSACTION_TYPE ,@BUYING_COST,@SELLING_COST,@DISCOUNT_AMOUNT,@NET_AMOUNT,@CURR_STOCK_BALANCE,@NEW_STOCK_BALANCE,@USER_NAME,GetDate(),@EXPIERY_DATE,@VENDER)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@INVOICE_NO", SqlDbType.Int),
                                            new SqlParameter("@ITEMCAT_ID", SqlDbType.Int),
                                            new SqlParameter("@CAT_QUANTITY", SqlDbType.Decimal),
                                            new SqlParameter("@TRANSACTION_TYPE", SqlDbType.Char),
                                            new SqlParameter("@BUYING_COST", SqlDbType.Decimal),
                                            new SqlParameter("@SELLING_COST", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_AMOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@NET_AMOUNT", SqlDbType.Decimal),
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
            sqlParams[6].Value = DISCOUNT_AMOUNT;
            sqlParams[7].Value = NET_AMOUNT;
            sqlParams[8].Value = CURR_STOCK_BALANCE;
            sqlParams[9].Value = NEW_STOCK_BALANCE;
            sqlParams[10].Value = USER_NAME;
            sqlParams[11].Value = EXPIERY_DATE;
            sqlParams[12].Value = VENDER;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetDailySales(DateTime DateVal)
        {
            String query = "DECLARE	@return_value int EXEC	@return_value = [dbo].[sp_rpt_Daily_Sales] @Date = '"+ DateVal.ToShortDateString()+ "' SELECT	'Return Value' = @return_value";
        

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
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
            String query = "SELECT MAX([INVOICE_NO])  FROM [POS].[dbo].[Transaction] WHERE [TRANSACTION_TYPE]='Customer_Invoice'"; 

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public SqlDataReader GetMaxGRNNo()
        {
            String query = "SELECT MAX([INVOICE_NO])  FROM [POS].[dbo].[Transaction] WHERE [TRANSACTION_TYPE]='STOCK_ADD'";

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public int InsertIvoice(int INVOICE_NO, decimal Amount, decimal Discount, decimal LineDiscount, decimal TaxAmount, DateTime EnterderDate, decimal PaidAmount, decimal VoucherAmount, decimal BalanceAmount)
        {
            String selectCommand = "INSERT INTO [dbo].[Invoice_Data]([INVOICE_ID],[INVOICE_TOTAL],[DISCOUNT_AMOUNT],[LINE_DISCOUNT_AMOUNT],[TAX_AMOUNT],[INVOICE_DATE],[PAID_AMOUNT],[VOUCHER_AMOUNT],[BALANCE_AMOUNT])VALUES(@INVOICE_ID,@INVOICE_TOTAL,@DISCOUNT_AMOUNT,@LINE_DISCOUNT_AMOUNT,@TAX_AMOUNT,@INVOICE_DATE,@PAID_AMOUNT,@VOUCHER_AMOUNT,@BALANCE_AMOUNT)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@INVOICE_ID", SqlDbType.Int),          
                                            new SqlParameter("@INVOICE_TOTAL", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_AMOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@LINE_DISCOUNT_AMOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@TAX_AMOUNT", SqlDbType.Decimal),                             
                                            new SqlParameter("@INVOICE_DATE", SqlDbType.DateTime),
                                            new SqlParameter("@PAID_AMOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@VOUCHER_AMOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@BALANCE_AMOUNT", SqlDbType.Decimal),
                                       };

            sqlParams[0].Value = INVOICE_NO;
            sqlParams[1].Value = Amount;
            sqlParams[2].Value = Discount;
            sqlParams[3].Value = LineDiscount;
            sqlParams[4].Value = TaxAmount;   
            sqlParams[5].Value = EnterderDate;
            sqlParams[6].Value = PaidAmount;
            sqlParams[7].Value = VoucherAmount;
            sqlParams[8].Value = BalanceAmount;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetInvoiceDetails(String INVOICE_NO)
        {
            String query = "SELECT[Transaction].TRANSACTION_ID, Item_Category.BARCODE, Item_Category.CATEGORY_NAME, Item_Category.UNIT, Item_Category.SELLING_COST / [Transaction].CAT_QUANTITY AS UNIT_PRICE, [Transaction].DISCOUNT_AMOUNT, [Transaction].CAT_QUANTITY, [Transaction].NET_AMOUNT FROM[Transaction] INNER JOIN  Item_Category ON[Transaction].ITEMCAT_ID = Item_Category.ITEMCAT_ID WHERE([Transaction].TRANSACTION_TYPE = 'Customer_Invoice') AND([Transaction].INVOICE_NO = @INVOICE_NO)";
            SqlParameter sqlParam = new SqlParameter("@INVOICE_NO", SqlDbType.Int);
            sqlParam.Value = INVOICE_NO;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public SqlDataReader GetRecallInvoiceDetails(String INVOICE_NO)
        {
            String query = "SELECT SUM([Transaction].NET_AMOUNT) FROM[Transaction] INNER JOIN  Item_Category ON[Transaction].ITEMCAT_ID = Item_Category.ITEMCAT_ID WHERE([Transaction].TRANSACTION_TYPE = 'Customer_Invoice') AND([Transaction].INVOICE_NO = @INVOICE_NO) AND([Transaction].[TRANSACTION_STATUS] = '0')";
            SqlParameter sqlParam = new SqlParameter("@INVOICE_NO", SqlDbType.Int);
            sqlParam.Value = INVOICE_NO;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public int RecallItem(Boolean TRANSACTION_STATUS,int TRANSACTION_ID)
        {
            String query = "UPDATE [dbo].[Transaction]  SET  [TRANSACTION_STATUS] = @TRANSACTION_STATUS  WHERE [TRANSACTION_ID]=@TRANSACTION_ID";
            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@TRANSACTION_STATUS", SqlDbType.Bit),
                                            new SqlParameter("@TRANSACTION_ID", SqlDbType.Int),
            };
            sqlParams[0].Value = TRANSACTION_STATUS;
            sqlParams[1].Value = TRANSACTION_ID;

            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(query, ref sqlParams);
        }
    }
}
