using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Item_Management : Form
    {

        public Item_Management()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Item_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetItems.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.pOSDataSetItems.Items);
            buttonsave.Hide();
            button_update.Show();
            textBoxName.Hide();
            comboBoxName.Show();
            textBoxNameUpdate.Show();

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBy(this.pOSDataSetItems.Items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkBox_new_CheckedChanged(object sender, EventArgs e)
        {       
            if (checkBox_new.Checked == true)
            {
                textBoxName.Show();
                comboBoxName.Hide();
                button_update.Hide();
                buttonsave.Show();
                textBoxNameUpdate.Hide();
                TextClear();
                checkBoxActive.Checked = true;
            }
            else
            {
                buttonsave.Hide();
                button_update.Show();
                textBoxName.Hide();
                comboBoxName.Show();
                textBoxNameUpdate.Show();
                TextClear();
            }         
        }

        private void TextClear()
        {
            textBoxName.Clear();
            textBoxLineDiscription.Clear();
            textBoxNameUpdate.Clear();
            checkBoxActive.Checked = false;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {

                DataInsertManager DIM = new DataInsertManager();
                bool checkedstatus = false;
                if(checkBoxActive.Checked == true)
                {
                    checkedstatus = true;
                }

                SqlParameter[] parraarray = new SqlParameter[3];
                string query = "INSERT INTO[dbo].[Items]([ITEM_NAME],[ITEM_DISCRIPTION],[ITEM_STATUS])VALUES(@ITEM_NAME, @Item_Discription, @ItemStatus)";

                SqlParameter sqlParamname = new SqlParameter("@ITEM_NAME", SqlDbType.VarChar);
                sqlParamname.Value = textBoxName.Text;
                parraarray[0] = sqlParamname;
                SqlParameter sqlParamdescrip = new SqlParameter("@Item_Discription", SqlDbType.VarChar);
                sqlParamdescrip.Value = textBoxLineDiscription.Text;
                parraarray[1] = sqlParamdescrip;
                SqlParameter sqlParamstatus = new SqlParameter("@ItemStatus", SqlDbType.Bit);
                sqlParamstatus.Value = checkedstatus;
                parraarray[2] = sqlParamstatus;

                int x = DIM.insertRecord(query,ref parraarray);

                if (x>0)
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Successfully Created");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonsave.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();

                }
                else
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Creating Error");
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (TextVAlidation())
            {

                SqlParameter[] parraarray = new SqlParameter[4];
                DataUpdateManager DUM = new DataUpdateManager();

                bool checkedstatus = false;
                if (checkBoxActive.Checked == true)
                {
                    checkedstatus = true;
                }

                string query = "UPDATE [dbo].[Items] SET [ITEM_NAME] = @ITEM_NAME ,[ITEM_DISCRIPTION] = @Item_Discription ,[ITEM_STATUS] = @ItemStatus WHERE [ITEM_ID] = @Item_ID";
                SqlParameter sqlParamname = new SqlParameter("@ITEM_NAME", SqlDbType.VarChar);
                sqlParamname.Value = textBoxNameUpdate.Text;
                parraarray[0] = sqlParamname;
                SqlParameter sqlParamdescrip = new SqlParameter("@Item_Discription", SqlDbType.VarChar);
                sqlParamdescrip.Value = textBoxLineDiscription.Text;
                parraarray[1] = sqlParamdescrip;
                SqlParameter sqlParamstatus = new SqlParameter("@ItemStatus", SqlDbType.Bit);
                sqlParamstatus.Value = checkedstatus;
                parraarray[2] = sqlParamstatus;
                SqlParameter sqlParamsItemID = new SqlParameter("@Item_ID", SqlDbType.Int);
                sqlParamsItemID.Value = comboBoxName.SelectedValue.ToString();
                parraarray[3] = sqlParamsItemID;

                int x = DUM.updateRecord(query, ref parraarray);
            
                if (x>0)
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Successfully Updated");
                    TextClear();
                    checkBox_new.Checked = false;
                    buttonsave.Hide();
                    button_update.Show();
                    textBoxName.Hide();
                    comboBoxName.Show();
                    textBoxNameUpdate.Show();
                    comboBoxName.Refresh();
                }
                else
                {
                    MessageBox.Show("Item " + textBoxName.Text + " Updating Error");
                }
            }
        }

        private bool TextVAlidation()
        {
            bool valid = true;

            if (checkBox_new.Checked == true)
            {
                if (textBoxName.Text.Trim() == String.Empty)
                {
                    textBoxName.BackColor = Color.LightPink;
                    valid = false;
                }
                else
                    textBoxName.BackColor = Color.White;
            }
            else
            {
                if (textBoxNameUpdate.Text.Trim() == String.Empty)
                {
                    textBoxNameUpdate.BackColor = Color.LightPink;
                    valid = false;
                }
                else
                    textBoxNameUpdate.BackColor = Color.White;
            }

            if (textBoxLineDiscription.Text.Trim() == String.Empty)
            {
                textBoxLineDiscription.BackColor = Color.LightPink;
                valid = false;
            }
            else
                textBoxLineDiscription.BackColor = Color.White;

            return valid;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Item_ID = "";
                if (comboBoxName.Text != "")
                    Item_ID = comboBoxName.SelectedValue.ToString();

                String query = "SELECT [ITEM_NAME],[ITEM_DISCRIPTION],[ITEM_STATUS] FROM [dbo].[Items] where [ITEM_ID]=@Item_ID";
                SqlParameter sqlParam = new SqlParameter("@Item_ID", SqlDbType.Int);
                sqlParam.Value = Item_ID;

                DataReaderManager DRM = new DataReaderManager();
                SqlDataReader sqd = DRM.getDataReader(query, ref sqlParam);

                if (sqd != null)
                {
                    while (sqd.Read())

                    {
                        textBoxNameUpdate.Text = sqd.GetString(0).ToString();
                        textBoxLineDiscription.Text = sqd.GetString(1);
                        checkBoxActive.Checked = sqd.GetBoolean(2);                     
                        comboBoxName.Refresh();
                    }
                    sqd.Close();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
