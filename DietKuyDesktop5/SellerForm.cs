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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        //Membuat SQL Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raisa Salsabila\Documents\dietkuy5db.mdf;Integrated Security=True;Connect Timeout=30");

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Menampilkan data ke dgvProd
        private void populate()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvSeller.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" + tbSellerId.Text + ", '" + tbSellerName.Text + "', '" + tbSellerAge.Text + "', '" + tbSellerPhone.Text + "', '" + tbSellerPassword.Text + "')";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully!");
                Con.Close();
                populate();
                /*tbSellerId.Text = "";
                tbSellerName.Text = "";
                tbSellerAge.Text = "";
                tbSellerPhone.Text = "";
                tbSellerPassword.Text = "";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //https://stackoverflow.com/questions/35250593/selectedrow-error-datagridview-error

            int i = e.RowIndex;
            DataGridViewRow row = dgvSeller.Rows[i];
            tbSellerId.Text = row.Cells[0].Value.ToString();
            tbSellerName.Text = row.Cells[1].Value.ToString();
            tbSellerAge.Text = row.Cells[2].Value.ToString();
            tbSellerPhone.Text = row.Cells[3].Value.ToString();
            tbSellerPassword.Text = row.Cells[4].Value.ToString();
        }
        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSellerId.Text == "")
                {
                    MessageBox.Show("Select the product to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTbl where SellerId = " + tbSellerId.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted successfully");
                    Con.Close();
                    populate();
                    tbSellerId.Text = "";
                    tbSellerName.Text = "";
                    tbSellerAge.Text = "";
                    tbSellerPhone.Text = "";
                    tbSellerPassword.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSellerId.Text == "" || tbSellerName.Text == "" || tbSellerAge.Text == "" || tbSellerPhone.Text == "" || tbSellerPassword.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set SellerName = '" + tbSellerName.Text + "', SellerAge= '" + tbSellerAge.Text + "', SellerPhone= '" + tbSellerPhone.Text + "', SellerPass= '" + tbSellerPassword.Text + "' where SellerId = " + tbSellerId.Text + " ; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
