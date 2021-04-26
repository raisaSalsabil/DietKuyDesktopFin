
namespace DietKuyDesktop5
{
    partial class CategoryForm
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
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnEditCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.tbCatDesc = new System.Windows.Forms.TextBox();
            this.lblCatDesc = new System.Windows.Forms.Label();
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.tbCatId = new System.Windows.Forms.TextBox();
            this.lblSellerId = new System.Windows.Forms.Label();
            this.lblManageCategories = new System.Windows.Forms.Label();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnPoducts = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.btnRefreshProduct);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dgvCat);
            this.panel1.Controls.Add(this.btnDeleteCat);
            this.panel1.Controls.Add(this.btnEditCat);
            this.panel1.Controls.Add(this.btnAddCat);
            this.panel1.Controls.Add(this.tbCatDesc);
            this.panel1.Controls.Add(this.lblCatDesc);
            this.panel1.Controls.Add(this.tbCatName);
            this.panel1.Controls.Add(this.lblSellerName);
            this.panel1.Controls.Add(this.tbCatId);
            this.panel1.Controls.Add(this.lblSellerId);
            this.panel1.Controls.Add(this.lblManageCategories);
            this.panel1.Location = new System.Drawing.Point(214, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 743);
            this.panel1.TabIndex = 2;
            // 
            // btnRefreshProduct
            // 
            this.btnRefreshProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProduct.Location = new System.Drawing.Point(853, 91);
            this.btnRefreshProduct.Name = "btnRefreshProduct";
            this.btnRefreshProduct.Size = new System.Drawing.Size(115, 39);
            this.btnRefreshProduct.TabIndex = 25;
            this.btnRefreshProduct.Text = "Refresh";
            this.btnRefreshProduct.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(599, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Select Category";
            // 
            // dgvCat
            // 
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Location = new System.Drawing.Point(447, 136);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.RowHeadersWidth = 51;
            this.dgvCat.RowTemplate.Height = 24;
            this.dgvCat.Size = new System.Drawing.Size(625, 570);
            this.dgvCat.TabIndex = 23;
            this.dgvCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCat_CellContentClick);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCat.Location = new System.Drawing.Point(303, 268);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(115, 39);
            this.btnDeleteCat.TabIndex = 22;
            this.btnDeleteCat.Text = "DELETE";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCat.Location = new System.Drawing.Point(171, 268);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(115, 39);
            this.btnEditCat.TabIndex = 21;
            this.btnEditCat.Text = "EDIT";
            this.btnEditCat.UseVisualStyleBackColor = true;
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Location = new System.Drawing.Point(36, 268);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(115, 39);
            this.btnAddCat.TabIndex = 20;
            this.btnAddCat.Text = "ADD";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // tbCatDesc
            // 
            this.tbCatDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatDesc.Location = new System.Drawing.Point(161, 208);
            this.tbCatDesc.Name = "tbCatDesc";
            this.tbCatDesc.Size = new System.Drawing.Size(257, 30);
            this.tbCatDesc.TabIndex = 13;
            // 
            // lblCatDesc
            // 
            this.lblCatDesc.AutoSize = true;
            this.lblCatDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatDesc.Location = new System.Drawing.Point(18, 209);
            this.lblCatDesc.Name = "lblCatDesc";
            this.lblCatDesc.Size = new System.Drawing.Size(135, 29);
            this.lblCatDesc.TabIndex = 12;
            this.lblCatDesc.Text = "Description";
            // 
            // tbCatName
            // 
            this.tbCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatName.Location = new System.Drawing.Point(161, 161);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(257, 30);
            this.tbCatName.TabIndex = 11;
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.Location = new System.Drawing.Point(18, 162);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(78, 29);
            this.lblSellerName.TabIndex = 10;
            this.lblSellerName.Text = "Name";
            // 
            // tbCatId
            // 
            this.tbCatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatId.Location = new System.Drawing.Point(161, 115);
            this.tbCatId.Name = "tbCatId";
            this.tbCatId.Size = new System.Drawing.Size(257, 30);
            this.tbCatId.TabIndex = 9;
            // 
            // lblSellerId
            // 
            this.lblSellerId.AutoSize = true;
            this.lblSellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerId.Location = new System.Drawing.Point(18, 116);
            this.lblSellerId.Name = "lblSellerId";
            this.lblSellerId.Size = new System.Drawing.Size(36, 29);
            this.lblSellerId.TabIndex = 8;
            this.lblSellerId.Text = "ID";
            // 
            // lblManageCategories
            // 
            this.lblManageCategories.AutoSize = true;
            this.lblManageCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCategories.Location = new System.Drawing.Point(512, 23);
            this.lblManageCategories.Name = "lblManageCategories";
            this.lblManageCategories.Size = new System.Drawing.Size(224, 29);
            this.lblManageCategories.TabIndex = 6;
            this.lblManageCategories.Text = "Manage Categories";
            // 
            // btnSelling
            // 
            this.btnSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.Location = new System.Drawing.Point(32, 313);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(150, 39);
            this.btnSelling.TabIndex = 25;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            // 
            // btnPoducts
            // 
            this.btnPoducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoducts.Location = new System.Drawing.Point(32, 258);
            this.btnPoducts.Name = "btnPoducts";
            this.btnPoducts.Size = new System.Drawing.Size(150, 39);
            this.btnPoducts.TabIndex = 24;
            this.btnPoducts.Text = "Products";
            this.btnPoducts.UseVisualStyleBackColor = true;
            this.btnPoducts.Click += new System.EventHandler(this.btnPoducts_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellers.Location = new System.Drawing.Point(32, 205);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(150, 39);
            this.btnSellers.TabIndex = 23;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = true;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1296, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 29);
            this.lblClose.TabIndex = 26;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(32, 369);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 39);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 842);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnPoducts);
            this.Controls.Add(this.btnSellers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefreshProduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnEditCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.TextBox tbCatDesc;
        private System.Windows.Forms.Label lblCatDesc;
        private System.Windows.Forms.TextBox tbCatName;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.TextBox tbCatId;
        private System.Windows.Forms.Label lblSellerId;
        private System.Windows.Forms.Label lblManageCategories;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnPoducts;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnHome;
    }
}