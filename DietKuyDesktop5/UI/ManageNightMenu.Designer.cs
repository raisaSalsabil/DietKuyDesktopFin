
namespace DietKuyDesktop5.UI
{
    partial class ManageNightMenu
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
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cbExtra = new System.Windows.Forms.ComboBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.lblProdCat = new System.Windows.Forms.Label();
            this.tbNightMenuPrice = new System.Windows.Forms.TextBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.tbNightMenuQty = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.tbNightMenuName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.tbNightMenuId = new System.Windows.Forms.TextBox();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblManageNightMenu = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHome.Location = new System.Drawing.Point(-1, 540);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(93, 43);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.cbExtra);
            this.panel1.Controls.Add(this.lblExtra);
            this.panel1.Controls.Add(this.cbSize);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.dgvProd);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.cbCat);
            this.panel1.Controls.Add(this.lblProdCat);
            this.panel1.Controls.Add(this.tbNightMenuPrice);
            this.panel1.Controls.Add(this.lblProdPrice);
            this.panel1.Controls.Add(this.tbNightMenuQty);
            this.panel1.Controls.Add(this.lblProdQty);
            this.panel1.Controls.Add(this.tbNightMenuName);
            this.panel1.Controls.Add(this.lblProdName);
            this.panel1.Controls.Add(this.tbNightMenuId);
            this.panel1.Controls.Add(this.lblProdId);
            this.panel1.Controls.Add(this.lblManageNightMenu);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 591);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Location = new System.Drawing.Point(299, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 39);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(411, 114);
            this.lblMessage.MaximumSize = new System.Drawing.Size(670, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 20);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "Message";
            // 
            // cbExtra
            // 
            this.cbExtra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtra.FormattingEnabled = true;
            this.cbExtra.Items.AddRange(new object[] {
            "Pickles",
            "Sauce",
            "Low-fat mayo",
            "None"});
            this.cbExtra.Location = new System.Drawing.Point(246, 381);
            this.cbExtra.Name = "cbExtra";
            this.cbExtra.Size = new System.Drawing.Size(135, 31);
            this.cbExtra.TabIndex = 31;
            this.cbExtra.Text = "Select extra";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblExtra.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblExtra.ForeColor = System.Drawing.Color.White;
            this.lblExtra.Location = new System.Drawing.Point(188, 384);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(54, 24);
            this.lblExtra.TabIndex = 30;
            this.lblExtra.Text = "Extra";
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Normal",
            "Ekstra 1",
            "Ekstra 2"});
            this.cbSize.Location = new System.Drawing.Point(75, 381);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(106, 31);
            this.cbSize.TabIndex = 29;
            this.cbSize.Text = "Select size";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(23, 384);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 24);
            this.lblSize.TabIndex = 28;
            this.lblSize.Text = "Size";
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(409, 165);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.RowTemplate.Height = 24;
            this.dgvProd.Size = new System.Drawing.Size(681, 387);
            this.dgvProd.TabIndex = 23;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteProduct.Location = new System.Drawing.Point(279, 440);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(99, 39);
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
            this.btnEditProduct.Location = new System.Drawing.Point(154, 440);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(105, 39);
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
            this.btnAddProduct.Location = new System.Drawing.Point(25, 440);
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
            this.cbCat.Location = new System.Drawing.Point(131, 324);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(246, 36);
            this.cbCat.TabIndex = 17;
            this.cbCat.Text = "Select Category";
            // 
            // lblProdCat
            // 
            this.lblProdCat.AutoSize = true;
            this.lblProdCat.BackColor = System.Drawing.Color.Transparent;
            this.lblProdCat.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdCat.ForeColor = System.Drawing.Color.White;
            this.lblProdCat.Location = new System.Drawing.Point(14, 325);
            this.lblProdCat.Name = "lblProdCat";
            this.lblProdCat.Size = new System.Drawing.Size(113, 30);
            this.lblProdCat.TabIndex = 16;
            this.lblProdCat.Text = "Category";
            // 
            // tbNightMenuPrice
            // 
            this.tbNightMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNightMenuPrice.Location = new System.Drawing.Point(131, 267);
            this.tbNightMenuPrice.Name = "tbNightMenuPrice";
            this.tbNightMenuPrice.Size = new System.Drawing.Size(246, 30);
            this.tbNightMenuPrice.TabIndex = 15;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblProdPrice.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdPrice.ForeColor = System.Drawing.Color.White;
            this.lblProdPrice.Location = new System.Drawing.Point(14, 268);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(67, 30);
            this.lblProdPrice.TabIndex = 14;
            this.lblProdPrice.Text = "Price";
            // 
            // tbNightMenuQty
            // 
            this.tbNightMenuQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNightMenuQty.Location = new System.Drawing.Point(131, 219);
            this.tbNightMenuQty.Name = "tbNightMenuQty";
            this.tbNightMenuQty.Size = new System.Drawing.Size(246, 30);
            this.tbNightMenuQty.TabIndex = 13;
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.BackColor = System.Drawing.Color.Transparent;
            this.lblProdQty.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdQty.ForeColor = System.Drawing.Color.White;
            this.lblProdQty.Location = new System.Drawing.Point(14, 220);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(110, 30);
            this.lblProdQty.TabIndex = 12;
            this.lblProdQty.Text = "Quantity";
            // 
            // tbNightMenuName
            // 
            this.tbNightMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNightMenuName.Location = new System.Drawing.Point(131, 172);
            this.tbNightMenuName.Name = "tbNightMenuName";
            this.tbNightMenuName.Size = new System.Drawing.Size(246, 30);
            this.tbNightMenuName.TabIndex = 11;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.BackColor = System.Drawing.Color.Transparent;
            this.lblProdName.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdName.ForeColor = System.Drawing.Color.White;
            this.lblProdName.Location = new System.Drawing.Point(14, 173);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(78, 30);
            this.lblProdName.TabIndex = 10;
            this.lblProdName.Text = "Name";
            // 
            // tbNightMenuId
            // 
            this.tbNightMenuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNightMenuId.Location = new System.Drawing.Point(131, 126);
            this.tbNightMenuId.Name = "tbNightMenuId";
            this.tbNightMenuId.Size = new System.Drawing.Size(246, 30);
            this.tbNightMenuId.TabIndex = 9;
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.BackColor = System.Drawing.Color.Transparent;
            this.lblProdId.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProdId.ForeColor = System.Drawing.Color.White;
            this.lblProdId.Location = new System.Drawing.Point(14, 127);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(37, 30);
            this.lblProdId.TabIndex = 8;
            this.lblProdId.Text = "ID";
            // 
            // lblManageNightMenu
            // 
            this.lblManageNightMenu.AutoSize = true;
            this.lblManageNightMenu.Font = new System.Drawing.Font("Adobe Gothic Std B", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblManageNightMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblManageNightMenu.Location = new System.Drawing.Point(570, 41);
            this.lblManageNightMenu.Name = "lblManageNightMenu";
            this.lblManageNightMenu.Size = new System.Drawing.Size(327, 41);
            this.lblManageNightMenu.TabIndex = 6;
            this.lblManageNightMenu.Text = "Manage Night Menu";
            // 
            // pbBack
            // 
            this.pbBack.Image = global::DietKuyDesktop5.Properties.Resources.labelBack;
            this.pbBack.Location = new System.Drawing.Point(-2, -2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(397, 590);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 35;
            this.pbBack.TabStop = false;
            // 
            // ManageNightMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageNightMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageNightMenu";
            this.Load += new System.EventHandler(this.ManageNightMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label lblProdCat;
        private System.Windows.Forms.TextBox tbNightMenuPrice;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.TextBox tbNightMenuQty;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.TextBox tbNightMenuName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox tbNightMenuId;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblManageNightMenu;
        private System.Windows.Forms.ComboBox cbExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnClear;
    }
}