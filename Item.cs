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

        public SqlDataReader GetItemList()
        {
            String query = "SELECT [ITEM_ID],[ITEM_NAME] FROM [dbo].[Items]";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public int insertItemCatagory(String Catagory_NAME, String ITEM_ID,String Barcode_No, String Unit, float Buying, float Selling, String Item_Discription, Boolean ItemStatus)
        {
            String selectCommand = "INSERT INTO [dbo].[Item_Catagory]([CATAGORY_NAME],[ITEM_ID],[BARCODE],[UNIT],[BUYING_COST],[SELLING_COST],[CAT_DISCRIPTION],[CAT_STATUS],[ENTERDE_DATE])VALUES(@Catagory_NAME, @ITEM_ID, @Barcode_No, @Unit, @Buying, @Selling, @Item_Discription, @ItemStatus, @EnteredDate)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Catagory_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@ITEM_ID", SqlDbType.Int),
                                            new SqlParameter("@Barcode_No", SqlDbType.VarChar),
                                            new SqlParameter("@Unit", SqlDbType.VarChar),
                                            new SqlParameter("@Buying", SqlDbType.Float),
                                            new SqlParameter("@Selling", SqlDbType.Float),
                                            new SqlParameter("@Item_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                            new SqlParameter("@EnteredDate", SqlDbType.DateTime),
                                       };

            sqlParams[0].Value = Catagory_NAME;
            sqlParams[1].Value = ITEM_ID;
            sqlParams[2].Value = Barcode_No;
            sqlParams[3].Value = Unit;
            sqlParams[4].Value = Buying;
            sqlParams[5].Value = Selling;
            sqlParams[6].Value = Item_Discription;
            sqlParams[7].Value = ItemStatus;
            sqlParams[8].Value = DateTime.Now;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetItemCatagoryDetails(String Catagory_ID)
        {
            String query = "SELECT Item_Catagory.BARCODE, Item_Catagory.CATAGORY_NAME, Item_Catagory.CAT_DISCRIPTION, Item_Catagory.UNIT, Item_Catagory.BUYING_COST, Item_Catagory.SELLING_COST,Item_Catagory.CAT_STATUS, Items.ITEM_NAME FROM Item_Catagory INNER JOIN Items ON Item_Catagory.ITEM_ID = Items.ITEM_ID where Item_Catagory.ITEMCAT_ID = @ItemCatID";
            SqlParameter sqlParam = new SqlParameter("@ItemCatID", SqlDbType.Int);
            sqlParam.Value = Catagory_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public int updateItemCatagory(String Catagory_NAME, String ITEM_ID, String Barcode_No, String Unit, float Buying, float Selling, String Item_Discription, Boolean ItemStatus, String Catagory_ID)
        {
            String selectCommand = "UPDATE [dbo].[Item_Catagory] SET [CATAGORY_NAME] = @Catagory_NAME, [ITEM_ID] = @ITEM_ID, BARCODE = @Barcode_No, [UNIT] = @Unit, [BUYING_COST] = @Buying, [SELLING_COST]= @Selling ,[CAT_DISCRIPTION] = @Catagory_Discription ,[CAT_STATUS] = @ItemStatus , [UPDATED_DATE] = @UpdateddDate WHERE [ITEMCAT_ID] = @Catagory_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Catagory_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@ITEM_ID", SqlDbType.Int),
                                            new SqlParameter("@Barcode_No", SqlDbType.VarChar),
                                            new SqlParameter("@Unit", SqlDbType.VarChar),
                                            new SqlParameter("@Buying", SqlDbType.Float),
                                            new SqlParameter("@Selling", SqlDbType.Float),
                                            new SqlParameter("@Catagory_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                            new SqlParameter("@UpdateddDate", SqlDbType.DateTime),
                                            new SqlParameter("@Catagory_ID", SqlDbType.Int),
                                       };

            sqlParams[0].Value = Catagory_NAME;
            sqlParams[1].Value = ITEM_ID;
            sqlParams[2].Value = Barcode_No;
            sqlParams[3].Value = Unit;
            sqlParams[4].Value = Buying;
            sqlParams[5].Value = Selling;
            sqlParams[6].Value = Item_Discription;
            sqlParams[7].Value = ItemStatus;
            sqlParams[8].Value = DateTime.Now;
            sqlParams[9].Value = Catagory_ID;

            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }
    }
}
