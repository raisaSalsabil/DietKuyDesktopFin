
namespace DietKuyDesktop5
{
    partial class ManageDayMenu
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
            this.btnRefreshProduct = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.tbDayMenuPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tbDayMenuQty = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.tbDayMenuName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbDayMenuId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblManageDayMenu = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnRefreshProduct);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dgvProd);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.cbCat);
            this.panel1.Controls.Add(this.lblProductCategory);
            this.panel1.Controls.Add(this.tbDayMenuPrice);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.tbDayMenuQty);
            this.panel1.Controls.Add(this.lblProductQuantity);
            this.panel1.Controls.Add(this.tbDayMenuName);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.tbDayMenuId);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.lblManageDayMenu);
            this.panel1.Location = new System.Drawing.Point(188, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 434);
            this.panel1.TabIndex = 0;
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.BackColor = System.Drawing.Color.MintCream;
            this.btnRefreshProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRefreshProduct.Location = new System.Drawing.Point(853, 75);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(115, 39);
            this.btnRefreshProduct.TabIndex = 25;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(599, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 36);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Select Category";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(449, 137);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.RowTemplate.Height = 24;
            this.dgvProd.Size = new System.Drawing.Size(700, 268);
            this.dgvProd.TabIndex = 23;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteProduct.Location = new System.Drawing.Point(303, 366);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(115, 39);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.White;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditProduct.Location = new System.Drawing.Point(171, 366);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(115, 39);
            this.btnEditProduct.TabIndex = 21;
            this.btnEditProduct.Text = "EDIT";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.Location = new System.Drawing.Point(36, 366);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 39);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbCat
            // 
            this.cbCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Items.AddRange(new object[] {
            "Makanan berat",
            "Minuman",
            "Snack",
            "Lainnya"});
            this.cbCat.Location = new System.Drawing.Point(181, 298);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(237, 36);
            this.cbCat.TabIndex = 17;
            this.cbCat.Text = "Select Category";
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(31, 298);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(111, 32);
            this.lblProductCategory.TabIndex = 16;
            this.lblProductCategory.Text = "Category";
            // 
            // tbDayMenuPrice
            // 
            this.tbDayMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuPrice.Location = new System.Drawing.Point(143, 240);
            this.tbDayMenuPrice.Name = "tbDayMenuPrice";
            this.tbDayMenuPrice.Size = new System.Drawing.Size(275, 30);
            this.tbDayMenuPrice.TabIndex = 15;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(31, 241);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(66, 32);
            this.lblProductPrice.TabIndex = 14;
            this.lblProductPrice.Text = "Price";
            // 
            // tbDayMenuQty
            // 
            this.tbDayMenuQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuQty.Location = new System.Drawing.Point(143, 192);
            this.tbDayMenuQty.Name = "tbDayMenuQty";
            this.tbDayMenuQty.Size = new System.Drawing.Size(275, 30);
            this.tbDayMenuQty.TabIndex = 13;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(31, 193);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(107, 32);
            this.lblProductQuantity.TabIndex = 12;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // tbDayMenuName
            // 
            this.tbDayMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuName.Location = new System.Drawing.Point(143, 145);
            this.tbDayMenuName.Name = "tbDayMenuName";
            this.tbDayMenuName.Size = new System.Drawing.Size(275, 30);
            this.tbDayMenuName.TabIndex = 11;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(31, 146);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 32);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Name";
            // 
            // tbDayMenuId
            // 
            this.tbDayMenuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuId.Location = new System.Drawing.Point(143, 99);
            this.tbDayMenuId.Name = "tbDayMenuId";
            this.tbDayMenuId.Size = new System.Drawing.Size(275, 30);
            this.tbDayMenuId.TabIndex = 9;
            this.tbDayMenuId.TextChanged += new System.EventHandler(this.tbProductId_TextChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(31, 100);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(38, 32);
            this.lblProductId.TabIndex = 8;
            this.lblProductId.Text = "ID";
            this.lblProductId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblManageDayMenu
            // 
            this.lblManageDayMenu.AutoSize = true;
            this.lblManageDayMenu.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageDayMenu.Location = new System.Drawing.Point(439, 0);
            this.lblManageDayMenu.Name = "lblManageDayMenu";
            this.lblManageDayMenu.Size = new System.Drawing.Size(332, 58);
            this.lblManageDayMenu.TabIndex = 6;
            this.lblManageDayMenu.Text = "Manage Day Menu";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(1324, -2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 38);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCategory.Location = new System.Drawing.Point(-3, 331);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(191, 75);
            this.btnCategory.TabIndex = 18;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnHome.Location = new System.Drawing.Point(-3, 400);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(191, 75);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ManageDayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1363, 478);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDayMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageDayMenu;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox tbDayMenuId;
        private System.Windows.Forms.TextBox tbDayMenuName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbDayMenuPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox tbDayMenuQty;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnHome;
    }
}