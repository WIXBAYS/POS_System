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
            String query = "SELECT   [BRAND_ID]  ,[BRAND_NAME]   FROM  [dbo].[Brand] WHERE [ITEM_ID]=@ITEM_ID";
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
    }
}
