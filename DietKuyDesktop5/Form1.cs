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

namespace DietKuyDesktop5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Membuat SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raisa Salsabila\Documents\dietkuy5db.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == ""|| tbPassword.Text == "")
            {
                MessageBox.Show("Enter the username and password");
            }
            else
            {
                if(cbSelectRole.SelectedIndex > -1)
                {
                    if (cbSelectRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (tbUsername.Text == "Admin" && tbPassword.Text == "Admin")
                        {
                            ManageDayMenu prod = new ManageDayMenu();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you're the Admin, enter the correct ID and password!");
                        }
                    }
                    else if (cbSelectRole.SelectedItem.ToString() == "USER")
                    {
                        //MessageBox.Show("You are in the user section");
                        /*Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where SellerName = '"+tbUsername.Text+"' and SellerPass = '"+tbPassword.Text+"'", Con);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if(dt.Rows[0][0].ToString() == "1")
                        {
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                        }
                        Con.Close();*/
                        CategoryForm cat = new CategoryForm();
                        cat.Show();
                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}
