using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Dispose();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //UserManage um = new UserManage();
            //um.MdiParent = this;
            //um.Text = "User Manage";
            //um.WindowState= System.Windows.Forms.FormWindowState.Normal;
            //um.Show();

            UserManage childForm = new UserManage();
            childForm.ShowDialog(this);
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vendor_Management vm = new Vendor_Management();
            //vm.MdiParent = this;
            //vm.WindowState = System.Windows.Forms.FormWindowState.Normal;

            //vm.Show();


            Vendor_Management childForm = new Vendor_Management();
            childForm.ShowDialog(this);
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category_Management childForm = new Category_Management();
            childForm.ShowDialog(this);
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Management childForm = new Item_Management();
            childForm.ShowDialog(this);
        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GNR grn = new GNR();
            grn.ShowDialog(this);
        }

        private void DiscountType1MenuItem_Click(object sender, EventArgs e)
        {
            Discount_Type1 dis1 = new Discount_Type1();
            dis1.ShowDialog(this);
        }
        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Invoice invoi = new Invoice();
            //invoi.ShowDialog(this);

            Invoice cf = new Invoice();
            cf.MdiParent = this;
            cf.ClientSize = new System.Drawing.Size(2000, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cf.Dock = DockStyle.Fill;
            cf.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Report str = new Stock_Report();
            str.ShowDialog(this);
        }

        private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daily_Sales str = new Daily_Sales();
            str.ShowDialog(this);
        }

        private void gRNReprtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GRN_Report GRN_Report = new GRN_Report(0);
            GRN_Report.ShowDialog(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Dispose();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandRegistration brandwin = new BrandRegistration();
            brandwin.ShowDialog(this);
        }

        private void discountForTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Discount_Type2 childForm = new Discount_Type2();
            childForm.ShowDialog(this);
        }
    }
}
