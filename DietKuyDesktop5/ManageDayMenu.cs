using DietKuyDesktop5.BLL;
using DietKuyDesktop5.DAL;
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
using System.Configuration;

namespace DietKuyDesktop5
{
    public partial class ManageDayMenu : Form
    {
        public ManageDayMenu()
        {
            InitializeComponent();
        }

        //create object for userBLL and userDAL
        DayMenuBLL u = new DayMenuBLL();
        DayMenuDAL dal = new DayMenuDAL();

        #region SQL connection helper
        //Create a Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Membuat SQL Connection Sementara
        SqlConnection Con = new SqlConnection(myconnstrng);
        #endregion

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillcombo()
        {
            //method ini akan bind ComboBox dengan database Category
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CatName FROM CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            cbCat.ValueMember = "catName";
            cbCat.DataSource = dt;
            Con.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            //Display the Users in DAtagrid View When the Form is Loaded
            DataTable dt = dal.Select();
            dgvProd.DataSource = dt;

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void tbProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //step 1: Get the values from UI
            u.ProdId = Convert.ToInt32(tbDayMenuId.Text);
            u.ProdName = tbDayMenuName.Text;
            u.ProdQty = Convert.ToInt32(tbDayMenuQty.Text);
            u.ProdPrice = Convert.ToInt32(tbDayMenuPrice.Text);
            u.ProdCat = cbCat.Text;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //https://stackoverflow.com/questions/35250593/selectedrow-error-datagridview-error

            int i = e.RowIndex;
            DataGridViewRow row = dgvProd.Rows[i];
            tbDayMenuId.Text = row.Cells[0].Value.ToString();
            tbDayMenuName.Text = row.Cells[1].Value.ToString();
            tbDayMenuQty.Text = row.Cells[2].Value.ToString();
            tbDayMenuPrice.Text = row.Cells[3].Value.ToString();
            cbCat.SelectedValue = row.Cells[4].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //Step 1: Get the UserID from Text Box to Delete the User
            u.ProdId = int.Parse(tbDayMenuId.Text);

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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDayMenuId.Text == "" || tbDayMenuName.Text == "" || tbDayMenuQty.Text == "" || tbDayMenuPrice.Text == "" )
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update DayMenuTbl set ProdName = '" + tbDayMenuName.Text + "', ProdQty= '" + tbDayMenuQty.Text + "', ProdPrice= '" + tbDayMenuPrice.Text + "', ProdCat= '" + cbCat.SelectedValue.ToString() + "' where ProdId = " + tbDayMenuId.Text + " ; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Day Menu Successfully Updated");
                    Con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method or Function to Clear TextBoxes
        public void Clear()
        {
            tbDayMenuId.Text = "";
            tbDayMenuName.Text = "";
            tbDayMenuQty.Text = "";
            tbDayMenuPrice.Text = "";
            cbCat.Text = "";
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
