namespace HotelReservationSoftware
{
    partial class frmAllReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllReservations));
            this.dgvAllReservations = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasCarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referredByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allReservationsDataSet = new HotelReservationSoftware.AllReservationsDataSet();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnEditReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.bookingsTableAdapter = new HotelReservationSoftware.AllReservationsDataSetTableAdapters.BookingsTableAdapter();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllReservations
            // 
            this.dgvAllReservations.AllowUserToAddRows = false;
            this.dgvAllReservations.AllowUserToDeleteRows = false;
            this.dgvAllReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllReservations.AutoGenerateColumns = false;
            this.dgvAllReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllReservations.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvAllReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.bookingStatusNameDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.checkInDataGridViewTextBoxColumn,
            this.checkOutDataGridViewTextBoxColumn,
            this.nightsDataGridViewTextBoxColumn,
            this.hasCarDataGridViewTextBoxColumn,
            this.bookDateDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.totalSumDataGridViewTextBoxColumn,
            this.restSumDataGridViewTextBoxColumn,
            this.referredByDataGridViewTextBoxColumn});
            this.dgvAllReservations.DataSource = this.bookingsBindingSource;
            this.dgvAllReservations.Location = new System.Drawing.Point(0, 0);
            this.dgvAllReservations.Name = "dgvAllReservations";
            this.dgvAllReservations.ReadOnly = true;
            this.dgvAllReservations.RowTemplate.Height = 24;
            this.dgvAllReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllReservations.Size = new System.Drawing.Size(1687, 613);
            this.dgvAllReservations.TabIndex = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookingStatusNameDataGridViewTextBoxColumn
            // 
            this.bookingStatusNameDataGridViewTextBoxColumn.DataPropertyName = "BookingStatusName";
            this.bookingStatusNameDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.bookingStatusNameDataGridViewTextBoxColumn.Name = "bookingStatusNameDataGridViewTextBoxColumn";
            this.bookingStatusNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "Гост";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            this.checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.HeaderText = "Настаняване";
            this.checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            this.checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            this.checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.HeaderText = "Напускане";
            this.checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            this.checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nightsDataGridViewTextBoxColumn
            // 
            this.nightsDataGridViewTextBoxColumn.DataPropertyName = "Nights";
            this.nightsDataGridViewTextBoxColumn.HeaderText = "Нощувки";
            this.nightsDataGridViewTextBoxColumn.Name = "nightsDataGridViewTextBoxColumn";
            this.nightsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasCarDataGridViewTextBoxColumn
            // 
            this.hasCarDataGridViewTextBoxColumn.DataPropertyName = "HasCar";
            this.hasCarDataGridViewTextBoxColumn.HeaderText = "Кола";
            this.hasCarDataGridViewTextBoxColumn.Name = "hasCarDataGridViewTextBoxColumn";
            this.hasCarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookDateDataGridViewTextBoxColumn
            // 
            this.bookDateDataGridViewTextBoxColumn.DataPropertyName = "BookDate";
            this.bookDateDataGridViewTextBoxColumn.HeaderText = "Дата на резервация";
            this.bookDateDataGridViewTextBoxColumn.Name = "bookDateDataGridViewTextBoxColumn";
            this.bookDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Имейл";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Забележки";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "Обща сума";
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restSumDataGridViewTextBoxColumn
            // 
            this.restSumDataGridViewTextBoxColumn.DataPropertyName = "RestSum";
            this.restSumDataGridViewTextBoxColumn.HeaderText = "Оставаща сума";
            this.restSumDataGridViewTextBoxColumn.Name = "restSumDataGridViewTextBoxColumn";
            this.restSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referredByDataGridViewTextBoxColumn
            // 
            this.referredByDataGridViewTextBoxColumn.DataPropertyName = "ReferredBy";
            this.referredByDataGridViewTextBoxColumn.HeaderText = "Препоръчан от";
            this.referredByDataGridViewTextBoxColumn.Name = "referredByDataGridViewTextBoxColumn";
            this.referredByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.allReservationsDataSet;
            // 
            // allReservationsDataSet
            // 
            this.allReservationsDataSet.DataSetName = "AllReservationsDataSet";
            this.allReservationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.Location = new System.Drawing.Point(31, 637);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(111, 41);
            this.btnNewReservation.TabIndex = 1;
            this.btnNewReservation.Text = "Нов";
            this.btnNewReservation.UseVisualStyleBackColor = true;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.Location = new System.Drawing.Point(143, 637);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Size = new System.Drawing.Size(111, 41);
            this.btnEditReservation.TabIndex = 1;
            this.btnEditReservation.Text = "Редактирай";
            this.btnEditReservation.UseVisualStyleBackColor = true;
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(255, 637);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(111, 41);
            this.btnDeleteReservation.TabIndex = 1;
            this.btnDeleteReservation.Text = "Изтрий";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(1422, 632);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(138, 50);
            this.btnPrintReceipt.TabIndex = 2;
            this.btnPrintReceipt.Text = "Принтирай касова бележка";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(1566, 632);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(109, 50);
            this.btnExportData.TabIndex = 2;
            this.btnExportData.Text = "Експорт...";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // frmAllReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1687, 706);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnEditReservation);
            this.Controls.Add(this.btnNewReservation);
            this.Controls.Add(this.dgvAllReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Всички резервации";
            this.Activated += new System.EventHandler(this.frmAllReservations_Activated);
            this.Load += new System.EventHandler(this.frmAllReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllReservations;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnEditReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private AllReservationsDataSet allReservationsDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private AllReservationsDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referredByDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnExportData;
    }
}