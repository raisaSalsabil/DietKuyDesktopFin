using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietKuyDesktop5
{
    public partial class BMICalculator : Form
    {
        double height;
        double weight;
        double bmiValue;
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbWeight.Clear();
            tbHeight.Clear();
            lblBmiValue.Text = "";
            /*lblBmiValue.BackColor = Color.White;*/

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            /*lblBmi.BackColor = Color.White;*/
            height = Double.Parse(tbHeight.Text);
            weight = Double.Parse(tbWeight.Text);

            bmiValue = weight / (height * height);
            lblBmiValue.Text = String.Format("{0:f}", bmiValue);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void lblCheckMenu_Click(object sender, EventArgs e)
        {
            // BELUM SESUAI FORM YANG DIBUKA
            if(Convert.ToDouble(lblBmiValue.Text) < 18.5)
            {
                UnderWeight underWeight = new UnderWeight();
                underWeight.Show();
                this.Hide();
            }
            else if(Convert.ToDouble(lblBmiValue.Text) >= 18.5 && 
                Convert.ToDouble(lblBmiValue.Text) <= 24.9)
            {
                NormalWeight normalWeight = new NormalWeight();
                normalWeight.Show();
                this.Hide();
            }
            else if (Convert.ToDouble(lblBmiValue.Text) >= 25 &&
                Convert.ToDouble(lblBmiValue.Text) <= 29.9)
            {
                NormalWeight normalWeight = new NormalWeight();
                normalWeight.Show();
                this.Hide();
            }
            else if (Convert.ToDouble(lblBmiValue.Text) >= 30.0 &&
                Convert.ToDouble(lblBmiValue.Text) <= 34.9)
            {
                NormalWeight normalWeight = new NormalWeight();
                normalWeight.Show();
                this.Hide();
            }
            else if (Convert.ToDouble(lblBmiValue.Text) >= 35 &&
                Convert.ToDouble(lblBmiValue.Text) <= 39.9)
            {
                NormalWeight normalWeight = new NormalWeight();
                normalWeight.Show();
                this.Hide();
            }
            else if (Convert.ToDouble(lblBmiValue.Text) >= 40)
            {
                NormalWeight normalWeight = new NormalWeight();
                normalWeight.Show();
                this.Hide();
            }
        }
    }
}
