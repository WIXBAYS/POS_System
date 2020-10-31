using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Discount_Type1 : Form
    {
        public Discount_Type1()
        {
            InitializeComponent();
        }




        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Discount_Type1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSetBrand.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.pOSDataSetBrand.Brand);
            // TODO: This line of code loads data into the 'pOSDataSetItems.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.pOSDataSetItems.Items);

        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BrandID = comboBoxBrand.SelectedValue.ToString().Trim();
            SqlDataReader sdrsec = new Item().GetItemCatagoryDetailsByBrand(BrandID);
            if (sdrsec != null)
            {
                try
                {
                    String DiscountCol = "";
                    String CategoryName = "";
                    string CategoryTD = "";
                    String ItemName = "";
                    String Unit = "";
                    Decimal Buying_Cost = 0.0m;
                    Decimal Selling_Cost = 0.0m;
                    dataGridViewAll.Rows.Clear();
                    while (sdrsec.Read())
                    {
                        String DiscountFromCol = "";
                        String DiscountToCol = "";
                        ItemName = sdrsec.GetString(0).Trim();
                        CategoryName = sdrsec.GetString(1).Trim();
                        Unit = sdrsec.GetString(3).Trim();
                        Buying_Cost = sdrsec.GetDecimal(4);
                        Selling_Cost = sdrsec.GetDecimal(5);
                        Decimal DiscountAmount = sdrsec.GetDecimal(7);
                        String DiscountType = sdrsec.GetString(8).ToString().Trim();
                        DateTime DiscountFrom= sdrsec.GetDateTime(11);
                        DateTime DiscountTo = sdrsec.GetDateTime(12);
                        bool DiscountPrdcly = sdrsec.GetBoolean(13);
                        CategoryTD = sdrsec.GetInt32(14).ToString().Trim();
                        if (!DiscountPrdcly || (DateTime.Now.Date >= DiscountFrom || DateTime.Now.Date <= DiscountTo))
                        {
                            if (DiscountType.Equals("AMNT"))
                            {
                                DiscountCol = DiscountAmount + "/=";
                            }
                            if (DiscountType.Equals("PR"))
                            {
                                DiscountCol = DiscountAmount + "%";
                            }
                            if (DiscountFrom != DateTime.Parse("1900-01-01") && DiscountPrdcly) DiscountFromCol = DiscountFrom.ToShortDateString();
                            if (DiscountTo != DateTime.Parse("1900-01-01") && DiscountPrdcly) DiscountToCol = DiscountTo.ToShortDateString();
                            dataGridViewAll.Rows.Add(true, CategoryTD, ItemName, CategoryName, Unit, DiscountCol, DiscountFromCol, DiscountToCol);
                        }
                        else
                        {
                            dataGridViewAll.Rows.Add(true, CategoryTD, ItemName, CategoryName, Unit, 0.0m, "", "");
                        }
                        
                    }
                }
                catch { }
            }
        }

        private void checkBoxPeriodically_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeriodically.Checked)
            {
                labelDiscountFrom.Visible = true;
                labelDiscountTo.Visible = true;
                dateTimePickerDiscountFrom.Visible = true;
                dateTimePickerDiscountTo.Visible = true;
            }
            else
            {
                labelDiscountFrom.Visible = false;
                labelDiscountTo.Visible = false;
                dateTimePickerDiscountFrom.Visible = false;
                dateTimePickerDiscountTo.Visible = false;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            DateTime DiscountFrom = DateTime.Parse("1900-01-01");
            DateTime DiscountTo = DateTime.Parse("1900-01-01");
            Decimal Discount = decimal.Parse(textBoxDiscount.Text);
            String DiscountType = comboBoxDiscountType.SelectedItem.ToString();
            Boolean Periodically = false;
            if (checkBoxPeriodically.Checked)
            {
                DiscountFrom = dateTimePickerDiscountFrom.Value;
                DiscountTo = dateTimePickerDiscountTo.Value;
            }
            for (int i = 0; i < dataGridViewAll.Rows.Count; ++i)
            {
                if (Convert.ToBoolean(dataGridViewAll.Rows[i].Cells[0].Value))
                {
                    string catID = (dataGridViewAll.Rows[i].Cells[1].Value).ToString();
                    int success=item.updateDiscount(Discount, DiscountType, DiscountFrom, DiscountTo, checkBoxPeriodically.Checked, catID);
                    
                }
            }
            
                MessageBox.Show("Successfully Saved");
            
        }
    }
}
