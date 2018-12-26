namespace HotelReservationSoftware
{
    partial class frmAllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllUsers));
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(474, 306);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 41);
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.Text = "Изтрий";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(229, 306);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(95, 41);
            this.btnNewRecord.TabIndex = 15;
            this.btnNewRecord.Text = "Нов";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(349, 306);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 41);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtName,
            this.dgvtxtUserName,
            this.dgvtxtUserLevelID,
            this.dgvtxtPass,
            this.dgvtxtUserID});
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.GridColor = System.Drawing.Color.MediumAquamarine;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(789, 291);
            this.dgvUsers.TabIndex = 0;
            // 
            // dgvtxtName
            // 
            this.dgvtxtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtName.DataPropertyName = "Name";
            this.dgvtxtName.HeaderText = "Потребител";
            this.dgvtxtName.Name = "dgvtxtName";
            this.dgvtxtName.ReadOnly = true;
            // 
            // dgvtxtUserName
            // 
            this.dgvtxtUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtUserName.DataPropertyName = "Username";
            this.dgvtxtUserName.HeaderText = "Потребителско име";
            this.dgvtxtUserName.Name = "dgvtxtUserName";
            this.dgvtxtUserName.ReadOnly = true;
            // 
            // dgvtxtUserLevelID
            // 
            this.dgvtxtUserLevelID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtUserLevelID.DataPropertyName = "UserLevelID";
            this.dgvtxtUserLevelID.HeaderText = "Потребителско ниво";
            this.dgvtxtUserLevelID.Name = "dgvtxtUserLevelID";
            this.dgvtxtUserLevelID.ReadOnly = true;
            // 
            // dgvtxtPass
            // 
            this.dgvtxtPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtPass.DataPropertyName = "Password";
            this.dgvtxtPass.HeaderText = "Password";
            this.dgvtxtPass.Name = "dgvtxtPass";
            this.dgvtxtPass.ReadOnly = true;
            this.dgvtxtPass.Visible = false;
            // 
            // dgvtxtUserID
            // 
            this.dgvtxtUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtUserID.DataPropertyName = "UserID";
            this.dgvtxtUserID.HeaderText = "UserID";
            this.dgvtxtUserID.Name = "dgvtxtUserID";
            this.dgvtxtUserID.ReadOnly = true;
            this.dgvtxtUserID.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(HotelReservationSoftware.UsersDTO);
            // 
            // userLevelBindingSource
            // 
            this.userLevelBindingSource.DataSource = typeof(HotelReservationSoftware.UserLevel);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(HotelReservationSoftware.UsersDTO);
            // 
            // frmAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(789, 370);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewRecord);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dgvUsers);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Всички потребители";
            this.Activated += new System.EventHandler(this.frmAllUsers_Activated);
            this.Load += new System.EventHandler(this.AllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userLevelBindingSource;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserID;
    }
}