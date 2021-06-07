using DietKuyDesktop5.BLL;
using System;
using System.Windows.Forms;

namespace DietKuyDesktop5.UI
{
    public partial class ClientHome : Form
    {
        ClientBLL client = ClientBLL.GetInstance;
        public ClientHome()
        {
            InitializeComponent();
        }

        private void btnBmiCalc_Click(object sender, EventArgs e)
        {
            BMICalculator bmiCalculator = new BMICalculator();
            bmiCalculator.Show();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            FrmDelivery frmDelivery = new FrmDelivery();
            frmDelivery.Show();
            this.Hide();
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void ClientHome_Load(object sender, EventArgs e)
        {
            lblMessage.Text = client.PrintMessage();
        }
    }
}
