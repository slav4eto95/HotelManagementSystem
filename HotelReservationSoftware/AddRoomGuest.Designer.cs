namespace HotelReservationSoftware
{
    partial class frmAddRoomGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRoomGuest));
            this.nudNumChilds = new System.Windows.Forms.NumericUpDown();
            this.nudNumAdults = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblNumOfChilds = new System.Windows.Forms.Label();
            this.lblNumOfAdults = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsDataSet = new HotelReservationSoftware.RoomsDataSet();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.roomsTableAdapter = new HotelReservationSoftware.RoomsDataSetTableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumChilds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumChilds
            // 
            this.nudNumChilds.Location = new System.Drawing.Point(139, 296);
            this.nudNumChilds.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumChilds.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumChilds.Name = "nudNumChilds";
            this.nudNumChilds.Size = new System.Drawing.Size(215, 26);
            this.nudNumChilds.TabIndex = 32;
            this.nudNumChilds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudNumAdults
            // 
            this.nudNumAdults.Location = new System.Drawing.Point(139, 251);
            this.nudNumAdults.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumAdults.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumAdults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumAdults.Name = "nudNumAdults";
            this.nudNumAdults.Size = new System.Drawing.Size(215, 26);
            this.nudNumAdults.TabIndex = 31;
            this.nudNumAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(139, 202);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 26);
            this.txtEmail.TabIndex = 30;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(139, 155);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 26);
            this.txtPhone.TabIndex = 29;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Location = new System.Drawing.Point(139, 111);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(213, 26);
            this.txtGuestName.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(218, 346);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 33);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&Откажи";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(126, 346);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 33);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "&ОК";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(23, 26);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(46, 19);
            this.lblRoomID.TabIndex = 17;
            this.lblRoomID.Text = "label1";
            // 
            // lblNumOfChilds
            // 
            this.lblNumOfChilds.AutoSize = true;
            this.lblNumOfChilds.Location = new System.Drawing.Point(23, 299);
            this.lblNumOfChilds.Name = "lblNumOfChilds";
            this.lblNumOfChilds.Size = new System.Drawing.Size(49, 19);
            this.lblNumOfChilds.TabIndex = 23;
            this.lblNumOfChilds.Text = "label7";
            // 
            // lblNumOfAdults
            // 
            this.lblNumOfAdults.AutoSize = true;
            this.lblNumOfAdults.Location = new System.Drawing.Point(23, 253);
            this.lblNumOfAdults.Name = "lblNumOfAdults";
            this.lblNumOfAdults.Size = new System.Drawing.Size(49, 19);
            this.lblNumOfAdults.TabIndex = 22;
            this.lblNumOfAdults.Text = "label6";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "label5";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 19);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "label4";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(23, 115);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(49, 19);
            this.lblGuestName.TabIndex = 19;
            this.lblGuestName.Text = "label3";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(23, 70);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(49, 19);
            this.lblRoomType.TabIndex = 18;
            this.lblRoomType.Text = "label2";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DataSource = this.roomsBindingSource;
            this.cmbRoomType.DisplayMember = "RoomTypeDesc";
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(139, 67);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(213, 26);
            this.cmbRoomType.TabIndex = 34;
            this.cmbRoomType.ValueMember = "RoomID";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomsDataSet;
            // 
            // roomsDataSet
            // 
            this.roomsDataSet.DataSetName = "RoomsDataSet";
            this.roomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbRooms
            // 
            this.cmbRooms.DataSource = this.roomsBindingSource;
            this.cmbRooms.DisplayMember = "RoomID";
            this.cmbRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(139, 23);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(213, 26);
            this.cmbRooms.TabIndex = 35;
            this.cmbRooms.ValueMember = "RoomTypeDesc";
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddRoomGuest
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(399, 395);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.nudNumChilds);
            this.Controls.Add(this.nudNumAdults);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblNumOfChilds);
            this.Controls.Add(this.lblNumOfAdults);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblRoomType);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddRoomGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoomGuest";
            this.Load += new System.EventHandler(this.frmAddRoomGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumChilds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNumChilds;
        private System.Windows.Forms.NumericUpDown nudNumAdults;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblNumOfChilds;
        private System.Windows.Forms.Label lblNumOfAdults;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbRooms;
        private RoomsDataSet roomsDataSet;
        private RoomsDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}