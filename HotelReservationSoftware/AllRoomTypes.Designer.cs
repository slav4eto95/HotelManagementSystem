namespace HotelReservationSoftware
{
    partial class frmAllRoomTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllRoomTypes));
            this.dgvAllRoomTypes = new System.Windows.Forms.DataGridView();
            this.roomTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypesDataSet = new HotelReservationSoftware.RoomTypesDataSet();
            this.hotelManagementSystemDataSet1 = new HotelReservationSoftware.HotelManagementSystemDataSet1();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewRoomType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.roomTypesTableAdapter = new HotelReservationSoftware.RoomTypesDataSetTableAdapters.RoomTypesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canSmokeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRoomTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllRoomTypes
            // 
            this.dgvAllRoomTypes.AllowUserToAddRows = false;
            this.dgvAllRoomTypes.AllowUserToDeleteRows = false;
            this.dgvAllRoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllRoomTypes.AutoGenerateColumns = false;
            this.dgvAllRoomTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllRoomTypes.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvAllRoomTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAllRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRoomTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.canSmokeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8});
            this.dgvAllRoomTypes.DataSource = this.roomTypesBindingSource;
            this.dgvAllRoomTypes.Location = new System.Drawing.Point(15, 70);
            this.dgvAllRoomTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllRoomTypes.Name = "dgvAllRoomTypes";
            this.dgvAllRoomTypes.ReadOnly = true;
            this.dgvAllRoomTypes.RowTemplate.Height = 24;
            this.dgvAllRoomTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRoomTypes.Size = new System.Drawing.Size(987, 290);
            this.dgvAllRoomTypes.TabIndex = 7;
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
            // hotelManagementSystemDataSet1
            // 
            this.hotelManagementSystemDataSet1.DataSetName = "HotelManagementSystemDataSet1";
            this.hotelManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(234, 22);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(410, 26);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Филтрирай";
            // 
            // btnAddNewRoomType
            // 
            this.btnAddNewRoomType.Location = new System.Drawing.Point(673, 22);
            this.btnAddNewRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewRoomType.Name = "btnAddNewRoomType";
            this.btnAddNewRoomType.Size = new System.Drawing.Size(165, 29);
            this.btnAddNewRoomType.TabIndex = 10;
            this.btnAddNewRoomType.Text = "Добави нов тип стая";
            this.btnAddNewRoomType.UseVisualStyleBackColor = true;
            this.btnAddNewRoomType.Click += new System.EventHandler(this.btnAddNewRoomType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(520, 380);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 54);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(394, 380);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 54);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // roomTypesTableAdapter
            // 
            this.roomTypesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomTypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomTypeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoomTypeDesc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfAdults";
            this.dataGridViewTextBoxColumn4.HeaderText = "Възрастни";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NumberOfChildren";
            this.dataGridViewTextBoxColumn6.HeaderText = "Деца";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumberOfBeds";
            this.dataGridViewTextBoxColumn5.HeaderText = "Легла";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BedType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Тип легло";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // canSmokeDataGridViewTextBoxColumn
            // 
            this.canSmokeDataGridViewTextBoxColumn.DataPropertyName = "CanSmoke";
            this.canSmokeDataGridViewTextBoxColumn.HeaderText = "Пушене";
            this.canSmokeDataGridViewTextBoxColumn.Name = "canSmokeDataGridViewTextBoxColumn";
            this.canSmokeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RoomAddDescription";
            this.dataGridViewTextBoxColumn8.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmAllRoomTypes
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1014, 457);
            this.Controls.Add(this.dgvAllRoomTypes);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewRoomType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllRoomTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типове стаи";
            this.Activated += new System.EventHandler(this.frmAllRoomTypes_Activated);
            this.Load += new System.EventHandler(this.AllRoomTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRoomTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRoomTypes;
        private HotelManagementSystemDataSet1 hotelManagementSystemDataSet1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewRoomType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAdultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canSmokeFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAddDescriptionDataGridViewTextBoxColumn;
        private RoomTypesDataSet roomTypesDataSet;
        private System.Windows.Forms.BindingSource roomTypesBindingSource;
        private RoomTypesDataSetTableAdapters.RoomTypesTableAdapter roomTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn canSmokeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}