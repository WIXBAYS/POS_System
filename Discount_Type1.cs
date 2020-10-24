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

        private void comboBoxItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            SqlDataReader sdr = new Brand().GetBrandDetails(comboBoxItemList.SelectedValue.ToString());
            try
            {
                comboBoxBrand.DataSource = null;
                comboBoxBrand.Items.Clear();

            }
            catch { }
            if (sdr != null)
            {
                while (sdr.Read())
                {
                    data.Add(new KeyValuePair<string, string>(sdr.GetInt32(0).ToString().Trim(), sdr.GetString(1).Trim()));
                }
                sdr.Dispose(); sdr.Close();
                // Clear the combobox



                // Bind the combobox
                comboBoxBrand.DataSource = new BindingSource(data, null);
                comboBoxBrand.DisplayMember = "Value";
                comboBoxBrand.ValueMember = "Key";
                sdr.Dispose();
                sdr.Close();
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
                SqlDataReader sdr = new Brand().GetCategoryDetails(comboBoxBrand.SelectedValue.ToString());
                try
                {
                    comboBoxName.DataSource = null;
                    comboBoxName.Items.Clear();

                }
                catch { }
                if (sdr != null)
                {
                    while (sdr.Read())
                    {
                        data.Add(new KeyValuePair<string, string>(sdr.GetInt32(0).ToString().Trim(), sdr.GetString(1).Trim()));
                    }
                    sdr.Dispose(); sdr.Close();
                    // Clear the combobox



                    // Bind the combobox
                    comboBoxName.DataSource = new BindingSource(data, null);
                    comboBoxName.DisplayMember = "Value";
                    comboBoxName.ValueMember = "Key";
                    sdr.Dispose();
                    sdr.Close();
                }
            }
            catch { }

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
            // TODO: This line of code loads data into the 'pOSDataSetItems.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.pOSDataSetItems.Items);

        }
    }
}
