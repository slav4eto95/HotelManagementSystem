using System;

namespace HotelReservationSoftware
{
    partial class frmAddReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddReservation));
            this.grpBoxGeneralInfo = new System.Windows.Forms.GroupBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfNigths = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpBookTime = new System.Windows.Forms.DateTimePicker();
            this.lblBookTime = new System.Windows.Forms.Label();
            this.cmbHasCar = new System.Windows.Forms.ComboBox();
            this.lblHasCar = new System.Windows.Forms.Label();
            this.lblNumNights = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultsNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedRoomsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedRoomsDataSet = new HotelReservationSoftware.BookedRoomsDataSet();
            this.grpBoxRoomsAndGuestInfo = new System.Windows.Forms.GroupBox();
            this.btnDeleteRoomInfo = new System.Windows.Forms.Button();
            this.btnEditRoomInfo = new System.Windows.Forms.Button();
            this.btnAddRoomInfo = new System.Windows.Forms.Button();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtEGN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblEGN = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpBoxGuestInfo = new System.Windows.Forms.GroupBox();
            this.cmbRefferedBy = new System.Windows.Forms.ComboBox();
            this.lblRefferedBy = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.bookedServiceIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedServiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedServiceDataSet = new HotelReservationSoftware.BookedServiceDataSet();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtRestSum = new System.Windows.Forms.TextBox();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.grpBoxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.cmbPayMethod = new System.Windows.Forms.ComboBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblRestSum = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblReferenceNo = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.btnDeleteServiceInfo = new System.Windows.Forms.Button();
            this.btnAddServiceInfo = new System.Windows.Forms.Button();
            this.btnEditServiceInfo = new System.Windows.Forms.Button();
            this.grpBoxServicesInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvtxtBookedServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedServicesTableAdapter = new HotelReservationSoftware.BookedServiceDataSetTableAdapters.BookedServicesTableAdapter();
            this.bookedRoomsTableAdapter = new HotelReservationSoftware.BookedRoomsDataSetTableAdapters.BookedRoomsTableAdapter();
            this.grpBoxGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomsDataSet)).BeginInit();
            this.grpBoxRoomsAndGuestInfo.SuspendLayout();
            this.grpBoxGuestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedServiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedServiceDataSet)).BeginInit();
            this.grpBoxPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.grpBoxServicesInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGeneralInfo
            // 
            this.grpBoxGeneralInfo.Controls.Add(this.dtpCheckOut);
            this.grpBoxGeneralInfo.Controls.Add(this.dtpCheckIn);
            this.grpBoxGeneralInfo.Controls.Add(this.txtNumberOfNigths);
            this.grpBoxGeneralInfo.Controls.Add(this.txtNotes);
            this.grpBoxGeneralInfo.Controls.Add(this.lblNotes);
            this.grpBoxGeneralInfo.Controls.Add(this.dtpBookTime);
            this.grpBoxGeneralInfo.Controls.Add(this.lblBookTime);
            this.grpBoxGeneralInfo.Controls.Add(this.cmbHasCar);
            this.grpBoxGeneralInfo.Controls.Add(this.lblHasCar);
            this.grpBoxGeneralInfo.Controls.Add(this.lblNumNights);
            this.grpBoxGeneralInfo.Controls.Add(this.lblCheckOut);
            this.grpBoxGeneralInfo.Controls.Add(this.lblCheckIn);
            this.grpBoxGeneralInfo.Controls.Add(this.cmbStatus);
            this.grpBoxGeneralInfo.Controls.Add(this.lblStatus);
            this.grpBoxGeneralInfo.Controls.Add(this.txtBookingID);
            this.grpBoxGeneralInfo.Controls.Add(this.lblBookingID);
            this.grpBoxGeneralInfo.Location = new System.Drawing.Point(13, 13);
            this.grpBoxGeneralInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxGeneralInfo.Name = "grpBoxGeneralInfo";
            this.grpBoxGeneralInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxGeneralInfo.Size = new System.Drawing.Size(417, 569);
            this.grpBoxGeneralInfo.TabIndex = 17;
            this.grpBoxGeneralInfo.TabStop = false;
            this.grpBoxGeneralInfo.Text = "groupBox1";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(141, 148);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(265, 26);
            this.dtpCheckOut.TabIndex = 4;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            this.dtpCheckOut.GotFocus += new System.EventHandler(this.dtpCheckOut_GotFocus);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(141, 106);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(265, 26);
            this.dtpCheckIn.TabIndex = 3;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            this.dtpCheckIn.GotFocus += new System.EventHandler(this.dtpCheckIn_GotFocus);
            // 
            // txtNumberOfNigths
            // 
            this.txtNumberOfNigths.Enabled = false;
            this.txtNumberOfNigths.Location = new System.Drawing.Point(141, 189);
            this.txtNumberOfNigths.Name = "txtNumberOfNigths";
            this.txtNumberOfNigths.Size = new System.Drawing.Size(265, 26);
            this.txtNumberOfNigths.TabIndex = 5;
            this.txtNumberOfNigths.Text = "0";
            this.txtNumberOfNigths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 367);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(394, 184);
            this.txtNotes.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(8, 326);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 19);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "label8";
            // 
            // dtpBookTime
            // 
            this.dtpBookTime.Location = new System.Drawing.Point(141, 274);
            this.dtpBookTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookTime.Name = "dtpBookTime";
            this.dtpBookTime.Size = new System.Drawing.Size(265, 26);
            this.dtpBookTime.TabIndex = 7;
            // 
            // lblBookTime
            // 
            this.lblBookTime.AutoSize = true;
            this.lblBookTime.Location = new System.Drawing.Point(9, 279);
            this.lblBookTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTime.Name = "lblBookTime";
            this.lblBookTime.Size = new System.Drawing.Size(49, 19);
            this.lblBookTime.TabIndex = 12;
            this.lblBookTime.Text = "label7";
            // 
            // cmbHasCar
            // 
            this.cmbHasCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasCar.FormattingEnabled = true;
            this.cmbHasCar.Items.AddRange(new object[] {
            "Не",
            "Да"});
            this.cmbHasCar.Location = new System.Drawing.Point(141, 228);
            this.cmbHasCar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHasCar.Name = "cmbHasCar";
            this.cmbHasCar.Size = new System.Drawing.Size(265, 26);
            this.cmbHasCar.TabIndex = 6;
            // 
            // lblHasCar
            // 
            this.lblHasCar.AutoSize = true;
            this.lblHasCar.Location = new System.Drawing.Point(8, 233);
            this.lblHasCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasCar.Name = "lblHasCar";
            this.lblHasCar.Size = new System.Drawing.Size(49, 19);
            this.lblHasCar.TabIndex = 10;
            this.lblHasCar.Text = "label6";
            // 
            // lblNumNights
            // 
            this.lblNumNights.AutoSize = true;
            this.lblNumNights.Location = new System.Drawing.Point(8, 192);
            this.lblNumNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumNights.Name = "lblNumNights";
            this.lblNumNights.Size = new System.Drawing.Size(49, 19);
            this.lblNumNights.TabIndex = 9;
            this.lblNumNights.Text = "label5";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCheckOut.Location = new System.Drawing.Point(8, 153);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(50, 19);
            this.lblCheckOut.TabIndex = 6;
            this.lblCheckOut.Text = "label4";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCheckIn.Location = new System.Drawing.Point(9, 111);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 19);
            this.lblCheckIn.TabIndex = 4;
            this.lblCheckIn.Text = "label3";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(141, 64);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(265, 26);
            this.cmbStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(9, 67);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label2";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Location = new System.Drawing.Point(141, 24);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(265, 26);
            this.txtBookingID.TabIndex = 1;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(8, 28);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(46, 19);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "label1";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoGenerateColumns = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn2,
            this.roomIDDataGridViewTextBoxColumn,
            this.RoomTypeDesc,
            this.guestNameDataGridViewTextBoxColumn,
            this.guestPhoneDataGridViewTextBoxColumn,
            this.adultsNoDataGridViewTextBoxColumn,
            this.childNoDataGridViewTextBoxColumn,
            this.roomPriceDataGridView});
            this.dgvRooms.DataSource = this.bookedRoomsBindingSource;
            this.dgvRooms.Location = new System.Drawing.Point(9, 72);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(640, 135);
            this.dgvRooms.TabIndex = 3;
            this.dgvRooms.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRooms_RowsAdded);
            this.dgvRooms.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvRooms_RowsRemoved);
            this.dgvRooms.SelectionChanged += new System.EventHandler(this.dgvRooms_SelectionChanged);
            // 
            // bookingIDDataGridViewTextBoxColumn2
            // 
            this.bookingIDDataGridViewTextBoxColumn2.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn2.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn2.Name = "bookingIDDataGridViewTextBoxColumn2";
            this.bookingIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Стая No";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RoomTypeDesc
            // 
            this.RoomTypeDesc.DataPropertyName = "RoomTypeDesc";
            this.RoomTypeDesc.HeaderText = "Тип на стаята";
            this.RoomTypeDesc.Name = "RoomTypeDesc";
            this.RoomTypeDesc.ReadOnly = true;
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "Име на госта";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestPhoneDataGridViewTextBoxColumn
            // 
            this.guestPhoneDataGridViewTextBoxColumn.DataPropertyName = "GuestPhone";
            this.guestPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.guestPhoneDataGridViewTextBoxColumn.Name = "guestPhoneDataGridViewTextBoxColumn";
            this.guestPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adultsNoDataGridViewTextBoxColumn
            // 
            this.adultsNoDataGridViewTextBoxColumn.DataPropertyName = "AdultsNo";
            this.adultsNoDataGridViewTextBoxColumn.HeaderText = "Възрастни";
            this.adultsNoDataGridViewTextBoxColumn.Name = "adultsNoDataGridViewTextBoxColumn";
            this.adultsNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childNoDataGridViewTextBoxColumn
            // 
            this.childNoDataGridViewTextBoxColumn.DataPropertyName = "ChildNo";
            this.childNoDataGridViewTextBoxColumn.HeaderText = "Деца";
            this.childNoDataGridViewTextBoxColumn.Name = "childNoDataGridViewTextBoxColumn";
            this.childNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomPriceDataGridView
            // 
            this.roomPriceDataGridView.DataPropertyName = "RoomPrice";
            this.roomPriceDataGridView.HeaderText = "Цена";
            this.roomPriceDataGridView.Name = "roomPriceDataGridView";
            this.roomPriceDataGridView.ReadOnly = true;
            // 
            // bookedRoomsBindingSource
            // 
            this.bookedRoomsBindingSource.DataMember = "BookedRooms";
            this.bookedRoomsBindingSource.DataSource = this.bookedRoomsDataSetBindingSource;
            // 
            // bookedRoomsDataSetBindingSource
            // 
            this.bookedRoomsDataSetBindingSource.DataSource = this.bookedRoomsDataSet;
            this.bookedRoomsDataSetBindingSource.Position = 0;
            // 
            // bookedRoomsDataSet
            // 
            this.bookedRoomsDataSet.DataSetName = "BookedRoomsDataSet";
            this.bookedRoomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBoxRoomsAndGuestInfo
            // 
            this.grpBoxRoomsAndGuestInfo.Controls.Add(this.dgvRooms);
            this.grpBoxRoomsAndGuestInfo.Controls.Add(this.btnDeleteRoomInfo);
            this.grpBoxRoomsAndGuestInfo.Controls.Add(this.btnEditRoomInfo);
            this.grpBoxRoomsAndGuestInfo.Controls.Add(this.btnAddRoomInfo);
            this.grpBoxRoomsAndGuestInfo.Location = new System.Drawing.Point(13, 591);
            this.grpBoxRoomsAndGuestInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxRoomsAndGuestInfo.Name = "grpBoxRoomsAndGuestInfo";
            this.grpBoxRoomsAndGuestInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxRoomsAndGuestInfo.Size = new System.Drawing.Size(656, 214);
            this.grpBoxRoomsAndGuestInfo.TabIndex = 20;
            this.grpBoxRoomsAndGuestInfo.TabStop = false;
            this.grpBoxRoomsAndGuestInfo.Text = "groupBox1";
            // 
            // btnDeleteRoomInfo
            // 
            this.btnDeleteRoomInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoomInfo.Enabled = false;
            this.btnDeleteRoomInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoomInfo.Image")));
            this.btnDeleteRoomInfo.Location = new System.Drawing.Point(272, 28);
            this.btnDeleteRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRoomInfo.Name = "btnDeleteRoomInfo";
            this.btnDeleteRoomInfo.Size = new System.Drawing.Size(113, 37);
            this.btnDeleteRoomInfo.TabIndex = 37;
            this.btnDeleteRoomInfo.Text = "button5";
            this.btnDeleteRoomInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteRoomInfo.UseVisualStyleBackColor = true;
            this.btnDeleteRoomInfo.Click += new System.EventHandler(this.btnDeleteRoomInfo_Click);
            // 
            // btnEditRoomInfo
            // 
            this.btnEditRoomInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRoomInfo.Enabled = false;
            this.btnEditRoomInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRoomInfo.Image")));
            this.btnEditRoomInfo.Location = new System.Drawing.Point(141, 28);
            this.btnEditRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRoomInfo.Name = "btnEditRoomInfo";
            this.btnEditRoomInfo.Size = new System.Drawing.Size(127, 37);
            this.btnEditRoomInfo.TabIndex = 36;
            this.btnEditRoomInfo.Text = "button4";
            this.btnEditRoomInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditRoomInfo.UseVisualStyleBackColor = true;
            this.btnEditRoomInfo.Click += new System.EventHandler(this.btnEditRoomInfo_Click);
            // 
            // btnAddRoomInfo
            // 
            this.btnAddRoomInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoomInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoomInfo.Image")));
            this.btnAddRoomInfo.Location = new System.Drawing.Point(9, 28);
            this.btnAddRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoomInfo.Name = "btnAddRoomInfo";
            this.btnAddRoomInfo.Size = new System.Drawing.Size(127, 37);
            this.btnAddRoomInfo.TabIndex = 35;
            this.btnAddRoomInfo.Text = "button3";
            this.btnAddRoomInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRoomInfo.UseVisualStyleBackColor = true;
            this.btnAddRoomInfo.Click += new System.EventHandler(this.btnAddRoomInfo_Click);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(141, 347);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostCode.MaxLength = 4;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(285, 26);
            this.txtPostCode.TabIndex = 30;
            this.txtPostCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostCode_KeyPress);
            // 
            // txtEGN
            // 
            this.txtEGN.Location = new System.Drawing.Point(141, 389);
            this.txtEGN.Margin = new System.Windows.Forms.Padding(4);
            this.txtEGN.MaxLength = 10;
            this.txtEGN.Name = "txtEGN";
            this.txtEGN.Size = new System.Drawing.Size(285, 26);
            this.txtEGN.TabIndex = 31;
            this.txtEGN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEGN_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 474);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 26);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(141, 433);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(285, 26);
            this.txtPhone.TabIndex = 32;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(141, 188);
            this.txtFirmName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(285, 26);
            this.txtFirmName.TabIndex = 26;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 65);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(285, 26);
            this.txtFirstName.TabIndex = 23;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(141, 106);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(285, 26);
            this.txtMiddleName.TabIndex = 24;
            this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddleName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 146);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(285, 26);
            this.txtLastName.TabIndex = 25;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(141, 270);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(285, 26);
            this.txtCity.TabIndex = 28;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(16, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 19);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "label22";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(16, 70);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(59, 19);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "label23";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(16, 109);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(58, 19);
            this.lblMiddleName.TabIndex = 29;
            this.lblMiddleName.Text = "label24";
            // 
            // cmbTitle
            // 
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(141, 26);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(285, 26);
            this.cmbTitle.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 230);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 26);
            this.txtAddress.TabIndex = 27;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(16, 148);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 19);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "label25";
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Location = new System.Drawing.Point(16, 192);
            this.lblFirmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(58, 19);
            this.lblFirmName.TabIndex = 27;
            this.lblFirmName.Text = "label26";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(16, 235);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(58, 19);
            this.lblAddress1.TabIndex = 25;
            this.lblAddress1.Text = "label27";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 275);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 19);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "label29";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(16, 315);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 19);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "label30";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(16, 356);
            this.lblPostCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(55, 19);
            this.lblPostCode.TabIndex = 22;
            this.lblPostCode.Text = "label31";
            // 
            // lblEGN
            // 
            this.lblEGN.AutoSize = true;
            this.lblEGN.Location = new System.Drawing.Point(16, 395);
            this.lblEGN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(58, 19);
            this.lblEGN.TabIndex = 21;
            this.lblEGN.Text = "label32";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 436);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 19);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "label33";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 475);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 19);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "label34";
            // 
            // grpBoxGuestInfo
            // 
            this.grpBoxGuestInfo.Controls.Add(this.cmbRefferedBy);
            this.grpBoxGuestInfo.Controls.Add(this.lblRefferedBy);
            this.grpBoxGuestInfo.Controls.Add(this.cmbCountry);
            this.grpBoxGuestInfo.Controls.Add(this.cmbTitle);
            this.grpBoxGuestInfo.Controls.Add(this.txtPostCode);
            this.grpBoxGuestInfo.Controls.Add(this.txtEGN);
            this.grpBoxGuestInfo.Controls.Add(this.txtEmail);
            this.grpBoxGuestInfo.Controls.Add(this.txtPhone);
            this.grpBoxGuestInfo.Controls.Add(this.txtFirmName);
            this.grpBoxGuestInfo.Controls.Add(this.txtFirstName);
            this.grpBoxGuestInfo.Controls.Add(this.txtAddress);
            this.grpBoxGuestInfo.Controls.Add(this.txtMiddleName);
            this.grpBoxGuestInfo.Controls.Add(this.txtLastName);
            this.grpBoxGuestInfo.Controls.Add(this.txtCity);
            this.grpBoxGuestInfo.Controls.Add(this.lblTitle);
            this.grpBoxGuestInfo.Controls.Add(this.lblFirstName);
            this.grpBoxGuestInfo.Controls.Add(this.lblMiddleName);
            this.grpBoxGuestInfo.Controls.Add(this.lblLastName);
            this.grpBoxGuestInfo.Controls.Add(this.lblFirmName);
            this.grpBoxGuestInfo.Controls.Add(this.lblAddress1);
            this.grpBoxGuestInfo.Controls.Add(this.lblCity);
            this.grpBoxGuestInfo.Controls.Add(this.lblCountry);
            this.grpBoxGuestInfo.Controls.Add(this.lblPostCode);
            this.grpBoxGuestInfo.Controls.Add(this.lblEGN);
            this.grpBoxGuestInfo.Controls.Add(this.lblPhone);
            this.grpBoxGuestInfo.Controls.Add(this.lblEmail);
            this.grpBoxGuestInfo.Location = new System.Drawing.Point(910, 13);
            this.grpBoxGuestInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxGuestInfo.Name = "grpBoxGuestInfo";
            this.grpBoxGuestInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxGuestInfo.Size = new System.Drawing.Size(440, 569);
            this.grpBoxGuestInfo.TabIndex = 19;
            this.grpBoxGuestInfo.TabStop = false;
            this.grpBoxGuestInfo.Text = "groupBox3";
            // 
            // cmbRefferedBy
            // 
            this.cmbRefferedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefferedBy.FormattingEnabled = true;
            this.cmbRefferedBy.Location = new System.Drawing.Point(141, 515);
            this.cmbRefferedBy.Name = "cmbRefferedBy";
            this.cmbRefferedBy.Size = new System.Drawing.Size(285, 26);
            this.cmbRefferedBy.TabIndex = 34;
            // 
            // lblRefferedBy
            // 
            this.lblRefferedBy.AutoSize = true;
            this.lblRefferedBy.Location = new System.Drawing.Point(16, 519);
            this.lblRefferedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefferedBy.Name = "lblRefferedBy";
            this.lblRefferedBy.Size = new System.Drawing.Size(58, 19);
            this.lblRefferedBy.TabIndex = 57;
            this.lblRefferedBy.Text = "label28";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(141, 312);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(285, 26);
            this.cmbCountry.TabIndex = 29;
            this.cmbCountry.SelectedValueChanged += new System.EventHandler(this.cmbCountry_SelectedValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(568, 812);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 37);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "&ОК";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.AutoGenerateColumns = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookedServiceIDDataGridViewTextBoxColumn1,
            this.bookingIDDataGridViewTextBoxColumn1,
            this.serviceIDDataGridViewTextBoxColumn2,
            this.serviceNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvServices.DataSource = this.bookedServicesBindingSource;
            this.dgvServices.Location = new System.Drawing.Point(8, 72);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(641, 134);
            this.dgvServices.TabIndex = 6;
            this.dgvServices.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvServices_RowsAdded);
            this.dgvServices.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvServices_RowsRemoved);
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // bookedServiceIDDataGridViewTextBoxColumn1
            // 
            this.bookedServiceIDDataGridViewTextBoxColumn1.DataPropertyName = "BookedServiceID";
            this.bookedServiceIDDataGridViewTextBoxColumn1.HeaderText = "BookedServiceID";
            this.bookedServiceIDDataGridViewTextBoxColumn1.Name = "bookedServiceIDDataGridViewTextBoxColumn1";
            this.bookedServiceIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookedServiceIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bookingIDDataGridViewTextBoxColumn1
            // 
            this.bookingIDDataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.Name = "bookingIDDataGridViewTextBoxColumn1";
            this.bookingIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // serviceIDDataGridViewTextBoxColumn2
            // 
            this.serviceIDDataGridViewTextBoxColumn2.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn2.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn2.Name = "serviceIDDataGridViewTextBoxColumn2";
            this.serviceIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Общо";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedServicesBindingSource
            // 
            this.bookedServicesBindingSource.DataMember = "BookedServices";
            this.bookedServicesBindingSource.DataSource = this.bookedServiceDataSetBindingSource;
            // 
            // bookedServiceDataSetBindingSource
            // 
            this.bookedServiceDataSetBindingSource.DataSource = this.bookedServiceDataSet;
            this.bookedServiceDataSetBindingSource.Position = 0;
            // 
            // bookedServiceDataSet
            // 
            this.bookedServiceDataSet.DataSetName = "BookedServiceDataSet";
            this.bookedServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(156, 461);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(285, 26);
            this.txtPaid.TabIndex = 20;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // txtRestSum
            // 
            this.txtRestSum.Enabled = false;
            this.txtRestSum.Location = new System.Drawing.Point(156, 500);
            this.txtRestSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtRestSum.Name = "txtRestSum";
            this.txtRestSum.Size = new System.Drawing.Size(285, 26);
            this.txtRestSum.TabIndex = 21;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(156, 253);
            this.txtReferenceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(285, 26);
            this.txtReferenceNo.TabIndex = 15;
            this.txtReferenceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferenceNo_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(156, 423);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(285, 26);
            this.txtTotal.TabIndex = 19;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(156, 294);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(285, 26);
            this.txtInvoiceNumber.TabIndex = 16;
            this.txtInvoiceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(156, 339);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(285, 26);
            this.txtSubtotal.TabIndex = 17;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Enabled = false;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(281, 206);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(160, 26);
            this.cmbYear.TabIndex = 14;
            // 
            // grpBoxPaymentInfo
            // 
            this.grpBoxPaymentInfo.Controls.Add(this.nudDiscount);
            this.grpBoxPaymentInfo.Controls.Add(this.txtPaid);
            this.grpBoxPaymentInfo.Controls.Add(this.txtRestSum);
            this.grpBoxPaymentInfo.Controls.Add(this.txtReferenceNo);
            this.grpBoxPaymentInfo.Controls.Add(this.txtTotal);
            this.grpBoxPaymentInfo.Controls.Add(this.txtInvoiceNumber);
            this.grpBoxPaymentInfo.Controls.Add(this.txtSubtotal);
            this.grpBoxPaymentInfo.Controls.Add(this.cmbYear);
            this.grpBoxPaymentInfo.Controls.Add(this.cmbMonth);
            this.grpBoxPaymentInfo.Controls.Add(this.txtSecurityCode);
            this.grpBoxPaymentInfo.Controls.Add(this.txtCardNumber);
            this.grpBoxPaymentInfo.Controls.Add(this.txtNameOnCard);
            this.grpBoxPaymentInfo.Controls.Add(this.cmbPayMethod);
            this.grpBoxPaymentInfo.Controls.Add(this.lblSubtotal);
            this.grpBoxPaymentInfo.Controls.Add(this.lblDiscount);
            this.grpBoxPaymentInfo.Controls.Add(this.lblTotal);
            this.grpBoxPaymentInfo.Controls.Add(this.lblPaid);
            this.grpBoxPaymentInfo.Controls.Add(this.lblRestSum);
            this.grpBoxPaymentInfo.Controls.Add(this.lblInvoiceNumber);
            this.grpBoxPaymentInfo.Controls.Add(this.lblReferenceNo);
            this.grpBoxPaymentInfo.Controls.Add(this.lblExpirationDate);
            this.grpBoxPaymentInfo.Controls.Add(this.lblSecurityCode);
            this.grpBoxPaymentInfo.Controls.Add(this.lblCardNumber);
            this.grpBoxPaymentInfo.Controls.Add(this.lblNameOnCard);
            this.grpBoxPaymentInfo.Controls.Add(this.lblPayMethod);
            this.grpBoxPaymentInfo.Location = new System.Drawing.Point(442, 13);
            this.grpBoxPaymentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxPaymentInfo.Name = "grpBoxPaymentInfo";
            this.grpBoxPaymentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxPaymentInfo.Size = new System.Drawing.Size(453, 569);
            this.grpBoxPaymentInfo.TabIndex = 18;
            this.grpBoxPaymentInfo.TabStop = false;
            this.grpBoxPaymentInfo.Text = "groupBox2";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(156, 382);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.ReadOnly = true;
            this.nudDiscount.Size = new System.Drawing.Size(285, 26);
            this.nudDiscount.TabIndex = 18;
            this.nudDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDiscount.ValueChanged += new System.EventHandler(this.nudDiscount_ValueChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Enabled = false;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(156, 206);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(116, 26);
            this.cmbMonth.TabIndex = 13;
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Enabled = false;
            this.txtSecurityCode.Location = new System.Drawing.Point(156, 163);
            this.txtSecurityCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(285, 26);
            this.txtSecurityCode.TabIndex = 12;
            this.txtSecurityCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecurityCode_KeyPress);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Location = new System.Drawing.Point(156, 122);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(285, 26);
            this.txtCardNumber.TabIndex = 11;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Enabled = false;
            this.txtNameOnCard.Location = new System.Drawing.Point(156, 82);
            this.txtNameOnCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(285, 26);
            this.txtNameOnCard.TabIndex = 10;
            this.txtNameOnCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameOnCard_KeyPress);
            // 
            // cmbPayMethod
            // 
            this.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMethod.FormattingEnabled = true;
            this.cmbPayMethod.Location = new System.Drawing.Point(156, 42);
            this.cmbPayMethod.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPayMethod.Name = "cmbPayMethod";
            this.cmbPayMethod.Size = new System.Drawing.Size(285, 26);
            this.cmbPayMethod.TabIndex = 9;
            this.cmbPayMethod.SelectedValueChanged += new System.EventHandler(this.cmbPayMethod_SelectedValueChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(8, 342);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(55, 19);
            this.lblSubtotal.TabIndex = 18;
            this.lblSubtotal.Text = "label16";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(8, 384);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 19);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "label17";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(8, 426);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 19);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "label19";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(8, 464);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(58, 19);
            this.lblPaid.TabIndex = 14;
            this.lblPaid.Text = "label20";
            // 
            // lblRestSum
            // 
            this.lblRestSum.AutoSize = true;
            this.lblRestSum.Location = new System.Drawing.Point(8, 503);
            this.lblRestSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestSum.Name = "lblRestSum";
            this.lblRestSum.Size = new System.Drawing.Size(55, 19);
            this.lblRestSum.TabIndex = 13;
            this.lblRestSum.Text = "label21";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(8, 297);
            this.lblInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(55, 19);
            this.lblInvoiceNumber.TabIndex = 13;
            this.lblInvoiceNumber.Text = "label15";
            // 
            // lblReferenceNo
            // 
            this.lblReferenceNo.AutoSize = true;
            this.lblReferenceNo.Location = new System.Drawing.Point(8, 255);
            this.lblReferenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenceNo.Name = "lblReferenceNo";
            this.lblReferenceNo.Size = new System.Drawing.Size(55, 19);
            this.lblReferenceNo.TabIndex = 11;
            this.lblReferenceNo.Text = "label14";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(8, 209);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(55, 19);
            this.lblExpirationDate.TabIndex = 8;
            this.lblExpirationDate.Text = "label13";
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Location = new System.Drawing.Point(8, 166);
            this.lblSecurityCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(55, 19);
            this.lblSecurityCode.TabIndex = 6;
            this.lblSecurityCode.Text = "label12";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(10, 125);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(52, 19);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "label11";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Location = new System.Drawing.Point(8, 89);
            this.lblNameOnCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(55, 19);
            this.lblNameOnCard.TabIndex = 2;
            this.lblNameOnCard.Text = "label10";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayMethod.Location = new System.Drawing.Point(8, 46);
            this.lblPayMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(50, 19);
            this.lblPayMethod.TabIndex = 0;
            this.lblPayMethod.Text = "label9";
            // 
            // btnDeleteServiceInfo
            // 
            this.btnDeleteServiceInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteServiceInfo.Enabled = false;
            this.btnDeleteServiceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteServiceInfo.Image")));
            this.btnDeleteServiceInfo.Location = new System.Drawing.Point(271, 28);
            this.btnDeleteServiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteServiceInfo.Name = "btnDeleteServiceInfo";
            this.btnDeleteServiceInfo.Size = new System.Drawing.Size(113, 37);
            this.btnDeleteServiceInfo.TabIndex = 40;
            this.btnDeleteServiceInfo.Text = "button8";
            this.btnDeleteServiceInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteServiceInfo.UseVisualStyleBackColor = true;
            this.btnDeleteServiceInfo.Click += new System.EventHandler(this.btnDeleteServiceInfo_Click);
            // 
            // btnAddServiceInfo
            // 
            this.btnAddServiceInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddServiceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddServiceInfo.Image")));
            this.btnAddServiceInfo.Location = new System.Drawing.Point(8, 28);
            this.btnAddServiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddServiceInfo.Name = "btnAddServiceInfo";
            this.btnAddServiceInfo.Size = new System.Drawing.Size(127, 37);
            this.btnAddServiceInfo.TabIndex = 38;
            this.btnAddServiceInfo.Text = "button6";
            this.btnAddServiceInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddServiceInfo.UseVisualStyleBackColor = true;
            this.btnAddServiceInfo.Click += new System.EventHandler(this.btnAddServiceInfo_Click);
            // 
            // btnEditServiceInfo
            // 
            this.btnEditServiceInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditServiceInfo.Enabled = false;
            this.btnEditServiceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditServiceInfo.Image")));
            this.btnEditServiceInfo.Location = new System.Drawing.Point(140, 28);
            this.btnEditServiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditServiceInfo.Name = "btnEditServiceInfo";
            this.btnEditServiceInfo.Size = new System.Drawing.Size(127, 37);
            this.btnEditServiceInfo.TabIndex = 39;
            this.btnEditServiceInfo.Text = "button7";
            this.btnEditServiceInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditServiceInfo.UseVisualStyleBackColor = true;
            this.btnEditServiceInfo.Click += new System.EventHandler(this.btnEditServiceInfo_Click);
            // 
            // grpBoxServicesInfo
            // 
            this.grpBoxServicesInfo.Controls.Add(this.dgvServices);
            this.grpBoxServicesInfo.Controls.Add(this.btnDeleteServiceInfo);
            this.grpBoxServicesInfo.Controls.Add(this.btnAddServiceInfo);
            this.grpBoxServicesInfo.Controls.Add(this.btnEditServiceInfo);
            this.grpBoxServicesInfo.Location = new System.Drawing.Point(693, 591);
            this.grpBoxServicesInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxServicesInfo.Name = "grpBoxServicesInfo";
            this.grpBoxServicesInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxServicesInfo.Size = new System.Drawing.Size(656, 213);
            this.grpBoxServicesInfo.TabIndex = 21;
            this.grpBoxServicesInfo.TabStop = false;
            this.grpBoxServicesInfo.Text = "groupBox2";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(693, 812);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 37);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "&Откажи";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvtxtBookedServiceID
            // 
            this.dgvtxtBookedServiceID.DataPropertyName = "BookedServiceID";
            this.dgvtxtBookedServiceID.HeaderText = "BookedServiceID";
            this.dgvtxtBookedServiceID.Name = "dgvtxtBookedServiceID";
            this.dgvtxtBookedServiceID.Visible = false;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookedServiceIDDataGridViewTextBoxColumn
            // 
            this.bookedServiceIDDataGridViewTextBoxColumn.DataPropertyName = "BookedServiceID";
            this.bookedServiceIDDataGridViewTextBoxColumn.HeaderText = "BookedServiceID";
            this.bookedServiceIDDataGridViewTextBoxColumn.Name = "bookedServiceIDDataGridViewTextBoxColumn";
            this.bookedServiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookedServiceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceIDDataGridViewTextBoxColumn1
            // 
            this.serviceIDDataGridViewTextBoxColumn1.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn1.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn1.Name = "serviceIDDataGridViewTextBoxColumn1";
            this.serviceIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn1.Visible = false;
            this.serviceIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // bookedServicesTableAdapter
            // 
            this.bookedServicesTableAdapter.ClearBeforeFill = true;
            // 
            // bookedRoomsTableAdapter
            // 
            this.bookedRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddReservation
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1363, 862);
            this.Controls.Add(this.grpBoxGeneralInfo);
            this.Controls.Add(this.grpBoxRoomsAndGuestInfo);
            this.Controls.Add(this.grpBoxGuestInfo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxPaymentInfo);
            this.Controls.Add(this.grpBoxServicesInfo);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReservation";
            this.Activated += new System.EventHandler(this.frmAddReservation_Activated);
            this.Load += new System.EventHandler(this.frmAddReservation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddReservation_KeyDown);
            this.grpBoxGeneralInfo.ResumeLayout(false);
            this.grpBoxGeneralInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomsDataSet)).EndInit();
            this.grpBoxRoomsAndGuestInfo.ResumeLayout(false);
            this.grpBoxGuestInfo.ResumeLayout(false);
            this.grpBoxGuestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedServiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedServiceDataSet)).EndInit();
            this.grpBoxPaymentInfo.ResumeLayout(false);
            this.grpBoxPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.grpBoxServicesInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxGeneralInfo;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DateTimePicker dtpBookTime;
        private System.Windows.Forms.Label lblBookTime;
        private System.Windows.Forms.ComboBox cmbHasCar;
        private System.Windows.Forms.Label lblHasCar;
        private System.Windows.Forms.Label lblNumNights;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.GroupBox grpBoxRoomsAndGuestInfo;
        private System.Windows.Forms.Button btnDeleteRoomInfo;
        private System.Windows.Forms.Button btnEditRoomInfo;
        private System.Windows.Forms.Button btnAddRoomInfo;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtEGN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblEGN;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpBoxGuestInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtRestSum;
        private System.Windows.Forms.TextBox txtReferenceNo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.GroupBox grpBoxPaymentInfo;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.ComboBox cmbPayMethod;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblRestSum;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblReferenceNo;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.Button btnDeleteServiceInfo;
        private System.Windows.Forms.Button btnAddServiceInfo;
        private System.Windows.Forms.Button btnEditServiceInfo;
        private System.Windows.Forms.GroupBox grpBoxServicesInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblRefferedBy;
        private System.Windows.Forms.ComboBox cmbRefferedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBookedServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedServiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bookedServiceDataSetBindingSource;
        private BookedServiceDataSet bookedServiceDataSet;
        private System.Windows.Forms.BindingSource bookedServicesBindingSource;
        private BookedServiceDataSetTableAdapters.BookedServicesTableAdapter bookedServicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedServiceIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookedRoomsDataSetBindingSource;
        private BookedRoomsDataSet bookedRoomsDataSet;
        private System.Windows.Forms.BindingSource bookedRoomsBindingSource;
        private BookedRoomsDataSetTableAdapters.BookedRoomsTableAdapter bookedRoomsTableAdapter;
        private System.Windows.Forms.TextBox txtNumberOfNigths;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridView;
    }
}