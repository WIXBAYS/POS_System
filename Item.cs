using System;
using System.Data.SqlClient;
using System.Data;

namespace POS
{
    public class Item
    {
        public int insertItem(String ITEM_NAME, String Item_Discription, Boolean ItemStatus)
        {
            String selectCommand = "INSERT INTO[dbo].[Items]([ITEM_NAME],[ITEM_DISCRIPTION],[ITEM_STATUS])VALUES(@ITEM_NAME, @Item_Discription, @ItemStatus)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@ITEM_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@Item_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                       };

            sqlParams[0].Value = ITEM_NAME;
            sqlParams[1].Value = Item_Discription;
            sqlParams[2].Value = ItemStatus;



            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }


        public int updateItem(String Name, String Discription, Boolean ItemStatus, String Item_ID)
        {
            String selectCommand = "UPDATE [dbo].[Items] SET [ITEM_NAME] = @ITEM_NAME ,[ITEM_DISCRIPTION] = @Item_Discription ,[ITEM_STATUS] = @ItemStatus WHERE [ITEM_ID] = @Item_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@ITEM_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@Item_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                            new SqlParameter("@Item_ID", SqlDbType.Int)
                                       };

            sqlParams[0].Value = Name;
            sqlParams[1].Value = Discription;
            sqlParams[2].Value = ItemStatus;
            sqlParams[3].Value = Item_ID;



            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetItemDetails(String Item_ID)
        {
            String query = "SELECT [ITEM_NAME],[ITEM_DISCRIPTION],[ITEM_STATUS] FROM [dbo].[Items] where [ITEM_ID]=@Item_ID";
            SqlParameter sqlParam = new SqlParameter("@Item_ID", SqlDbType.Int);
            sqlParam.Value = Item_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
    }
}
