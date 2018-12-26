namespace HotelReservationSoftware
{
    partial class frmCheckInCheckOutGuests
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
            this.checkInCheckOutToday = new HotelReservationSoftware.CheckInCheckOutToday();
            this.todayCheckInBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.todayCheckInTableAdapter = new HotelReservationSoftware.CheckInCheckOutTodayTableAdapters.TodayCheckInTableAdapter();
            this.tableAdapterManager = new HotelReservationSoftware.CheckInCheckOutTodayTableAdapters.TableAdapterManager();
            this.todayCheckInBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.todayCheckInCheckOutDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todayCheckOutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.todayCheckOutTableAdapter = new HotelReservationSoftware.CheckInCheckOutTodayTableAdapters.TodayCheckOutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkInCheckOutToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckInBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckInBindingSource1BindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckInCheckOutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckOutBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkInCheckOutToday
            // 
            this.checkInCheckOutToday.DataSetName = "CheckInCheckOutToday";
            this.checkInCheckOutToday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todayCheckInBindingSource1
            // 
            this.todayCheckInBindingSource1.DataMember = "TodayCheckIn";
            this.todayCheckInBindingSource1.DataSource = this.checkInCheckOutToday;
            // 
            // todayCheckInTableAdapter
            // 
            this.todayCheckInTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = HotelReservationSoftware.CheckInCheckOutTodayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // todayCheckInBindingSource1BindingNavigator
            // 
            this.todayCheckInBindingSource1BindingNavigator.AddNewItem = null;
            this.todayCheckInBindingSource1BindingNavigator.BindingSource = this.todayCheckInBindingSource1;
            this.todayCheckInBindingSource1BindingNavigator.CountItem = null;
            this.todayCheckInBindingSource1BindingNavigator.DeleteItem = null;
            this.todayCheckInBindingSource1BindingNavigator.Enabled = false;
            this.todayCheckInBindingSource1BindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.todayCheckInBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.todayCheckInBindingSource1BindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.todayCheckInBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.todayCheckInBindingSource1BindingNavigator.MoveFirstItem = null;
            this.todayCheckInBindingSource1BindingNavigator.MoveLastItem = null;
            this.todayCheckInBindingSource1BindingNavigator.MoveNextItem = null;
            this.todayCheckInBindingSource1BindingNavigator.MovePreviousItem = null;
            this.todayCheckInBindingSource1BindingNavigator.Name = "todayCheckInBindingSource1BindingNavigator";
            this.todayCheckInBindingSource1BindingNavigator.PositionItem = null;
            this.todayCheckInBindingSource1BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.todayCheckInBindingSource1BindingNavigator.Size = new System.Drawing.Size(1687, 25);
            this.todayCheckInBindingSource1BindingNavigator.TabIndex = 0;
            this.todayCheckInBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // todayCheckInCheckOutDataGridView
            // 
            this.todayCheckInCheckOutDataGridView.AllowUserToAddRows = false;
            this.todayCheckInCheckOutDataGridView.AllowUserToDeleteRows = false;
            this.todayCheckInCheckOutDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayCheckInCheckOutDataGridView.AutoGenerateColumns = false;
            this.todayCheckInCheckOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todayCheckInCheckOutDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.todayCheckInCheckOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todayCheckInCheckOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.todayCheckInCheckOutDataGridView.DataSource = this.todayCheckInBindingSource1;
            this.todayCheckInCheckOutDataGridView.Location = new System.Drawing.Point(0, 25);
            this.todayCheckInCheckOutDataGridView.Name = "todayCheckInCheckOutDataGridView";
            this.todayCheckInCheckOutDataGridView.ReadOnly = true;
            this.todayCheckInCheckOutDataGridView.RowTemplate.Height = 24;
            this.todayCheckInCheckOutDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todayCheckInCheckOutDataGridView.Size = new System.Drawing.Size(1687, 679);
            this.todayCheckInCheckOutDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookingStatusName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Статус на резервацията";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GuestName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име на госта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Настаняване";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn4.HeaderText = "Напускане";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nights";
            this.dataGridViewTextBoxColumn5.HeaderText = "Нощувки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HasCar";
            this.dataGridViewTextBoxColumn6.HeaderText = "Кола";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BookDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата на резервация";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Забележки";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CreditCardName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Име върху кредитната карта";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CreditCardNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Номер на кредитната карта";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CreditCardSecurityCode";
            this.dataGridViewTextBoxColumn11.HeaderText = "Защитен код";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CreditCardExpiry";
            this.dataGridViewTextBoxColumn12.HeaderText = "Валидност на кредитната карта";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ReferenceNumber";
            this.dataGridViewTextBoxColumn13.HeaderText = "Справка No";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "InvoiceNumber";
            this.dataGridViewTextBoxColumn14.HeaderText = "Фактура No";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TotalSum";
            this.dataGridViewTextBoxColumn15.HeaderText = "Обща сума";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "RestSum";
            this.dataGridViewTextBoxColumn16.HeaderText = "Оставаща сума";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // todayCheckOutBindingSource1
            // 
            this.todayCheckOutBindingSource1.DataMember = "TodayCheckOut";
            this.todayCheckOutBindingSource1.DataSource = this.checkInCheckOutToday;
            // 
            // todayCheckOutTableAdapter
            // 
            this.todayCheckOutTableAdapter.ClearBeforeFill = true;
            // 
            // frmCheckInCheckOutGuests
            // 
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1687, 706);
            this.Controls.Add(this.todayCheckInCheckOutDataGridView);
            this.Controls.Add(this.todayCheckInBindingSource1BindingNavigator);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCheckInCheckOutGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCheckInCheckOutGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkInCheckOutToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckInBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckInBindingSource1BindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckInCheckOutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayCheckOutBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTodayCheckInCheckOut;
        private System.Windows.Forms.BindingSource todayCheckInBindingSource;
        private System.Windows.Forms.BindingSource todayCheckOutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasCarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardSecurityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardExpiryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restSumDataGridViewTextBoxColumn;
        private CheckInCheckOutToday checkInCheckOutToday;
        private System.Windows.Forms.BindingSource todayCheckInBindingSource1;
        private CheckInCheckOutTodayTableAdapters.TodayCheckInTableAdapter todayCheckInTableAdapter;
        private CheckInCheckOutTodayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator todayCheckInBindingSource1BindingNavigator;
        private System.Windows.Forms.DataGridView todayCheckInCheckOutDataGridView;
        private System.Windows.Forms.BindingSource todayCheckOutBindingSource1;
        private CheckInCheckOutTodayTableAdapters.TodayCheckOutTableAdapter todayCheckOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}