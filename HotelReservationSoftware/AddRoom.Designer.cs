namespace HotelReservationSoftware
{
    partial class frmAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRoom));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblMaxAdultNo = new System.Windows.Forms.Label();
            this.lblMaxChildNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblBedType = new System.Windows.Forms.Label();
            this.lblSmokingAllowed = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtMaxAdultsNo = new System.Windows.Forms.TextBox();
            this.txtMaxChildNo = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.roomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypesDataSet = new HotelReservationSoftware.RoomTypesDataSet();
            this.cmbBedType = new System.Windows.Forms.ComboBox();
            this.cmbSmokingAllowed = new System.Windows.Forms.ComboBox();
            this.roomTypesTableAdapter = new HotelReservationSoftware.RoomTypesDataSetTableAdapters.RoomTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(228, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 43);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(353, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoomNo.Location = new System.Drawing.Point(12, 23);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(77, 19);
            this.lblRoomNo.TabIndex = 1;
            this.lblRoomNo.Text = "Стая No *";
            // 
            // lblMaxAdultNo
            // 
            this.lblMaxAdultNo.AutoSize = true;
            this.lblMaxAdultNo.Location = new System.Drawing.Point(12, 74);
            this.lblMaxAdultNo.Name = "lblMaxAdultNo";
            this.lblMaxAdultNo.Size = new System.Drawing.Size(128, 38);
            this.lblMaxAdultNo.TabIndex = 1;
            this.lblMaxAdultNo.Text = "Максимален брой\r\nвъзрастни";
            // 
            // lblMaxChildNo
            // 
            this.lblMaxChildNo.AutoSize = true;
            this.lblMaxChildNo.Location = new System.Drawing.Point(12, 144);
            this.lblMaxChildNo.Name = "lblMaxChildNo";
            this.lblMaxChildNo.Size = new System.Drawing.Size(128, 38);
            this.lblMaxChildNo.TabIndex = 1;
            this.lblMaxChildNo.Text = "Максимален брой\r\nдеца";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoomType.Location = new System.Drawing.Point(331, 23);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(122, 19);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Тип на стаята *";
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.Location = new System.Drawing.Point(330, 87);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(116, 19);
            this.lblBedType.TabIndex = 1;
            this.lblBedType.Text = "Тип на леглото";
            // 
            // lblSmokingAllowed
            // 
            this.lblSmokingAllowed.AutoSize = true;
            this.lblSmokingAllowed.Location = new System.Drawing.Point(331, 154);
            this.lblSmokingAllowed.Name = "lblSmokingAllowed";
            this.lblSmokingAllowed.Size = new System.Drawing.Size(64, 19);
            this.lblSmokingAllowed.TabIndex = 1;
            this.lblSmokingAllowed.Text = "Пушене";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(154, 21);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(161, 26);
            this.txtRoomNo.TabIndex = 2;
            // 
            // txtMaxAdultsNo
            // 
            this.txtMaxAdultsNo.Enabled = false;
            this.txtMaxAdultsNo.Location = new System.Drawing.Point(154, 84);
            this.txtMaxAdultsNo.Name = "txtMaxAdultsNo";
            this.txtMaxAdultsNo.Size = new System.Drawing.Size(161, 26);
            this.txtMaxAdultsNo.TabIndex = 2;
            // 
            // txtMaxChildNo
            // 
            this.txtMaxChildNo.Enabled = false;
            this.txtMaxChildNo.Location = new System.Drawing.Point(154, 147);
            this.txtMaxChildNo.Name = "txtMaxChildNo";
            this.txtMaxChildNo.Size = new System.Drawing.Size(161, 26);
            this.txtMaxChildNo.TabIndex = 2;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DataSource = this.roomTypesBindingSource;
            this.cmbRoomType.DisplayMember = "RoomTypeDesc";
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(472, 21);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(177, 26);
            this.cmbRoomType.TabIndex = 3;
            this.cmbRoomType.ValueMember = "RoomTypeDesc";
            this.cmbRoomType.SelectedValueChanged += new System.EventHandler(this.cmbRoomType_SelectedValueChanged);
            // 
            // roomTypesBindingSource
            // 
            this.roomTypesBindingSource.DataMember = "RoomTypes";
            this.roomTypesBindingSource.DataSource = this.roomTypesDataSet;
            // 
            // roomTypesDataSet
            // 
            this.roomTypesDataSet.DataSetName = "RoomTypesDataSet";
            this.roomTypesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBedType
            // 
            this.cmbBedType.DataSource = this.roomTypesBindingSource;
            this.cmbBedType.DisplayMember = "BedType";
            this.cmbBedType.Enabled = false;
            this.cmbBedType.FormattingEnabled = true;
            this.cmbBedType.Location = new System.Drawing.Point(472, 84);
            this.cmbBedType.Name = "cmbBedType";
            this.cmbBedType.Size = new System.Drawing.Size(177, 26);
            this.cmbBedType.TabIndex = 3;
            this.cmbBedType.ValueMember = "BedType";
            // 
            // cmbSmokingAllowed
            // 
            this.cmbSmokingAllowed.Enabled = false;
            this.cmbSmokingAllowed.FormattingEnabled = true;
            this.cmbSmokingAllowed.Items.AddRange(new object[] {
            "Не",
            "Да"});
            this.cmbSmokingAllowed.Location = new System.Drawing.Point(472, 147);
            this.cmbSmokingAllowed.Name = "cmbSmokingAllowed";
            this.cmbSmokingAllowed.Size = new System.Drawing.Size(177, 26);
            this.cmbSmokingAllowed.TabIndex = 3;
            // 
            // roomTypesTableAdapter
            // 
            this.roomTypesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddRoom
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(665, 269);
            this.Controls.Add(this.cmbSmokingAllowed);
            this.Controls.Add(this.cmbBedType);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtMaxChildNo);
            this.Controls.Add(this.txtMaxAdultsNo);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.lblSmokingAllowed);
            this.Controls.Add(this.lblBedType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblMaxChildNo);
            this.Controls.Add(this.lblMaxAdultNo);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Room";
            this.Load += new System.EventHandler(this.frmAddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblMaxAdultNo;
        private System.Windows.Forms.Label lblMaxChildNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.Label lblSmokingAllowed;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtMaxAdultsNo;
        private System.Windows.Forms.TextBox txtMaxChildNo;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbBedType;
        private System.Windows.Forms.ComboBox cmbSmokingAllowed;
        private RoomTypesDataSet roomTypesDataSet;
        private System.Windows.Forms.BindingSource roomTypesBindingSource;
        private RoomTypesDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
    }
}