namespace HotelReservationSoftware
{
    partial class frmAllRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllRooms));
            this.dgvAllRooms = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsWithTheirTypeDataSet = new HotelReservationSoftware.RoomsWithTheirTypeDataSet();
            this.roomsTableAdapter = new HotelReservationSoftware.RoomsWithTheirTypeDataSetTableAdapters.RoomsTableAdapter();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAdultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmokingAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomAddDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsWithTheirTypeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllRooms
            // 
            this.dgvAllRooms.AllowUserToAddRows = false;
            this.dgvAllRooms.AllowUserToDeleteRows = false;
            this.dgvAllRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllRooms.AutoGenerateColumns = false;
            this.dgvAllRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllRooms.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvAllRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAllRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.RoomType,
            this.roomPriceDataGridViewTextBoxColumn,
            this.numberOfAdultsDataGridViewTextBoxColumn,
            this.numberOfBedsDataGridViewTextBoxColumn,
            this.numberOfChildrenDataGridViewTextBoxColumn,
            this.bedTypeDataGridViewTextBoxColumn,
            this.SmokingAllowed,
            this.roomAddDescriptionDataGridViewTextBoxColumn});
            this.dgvAllRooms.DataSource = this.roomsBindingSource;
            this.dgvAllRooms.Location = new System.Drawing.Point(0, 0);
            this.dgvAllRooms.Name = "dgvAllRooms";
            this.dgvAllRooms.ReadOnly = true;
            this.dgvAllRooms.RowTemplate.Height = 24;
            this.dgvAllRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRooms.Size = new System.Drawing.Size(1110, 375);
            this.dgvAllRooms.TabIndex = 0;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(340, 412);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(110, 44);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Добави";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(480, 412);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(110, 44);
            this.btnEditRoom.TabIndex = 1;
            this.btnEditRoom.Text = "Редактирай";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(623, 412);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(110, 44);
            this.btnDeleteRoom.TabIndex = 1;
            this.btnDeleteRoom.Text = "Изтрий";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomsWithTheirTypeDataSet;
            // 
            // roomsWithTheirTypeDataSet
            // 
            this.roomsWithTheirTypeDataSet.DataSetName = "RoomsWithTheirTypeDataSet";
            this.roomsWithTheirTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Стая No";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "RoomType";
            this.RoomType.HeaderText = "Тип на стаята";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            this.roomPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfAdultsDataGridViewTextBoxColumn
            // 
            this.numberOfAdultsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfAdults";
            this.numberOfAdultsDataGridViewTextBoxColumn.HeaderText = "Възрастни";
            this.numberOfAdultsDataGridViewTextBoxColumn.Name = "numberOfAdultsDataGridViewTextBoxColumn";
            this.numberOfAdultsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfBedsDataGridViewTextBoxColumn
            // 
            this.numberOfBedsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfBeds";
            this.numberOfBedsDataGridViewTextBoxColumn.HeaderText = "Брой легла";
            this.numberOfBedsDataGridViewTextBoxColumn.Name = "numberOfBedsDataGridViewTextBoxColumn";
            this.numberOfBedsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfChildrenDataGridViewTextBoxColumn
            // 
            this.numberOfChildrenDataGridViewTextBoxColumn.DataPropertyName = "NumberOfChildren";
            this.numberOfChildrenDataGridViewTextBoxColumn.HeaderText = "Деца";
            this.numberOfChildrenDataGridViewTextBoxColumn.Name = "numberOfChildrenDataGridViewTextBoxColumn";
            this.numberOfChildrenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedTypeDataGridViewTextBoxColumn
            // 
            this.bedTypeDataGridViewTextBoxColumn.DataPropertyName = "BedType";
            this.bedTypeDataGridViewTextBoxColumn.HeaderText = "Тип на леглото";
            this.bedTypeDataGridViewTextBoxColumn.Name = "bedTypeDataGridViewTextBoxColumn";
            this.bedTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SmokingAllowed
            // 
            this.SmokingAllowed.DataPropertyName = "SmokingAllowed";
            this.SmokingAllowed.HeaderText = "Позволено пушене";
            this.SmokingAllowed.Name = "SmokingAllowed";
            this.SmokingAllowed.ReadOnly = true;
            // 
            // roomAddDescriptionDataGridViewTextBoxColumn
            // 
            this.roomAddDescriptionDataGridViewTextBoxColumn.DataPropertyName = "RoomAddDescription";
            this.roomAddDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.roomAddDescriptionDataGridViewTextBoxColumn.Name = "roomAddDescriptionDataGridViewTextBoxColumn";
            this.roomAddDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmAllRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1110, 497);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.dgvAllRooms);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAllRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Всички стаи";
            this.Activated += new System.EventHandler(this.frmAllRooms_Activated);
            this.Load += new System.EventHandler(this.frmAllRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsWithTheirTypeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRooms;
        private RoomsWithTheirTypeDataSet roomsWithTheirTypeDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private RoomsWithTheirTypeDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAdultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmokingAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAddDescriptionDataGridViewTextBoxColumn;
    }
}