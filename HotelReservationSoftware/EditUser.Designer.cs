namespace HotelReservationSoftware
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            this.cmbUserLevel = new System.Windows.Forms.ComboBox();
            this.userLevelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userLevelsDataSet = new HotelReservationSoftware.UserLevelsDataSet();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.userLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLevelsTableAdapter = new HotelReservationSoftware.HotelManagementSystemDataSetTableAdapters.UserLevelsTableAdapter();
            this.userLevelsTableAdapter1 = new HotelReservationSoftware.UserLevelsDataSetTableAdapters.UserLevelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUserLevel
            // 
            this.cmbUserLevel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userLevelsBindingSource1, "UserLevelDesc", true));
            this.cmbUserLevel.DataSource = this.userLevelsBindingSource1;
            this.cmbUserLevel.DisplayMember = "UserLevelDesc";
            this.cmbUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserLevel.FormattingEnabled = true;
            this.cmbUserLevel.Location = new System.Drawing.Point(540, 100);
            this.cmbUserLevel.Name = "cmbUserLevel";
            this.cmbUserLevel.Size = new System.Drawing.Size(151, 24);
            this.cmbUserLevel.TabIndex = 16;
            this.cmbUserLevel.ValueMember = "UserLevelID";
            // 
            // userLevelsBindingSource1
            // 
            this.userLevelsBindingSource1.DataMember = "UserLevels";
            this.userLevelsBindingSource1.DataSource = this.userLevelsDataSet;
            // 
            // userLevelsDataSet
            // 
            this.userLevelsDataSet.DataSetName = "UserLevelsDataSet";
            this.userLevelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(202, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 22);
            this.txtUserName.TabIndex = 13;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(47, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(143, 17);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Потребителско име:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(385, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 17);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Парола:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(540, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.Location = new System.Drawing.Point(385, 103);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(149, 17);
            this.lblUserLevel.TabIndex = 11;
            this.lblUserLevel.Text = "Потребителско ниво:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Име:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 47);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Съхрани";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(388, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 47);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // userLevelsTableAdapter
            // 
            this.userLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // userLevelsTableAdapter1
            // 
            this.userLevelsTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEditUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(762, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUserLevel);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирай потребител";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userLevelsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserLevel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource userLevelsBindingSource;
        private HotelManagementSystemDataSetTableAdapters.UserLevelsTableAdapter userLevelsTableAdapter;
        private UserLevelsDataSet userLevelsDataSet;
        private System.Windows.Forms.BindingSource userLevelsBindingSource1;
        private UserLevelsDataSetTableAdapters.UserLevelsTableAdapter userLevelsTableAdapter1;
    }
}