using DietKuyDesktop5.UI;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietKuyDesktop5
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        //Membuat SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raisa Salsabila\Documents\dietkuy5db.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Enter the username and password");
            }
            else
            {
                if (cbSelectRole.SelectedIndex > -1)
                {
                    if (cbSelectRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (tbUsername.Text == "Admin" && tbPassword.Text == "Admin")
                        {
                            AdminHome admHome = new AdminHome();
                            admHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you're the Admin, enter the correct ID and password!");
                        }
                    }
                    else if (cbSelectRole.SelectedItem.ToString() == "USER")
                    {
                        ClientHome cH = new ClientHome();

                        cH.Show();
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
