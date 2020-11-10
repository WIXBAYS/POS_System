using System;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    class Voucher
    {
        public int insertVoucher(String VOUCHER_NO, String BARCODE, Decimal AMOUNT)
        {
            String selectCommand = "INSERT INTO [dbo].[Voucher] ([VOUCHER_NO]  ,[BARCODE]  ,[AMOUNT] ) VALUES (@VOUCHER_NO  ,@BARCODE  ,@AMOUNT)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@VOUCHER_NO", SqlDbType.VarChar),
                                            new SqlParameter("@BARCODE", SqlDbType.VarChar),
                                            new SqlParameter("@AMOUNT", SqlDbType.Decimal)
                                       };

            sqlParams[0].Value = VOUCHER_NO;
            sqlParams[1].Value = BARCODE;
            sqlParams[2].Value = AMOUNT;



            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public int updateVoucher(int ID, int INVOICE_ID)
        {
            String Command = "UPDATE [dbo].[Voucher]  SET  [VOUCHER_STATUS] = '1'  ,[INVOICE_ID] = @INVOICE_ID WHERE [ID] =@ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@ID", SqlDbType.Int),
                                            new SqlParameter("@INVOICE_ID", SqlDbType.Int)
                                       };

            sqlParams[0].Value = ID;
            sqlParams[1].Value = INVOICE_ID;



            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(Command, ref sqlParams);
        }

        public SqlDataReader getVoucherbyVoucher_No(String VOUCHER_NO)
        {
            String selectCommand = "SELECT [ID],[BARCODE],[AMOUNT],[VOUCHER_STATUS]    FROM [POS].[dbo].[Voucher] WHERE [VOUCHER_NO]=@VOUCHER_NO";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@VOUCHER_NO", SqlDbType.VarChar)
                                       };

            sqlParams[0].Value = VOUCHER_NO;



            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(selectCommand, ref sqlParams);
        }

        public SqlDataReader getVoucherbyBrCode(String BARCODE)
        {
            String selectCommand = "SELECT [ID],[VOUCHER_NO],[AMOUNT],[VOUCHER_STATUS]   FROM [POS].[dbo].[Voucher] WHERE [BARCODE]=@BARCODE";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@BARCODE", SqlDbType.VarChar)
                                       };

            sqlParams[0].Value = BARCODE;



            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(selectCommand, ref sqlParams);
        }
    }
}
