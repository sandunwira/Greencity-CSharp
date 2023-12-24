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
    public partial class Cashiers : Form
    {
        public Cashiers()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Greencity\Categories.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void btncatadd_Click(object sender, EventArgs e)
        {
            try
            { 
                conn.Open();
                string query = "insert into CashTbl values(" + txtcashid.Text + ",'" + txtcashname.Text + "'," + txtcashbd.Text + "," + txtcashcontact.Text + ",'" + txtcashpw.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Added Successfully!");
                conn.Close();
                populate();
                txtcashid.Text = "";
                txtcashname.Text = "";
                txtcashbd.Text = "";
                txtcashcontact.Text = "";
                txtcashpw.Text = "";
            }
            catch (Exception ex)  
            { 
                MessageBox.Show(ex.Message);    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcashid.Text == "" || txtcashname.Text == "" || txtcashbd.Text == "" || txtcashcontact.Text == "" || txtcashpw.Text == "") 
                {
                    MessageBox.Show("Error: Missing Information!");
                }
                else
                {
                    conn.Open();
                    string query = "Update CashTbl set CashierName='" + txtcashname.Text + "',CashierAge='" + txtcashbd.Text + "',CashierMobileNo='" + txtcashcontact.Text + "',CashierPassword='" + txtcashpw.Text +"' where CashierId=" + txtcashid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Successfully Updated!");
                    conn.Close();
                    txtcashid.Text = "";
                    txtcashname.Text = "";
                    txtcashbd.Text = "";
                    txtcashcontact.Text = "";
                    txtcashpw.Text = "";
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
                if (txtcashid.Text == "")
                {
                    MessageBox.Show("Error: Select the Cashier to Delete!");
                }
                else
                {
                    conn.Open();
                    string query = "delete from CashTbl where CashierId=" + txtcashid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Deleted Successfully!");
                    conn.Close();
                    populate();
                    txtcashid.Text = "";
                    txtcashname.Text = "";
                    txtcashbd.Text = "";
                    txtcashcontact.Text = "";
                    txtcashpw.Text = "";
                }
            }
            catch(Exception ex) 
            { 
               MessageBox.Show(ex.Message);    
            }
        }
        private void populate()
        {
            conn.Open();
            string query = "select * from cashTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgcashiers.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void dgcashiers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtcashid.Text = dgcashiers.SelectedRows[0].Cells[0].Value.ToString();
            txtcashname.Text = dgcashiers.SelectedRows[0].Cells[1].Value.ToString();
            txtcashbd.Text = dgcashiers.SelectedRows[0].Cells[2].Value.ToString();
            txtcashcontact.Text = dgcashiers.SelectedRows[0].Cells[3].Value.ToString();
            txtcashpw.Text = dgcashiers.SelectedRows[0].Cells[4].Value.ToString();*/
        }

        private void btnadmininventory_Click(object sender, EventArgs e)
        {
            Admininventory objadmin = new Admininventory();
            this.Hide();
            objadmin.Show();
        }

        private void btnadmincategory_Click(object sender, EventArgs e)
        {
            Categories objcat = new Categories();
            this.Hide();
            objcat.Show();
        }

        private void btnadminsales_Click(object sender, EventArgs e)
        {
            Sales objsale = new Sales();
            this.Hide();
            objsale.Show();
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
