using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace Login
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        public static string CashierName = "";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Greencity\Categories.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassw.Text == "")
            {
                MessageBox.Show("Error: Please Enter the Username and Password!");
            }
            else
            {
                if (cbRole.SelectedIndex > -1)
                {
                    if (cbRole.SelectedItem.ToString() == "Admin")
                    {
                        if (txtusername.Text == "Admin"  &&  txtpassw.Text == "Admin")
                        {
                            Admininventory objadmin = new Admininventory();
                            this.Hide();
                            objadmin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error: Enter The Correct Username and Password For The Admin!");
                        }
                    }
                    else 
                    { 
                      conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CashTbl Where CashierName='" + txtusername.Text+"' and CashierPassword='"+txtpassw.Text+"'",conn);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            CashierName = txtusername.Text;
                            transaction objtran = new transaction();
                            this.Hide();
                            objtran.Show();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error: Wrong Username and Password!");
                        }
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Select the Role to Login!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassw.Text = "";
        }
    }
}
