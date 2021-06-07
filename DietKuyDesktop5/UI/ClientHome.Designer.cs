
namespace DietKuyDesktop5.UI
{
    partial class ClientHome
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
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnBmiCalc = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToLogin
            // 
            this.btnToLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLogin.Font = new System.Drawing.Font("Adobe Gothic Std B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnToLogin.ForeColor = System.Drawing.Color.White;
            this.btnToLogin.Location = new System.Drawing.Point(0, 459);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(265, 96);
            this.btnToLogin.TabIndex = 34;
            this.btnToLogin.Text = "Go to Login Menu";
            this.btnToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToLogin.UseVisualStyleBackColor = false;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.Gray;
            this.btnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddress.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddress.ForeColor = System.Drawing.Color.White;
            this.btnAddress.Location = new System.Drawing.Point(0, 229);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(265, 230);
            this.btnAddress.TabIndex = 33;
            this.btnAddress.Text = "Add Address";
            this.btnAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnBmiCalc
            // 
            this.btnBmiCalc.BackColor = System.Drawing.Color.Gray;
            this.btnBmiCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBmiCalc.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBmiCalc.ForeColor = System.Drawing.Color.White;
            this.btnBmiCalc.Location = new System.Drawing.Point(0, 0);
            this.btnBmiCalc.Name = "btnBmiCalc";
            this.btnBmiCalc.Size = new System.Drawing.Size(265, 230);
            this.btnBmiCalc.TabIndex = 31;
            this.btnBmiCalc.Text = "BMI Calculator";
            this.btnBmiCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBmiCalc.UseVisualStyleBackColor = false;
            this.btnBmiCalc.Click += new System.EventHandler(this.btnBmiCalc_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(288, 513);
            this.lblMessage.MaximumSize = new System.Drawing.Size(560, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 36;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietKuyDesktop5.Properties.Resources.HomeImage_min;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.btnBmiCalc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientHome";
            this.Load += new System.EventHandler(this.ClientHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnBmiCalc;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}