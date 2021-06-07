﻿using DietKuyDesktop5.BLL;
using DietKuyDesktop5.DAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietKuyDesktop5.UI
{
    public partial class ManageNightMenu : Form
    {
        public ManageNightMenu()
        {
            InitializeComponent();
        }

        //create object for userBLL and userDAL
        NightMenuBLL u = NightMenuBLL.GetInstance;
        NightMenuDAL dal = NightMenuDAL.GetInstance;

        #region SQL connection helper
        //Create a Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["DietKuyDesktop5.Properties.Settings.connstrng"].ConnectionString;

        //Membuat SQL Connection Sementara
        SqlConnection Con = new SqlConnection(myconnstrng);
        #endregion
        private void ManageNightMenu_Load(object sender, EventArgs e)
        {
            //Display the Users in DAtagrid View When the Form is Loaded
            DataTable dt = dal.Select();
            dgvProd.DataSource = dt;

            lblMessage.Text = u.PrintMessage();
            Transparent();
        }
        private void Transparent()
        {
            lblProdId.Parent = pbBack;
            lblProdName.Parent = pbBack;
            lblProdQty.Parent = pbBack;
            lblProdPrice.Parent = pbBack;
            lblProdCat.Parent = pbBack;
            lblSize.Parent = pbBack;
            lblExtra.Parent = pbBack;
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //https://stackoverflow.com/questions/35250593/selectedrow-error-datagridview-error

            int i = e.RowIndex;
            DataGridViewRow row = dgvProd.Rows[i];
            tbNightMenuId.Text = row.Cells[0].Value.ToString();
            tbNightMenuName.Text = row.Cells[1].Value.ToString();
            tbNightMenuQty.Text = row.Cells[2].Value.ToString();
            tbNightMenuPrice.Text = row.Cells[3].Value.ToString();
            cbCat.Text = row.Cells[4].Value.ToString();
            cbSize.Text = row.Cells[5].Value.ToString();
            cbExtra.Text = row.Cells[6].Value.ToString();
        }

        #region AddNightMenu
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //step 1: Get the values from UI and inserto to properties in BLL
            u.ProdId = Convert.ToInt32(tbNightMenuId.Text);
            u.ProdName = tbNightMenuName.Text;
            u.ProdQty = Convert.ToInt32(tbNightMenuQty.Text);
            u.ProdPrice = Convert.ToInt32(tbNightMenuPrice.Text);
            u.ProdCat = cbCat.Text;
            u.ProdSize = cbSize.Text;
            u.ProdExtra = cbExtra.Text;

            //step 2 : Adding the values from UI to the database
            //create a bool variable to check wether the data is inserted succesfulllly or not
            bool success = dal.Insert(u);

            //step 3: check wether the data is inserted succesfully or not 
            if (success == true)
            {
                //data or user added succesfully
                MessageBox.Show("New Menu Added Succesfully");

                //Display the user in DataGrid View
                DataTable dt = dal.Select();
                dgvProd.DataSource = dt;

                //Clear TextBoxes
                Clear();
            }
            else
            {
                //failed to add user
                MessageBox.Show("Failed to add new menu");
            }
        }
        #endregion AddNightMenu

        #region DeleteNightMenu
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //Step 1: Get the UserID from Text Box to Delete the User
            u.ProdId = int.Parse(tbNightMenuId.Text);

            //Step Create the Boolean value to check whether the user deleted or not
            bool success = dal.Delete(u);

            //Let's check whteher the user is Deleted or Not
            if (success == true)
            {
                //User Deleted Successfully
                MessageBox.Show("User Deleted Successfully.");

                //Refresh DataGrid View
                DataTable dt = dal.Select();
                dgvProd.DataSource = dt;

                //Clear the TextBoxes
                Clear();
            }
        }
        #endregion DeleteNightMenu

        #region EditNightMenu
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNightMenuId.Text == "" || tbNightMenuName.Text == "" || tbNightMenuQty.Text == "" || tbNightMenuPrice.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update DayMenuTbl set ProdName = '" + tbNightMenuName.Text + "', ProdQty= '" + tbNightMenuQty.Text + "', ProdPrice= '" + tbNightMenuPrice.Text + "', ProdCat= '" + cbCat.SelectedValue.ToString() + "', ProdSize= '" + cbSize.SelectedValue.ToString() + "', ProdExtra= '" + cbExtra.SelectedValue.ToString() + "' where ProdId = " + tbNightMenuId.Text + " ; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Night Menu Successfully Updated");
                    Con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion EditNightMenu

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome admHome = new AdminHome();
            admHome.Show();
            this.Hide();
        }
        public void Clear()
        {
            tbNightMenuId.Text = "";
            tbNightMenuName.Text = "";
            tbNightMenuQty.Text = "";
            tbNightMenuPrice.Text = "";
            cbCat.Text = "";
            cbSize.Text = "";
            cbExtra.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}