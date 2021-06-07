
namespace DietKuyDesktop5.UI
{
    partial class AdminHome
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
            this.btnToLogin = new System.Windows.Forms.Button();
            this.btnMngNightMenu = new System.Windows.Forms.Button();
            this.btnMngDayMenu = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToLogin
            // 
            this.btnToLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLogin.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnToLogin.ForeColor = System.Drawing.Color.White;
            this.btnToLogin.Location = new System.Drawing.Point(1, 450);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(264, 104);
            this.btnToLogin.TabIndex = 33;
            this.btnToLogin.Text = "Go to Login Menu";
            this.btnToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToLogin.UseVisualStyleBackColor = false;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // btnMngNightMenu
            // 
            this.btnMngNightMenu.BackColor = System.Drawing.Color.Gray;
            this.btnMngNightMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngNightMenu.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnMngNightMenu.ForeColor = System.Drawing.Color.White;
            this.btnMngNightMenu.Location = new System.Drawing.Point(0, 225);
            this.btnMngNightMenu.Name = "btnMngNightMenu";
            this.btnMngNightMenu.Size = new System.Drawing.Size(265, 230);
            this.btnMngNightMenu.TabIndex = 32;
            this.btnMngNightMenu.Text = "Manage Night Menu";
            this.btnMngNightMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMngNightMenu.UseVisualStyleBackColor = false;
            this.btnMngNightMenu.Click += new System.EventHandler(this.btnMngNightMenu_Click);
            // 
            // btnMngDayMenu
            // 
            this.btnMngDayMenu.BackColor = System.Drawing.Color.Gray;
            this.btnMngDayMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngDayMenu.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnMngDayMenu.ForeColor = System.Drawing.Color.White;
            this.btnMngDayMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMngDayMenu.Name = "btnMngDayMenu";
            this.btnMngDayMenu.Size = new System.Drawing.Size(265, 230);
            this.btnMngDayMenu.TabIndex = 31;
            this.btnMngDayMenu.Text = "Manage    Day Menu";
            this.btnMngDayMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMngDayMenu.UseVisualStyleBackColor = false;
            this.btnMngDayMenu.Click += new System.EventHandler(this.btnMngDayMenu_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(302, 512);
            this.lblMessage.MaximumSize = new System.Drawing.Size(560, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 37;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietKuyDesktop5.Properties.Resources.HomeImage_min;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.btnMngNightMenu);
            this.Controls.Add(this.btnMngDayMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminHome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Button btnMngNightMenu;
        private System.Windows.Forms.Button btnMngDayMenu;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}