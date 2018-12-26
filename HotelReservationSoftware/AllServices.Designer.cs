namespace HotelReservationSoftware
{
    partial class frmAllServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllServices));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvAllServices = new System.Windows.Forms.DataGridView();
            this.dgvtxtServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementSystemDataSet1 = new HotelReservationSoftware.HotelManagementSystemDataSet1();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNewService = new System.Windows.Forms.Button();
            this.servicesTableAdapter = new HotelReservationSoftware.HotelManagementSystemDataSet1TableAdapters.ServicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Филтрирай";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(151, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(410, 26);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvAllServices
            // 
            this.dgvAllServices.AllowUserToAddRows = false;
            this.dgvAllServices.AllowUserToDeleteRows = false;
            this.dgvAllServices.AutoGenerateColumns = false;
            this.dgvAllServices.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvAllServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtServiceID,
            this.dgvtxtServiceName,
            this.dgvtxtServicePrice});
            this.dgvAllServices.DataSource = this.servicesBindingSource;
            this.dgvAllServices.Location = new System.Drawing.Point(16, 61);
            this.dgvAllServices.Name = "dgvAllServices";
            this.dgvAllServices.ReadOnly = true;
            this.dgvAllServices.RowTemplate.Height = 24;
            this.dgvAllServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllServices.Size = new System.Drawing.Size(775, 258);
            this.dgvAllServices.TabIndex = 2;
            // 
            // dgvtxtServiceID
            // 
            this.dgvtxtServiceID.DataPropertyName = "ServiceID";
            this.dgvtxtServiceID.HeaderText = "ServiceID";
            this.dgvtxtServiceID.Name = "dgvtxtServiceID";
            this.dgvtxtServiceID.ReadOnly = true;
            this.dgvtxtServiceID.Visible = false;
            // 
            // dgvtxtServiceName
            // 
            this.dgvtxtServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtServiceName.DataPropertyName = "ServiceName";
            this.dgvtxtServiceName.HeaderText = "Услуга";
            this.dgvtxtServiceName.Name = "dgvtxtServiceName";
            this.dgvtxtServiceName.ReadOnly = true;
            // 
            // dgvtxtServicePrice
            // 
            this.dgvtxtServicePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtServicePrice.DataPropertyName = "ServicePrice";
            this.dgvtxtServicePrice.HeaderText = "Цена";
            this.dgvtxtServicePrice.Name = "dgvtxtServicePrice";
            this.dgvtxtServicePrice.ReadOnly = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hotelManagementSystemDataSet1;
            // 
            // hotelManagementSystemDataSet1
            // 
            this.hotelManagementSystemDataSet1.DataSetName = "HotelManagementSystemDataSet1";
            this.hotelManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(281, 337);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 48);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(407, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 48);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNewService
            // 
            this.btnAddNewService.Location = new System.Drawing.Point(590, 19);
            this.btnAddNewService.Name = "btnAddNewService";
            this.btnAddNewService.Size = new System.Drawing.Size(165, 26);
            this.btnAddNewService.TabIndex = 4;
            this.btnAddNewService.Text = "Добави нова услуга";
            this.btnAddNewService.UseVisualStyleBackColor = true;
            this.btnAddNewService.Click += new System.EventHandler(this.btnAddNewService_Click);
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAllServices
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(803, 404);
            this.Controls.Add(this.btnAddNewService);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvAllServices);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Activated += new System.EventHandler(this.frmAllServices_Activated);
            this.Load += new System.EventHandler(this.frmAllServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgvAllServices;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewService;
        private HotelManagementSystemDataSet1 hotelManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private HotelManagementSystemDataSet1TableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtServicePrice;
    }
}