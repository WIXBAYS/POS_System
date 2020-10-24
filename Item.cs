﻿using System;
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

        public int insertItemCatagory(String Catagory_NAME, String BRAND_ID, String Barcode_No, String Unit, decimal Buying, decimal Selling, String Item_Discription, Boolean ItemStatus, decimal Discount, String Discount_Type)
        {
            String selectCommand = "INSERT INTO [dbo].[Item_Catagory]([CATAGORY_NAME],[BRAND_ID],[BARCODE],[UNIT],[BUYING_COST],[SELLING_COST],[CAT_DISCRIPTION],[CAT_STATUS],[ENTERDE_DATE],[DISCOUNT]  ,[DISCOUNT_TYPE])VALUES(@Catagory_NAME, @BRAND_ID, @Barcode_No, @Unit, @Buying, @Selling, @Item_Discription, @ItemStatus, @EnteredDate, @DISCOUNT,@DISCOUNT_TYPE)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Catagory_NAME", SqlDbType.VarChar),
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
                                       };

            sqlParams[0].Value = Catagory_NAME;
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

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetItemCatagoryDetails(String Catagory_ID)
        {
            String query = "SELECT Item_Catagory.BARCODE, Item_Catagory.CATAGORY_NAME, Item_Catagory.CAT_DISCRIPTION, Item_Catagory.UNIT, Item_Catagory.BUYING_COST, Item_Catagory.SELLING_COST,Item_Catagory.CAT_STATUS, Items.ITEM_NAME,Item_Catagory.DISCOUNT,Item_Catagory.DISCOUNT_TYPE,BRAND.BRAND_NAME,BRAND.BRAND_ID FROM Item_Catagory INNER JOIN Brand ON Brand.BRAND_ID=Item_Catagory.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Brand.ITEM_ID where Item_Catagory.ITEMCAT_ID = @ItemCatID";
            SqlParameter sqlParam = new SqlParameter("@ItemCatID", SqlDbType.Int);
            sqlParam.Value = Catagory_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public SqlDataReader GetMaxCatID()
        {
            String query = "SELECT MAX([ITEMCAT_ID]) FROM [dbo].[Item_Catagory]";
            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query);
        }

        public int updateItemCatagory(String Catagory_NAME, String BRAND_ID, String Barcode_No, String Unit, Decimal Buying, Decimal Selling, String Item_Discription, Boolean ItemStatus, String Catagory_ID, Decimal Discount, String Discount_Type)
        {
            String selectCommand = "UPDATE [dbo].[Item_Catagory] SET [CATAGORY_NAME] = @Catagory_NAME, [BRAND_ID] = @BRAND_ID, BARCODE = @Barcode_No, [UNIT] = @Unit, [BUYING_COST] = @Buying, [SELLING_COST]= @Selling ,[CAT_DISCRIPTION] = @Catagory_Discription ,[CAT_STATUS] = @ItemStatus , [UPDATED_DATE] = @UpdateddDate, [DISCOUNT]=@DISCOUNT, [DISCOUNT_TYPE]=@DISCOUNT_TYPE WHERE [ITEMCAT_ID] = @Catagory_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Catagory_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@BRAND_ID", SqlDbType.Int),
                                            new SqlParameter("@Barcode_No", SqlDbType.VarChar),
                                            new SqlParameter("@Unit", SqlDbType.VarChar),
                                            new SqlParameter("@Buying", SqlDbType.Decimal),
                                            new SqlParameter("@Selling", SqlDbType.Decimal),
                                            new SqlParameter("@Catagory_Discription", SqlDbType.VarChar),
                                            new SqlParameter("@ItemStatus", SqlDbType.Bit),
                                            new SqlParameter("@UpdateddDate", SqlDbType.DateTime),
                                            new SqlParameter("@Catagory_ID", SqlDbType.Int),
                                            new SqlParameter("@DISCOUNT", SqlDbType.Decimal),
                                            new SqlParameter("@DISCOUNT_TYPE", SqlDbType.VarChar)
                                       };

            sqlParams[0].Value = Catagory_NAME;
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

            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }

        public int insertStockBalanceDefault(int Catagory_ID, Decimal Balnce)
        {
            String selectCommand = "INSERT INTO [dbo].[Stock_Balance]([ITEMCAT_ID],[BALANCE])VALUES(@Catagory_ID,@Balance)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@Catagory_ID", SqlDbType.Int),
                                            new SqlParameter("@Balance", SqlDbType.Decimal),                                   
                                       };

            sqlParams[0].Value = Catagory_ID;
            sqlParams[1].Value = Balnce;


            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetCatagoryDetailsByBarcode(String Barcode)
        {
            String query = "SELECT Item_Catagory.BARCODE, Item_Catagory.CATAGORY_NAME, Item_Catagory.ITEMCAT_ID, Item_Catagory.UNIT, Item_Catagory.BUYING_COST, Item_Catagory.SELLING_COST, Items.ITEM_NAME,Item_Catagory.DISCOUNT ,Item_Catagory.DISCOUNT_TYPE,BRAND.BRAND_NAME FROM Item_Catagory INNER JOIN Brand ON Brand.BRAND_ID=Item_Catagory.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Brand.ITEM_ID  where Item_Catagory.BARCODE = @Barcode and Item_Catagory.CAT_STATUS = 1";
            SqlParameter sqlParam = new SqlParameter("@Barcode", SqlDbType.VarChar);
            sqlParam.Value = Barcode;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public SqlDataReader GetCatagoryDetailsByBarcodeAll(String Barcode)
        {
            String query = "SELECT Item_Catagory.BARCODE, Item_Catagory.CATAGORY_NAME, Item_Catagory.CAT_DISCRIPTION, Item_Catagory.UNIT, Item_Catagory.BUYING_COST, Item_Catagory.SELLING_COST,Item_Catagory.CAT_STATUS, Items.ITEM_NAME,Item_Catagory.DISCOUNT,Item_Catagory.DISCOUNT_TYPE,BRAND.BRAND_NAME,BRAND.BRAND_ID FROM Item_Catagory INNER JOIN Brand ON Brand.BRAND_ID=Item_Catagory.BRAND_ID INNER JOIN Items ON Items.ITEM_ID = Brand.ITEM_ID where Item_Catagory.BARCODE = @Barcode";
            SqlParameter sqlParam = new SqlParameter("@Barcode", SqlDbType.VarChar);
            sqlParam.Value = Barcode;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
    }
}
