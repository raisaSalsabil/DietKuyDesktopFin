using DietKuyDesktop5.BLL;
using System;
using System.Windows.Forms;

namespace DietKuyDesktop5.UI
{
    public partial class AdminHome : Form
    {
        AdminBLL admin = AdminBLL.GetInstance;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnMngDayMenu_Click(object sender, EventArgs e)
        {
            ManageDayMenu manageDayMenu = new ManageDayMenu();
            manageDayMenu.Show();
            this.Hide();
        }

        private void btnMngNightMenu_Click(object sender, EventArgs e)
        {
            ManageNightMenu manageNightMenu = new ManageNightMenu();
            manageNightMenu.Show();
            this.Hide();
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblMessage.Text = admin.PrintMessage();
        }
    }
}
