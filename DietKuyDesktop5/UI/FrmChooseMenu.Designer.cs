
namespace DietKuyDesktop5.UI
{
    partial class FrmChooseMenu
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
            this.components = new System.ComponentModel.Container();
            this.dayMenuTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nightMenuTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDayMenu = new System.Windows.Forms.Label();
            this.lblDayMenuChs = new System.Windows.Forms.Label();
            this.lblNightMenuChs = new System.Windows.Forms.Label();
            this.lblNightMenu = new System.Windows.Forms.Label();
            this.deliveryTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameChs = new System.Windows.Forms.Label();
            this.lblPhoneChs = new System.Windows.Forms.Label();
            this.lblAddressChs = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblYourCateg = new System.Windows.Forms.Label();
            this.btnGenerateQr = new System.Windows.Forms.Button();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.tbQrText = new System.Windows.Forms.TextBox();
            this.dgvDayMenu = new System.Windows.Forms.DataGridView();
            this.dgvNightMenu = new System.Windows.Forms.DataGridView();
            this.dgvIdenAddress = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dayMenuTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightMenuTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNightMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdenAddress)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayMenuTblBindingSource
            // 
            this.dayMenuTblBindingSource.DataMember = "DayMenuTbl";
            // 
            // nightMenuTblBindingSource
            // 
            this.nightMenuTblBindingSource.DataMember = "NightMenuTbl";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblTitle.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(124, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Choose Your Menus";
            // 
            // lblDayMenu
            // 
            this.lblDayMenu.AutoSize = true;
            this.lblDayMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblDayMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayMenu.ForeColor = System.Drawing.Color.White;
            this.lblDayMenu.Location = new System.Drawing.Point(28, 119);
            this.lblDayMenu.Name = "lblDayMenu";
            this.lblDayMenu.Size = new System.Drawing.Size(121, 23);
            this.lblDayMenu.TabIndex = 3;
            this.lblDayMenu.Text = "Day Menu     :";
            // 
            // lblDayMenuChs
            // 
            this.lblDayMenuChs.AutoSize = true;
            this.lblDayMenuChs.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblDayMenuChs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayMenuChs.ForeColor = System.Drawing.Color.White;
            this.lblDayMenuChs.Location = new System.Drawing.Point(169, 116);
            this.lblDayMenuChs.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDayMenuChs.Name = "lblDayMenuChs";
            this.lblDayMenuChs.Size = new System.Drawing.Size(17, 23);
            this.lblDayMenuChs.TabIndex = 4;
            this.lblDayMenuChs.Text = "-";
            // 
            // lblNightMenuChs
            // 
            this.lblNightMenuChs.AutoSize = true;
            this.lblNightMenuChs.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblNightMenuChs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightMenuChs.ForeColor = System.Drawing.Color.White;
            this.lblNightMenuChs.Location = new System.Drawing.Point(169, 153);
            this.lblNightMenuChs.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblNightMenuChs.Name = "lblNightMenuChs";
            this.lblNightMenuChs.Size = new System.Drawing.Size(17, 23);
            this.lblNightMenuChs.TabIndex = 6;
            this.lblNightMenuChs.Text = "-";
            // 
            // lblNightMenu
            // 
            this.lblNightMenu.AutoSize = true;
            this.lblNightMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblNightMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNightMenu.ForeColor = System.Drawing.Color.White;
            this.lblNightMenu.Location = new System.Drawing.Point(28, 153);
            this.lblNightMenu.Name = "lblNightMenu";
            this.lblNightMenu.Size = new System.Drawing.Size(126, 23);
            this.lblNightMenu.TabIndex = 5;
            this.lblNightMenu.Text = "Night Menu   :";
            // 
            // deliveryTblBindingSource
            // 
            this.deliveryTblBindingSource.DataMember = "DeliveryTbl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose your identitiy and address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choosen:";
            // 
            // lblNameChs
            // 
            this.lblNameChs.AutoSize = true;
            this.lblNameChs.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblNameChs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameChs.ForeColor = System.Drawing.Color.White;
            this.lblNameChs.Location = new System.Drawing.Point(40, 449);
            this.lblNameChs.MinimumSize = new System.Drawing.Size(350, 0);
            this.lblNameChs.Name = "lblNameChs";
            this.lblNameChs.Size = new System.Drawing.Size(350, 23);
            this.lblNameChs.TabIndex = 10;
            this.lblNameChs.Text = "-";
            // 
            // lblPhoneChs
            // 
            this.lblPhoneChs.AutoSize = true;
            this.lblPhoneChs.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblPhoneChs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneChs.ForeColor = System.Drawing.Color.White;
            this.lblPhoneChs.Location = new System.Drawing.Point(40, 484);
            this.lblPhoneChs.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPhoneChs.Name = "lblPhoneChs";
            this.lblPhoneChs.Size = new System.Drawing.Size(17, 23);
            this.lblPhoneChs.TabIndex = 11;
            this.lblPhoneChs.Text = "-";
            // 
            // lblAddressChs
            // 
            this.lblAddressChs.AutoSize = true;
            this.lblAddressChs.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblAddressChs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressChs.ForeColor = System.Drawing.Color.White;
            this.lblAddressChs.Location = new System.Drawing.Point(40, 519);
            this.lblAddressChs.MaximumSize = new System.Drawing.Size(350, 150);
            this.lblAddressChs.Name = "lblAddressChs";
            this.lblAddressChs.Size = new System.Drawing.Size(17, 23);
            this.lblAddressChs.TabIndex = 12;
            this.lblAddressChs.Text = "-";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(393, 589);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(147, 37);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order Now!";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblYourCateg
            // 
            this.lblYourCateg.AutoSize = true;
            this.lblYourCateg.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblYourCateg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCateg.ForeColor = System.Drawing.Color.White;
            this.lblYourCateg.Location = new System.Drawing.Point(29, 70);
            this.lblYourCateg.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblYourCateg.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblYourCateg.Name = "lblYourCateg";
            this.lblYourCateg.Size = new System.Drawing.Size(500, 46);
            this.lblYourCateg.TabIndex = 14;
            this.lblYourCateg.Text = "Reccomendation: Select Menus Match Your BMI Category Only!";
            // 
            // btnGenerateQr
            // 
            this.btnGenerateQr.BackColor = System.Drawing.Color.White;
            this.btnGenerateQr.Location = new System.Drawing.Point(100, 589);
            this.btnGenerateQr.Name = "btnGenerateQr";
            this.btnGenerateQr.Size = new System.Drawing.Size(183, 37);
            this.btnGenerateQr.TabIndex = 15;
            this.btnGenerateQr.Text = "Generate QR Code";
            this.btnGenerateQr.UseVisualStyleBackColor = false;
            this.btnGenerateQr.Click += new System.EventHandler(this.btnGenerateQr_Click);
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.LightSlateGray;
            this.pbQR.Location = new System.Drawing.Point(393, 217);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(147, 135);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQR.TabIndex = 16;
            this.pbQR.TabStop = false;
            // 
            // tbQrText
            // 
            this.tbQrText.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbQrText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQrText.ForeColor = System.Drawing.Color.White;
            this.tbQrText.Location = new System.Drawing.Point(393, 365);
            this.tbQrText.Multiline = true;
            this.tbQrText.Name = "tbQrText";
            this.tbQrText.Size = new System.Drawing.Size(147, 192);
            this.tbQrText.TabIndex = 17;
            // 
            // dgvDayMenu
            // 
            this.dgvDayMenu.AllowUserToAddRows = false;
            this.dgvDayMenu.AllowUserToDeleteRows = false;
            this.dgvDayMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayMenu.Location = new System.Drawing.Point(579, 12);
            this.dgvDayMenu.Name = "dgvDayMenu";
            this.dgvDayMenu.ReadOnly = true;
            this.dgvDayMenu.RowHeadersWidth = 51;
            this.dgvDayMenu.RowTemplate.Height = 24;
            this.dgvDayMenu.Size = new System.Drawing.Size(556, 312);
            this.dgvDayMenu.TabIndex = 18;
            this.dgvDayMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDayMenu_CellContentClick);
            // 
            // dgvNightMenu
            // 
            this.dgvNightMenu.AllowUserToAddRows = false;
            this.dgvNightMenu.AllowUserToDeleteRows = false;
            this.dgvNightMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNightMenu.Location = new System.Drawing.Point(579, 330);
            this.dgvNightMenu.Name = "dgvNightMenu";
            this.dgvNightMenu.ReadOnly = true;
            this.dgvNightMenu.RowHeadersWidth = 51;
            this.dgvNightMenu.RowTemplate.Height = 24;
            this.dgvNightMenu.Size = new System.Drawing.Size(556, 307);
            this.dgvNightMenu.TabIndex = 19;
            this.dgvNightMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNightMenu_CellContentClick);
            // 
            // dgvIdenAddress
            // 
            this.dgvIdenAddress.AllowUserToAddRows = false;
            this.dgvIdenAddress.AllowUserToDeleteRows = false;
            this.dgvIdenAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdenAddress.Location = new System.Drawing.Point(31, 216);
            this.dgvIdenAddress.Name = "dgvIdenAddress";
            this.dgvIdenAddress.ReadOnly = true;
            this.dgvIdenAddress.RowHeadersWidth = 51;
            this.dgvIdenAddress.RowTemplate.Height = 24;
            this.dgvIdenAddress.Size = new System.Drawing.Size(348, 190);
            this.dgvIdenAddress.TabIndex = 20;
            this.dgvIdenAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdenAddress_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.lblDayMenuChs);
            this.panel1.Controls.Add(this.lblNightMenuChs);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 652);
            this.panel1.TabIndex = 21;
            // 
            // FrmChooseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1147, 649);
            this.Controls.Add(this.dgvIdenAddress);
            this.Controls.Add(this.dgvNightMenu);
            this.Controls.Add(this.dgvDayMenu);
            this.Controls.Add(this.tbQrText);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.btnGenerateQr);
            this.Controls.Add(this.lblYourCateg);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblAddressChs);
            this.Controls.Add(this.lblPhoneChs);
            this.Controls.Add(this.lblNameChs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNightMenu);
            this.Controls.Add(this.lblDayMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmChooseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseMenu";
            this.Load += new System.EventHandler(this.FrmChooseMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayMenuTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightMenuTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNightMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdenAddress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDayMenu;
        private System.Windows.Forms.Label lblDayMenuChs;
        private System.Windows.Forms.Label lblNightMenuChs;
        private System.Windows.Forms.Label lblNightMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameChs;
        private System.Windows.Forms.Label lblPhoneChs;
        private System.Windows.Forms.BindingSource dayMenuTblBindingSource;
        private System.Windows.Forms.BindingSource nightMenuTblBindingSource;
        private System.Windows.Forms.BindingSource deliveryTblBindingSource;
        private System.Windows.Forms.Label lblAddressChs;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblYourCateg;
        private System.Windows.Forms.Button btnGenerateQr;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.TextBox tbQrText;
        private System.Windows.Forms.DataGridView dgvDayMenu;
        private System.Windows.Forms.DataGridView dgvNightMenu;
        private System.Windows.Forms.DataGridView dgvIdenAddress;
        private System.Windows.Forms.Panel panel1;
    }
}