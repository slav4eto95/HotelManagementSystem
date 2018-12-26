namespace HotelReservationSoftware
{
    partial class frmDBBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBBackupRestore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDataBase = new System.Windows.Forms.ComboBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.chk_Insec = new System.Windows.Forms.CheckBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lblServerPass = new System.Windows.Forms.Label();
            this.lblServerUserName = new System.Windows.Forms.Label();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.db_change = new System.Windows.Forms.Button();
            this.server_change = new System.Windows.Forms.Button();
            this.lblNameOfServer = new System.Windows.Forms.Label();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDataBase);
            this.groupBox1.Controls.Add(this.cmbServer);
            this.groupBox1.Controls.Add(this.chk_Insec);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.lblServerPass);
            this.groupBox1.Controls.Add(this.lblServerUserName);
            this.groupBox1.Controls.Add(this.pb_status);
            this.groupBox1.Controls.Add(this.lblDataBase);
            this.groupBox1.Controls.Add(this.db_change);
            this.groupBox1.Controls.Add(this.server_change);
            this.groupBox1.Controls.Add(this.lblNameOfServer);
            this.groupBox1.Controls.Add(this.btn_restore);
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // cmbDataBase
            // 
            this.cmbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBase.FormattingEnabled = true;
            this.cmbDataBase.Location = new System.Drawing.Point(373, 174);
            this.cmbDataBase.Name = "cmbDataBase";
            this.cmbDataBase.Size = new System.Drawing.Size(166, 28);
            this.cmbDataBase.TabIndex = 15;
            this.cmbDataBase.SelectedValueChanged += new System.EventHandler(this.cmbDataBase_SelectedValueChanged);
            this.cmbDataBase.Click += new System.EventHandler(this.cmbDataBase_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(373, 33);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(166, 28);
            this.cmbServer.TabIndex = 14;
            this.cmbServer.SelectedValueChanged += new System.EventHandler(this.cmbServer_SelectedValueChanged);
            // 
            // chk_Insec
            // 
            this.chk_Insec.AutoSize = true;
            this.chk_Insec.Location = new System.Drawing.Point(373, 139);
            this.chk_Insec.Name = "chk_Insec";
            this.chk_Insec.Size = new System.Drawing.Size(173, 24);
            this.chk_Insec.TabIndex = 13;
            this.chk_Insec.Text = "Integrated Security";
            this.chk_Insec.UseVisualStyleBackColor = true;
            this.chk_Insec.CheckedChanged += new System.EventHandler(this.chk_Insec_CheckedChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(373, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(166, 28);
            this.txt_username.TabIndex = 12;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(373, 109);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(166, 28);
            this.txt_password.TabIndex = 11;
            // 
            // lblServerPass
            // 
            this.lblServerPass.AutoSize = true;
            this.lblServerPass.Location = new System.Drawing.Point(238, 112);
            this.lblServerPass.Name = "lblServerPass";
            this.lblServerPass.Size = new System.Drawing.Size(66, 20);
            this.lblServerPass.TabIndex = 10;
            this.lblServerPass.Text = "Парола";
            // 
            // lblServerUserName
            // 
            this.lblServerUserName.AutoSize = true;
            this.lblServerUserName.Location = new System.Drawing.Point(238, 68);
            this.lblServerUserName.Name = "lblServerUserName";
            this.lblServerUserName.Size = new System.Drawing.Size(126, 40);
            this.lblServerUserName.TabIndex = 9;
            this.lblServerUserName.Text = "Потребителско \r\nиме";
            // 
            // pb_status
            // 
            this.pb_status.Image = ((System.Drawing.Image)(resources.GetObject("pb_status.Image")));
            this.pb_status.Location = new System.Drawing.Point(6, 22);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(226, 210);
            this.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_status.TabIndex = 8;
            this.pb_status.TabStop = false;
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(238, 178);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(108, 20);
            this.lblDataBase.TabIndex = 4;
            this.lblDataBase.Text = "База от данни";
            // 
            // db_change
            // 
            this.db_change.Location = new System.Drawing.Point(545, 174);
            this.db_change.Name = "db_change";
            this.db_change.Size = new System.Drawing.Size(87, 29);
            this.db_change.TabIndex = 3;
            this.db_change.Text = "Промени";
            this.db_change.UseVisualStyleBackColor = true;
            this.db_change.Click += new System.EventHandler(this.db_change_Click);
            // 
            // server_change
            // 
            this.server_change.Location = new System.Drawing.Point(545, 32);
            this.server_change.Name = "server_change";
            this.server_change.Size = new System.Drawing.Size(87, 30);
            this.server_change.TabIndex = 3;
            this.server_change.Text = "Промени";
            this.server_change.UseVisualStyleBackColor = true;
            this.server_change.Click += new System.EventHandler(this.server_change_Click);
            // 
            // lblNameOfServer
            // 
            this.lblNameOfServer.AutoSize = true;
            this.lblNameOfServer.Location = new System.Drawing.Point(238, 37);
            this.lblNameOfServer.Name = "lblNameOfServer";
            this.lblNameOfServer.Size = new System.Drawing.Size(121, 20);
            this.lblNameOfServer.TabIndex = 1;
            this.lblNameOfServer.Text = "Име на сървъра";
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(464, 207);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(75, 33);
            this.btn_restore.TabIndex = 0;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(373, 207);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(85, 33);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDBBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(677, 302);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDBBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/ Restore Database";
            this.Load += new System.EventHandler(this.frmDBBackupRestore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDataBase;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.CheckBox chk_Insec;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lblServerPass;
        private System.Windows.Forms.Label lblServerUserName;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Button db_change;
        private System.Windows.Forms.Button server_change;
        private System.Windows.Forms.Label lblNameOfServer;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}