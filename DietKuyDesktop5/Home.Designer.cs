
namespace DietKuyDesktop5
{
    partial class Home
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
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBmiCalc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSelling.Location = new System.Drawing.Point(-1, 74);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(264, 75);
            this.btnSelling.TabIndex = 22;
            this.btnSelling.Text = "Manage Day Menu";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCategory.Location = new System.Drawing.Point(-1, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(264, 75);
            this.btnCategory.TabIndex = 21;
            this.btnCategory.Text = "Add Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBmiCalc
            // 
            this.btnBmiCalc.BackColor = System.Drawing.Color.White;
            this.btnBmiCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBmiCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBmiCalc.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBmiCalc.Location = new System.Drawing.Point(-1, 358);
            this.btnBmiCalc.Name = "btnBmiCalc";
            this.btnBmiCalc.Size = new System.Drawing.Size(264, 75);
            this.btnBmiCalc.TabIndex = 24;
            this.btnBmiCalc.Text = "BMI Calculator";
            this.btnBmiCalc.UseVisualStyleBackColor = false;
            this.btnBmiCalc.Click += new System.EventHandler(this.btnBmiCalc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietKuyDesktop5.Properties.Resources.main_flip;
            this.pictureBox1.Location = new System.Drawing.Point(261, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblLogin.Location = new System.Drawing.Point(376, 144);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(285, 105);
            this.lblLogin.TabIndex = 27;
            this.lblLogin.Text = "DietKuy";
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.White;
            this.btnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddress.Location = new System.Drawing.Point(-1, 144);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(264, 75);
            this.btnAddress.TabIndex = 28;
            this.btnAddress.Text = "Add Address";
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 430);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBmiCalc);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBmiCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAddress;
    }
}