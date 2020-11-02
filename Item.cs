using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;

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

        public int updateDiscount(Decimal DISCOUNT,String DISCOUNT_TYPE,DateTime DISCOUNT_FROM,DateTime DISCOUNT_TO,Boolean DISCOUNT_PERIOADICALLY,String ITEMCAT_ID)
        {
            String selectCommand = "UPDATE [dbo].[Item_Category] SET [DISCOUNT] = @DISCOUNT ,[DISCOUNT_TYPE] = @DISCOUNT_TYPE ,[DISCOUNT_FROM] = @DISCOUNT_FROM ,[DISCOUNT_TO] = @DISCOUNT_TO ,[DISCOUNT_PERIOADICALLY] = @DISCOUNT_PERIOADICALLY WHERE [ITEMCAT_ID]=@ITEMCAT_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@DISCOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_TYPE", SqlDbType.VarChar),
                                            new SqlParameter("@DISCOUNT_FROM", SqlDbType.DateTime),
                                            new SqlParameter("@DISCOUNT_TO", SqlDbType.DateTime),
                                            new SqlParameter("@DISCOUNT_PERIOADICALLY", SqlDbType.Bit),
                                            new SqlParameter("@ITEMCAT_ID", SqlDbType.Int)
                                       };

            sqlParams[0].Value = DISCOUNT;
            sqlParams[1].Value = DISCOUNT_TYPE;
            sqlParams[2].Value = DISCOUNT_FROM;
            sqlParams[3].Value = DISCOUNT_TO;
            sqlParams[4].Value = DISCOUNT_PERIOADICALLY;
            sqlParams[5].Value = ITEMCAT_ID;

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

        public int insertItemCategory(String Category_NAME, String BRAND_ID, String Barcode_No, String Unit, decimal Buying, decimal Selling, String Item_Discription, Boolean ItemStatus, decimal Discount, String Discount_Type, String Item_ID, String Category_NAME_UNICODE)
        {
            String selectCommand = "INSERT INTO [dbo].[Item_Category]([CATEGORY_NAME],[BRAND_ID],[BARCODE],[UNIT],[BUYING_COST],[SELLING_COST],[CAT_DISCRIPTION],[CAT_STATUS],[ENTERDE_DATE],[DISCOUNT]  ,[DISCOUNT_TYPE],[ITEM_ID],[CATEGORY_NAME_UNICODE])VALUES(N'" + Category_NAME + "', @BRAND_ID, @Barcode_No, @Unit, @Buying, @Selling, @Item_Discription, @ItemStatus, @EnteredDate, @DISCOUNT,@DISCOUNT_TYPE, @ITEM_ID,N'"+ Category_NAME_UNICODE + "')";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Category_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@BRAND_ID", SqlDbType.Int),
                                            new SqlParameter("@Barcode_No", SqlDbType.VarChar),
                                            new SqlParameter("@Unit", SqlDbType.VarChar),
                                            new SqlParameter("@Buying", SqlDbType.Decimal),
                                            new SqlParameter("@Selling", SqlDbType.Decimal),
                                            new SqlParameter("@Item_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                            new SqlParameter("@EnteredDate", SqlDbType.DateTime),
                                            new SqlParameter("@DISCOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_TYPE", SqlDbType.VarChar),
                                            new SqlParameter("@ITEM_ID", SqlDbType.Int),
                                            new SqlParameter("@CATEGORY_NAME_UNICODE", SqlDbType.VarChar) 
                                       };

            sqlParams[0].Value = Category_NAME;
            sqlParams[1].Value = BRAND_ID;
            sqlParams[2].Value = Barcode_No;
            sqlParams[3].Value = Unit;
            sqlParams[4].Value = Buying;
            sqlParams[5].Value = Selling;
            sqlParams[6].Value = Item_Discription;
            sqlParams[7].Value = ItemStatus;
            sqlParams[8].Value = DateTime.Now;
            sqlParams[9].Value = Discount;
            sqlParams[10].Value = Discount_Type;
            sqlParams[11].Value = Item_ID;
            sqlParams[12].Value = Category_NAME_UNICODE;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetItemCatagoryDetails(String Catagory_ID)
        {
            String query = "SELECT Item_Category.BARCODE, Item_Category.CATEGORY_NAME, Item_Category.CAT_DISCRIPTION, Item_Category.UNIT, Item_Category.BUYING_COST, Item_Category.SELLING_COST,Item_Category.CAT_STATUS, Items.ITEM_NAME,Item_Category.DISCOUNT,Item_Category.DISCOUNT_TYPE,BRAND.BRAND_NAME,BRAND.BRAND_ID,DISCOUNT_FROM,DISCOUNT_TO,DISCOUNT_PERIOADICALLY,CATEGORY_NAME_UNICODE FROM Item_Category INNER JOIN Brand ON Brand.BRAND_ID=Item_Category.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Item_Category.ITEM_ID where Item_Category.ITEMCAT_ID = @ItemCatID";
            SqlParameter sqlParam = new SqlParameter("@ItemCatID", SqlDbType.Int);
            sqlParam.Value = Catagory_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
        public SqlDataReader GetItemCatagoryDetailsByBrand(String Brand_ID)
        {
            String query = "SELECT Items.ITEM_NAME, Item_Category.CATEGORY_NAME, Item_Category.CAT_DISCRIPTION, Item_Category.UNIT, Item_Category.BUYING_COST, Item_Category.SELLING_COST,Item_Category.CAT_STATUS, Item_Category.DISCOUNT,Item_Category.DISCOUNT_TYPE,BRAND.BRAND_NAME,BRAND.BRAND_ID,[DISCOUNT_FROM]  ,[DISCOUNT_TO]  ,[DISCOUNT_PERIOADICALLY],Item_Category.ITEMCAT_ID FROM Item_Category INNER JOIN Brand ON Brand.BRAND_ID=Item_Category.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Item_Category.ITEM_ID where Item_Category.BRAND_ID = @Brand_ID";
            SqlParameter sqlParam = new SqlParameter("@Brand_ID", SqlDbType.Int);
            sqlParam.Value = Brand_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public SqlDataReader GetItemCatagoryDetails_Combobox(String Item_ID, String Brand_ID)
        {
            String query = "SELECT Item_Category.ITEMCAT_ID, Item_Category.CATEGORY_NAME   FROM  [dbo].[Item_Category] where Item_Category.ITEM_ID = @ItemID AND Item_Category.BRAND_ID = @BrandID";
            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@ItemID", SqlDbType.Int),
                                            new SqlParameter("@BrandID", SqlDbType.Int),
            };
        
            sqlParams[0].Value = Item_ID;
            sqlParams[1].Value = Brand_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParams);
        }

        public SqlDataReader GetMaxCatID()
        {
            String query = "SELECT MAX([ITEMCAT_ID]) FROM [dbo].[Item_Category]";
            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public int updateItemCategory(String Category_NAME, String BRAND_ID, String Barcode_No, String Unit, Decimal Buying, Decimal Selling, String Item_Discription, Boolean ItemStatus, String Catagory_ID, Decimal Discount, String Discount_Type, String Item_ID, String Category_NAME_UNICODE)
        {
            String selectCommand = "UPDATE [dbo].[Item_Category] SET [CATEGORY_NAME] = N'"+ Category_NAME + "', [BRAND_ID] = @BRAND_ID, BARCODE = @Barcode_No, [UNIT] = @Unit, [BUYING_COST] = @Buying, [SELLING_COST]= @Selling ,[CAT_DISCRIPTION] = @Catagory_Discription ,[CAT_STATUS] = @ItemStatus , [UPDATED_DATE] = @UpdateddDate, [DISCOUNT]=@DISCOUNT, [DISCOUNT_TYPE]=@DISCOUNT_TYPE, [ITEM_ID]=@ITEM_ID,  [CATEGORY_NAME_UNICODE] = N'"+ Category_NAME_UNICODE + "' WHERE [ITEMCAT_ID] = @Catagory_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Category_NAME", SqlDbType.Text),
                                            new SqlParameter("@BRAND_ID", SqlDbType.Int),
                                            new SqlParameter("@Barcode_No", SqlDbType.VarChar),
                                            new SqlParameter("@Unit", SqlDbType.Text),
                                            new SqlParameter("@Buying", SqlDbType.Decimal),
                                            new SqlParameter("@Selling", SqlDbType.Decimal),
                                            new SqlParameter("@Catagory_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                            new SqlParameter("@UpdateddDate", SqlDbType.DateTime),
                                            new SqlParameter("@Catagory_ID", SqlDbType.Int),
                                            new SqlParameter("@DISCOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_TYPE", SqlDbType.VarChar),
                                            new SqlParameter("@ITEM_ID", SqlDbType.Int),
                                            new SqlParameter("@CATEGORY_NAME_UNICODE", SqlDbType.VarChar)
                                       };

            sqlParams[0].Value = Category_NAME;
            sqlParams[1].Value = BRAND_ID;
            sqlParams[2].Value = Barcode_No;
            sqlParams[3].Value = Unit;
            sqlParams[4].Value = Buying;
            sqlParams[5].Value = Selling;
            sqlParams[6].Value = Item_Discription;
            sqlParams[7].Value = ItemStatus;
            sqlParams[8].Value = DateTime.Now;
            sqlParams[9].Value = Catagory_ID;
            sqlParams[10].Value = Discount;
            sqlParams[11].Value = Discount_Type;
            sqlParams[12].Value = Item_ID;
            sqlParams[13].Value = Category_NAME_UNICODE;

            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }

        public int insertStockBalanceDefault(int Category_ID, Decimal Balance)
        {
            String selectCommand = "INSERT INTO [dbo].[Stock_Balance]([ITEMCAT_ID],[BALANCE])VALUES(@Category_ID,@Balance)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Category_ID", SqlDbType.Int),
                                            new SqlParameter("@Balance", SqlDbType.Decimal),                                   
                                       };

            sqlParams[0].Value = Category_ID;
            sqlParams[1].Value = Balance;


            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetCategoryDetailsByBarcode(String Barcode)
        {
            String query = "SELECT Item_Category.BARCODE, Item_Category.CATEGORY_NAME, Item_Category.ITEMCAT_ID, Item_Category.UNIT, Item_Category.BUYING_COST, Item_Category.SELLING_COST, Items.ITEM_NAME,Item_Category.DISCOUNT ,Item_Category.DISCOUNT_TYPE,BRAND.BRAND_NAME,DISCOUNT_FROM,DISCOUNT_TO,DISCOUNT_PERIOADICALLY FROM Item_Category INNER JOIN Brand ON Brand.BRAND_ID=Item_Category.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Item_Category.ITEM_ID  where Item_Category.BARCODE = @Barcode and Item_Category.CAT_STATUS = 1";
            SqlParameter sqlParam = new SqlParameter("@Barcode", SqlDbType.VarChar);
            sqlParam.Value = Barcode;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public SqlDataReader GetCategoryDetailsByBarcodeAll(String Barcode)
        {
            String query = "SELECT Item_Category.BARCODE, Item_Category.CATEGORY_NAME, Item_Category.CAT_DISCRIPTION, Item_Category.UNIT, Item_Category.BUYING_COST, Item_Category.SELLING_COST,Item_Category.CAT_STATUS, Items.ITEM_NAME,Item_Category.DISCOUNT,Item_Category.DISCOUNT_TYPE,BRAND.BRAND_NAME,BRAND.BRAND_ID FROM Item_Category INNER JOIN Brand ON Brand.BRAND_ID=Item_Category.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Item_Category.ITEM_ID where Item_Category.BARCODE = @Barcode";
            SqlParameter sqlParam = new SqlParameter("@Barcode", SqlDbType.VarChar);
            sqlParam.Value = Barcode;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
    }
}
