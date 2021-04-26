
namespace DietKuyDesktop5
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSellerPassword = new System.Windows.Forms.TextBox();
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.btnEditSeller = new System.Windows.Forms.Button();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.lblSellerPassword = new System.Windows.Forms.Label();
            this.tbSellerPhone = new System.Windows.Forms.TextBox();
            this.lblSellerPhone = new System.Windows.Forms.Label();
            this.tbSellerAge = new System.Windows.Forms.TextBox();
            this.lblSellerAge = new System.Windows.Forms.Label();
            this.tbSellerName = new System.Windows.Forms.TextBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.tbSellerId = new System.Windows.Forms.TextBox();
            this.lblSellerId = new System.Windows.Forms.Label();
            this.lblManageSellers = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.tbSellerPassword);
            this.panel1.Controls.Add(this.btnRefreshProduct);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dgvSeller);
            this.panel1.Controls.Add(this.btnDeleteSeller);
            this.panel1.Controls.Add(this.btnEditSeller);
            this.panel1.Controls.Add(this.btnAddSeller);
            this.panel1.Controls.Add(this.lblSellerPassword);
            this.panel1.Controls.Add(this.tbSellerPhone);
            this.panel1.Controls.Add(this.lblSellerPhone);
            this.panel1.Controls.Add(this.tbSellerAge);
            this.panel1.Controls.Add(this.lblSellerAge);
            this.panel1.Controls.Add(this.tbSellerName);
            this.panel1.Controls.Add(this.lblSellerName);
            this.panel1.Controls.Add(this.tbSellerId);
            this.panel1.Controls.Add(this.lblSellerId);
            this.panel1.Controls.Add(this.lblManageSellers);
            this.panel1.Location = new System.Drawing.Point(231, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 784);
            this.panel1.TabIndex = 1;
            // 
            // tbSellerPassword
            // 
            this.tbSellerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerPassword.Location = new System.Drawing.Point(143, 313);
            this.tbSellerPassword.Name = "tbSellerPassword";
            this.tbSellerPassword.Size = new System.Drawing.Size(275, 30);
            this.tbSellerPassword.TabIndex = 26;
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProduct.Location = new System.Drawing.Point(853, 91);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(115, 39);
            this.btnRefreshProduct.TabIndex = 25;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(599, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 36);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Select Category";
            // 
            // dgvSeller
            // 
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Location = new System.Drawing.Point(447, 140);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.RowHeadersWidth = 51;
            this.dgvSeller.RowTemplate.Height = 24;
            this.dgvSeller.Size = new System.Drawing.Size(661, 631);
            this.dgvSeller.TabIndex = 23;
            this.dgvSeller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.BackColor = System.Drawing.Color.White;
            this.btnDeleteSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeller.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSeller.Location = new System.Drawing.Point(303, 382);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(115, 39);
            this.btnDeleteSeller.TabIndex = 22;
            this.btnDeleteSeller.Text = "DELETE";
            this.btnDeleteSeller.UseVisualStyleBackColor = false;
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // btnEditSeller
            // 
            this.btnEditSeller.BackColor = System.Drawing.Color.White;
            this.btnEditSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSeller.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditSeller.Location = new System.Drawing.Point(171, 382);
            this.btnEditSeller.Name = "btnEditSeller";
            this.btnEditSeller.Size = new System.Drawing.Size(115, 39);
            this.btnEditSeller.TabIndex = 21;
            this.btnEditSeller.Text = "EDIT";
            this.btnEditSeller.UseVisualStyleBackColor = false;
            this.btnEditSeller.Click += new System.EventHandler(this.btnEditSeller_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.BackColor = System.Drawing.Color.White;
            this.btnAddSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeller.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddSeller.Location = new System.Drawing.Point(36, 382);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(115, 39);
            this.btnAddSeller.TabIndex = 20;
            this.btnAddSeller.Text = "ADD";
            this.btnAddSeller.UseVisualStyleBackColor = false;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // lblSellerPassword
            // 
            this.lblSellerPassword.AutoSize = true;
            this.lblSellerPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerPassword.ForeColor = System.Drawing.Color.White;
            this.lblSellerPassword.Location = new System.Drawing.Point(18, 314);
            this.lblSellerPassword.Name = "lblSellerPassword";
            this.lblSellerPassword.Size = new System.Drawing.Size(112, 32);
            this.lblSellerPassword.TabIndex = 16;
            this.lblSellerPassword.Text = "Password";
            // 
            // tbSellerPhone
            // 
            this.tbSellerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerPhone.Location = new System.Drawing.Point(143, 256);
            this.tbSellerPhone.Name = "tbSellerPhone";
            this.tbSellerPhone.Size = new System.Drawing.Size(275, 30);
            this.tbSellerPhone.TabIndex = 15;
            // 
            // lblSellerPhone
            // 
            this.lblSellerPhone.AutoSize = true;
            this.lblSellerPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerPhone.ForeColor = System.Drawing.Color.White;
            this.lblSellerPhone.Location = new System.Drawing.Point(18, 257);
            this.lblSellerPhone.Name = "lblSellerPhone";
            this.lblSellerPhone.Size = new System.Drawing.Size(83, 32);
            this.lblSellerPhone.TabIndex = 14;
            this.lblSellerPhone.Text = "Phone";
            // 
            // tbSellerAge
            // 
            this.tbSellerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerAge.Location = new System.Drawing.Point(143, 208);
            this.tbSellerAge.Name = "tbSellerAge";
            this.tbSellerAge.Size = new System.Drawing.Size(275, 30);
            this.tbSellerAge.TabIndex = 13;
            // 
            // lblSellerAge
            // 
            this.lblSellerAge.AutoSize = true;
            this.lblSellerAge.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerAge.ForeColor = System.Drawing.Color.White;
            this.lblSellerAge.Location = new System.Drawing.Point(18, 209);
            this.lblSellerAge.Name = "lblSellerAge";
            this.lblSellerAge.Size = new System.Drawing.Size(57, 32);
            this.lblSellerAge.TabIndex = 12;
            this.lblSellerAge.Text = "Age";
            // 
            // tbSellerName
            // 
            this.tbSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerName.Location = new System.Drawing.Point(143, 161);
            this.tbSellerName.Name = "tbSellerName";
            this.tbSellerName.Size = new System.Drawing.Size(275, 30);
            this.tbSellerName.TabIndex = 11;
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.ForeColor = System.Drawing.Color.White;
            this.lblSellerName.Location = new System.Drawing.Point(18, 162);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(79, 32);
            this.lblSellerName.TabIndex = 10;
            this.lblSellerName.Text = "Name";
            // 
            // tbSellerId
            // 
            this.tbSellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerId.Location = new System.Drawing.Point(143, 115);
            this.tbSellerId.Name = "tbSellerId";
            this.tbSellerId.Size = new System.Drawing.Size(275, 30);
            this.tbSellerId.TabIndex = 9;
            // 
            // lblSellerId
            // 
            this.lblSellerId.AutoSize = true;
            this.lblSellerId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerId.ForeColor = System.Drawing.Color.White;
            this.lblSellerId.Location = new System.Drawing.Point(18, 116);
            this.lblSellerId.Name = "lblSellerId";
            this.lblSellerId.Size = new System.Drawing.Size(38, 32);
            this.lblSellerId.TabIndex = 8;
            this.lblSellerId.Text = "ID";
            // 
            // lblManageSellers
            // 
            this.lblManageSellers.AutoSize = true;
            this.lblManageSellers.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblManageSellers.ForeColor = System.Drawing.Color.White;
            this.lblManageSellers.Location = new System.Drawing.Point(452, 11);
            this.lblManageSellers.Name = "lblManageSellers";
            this.lblManageSellers.Size = new System.Drawing.Size(269, 58);
            this.lblManageSellers.TabIndex = 6;
            this.lblManageSellers.Text = "Manage Sellers";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1327, -5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 38);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnSelling.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSelling.Location = new System.Drawing.Point(41, 298);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(191, 75);
            this.btnSelling.TabIndex = 22;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCategory.Location = new System.Drawing.Point(41, 225);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(191, 75);
            this.btnCategory.TabIndex = 21;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnProducts.Location = new System.Drawing.Point(41, 152);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(191, 75);
            this.btnProducts.TabIndex = 20;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 835);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvSeller;
        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.Button btnEditSeller;
        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.Label lblSellerPassword;
        private System.Windows.Forms.TextBox tbSellerPhone;
        private System.Windows.Forms.Label lblSellerPhone;
        private System.Windows.Forms.TextBox tbSellerAge;
        private System.Windows.Forms.Label lblSellerAge;
        private System.Windows.Forms.TextBox tbSellerName;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.TextBox tbSellerId;
        private System.Windows.Forms.Label lblSellerId;
        private System.Windows.Forms.Label lblManageSellers;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.TextBox tbSellerPassword;
    }
}