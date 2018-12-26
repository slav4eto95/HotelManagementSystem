namespace HotelReservationSoftware
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.cmbUserLevel = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.cbViewPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(66, 244);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(149, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Потребителско име:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(66, 318);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Парола:";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(66, 392);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(123, 19);
            this.lblPassword2.TabIndex = 3;
            this.lblPassword2.Text = "Повтори парола:";
            // 
            // cmbUserLevel
            // 
            this.cmbUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserLevel.FormattingEnabled = true;
            this.cmbUserLevel.Location = new System.Drawing.Point(243, 98);
            this.cmbUserLevel.Name = "cmbUserLevel";
            this.cmbUserLevel.Size = new System.Drawing.Size(151, 26);
            this.cmbUserLevel.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(243, 315);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(243, 241);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(124, 455);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 43);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(261, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(118, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Създай своя акаунт";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(243, 389);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(151, 26);
            this.txtPassword2.TabIndex = 5;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.Location = new System.Drawing.Point(66, 101);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(48, 19);
            this.lblUserLevel.TabIndex = 12;
            this.lblUserLevel.Text = "Ниво:";
            // 
            // cbViewPassword
            // 
            this.cbViewPassword.AutoSize = true;
            this.cbViewPassword.Location = new System.Drawing.Point(243, 351);
            this.cbViewPassword.Name = "cbViewPassword";
            this.cbViewPassword.Size = new System.Drawing.Size(136, 23);
            this.cbViewPassword.TabIndex = 13;
            this.cbViewPassword.Text = "Покажи парола";
            this.cbViewPassword.UseVisualStyleBackColor = true;
            this.cbViewPassword.CheckedChanged += new System.EventHandler(this.cbViewPassword_CheckedChanged);
            // 
            // frmRegistration
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(483, 537);
            this.Controls.Add(this.cbViewPassword);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbUserLevel);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.ComboBox cmbUserLevel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.CheckBox cbViewPassword;
    }
}