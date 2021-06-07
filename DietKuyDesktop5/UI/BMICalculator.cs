using DietKuyDesktop5.BLL;
using DietKuyDesktop5.UI;
using System;
using System.Windows.Forms;

namespace DietKuyDesktop5
{
    public partial class BMICalculator : Form
    {
        //instancing
        ClientBLL client = ClientBLL.GetInstance;

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbWeight.Clear();
            tbHeight.Clear();
            lblBmiValue.Text = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Calculate BMI
            client.Height = Double.Parse(tbHeight.Text);
            client.Weight = Double.Parse(tbWeight.Text);

            double bmiVal;
            bmiVal = client.CalcBmi(client.Height, client.Weight);
            lblBmiValue.Text = Convert.ToString(bmiVal);

            //Tampilkan  category di lblBmiCatVal
            lblBmiCatVal.Text = client.CategBmi(bmiVal);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientHome CliHome = new ClientHome();
            CliHome.Show();
            this.Hide();
        }

        private void lblCheckMenu_Click(object sender, EventArgs e)
        {
            //Buka dgvDayMenu dengan filter
            FrmChooseMenu chooseMenu = new FrmChooseMenu();
            chooseMenu.Show();
            this.Hide();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
