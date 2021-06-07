using DietKuyDesktop5.BLL;
using DietKuyDesktop5.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DietKuyDesktop5.UI
{
    public partial class FrmChooseMenu : Form
    {
        public FrmChooseMenu()
        {
            InitializeComponent();
        }
        DayMenuDAL dayDal = DayMenuDAL.GetInstance;
        NightMenuDAL nigDal = NightMenuDAL.GetInstance;
        DeliveryDAL delDal = DeliveryDAL.GetInstance;
        private void FrmChooseMenu_Load(object sender, EventArgs e)
        { //Display the Users in Dtagrid View When the Form is Loaded
            LoadDayMenu();
            LoadNigMenu();
            LoadDeliMenu();
        }
        private void LoadDayMenu()
        {
            DataTable dtDay = dayDal.Select();
            dtDay.Columns.Remove(dtDay.Columns[2]);
            dtDay.Columns.Remove(dtDay.Columns[0]);
            dgvDayMenu.DataSource = dtDay;
        }
        private void LoadNigMenu()
        {
            DataTable dtNight = nigDal.Select();
            dtNight.Columns.Remove(dtNight.Columns[2]);
            dtNight.Columns.Remove(dtNight.Columns[0]);
            dgvNightMenu.DataSource = dtNight;
        }
        private void LoadDeliMenu()
        {
            DataTable dtDel = delDal.Select();
            dtDel.Columns.Remove(dtDel.Columns[0]);
            dgvIdenAddress.DataSource = dtDel;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lblNameChs.Text != "-" && lblPhoneChs.Text != "-" && lblAddressChs.Text != "-")
            {
                if (lblDayMenuChs.Text != "-" || lblNightMenu.Text != "-")
                MessageBox.Show("Your order is being processed!");
            }
            else
            {
                MessageBox.Show("Please choose NAME, PHONE, ADDRESS, and One of the Menus!");
            }
            GoHome();   
        }
        private void GoHome()
        {
            ClientHome cliHome = new ClientHome();
            cliHome.Show();
            this.Hide();
        }
        private void btnGenerateQr_Click(object sender, EventArgs e)
        {
            Bitmap qr;
            tbQrText.Text = QRGenerator.GenerateInfo(
                lblNameChs.Text,
                lblPhoneChs.Text,
                lblAddressChs.Text,
                lblDayMenuChs.Text,
                lblNightMenuChs.Text,
            out qr);
            pbQR.Image = qr;
        }
        private void dgvDayMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dgvDayMenu.Rows[i];
            lblDayMenuChs.Text = row.Cells[0].Value.ToString();
        }

        private void dgvNightMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dgvNightMenu.Rows[i];
            lblNightMenuChs.Text = row.Cells[0].Value.ToString();
        }

        private void dgvIdenAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dgvIdenAddress.Rows[i];
            lblNameChs.Text = row.Cells[1].Value.ToString();
            lblPhoneChs.Text = row.Cells[2].Value.ToString();
            lblAddressChs.Text = row.Cells[3].Value.ToString();
        }
    }
}
