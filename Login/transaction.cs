using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Greencity\Categories.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            conn.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dginventory.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void populatebills()
        {
            conn.Open();
            string query = "select * from BillsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgsales.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text == "" || txtProdQty.Text == "")
            {
                MessageBox.Show("Error: Some Information is Missing!");
            }
            else
            {
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgcart);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtProdName.Text;
                newRow.Cells[2].Value = txtPrice.Text;
                newRow.Cells[3].Value = txtProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtProdQty.Text);
                dgcart.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                lblValue.Text = "" + GrdTotal;
            }

        }

        private void transaction_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCategory();
            lblCashierName.Text = frmlogin.CashierName;
            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            
        }

        private void dginventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtProdName.Text = dginventory.SelectedRows[0].Cells[0].ToString();
            txtProdQty.Text = dginventory.SelectedRows[0].Cells[1].ToString();*/

        }

        int GrdTotal = 0, n = 0;

        private void lblDate_Click(object sender, EventArgs e)
        {
            
        }

        private void FillCategory()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Catname from CategoriesTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            cbprcategory.ValueMember = "CatName";
            cbprcategory.DataSource = dt;
            dt.Load(rdr);
            conn.Close();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("GreenCity SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill Id:" + dgsales.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Cashier Name:" + dgsales.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Bill Date:" + dgsales.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + dgsales.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (PrintPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument.Print();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBill.Text == "")
            {
                MessageBox.Show("Error: Enter Bill ID!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into BillsTbl values(" + textBill.Text + ",'" + lblCashierName.Text + "','" + lblDate.Text + "'," + lblValue.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully!");
                    conn.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

      

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBill.Text == "")
                {
                    MessageBox.Show("Error: Select the Order to Delete!");
                }
                else
                {
                    conn.Open();
                    string query = "delete from BillsTbl where BillId=" + textBill.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Deleted Successfully!");
                    conn.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCashierName_Click(object sender, EventArgs e)
        {

        }

        private void dgcart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void lblValue_Click(object sender, EventArgs e)
        {
           
        }

        private void PrintPreviewDialog_Load(object sender, EventArgs e)
        {

        }

        private void cbprcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select ProdName,Prodqty from ProductTbl Where ProdCat='" + cbprcategory.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dginventory.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void dgsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
