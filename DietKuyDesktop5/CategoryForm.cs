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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        //Membuat SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raisa Salsabila\Documents\dietkuy5db.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + tbCatId.Text + ", '" + tbCatName.Text + "', '" + tbCatDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully!");
                Con.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Menampilkan data ke dgvCategory
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvCat.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgvCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*tbCatId.Text = dgvCat.SelectedRows[0].Cells[0].Value.ToString();
            tbCatName.Text = dgvCat.SelectedRows[0].Cells[1].Value.ToString();
            tbCatDesc.Text = dgvCat.SelectedRows[0].Cells[2].Value.ToString();*/
            //https://stackoverflow.com/questions/35250593/selectedrow-error-datagridview-error

            int i = e.RowIndex;
            DataGridViewRow row = dgvCat.Rows[i];
            tbCatId.Text = row.Cells[0].Value.ToString();
            tbCatName.Text = row.Cells[1].Value.ToString();
            tbCatDesc.Text = row.Cells[2].Value.ToString();
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbCatId.Text == "")
                {
                    MessageBox.Show("Select the category to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId = "+tbCatId.Text+" ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Mengedit data di dgvCategory
        private void btnEditCat_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbCatId.Text=="" || tbCatName.Text=="" || tbCatDesc.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName = '" + tbCatName.Text + "', CatDesc= '" + tbCatDesc.Text + "' where CatId = " + tbCatId.Text + " ; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPoducts_Click(object sender, EventArgs e)
        {
            ManageDayMenu prod = new ManageDayMenu();
            prod.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
