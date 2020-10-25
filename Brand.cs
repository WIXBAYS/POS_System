using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace POS
{
    class Brand
    {
        public SqlDataReader GetBrandDetails(String Item_ID)
        {
            String query = "SELECT [BRAND_ID],[BRAND_NAME],[BRAND_STATUS]  FROM  [dbo].[Brand] WHERE [ITEM_ID]=@ITEM_ID";
            SqlParameter sqlParam = new SqlParameter("@Item_ID", SqlDbType.Int);
            sqlParam.Value = Item_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
        public SqlDataReader GetCategoryDetails(String BRAND_ID)
        {
            String query = "SELECT   [ITEMCAT_ID]  ,[CATAGORY_NAME]   FROM  [dbo].[Item_Catagory] WHERE [BRAND_ID]=@BRAND_ID";
            SqlParameter sqlParam = new SqlParameter("@BRAND_ID", SqlDbType.Int);
            sqlParam.Value = BRAND_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }

        public int insertBrand(String Brand_NAME, String Brand_Discription, Boolean BrandStatus)
        {
            String selectCommand = "INSERT INTO[dbo].[Brand]([BRAND_NAME],[BRAND_DISCRIPTION],[BRAND_STATUS])VALUES(@BRAND_NAME, @BRAND_DISCRIPTION, @BRAND_STATUS)";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@BRAND_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@BRAND_DISCRIPTION", SqlDbType.VarChar),
                                            new SqlParameter("@BRAND_STATUS", SqlDbType.Bit),
                                       };

            sqlParams[0].Value = Brand_NAME;
            sqlParams[1].Value = Brand_Discription;
            sqlParams[2].Value = BrandStatus;

            DataInsertManager dim = new DataInsertManager();
            return dim.insertRecord(selectCommand, ref sqlParams);
        }

        public int updateBrand(String Name, String Discription, Boolean Brand_STATUS, String Brand_ID)
        {
            String selectCommand = "UPDATE [dbo].[Brand] SET [BRAND_NAME] = @BRAND_NAME ,[BRAND_DISCRIPTION] = @BRAND_DISCRIPTION ,[BRAND_STATUS] = @BRAND_STATUS WHERE [BRAND_ID] = @BRAND_ID";

            SqlParameter[] sqlParams = new SqlParameter[] {
                                            new SqlParameter("@BRAND_NAME", SqlDbType.VarChar),
                                            new SqlParameter("@BRAND_DISCRIPTION", SqlDbType.VarChar),
                                            new SqlParameter("@BRAND_STATUS", SqlDbType.Bit),
                                            new SqlParameter("@BRAND_ID", SqlDbType.Int)
                                       };

            sqlParams[0].Value = Name;
            sqlParams[1].Value = Discription;
            sqlParams[2].Value = Brand_STATUS;
            sqlParams[3].Value = Brand_ID;

            DataUpdateManager dum = new DataUpdateManager();
            return dum.updateRecord(selectCommand, ref sqlParams);
        }

        public SqlDataReader GetBrandDetailsbyID(String Brand_ID)
        {
            String query = "SELECT [BRAND_NAME],[BRAND_DISCRIPTION],[BRAND_STATUS] FROM [dbo].[Brand] where [BRAND_ID] = @BRAND_ID";
            SqlParameter sqlParam = new SqlParameter("@BRAND_ID", SqlDbType.Int);
            sqlParam.Value = Brand_ID;

            DataReaderManager drm = new DataReaderManager();
            return drm.getDataReader(query, ref sqlParam);
        }
    }
}
