using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietKuyDesktop5.UI;

namespace DietKuyDesktop5
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBmiCalc_Click(object sender, EventArgs e)
        {
            BMICalculator bmiCalculator = new BMICalculator();
            bmiCalculator.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            ManageDayMenu manageDayMenu = new ManageDayMenu();
            manageDayMenu.Show();
            this.Hide();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            FrmDelivery frmDelivery = new FrmDelivery();
            frmDelivery.Show();
            this.Hide();
        }
    }
}
