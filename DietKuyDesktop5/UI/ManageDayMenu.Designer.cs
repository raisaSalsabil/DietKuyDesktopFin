
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
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.lblProdCat = new System.Windows.Forms.Label();
            this.tbDayMenuPrice = new System.Windows.Forms.TextBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.tbDayMenuQty = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.tbDayMenuName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.tbDayMenuId = new System.Windows.Forms.TextBox();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblManageDayMenu = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.dgvProd);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.cbCat);
            this.panel1.Controls.Add(this.lblProdCat);
            this.panel1.Controls.Add(this.tbDayMenuPrice);
            this.panel1.Controls.Add(this.lblProdPrice);
            this.panel1.Controls.Add(this.tbDayMenuQty);
            this.panel1.Controls.Add(this.lblProdQty);
            this.panel1.Controls.Add(this.tbDayMenuName);
            this.panel1.Controls.Add(this.lblProdName);
            this.panel1.Controls.Add(this.tbDayMenuId);
            this.panel1.Controls.Add(this.lblProdId);
            this.panel1.Controls.Add(this.lblManageDayMenu);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 587);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Location = new System.Drawing.Point(301, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 39);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(409, 105);
            this.lblMessage.MaximumSize = new System.Drawing.Size(670, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 20);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = "Message";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHome.Location = new System.Drawing.Point(2, 540);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(93, 43);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(413, 150);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.RowTemplate.Height = 24;
            this.dgvProd.Size = new System.Drawing.Size(670, 406);
            this.dgvProd.TabIndex = 23;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteProduct.Location = new System.Drawing.Point(272, 403);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(102, 39);
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
            this.btnEditProduct.Location = new System.Drawing.Point(147, 403);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(101, 39);
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
            this.btnAddProduct.Location = new System.Drawing.Point(21, 403);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(102, 39);
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
            "Underweight -Food",
            "Underweight -Beverage",
            "Underweight  -Snack",
            "Underweight  -Others",
            "Normalweight -Food",
            "Normalweight -Beverage",
            "Normalweight  -Snack",
            "Normalweight  -Others",
            "Overweight -Food",
            "Overweight -Beverage",
            "Overweight  -Snack",
            "Overweight  -Others"});
            this.cbCat.Location = new System.Drawing.Point(134, 335);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(246, 36);
            this.cbCat.TabIndex = 17;
            this.cbCat.Text = "Select Category";
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // lblProdCat
            // 
            this.lblProdCat.AutoSize = true;
            this.lblProdCat.BackColor = System.Drawing.Color.Transparent;
            this.lblProdCat.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdCat.ForeColor = System.Drawing.Color.White;
            this.lblProdCat.Location = new System.Drawing.Point(16, 335);
            this.lblProdCat.Name = "lblProdCat";
            this.lblProdCat.Size = new System.Drawing.Size(113, 30);
            this.lblProdCat.TabIndex = 16;
            this.lblProdCat.Text = "Category";
            // 
            // tbDayMenuPrice
            // 
            this.tbDayMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuPrice.Location = new System.Drawing.Point(134, 277);
            this.tbDayMenuPrice.Name = "tbDayMenuPrice";
            this.tbDayMenuPrice.Size = new System.Drawing.Size(246, 30);
            this.tbDayMenuPrice.TabIndex = 15;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblProdPrice.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdPrice.ForeColor = System.Drawing.Color.White;
            this.lblProdPrice.Location = new System.Drawing.Point(16, 278);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(67, 30);
            this.lblProdPrice.TabIndex = 14;
            this.lblProdPrice.Text = "Price";
            // 
            // tbDayMenuQty
            // 
            this.tbDayMenuQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuQty.Location = new System.Drawing.Point(134, 229);
            this.tbDayMenuQty.Name = "tbDayMenuQty";
            this.tbDayMenuQty.Size = new System.Drawing.Size(246, 30);
            this.tbDayMenuQty.TabIndex = 13;
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.BackColor = System.Drawing.Color.Transparent;
            this.lblProdQty.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdQty.ForeColor = System.Drawing.Color.White;
            this.lblProdQty.Location = new System.Drawing.Point(16, 230);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(110, 30);
            this.lblProdQty.TabIndex = 12;
            this.lblProdQty.Text = "Quantity";
            // 
            // tbDayMenuName
            // 
            this.tbDayMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuName.Location = new System.Drawing.Point(134, 182);
            this.tbDayMenuName.Name = "tbDayMenuName";
            this.tbDayMenuName.Size = new System.Drawing.Size(246, 30);
            this.tbDayMenuName.TabIndex = 11;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.BackColor = System.Drawing.Color.Transparent;
            this.lblProdName.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdName.ForeColor = System.Drawing.Color.White;
            this.lblProdName.Location = new System.Drawing.Point(16, 183);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(78, 30);
            this.lblProdName.TabIndex = 10;
            this.lblProdName.Text = "Name";
            // 
            // tbDayMenuId
            // 
            this.tbDayMenuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayMenuId.Location = new System.Drawing.Point(134, 136);
            this.tbDayMenuId.Name = "tbDayMenuId";
            this.tbDayMenuId.Size = new System.Drawing.Size(246, 30);
            this.tbDayMenuId.TabIndex = 9;
            this.tbDayMenuId.TextChanged += new System.EventHandler(this.tbProductId_TextChanged);
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.BackColor = System.Drawing.Color.Transparent;
            this.lblProdId.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdId.ForeColor = System.Drawing.Color.White;
            this.lblProdId.Location = new System.Drawing.Point(16, 137);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(37, 30);
            this.lblProdId.TabIndex = 8;
            this.lblProdId.Text = "ID";
            this.lblProdId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblManageDayMenu
            // 
            this.lblManageDayMenu.AutoSize = true;
            this.lblManageDayMenu.Font = new System.Drawing.Font("Adobe Gothic Std B", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblManageDayMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblManageDayMenu.Location = new System.Drawing.Point(595, 39);
            this.lblManageDayMenu.Name = "lblManageDayMenu";
            this.lblManageDayMenu.Size = new System.Drawing.Size(301, 41);
            this.lblManageDayMenu.TabIndex = 6;
            this.lblManageDayMenu.Text = "Manage Day Menu";
            // 
            // pbBack
            // 
            this.pbBack.Image = global::DietKuyDesktop5.Properties.Resources.labelBack;
            this.pbBack.Location = new System.Drawing.Point(0, 0);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(397, 585);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 34;
            this.pbBack.TabStop = false;
            // 
            // ManageDayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 583);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDayMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageDayMenu;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.TextBox tbDayMenuId;
        private System.Windows.Forms.TextBox tbDayMenuName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox tbDayMenuPrice;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.TextBox tbDayMenuQty;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.Label lblProdCat;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnClear;
    }
}