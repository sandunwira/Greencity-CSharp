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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Greencity\Categories.mdf;Integrated Security=True;Connect Timeout=30";


        private void dgsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadmincashier_Click(object sender, EventArgs e)
        {
            Cashiers objcash = new Cashiers();  
            this.Hide();
            objcash.Show(); 
        }

        private void btnadmincategory_Click(object sender, EventArgs e)
        {
            Categories objcat = new Categories();
            this.Hide();
            objcat.Show();
        }

        private void btnadmininventory_Click(object sender, EventArgs e)
        {
            Admininventory objadmin = new Admininventory();
            this.Hide();
            objadmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void btnSendSales_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from BillsTbl",conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);   

                dgsendsales.DataSource = dt;
            }    

        }
    }
}
