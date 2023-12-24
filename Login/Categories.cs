using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Greencity\Categories.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            conn.Open();
            string query = "select * from categoriesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgcategory.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btncatadd_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string query = "insert into CategoriesTbl values(" + txtcatid.Text + ",'" + txtcatname.Text + "','" + txtcatdesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully!");
                conn.Close();
                populate();
                txtcatid.Text = "";
                txtcatname.Text = "";
                txtcatdesc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void dgcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                /*txtcatid.Text = dgcategory.SelectedRows[0].Cells[0].Value.ToString();
                txtcatname.Text = dgcategory.SelectedRows[0].Cells[1].Value.ToString();
                txtcatdesc.Text = dgcategory.SelectedRows[0].Cells[2].Value.ToString();*/
            
           
          

        }

        private void btncatupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcatid.Text == "" || txtcatname.Text == "" || txtcatdesc.Text == "")
                {
                    MessageBox.Show("Error: Missing Information!");
                }
                else
                {
                    conn.Open();
                    string query = "Update CategoriesTbl set CatName='" + txtcatname.Text + "',Catdesc='" + txtcatdesc.Text + "' where CatId=" + txtcatid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Has Been Updated Successfully!");
                    conn.Close();
                    populate();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncatdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcatid.Text == "")
                {
                    MessageBox.Show("Error: Select CatId to Delete!");
                }
                else
                {
                    conn.Open();
                    string query = "delete from CategoriesTbl where CatId= " + txtcatid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Has Been Deleted Successfully!");
                    conn.Close();
                    populate();
                    txtcatid.Text = "";
                    txtcatname.Text = "";
                    txtcatdesc.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void btnadmininventory_Click(object sender, EventArgs e)
        {
            Admininventory objadmin = new Admininventory();
            this.Hide();
            objadmin.Show();
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
    }
}
