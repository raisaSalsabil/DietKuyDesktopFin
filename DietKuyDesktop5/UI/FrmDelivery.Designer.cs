
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.tbDeliDesc = new System.Windows.Forms.TextBox();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.tbDeliAddress = new System.Windows.Forms.TextBox();
            this.lblProdAddr = new System.Windows.Forms.Label();
            this.tbDeliPhone = new System.Windows.Forms.TextBox();
            this.lblProdPhone = new System.Windows.Forms.Label();
            this.tbDeliName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbDeliId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.tbDeliDesc);
            this.panel1.Controls.Add(this.dgvDelivery);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.lblProdDesc);
            this.panel1.Controls.Add(this.tbDeliAddress);
            this.panel1.Controls.Add(this.lblProdAddr);
            this.panel1.Controls.Add(this.tbDeliPhone);
            this.panel1.Controls.Add(this.lblProdPhone);
            this.panel1.Controls.Add(this.tbDeliName);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.tbDeliId);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.lblDelivery);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 585);
            this.panel1.TabIndex = 24;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHome.Location = new System.Drawing.Point(0, 539);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(92, 43);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tbDeliDesc
            // 
            this.tbDeliDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliDesc.Location = new System.Drawing.Point(131, 328);
            this.tbDeliDesc.Name = "tbDeliDesc";
            this.tbDeliDesc.Size = new System.Drawing.Size(246, 30);
            this.tbDeliDesc.TabIndex = 24;
            this.tbDeliDesc.TextChanged += new System.EventHandler(this.tbDeliDesc_TextChanged);
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Location = new System.Drawing.Point(418, 121);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.RowHeadersWidth = 51;
            this.dgvDelivery.RowTemplate.Height = 24;
            this.dgvDelivery.Size = new System.Drawing.Size(640, 415);
            this.dgvDelivery.TabIndex = 23;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellContentClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteProduct.Location = new System.Drawing.Point(264, 369);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(113, 39);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.White;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditProduct.Location = new System.Drawing.Point(147, 369);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(107, 39);
            this.btnEditProduct.TabIndex = 21;
            this.btnEditProduct.Text = "EDIT";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddProduct.Location = new System.Drawing.Point(25, 369);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(109, 39);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblProdDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdDesc.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdDesc.ForeColor = System.Drawing.Color.White;
            this.lblProdDesc.Location = new System.Drawing.Point(19, 328);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(65, 30);
            this.lblProdDesc.TabIndex = 16;
            this.lblProdDesc.Text = "Desc";
            // 
            // tbDeliAddress
            // 
            this.tbDeliAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliAddress.Location = new System.Drawing.Point(131, 236);
            this.tbDeliAddress.Multiline = true;
            this.tbDeliAddress.Name = "tbDeliAddress";
            this.tbDeliAddress.Size = new System.Drawing.Size(246, 86);
            this.tbDeliAddress.TabIndex = 15;
            this.tbDeliAddress.TextChanged += new System.EventHandler(this.tbDeliAddress_TextChanged);
            // 
            // lblProdAddr
            // 
            this.lblProdAddr.AutoSize = true;
            this.lblProdAddr.BackColor = System.Drawing.Color.Transparent;
            this.lblProdAddr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdAddr.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdAddr.ForeColor = System.Drawing.Color.White;
            this.lblProdAddr.Location = new System.Drawing.Point(19, 237);
            this.lblProdAddr.Name = "lblProdAddr";
            this.lblProdAddr.Size = new System.Drawing.Size(103, 30);
            this.lblProdAddr.TabIndex = 14;
            this.lblProdAddr.Text = "Address";
            // 
            // tbDeliPhone
            // 
            this.tbDeliPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliPhone.Location = new System.Drawing.Point(131, 198);
            this.tbDeliPhone.Name = "tbDeliPhone";
            this.tbDeliPhone.Size = new System.Drawing.Size(246, 30);
            this.tbDeliPhone.TabIndex = 13;
            this.tbDeliPhone.TextChanged += new System.EventHandler(this.tbDeliPhone_TextChanged);
            // 
            // lblProdPhone
            // 
            this.lblProdPhone.AutoSize = true;
            this.lblProdPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblProdPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdPhone.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdPhone.ForeColor = System.Drawing.Color.White;
            this.lblProdPhone.Location = new System.Drawing.Point(19, 199);
            this.lblProdPhone.Name = "lblProdPhone";
            this.lblProdPhone.Size = new System.Drawing.Size(84, 30);
            this.lblProdPhone.TabIndex = 12;
            this.lblProdPhone.Text = "Phone";
            // 
            // tbDeliName
            // 
            this.tbDeliName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliName.Location = new System.Drawing.Point(131, 159);
            this.tbDeliName.Name = "tbDeliName";
            this.tbDeliName.Size = new System.Drawing.Size(246, 30);
            this.tbDeliName.TabIndex = 11;
            this.tbDeliName.TextChanged += new System.EventHandler(this.tbDeliName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(19, 160);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 30);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Name";
            // 
            // tbDeliId
            // 
            this.tbDeliId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeliId.Location = new System.Drawing.Point(131, 121);
            this.tbDeliId.Name = "tbDeliId";
            this.tbDeliId.Size = new System.Drawing.Size(246, 30);
            this.tbDeliId.TabIndex = 9;
            this.tbDeliId.TextChanged += new System.EventHandler(this.tbDeliId_TextChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.Transparent;
            this.lblProductId.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.Color.White;
            this.lblProductId.Location = new System.Drawing.Point(19, 122);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(37, 30);
            this.lblProductId.TabIndex = 8;
            this.lblProductId.Text = "ID";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Adobe Gothic Std B", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDelivery.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDelivery.Location = new System.Drawing.Point(479, 45);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(476, 41);
            this.lblDelivery.TabIndex = 6;
            this.lblDelivery.Text = "Identitiy and Delivery Address";
            this.lblDelivery.Click += new System.EventHandler(this.lblDelivery_Click);
            // 
            // pbBack
            // 
            this.pbBack.Image = global::DietKuyDesktop5.Properties.Resources.labelBack;
            this.pbBack.Location = new System.Drawing.Point(0, 0);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(400, 585);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 27;
            this.pbBack.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Location = new System.Drawing.Point(304, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 39);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDelivery";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDeliDesc;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.TextBox tbDeliAddress;
        private System.Windows.Forms.Label lblProdAddr;
        private System.Windows.Forms.TextBox tbDeliPhone;
        private System.Windows.Forms.Label lblProdPhone;
        private System.Windows.Forms.TextBox tbDeliName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbDeliId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnClear;
    }
}