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

namespace DietKuyDesktop5.UI
{
    public partial class FrmDelivery : Form
    {
        public FrmDelivery()
        {
            InitializeComponent();
        }

        //create object for DayMenuBLL and DayMenuDAL
        DeliveryBLL u = new DeliveryBLL();
        DeliveryDAL dal = new DeliveryDAL();
        

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

            //Mengecek apakah alamat sudah di-add/belum
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
                //Jika gagal memasukkan alamat baru
                MessageBox.Show("Gagal memasukkan alamat baru");
            }
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            //Menampilkan Day Menu di DGV ketika di-load
            DataTable dt = dal.Select();
            dgvDelivery.DataSource = dt;
        }

        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Sumber
            //https://stackoverflow.com/questions/35250593/selectedrow-error-datagridview-error

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
            //1. Ambil value DayMenuId dari textbox
            u.DeliId = Convert.ToInt32(tbDeliId.Text);
            u.DeliName = tbDeliName.Text;
            u.DeliPhone = tbDeliPhone.Text;
            u.DeliAddress = tbDeliAddress.Text;
            u.DeliDesc = tbDeliDesc.Text;

            //2. buat boolean value untuk mengecek apakah menunya sudah diupdate
            bool success = dal.Update(u);

            //Mengecek apakah menu sudah diupdate/belum
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

        //Method untuk Clear TextBox
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
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
