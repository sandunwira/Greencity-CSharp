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

namespace Login
{
    public partial class Admininventory : Form
    {
        public Admininventory()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Greencity\Categories.mdf;Integrated Security=True;Connect Timeout=30");


        private void btnpradd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into ProductTbl values(" + txtprid.Text + ",'" + txtprname.Text + "'," + txtprquant.Text + "," + txtprprice.Text + ",'" + cbprcategory.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully!");
                conn.Close();
                populate();
                txtprid.Text = "";
                txtprname.Text = "";
                txtprquant.Text = "";
                txtprprice.Text = "";
            }
            catch (Exception ex)  
            { 
               MessageBox.Show(ex.Message);
            }
        }

        private void FillCategory()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CatName from CategoriesTbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            cbprcategory.ValueMember = "CatName";
            cbprcategory.DataSource = dt;
            cbprcategory.ValueMember = "CatName";
            cbprcategory.DataSource = dt;          
            conn.Close();

        }
        
        private void populate()
        {
            conn.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgcategory.DataSource = ds.Tables[0];
            conn.Close();
        }


        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmlogin objlogout = new frmlogin();
            this.Hide();
            objlogout.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
       

        private void btnadmincategory_Click(object sender, EventArgs e)
        {
            Categories objcat = new Categories();
            this.Hide();
            objcat.Show();
        }

        private void btnadmincashier_Click(object sender, EventArgs e)
        {
            Cashiers objcash = new Cashiers();  
            this.Hide();
            objcash.Show(); 
        }

        private void btnadminsales_Click(object sender, EventArgs e)
        {
            Sales objsale = new Sales();
            this.Hide();
            objsale.Show(); 
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           
            populate();
        }

        private void dgcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* txtprid.Text = dgcategory.SelectedRows[0].Cells[0].Value.ToString();
            txtprname.Text = dgcategory.SelectedRows[0].Cells[1].Value.ToString();
            txtprquant.Text = dgcategory.SelectedRows[0].Cells[2].Value.ToString();
            txtprprice.Text = dgcategory.SelectedRows[0].Cells[3].Value.ToString(); 
            cbprcategory.SelectedValue = dgcategory.SelectedRows[0].Cells[4].Value.ToString();*/
        }

        private void btnprupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtprid.Text == "" || txtprname.Text == "" || txtprquant.Text == "" || txtprprice.Text == "")
                {
                    MessageBox.Show("Error: Missing Information!");
                }
                else
                {
                    conn.Open();
                    string query = "update ProductTbl set ProdName='" + txtprname.Text + "',ProdQty=" + txtprquant.Text + ",ProdPrice=" + txtprprice.Text + ",ProdCat='" + cbprcategory.SelectedValue.ToString() + "' where ProdId=" + txtprid.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated!");
                    conn.Close();
                    populate();
                    txtprid.Text = "";
                    txtprname.Text = "";
                    txtprquant.Text = "";
                    txtprprice.Text = "";
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnprdelete_Click(object sender, EventArgs e)
        {
            try 
            { 
               if (txtprid.Text == "")
                {
                    MessageBox.Show("Error: Select The Product To Delete!");
                }
               else
                {
                    conn.Open();
                    string query = "Delete from ProductTbl where ProdId=" + txtprid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully!");
                    conn.Close();
                    populate();
                    txtprid.Text = "";
                    txtprname.Text = "";
                    txtprquant.Text = "";
                    txtprprice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from ProductTbl where ProdCat='" + cbprcategory.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgcategory.DataSource = ds.Tables[0];
            conn.Close();
             
           
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cbprcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            FillCategory();
        }

        private void abc(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select ProdId,ProdName,ProdQty,ProdPrice,ProdCat from ProductTbl where ProdCat='" + cbprcategory.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgcategory.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
