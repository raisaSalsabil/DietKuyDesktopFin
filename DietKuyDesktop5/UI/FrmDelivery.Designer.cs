
namespace DietKuyDesktop5.UI
{
    partial class FrmDelivery
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDeliDesc = new System.Windows.Forms.TextBox();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.tbDeliAddress = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tbDeliPhone = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.tbDeliName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbDeliId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCategory.Location = new System.Drawing.Point(-4, 279);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(191, 75);
            this.btnCategory.TabIndex = 25;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.tbDeliDesc);
            this.panel1.Controls.Add(this.dgvDelivery);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.lblProductCategory);
            this.panel1.Controls.Add(this.tbDeliAddress);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.tbDeliPhone);
            this.panel1.Controls.Add(this.lblProductQuantity);
            this.panel1.Controls.Add(this.tbDeliName);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.tbDeliId);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.lblDelivery);
            this.panel1.Location = new System.Drawing.Point(186, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 427);
            this.panel1.TabIndex = 24;
            // 
            // tbDeliDesc
            // 
            this.tbDeliDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliDesc.Location = new System.Drawing.Point(143, 268);
            this.tbDeliDesc.Name = "tbDeliDesc";
            this.tbDeliDesc.Size = new System.Drawing.Size(275, 30);
            this.tbDeliDesc.TabIndex = 24;
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Location = new System.Drawing.Point(449, 61);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.RowHeadersWidth = 51;
            this.dgvDelivery.RowTemplate.Height = 24;
            this.dgvDelivery.Size = new System.Drawing.Size(700, 288);
            this.dgvDelivery.TabIndex = 23;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellContentClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteProduct.Location = new System.Drawing.Point(303, 309);
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
            this.btnEditProduct.Location = new System.Drawing.Point(171, 309);
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
            this.btnAddProduct.Location = new System.Drawing.Point(36, 309);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 39);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(31, 268);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(66, 32);
            this.lblProductCategory.TabIndex = 16;
            this.lblProductCategory.Text = "Desc";
            // 
            // tbDeliAddress
            // 
            this.tbDeliAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliAddress.Location = new System.Drawing.Point(143, 176);
            this.tbDeliAddress.Multiline = true;
            this.tbDeliAddress.Name = "tbDeliAddress";
            this.tbDeliAddress.Size = new System.Drawing.Size(275, 84);
            this.tbDeliAddress.TabIndex = 15;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(31, 177);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(99, 32);
            this.lblProductPrice.TabIndex = 14;
            this.lblProductPrice.Text = "Address";
            // 
            // tbDeliPhone
            // 
            this.tbDeliPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliPhone.Location = new System.Drawing.Point(143, 138);
            this.tbDeliPhone.Name = "tbDeliPhone";
            this.tbDeliPhone.Size = new System.Drawing.Size(275, 30);
            this.tbDeliPhone.TabIndex = 13;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(31, 139);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(83, 32);
            this.lblProductQuantity.TabIndex = 12;
            this.lblProductQuantity.Text = "Phone";
            // 
            // tbDeliName
            // 
            this.tbDeliName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliName.Location = new System.Drawing.Point(143, 99);
            this.tbDeliName.Name = "tbDeliName";
            this.tbDeliName.Size = new System.Drawing.Size(275, 30);
            this.tbDeliName.TabIndex = 11;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(31, 100);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 32);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Name";
            // 
            // tbDeliId
            // 
            this.tbDeliId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliId.Location = new System.Drawing.Point(143, 61);
            this.tbDeliId.Name = "tbDeliId";
            this.tbDeliId.Size = new System.Drawing.Size(275, 30);
            this.tbDeliId.TabIndex = 9;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(31, 62);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(38, 32);
            this.lblProductId.TabIndex = 8;
            this.lblProductId.Text = "ID";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(447, 2);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(257, 50);
            this.lblDelivery.TabIndex = 6;
            this.lblDelivery.Text = "Delivery Address";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnHome.Location = new System.Drawing.Point(-4, 209);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(191, 75);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FrmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 354);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDelivery";
            this.Text = "frmDelivery";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDeliDesc;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox tbDeliAddress;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox tbDeliPhone;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.TextBox tbDeliName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbDeliId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Button btnHome;
    }
}