using DietKuyDesktop5.BLL;
using DietKuyDesktop5.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace DietKuyDesktop5.UI
{
    public partial class FrmDelivery : Form
    {
        public FrmDelivery()
        {
            InitializeComponent();
        }
        //create object for DayMenuBLL and DayMenuDAL
        DeliveryBLL u = DeliveryBLL.GetInstance;
        DeliveryDAL dal = DeliveryDAL.GetInstance;
        /*bool success;*/
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //1. Ambil value DayMenuId dari textbox
            u.DeliId = Convert.ToInt32(tbDeliId.Text);
            u.DeliName = tbDeliName.Text;
            u.DeliPhone = tbDeliPhone.Text;
            u.DeliAddress = tbDeliAddress.Text;
            u.DeliDesc = tbDeliDesc.Text;
            //2. buat boolean value untuk mengecek apakah menunya sudah di-add
            bool success = dal.Insert(u);

            AddBranch(success);
        }
        private void AddBranch(bool success)
        {
            if (success == true)
            {
                //Jika berhasil di-add
                MessageBox.Show("Alamat baru berhasil dimasukkan");
                //Displayday menu di DGV
                DataTable dt = dal.Select();
                dgvDelivery.DataSource = dt;
                //Clear TextBox
                Clear();
            }
            else
            {
                ////Jika gagal memasukkan alamat baru
                MessageBox.Show("Gagal memasukkan alamat baru");
            }
        }
        private void frmDelivery_Load(object sender, EventArgs e)
        {
            //Menampilkan Day Menu di DGV ketika di-load
            DataTable dt = dal.Select();
            dgvDelivery.DataSource = dt;

            Transparent();
        }
        private void Transparent()
        {
            lblProductId.Parent = pbBack;
            lblProductName.Parent = pbBack;
            lblProdPhone.Parent = pbBack;
            lblProdAddr.Parent = pbBack;
            lblProdDesc.Parent = pbBack;  
        }
        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dgvDelivery.Rows[i];
            tbDeliId.Text = row.Cells[0].Value.ToString();
            tbDeliName.Text = row.Cells[1].Value.ToString();
            tbDeliPhone.Text = row.Cells[2].Value.ToString();
            tbDeliAddress.Text = row.Cells[3].Value.ToString();
            tbDeliDesc.Text = row.Cells[4].Value.ToString();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //1. Ambil value DayMenuId dari textbox untuk menghapus menu
            u.DeliId = int.Parse(tbDeliId.Text);
            //2. buat boolean value untuk mengecek apakah menunya sudah terhapus
            bool success = dal.Delete(u);
            //Mengecek apakah menu sudah dihapus/belum
            DelBranch(success);
        }
        private void DelBranch(bool success)
        {
            if (success == true)
            {
                //Jika menu terhapus
                MessageBox.Show("Menu Deleted Successfully.");
                //Refresh DGV
                DataTable dt = dal.Select();
                dgvDelivery.DataSource = dt;
                //Clear TextBox
                Clear();
            }
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            ////1. Ambil value DayMenuId dari textbox
            u.DeliId = Convert.ToInt32(tbDeliId.Text);
            u.DeliName = tbDeliName.Text;
            u.DeliPhone = tbDeliPhone.Text;
            u.DeliAddress = tbDeliAddress.Text;
            u.DeliDesc = tbDeliDesc.Text;
            //2. buat boolean value untuk mengecek apakah menunya sudah diupdate
            bool success = dal.Update(u);
            //Mengecek apakah menu sudah diupdate/belum
            EditBranch(success);
        }
        private void EditBranch(bool success)
        {
            if (success == true)
            {
                //Jika menu terhapus
                MessageBox.Show("Address Updated Successfully.");
                //Refresh DGV
                DataTable dt = dal.Select();
                dgvDelivery.DataSource = dt;
                //Clear the TextBoxes
                Clear();
            }
        }
        public void Clear()
        {
            tbDeliId.Text = "";
            tbDeliName.Text = "";
            tbDeliPhone.Text = "";
            tbDeliAddress.Text = "";
            tbDeliDesc.Text = "";
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ClientHome cliHome = new ClientHome();
            cliHome.Show();
            this.Hide();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void tbDeliDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductCategory_Click(object sender, EventArgs e)
        {

        }

        private void tbDeliAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbDeliPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductQuantity_Click(object sender, EventArgs e)
        {

        }

        private void tbDeliName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void tbDeliId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductId_Click(object sender, EventArgs e)
        {

        }

        private void lblDelivery_Click(object sender, EventArgs e)
        {

        }

        
    }
}
