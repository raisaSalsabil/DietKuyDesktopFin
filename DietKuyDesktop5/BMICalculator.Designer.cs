
namespace DietKuyDesktop5
{
    partial class BMICalculator
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblBmiValue = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCheckMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(53, 116);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(91, 32);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblHeight.ForeColor = System.Drawing.Color.Black;
            this.lblHeight.Location = new System.Drawing.Point(53, 161);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(87, 32);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblBmi.ForeColor = System.Drawing.Color.Black;
            this.lblBmi.Location = new System.Drawing.Point(57, 284);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(57, 32);
            this.lblBmi.TabIndex = 2;
            this.lblBmi.Text = "BMI";
            // 
            // tbWeight
            // 
            this.tbWeight.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeight.ForeColor = System.Drawing.Color.Black;
            this.tbWeight.Location = new System.Drawing.Point(164, 118);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(175, 30);
            this.tbWeight.TabIndex = 10;
            this.tbWeight.Text = "56";
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeight.ForeColor = System.Drawing.Color.Black;
            this.tbHeight.Location = new System.Drawing.Point(164, 161);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(175, 30);
            this.tbHeight.TabIndex = 11;
            this.tbHeight.Text = "1.6";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnClear.Location = new System.Drawing.Point(224, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 39);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddProduct.Location = new System.Drawing.Point(59, 212);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(159, 39);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Check BMI";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblBmiValue
            // 
            this.lblBmiValue.BackColor = System.Drawing.Color.White;
            this.lblBmiValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBmiValue.ForeColor = System.Drawing.Color.Black;
            this.lblBmiValue.Location = new System.Drawing.Point(161, 284);
            this.lblBmiValue.Name = "lblBmiValue";
            this.lblBmiValue.Size = new System.Drawing.Size(178, 32);
            this.lblBmiValue.TabIndex = 24;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblKg.ForeColor = System.Drawing.Color.Black;
            this.lblKg.Location = new System.Drawing.Point(345, 114);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(41, 32);
            this.lblKg.TabIndex = 25;
            this.lblKg.Text = "kg";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblM.ForeColor = System.Drawing.Color.Black;
            this.lblM.Location = new System.Drawing.Point(345, 160);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(36, 32);
            this.lblM.TabIndex = 26;
            this.lblM.Text = "m";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblLogin.Location = new System.Drawing.Point(81, 34);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(248, 54);
            this.lblLogin.TabIndex = 27;
            this.lblLogin.Text = "BMI Calculator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DietKuyDesktop5.Properties.Resources.bmiTable;
            this.pictureBox2.Location = new System.Drawing.Point(418, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 468);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietKuyDesktop5.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(361, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCheckMenu
            // 
            this.lblCheckMenu.BackColor = System.Drawing.Color.White;
            this.lblCheckMenu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckMenu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCheckMenu.Location = new System.Drawing.Point(63, 336);
            this.lblCheckMenu.Name = "lblCheckMenu";
            this.lblCheckMenu.Size = new System.Drawing.Size(276, 45);
            this.lblCheckMenu.TabIndex = 30;
            this.lblCheckMenu.Text = "Check Recomended Menu";
            this.lblCheckMenu.UseVisualStyleBackColor = false;
            this.lblCheckMenu.Click += new System.EventHandler(this.lblCheckMenu_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(847, 456);
            this.Controls.Add(this.lblCheckMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblBmiValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblBmiValue;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button lblCheckMenu;
    }
}