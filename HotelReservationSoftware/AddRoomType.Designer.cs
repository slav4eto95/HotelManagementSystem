namespace HotelReservationSoftware
{
    partial class frmAddRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRoomType));
            this.lblSeparatorLine = new System.Windows.Forms.Label();
            this.cmbBedType = new System.Windows.Forms.ComboBox();
            this.nudChildrenNum = new System.Windows.Forms.NumericUpDown();
            this.nudBedroomNum = new System.Windows.Forms.NumericUpDown();
            this.nudAdultNo = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkCanSmoke = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBedType = new System.Windows.Forms.Label();
            this.lblBedroomNum = new System.Windows.Forms.Label();
            this.lblChildrenNo = new System.Windows.Forms.Label();
            this.lblAdultsNo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBedroomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeparatorLine
            // 
            this.lblSeparatorLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparatorLine.Location = new System.Drawing.Point(18, 161);
            this.lblSeparatorLine.Name = "lblSeparatorLine";
            this.lblSeparatorLine.Size = new System.Drawing.Size(498, 10);
            this.lblSeparatorLine.TabIndex = 38;
            this.lblSeparatorLine.Text = "label1";
            // 
            // cmbBedType
            // 
            this.cmbBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBedType.FormattingEnabled = true;
            this.cmbBedType.Items.AddRange(new object[] {
            "Единично",
            "Двойно",
            "Queen Size",
            "King Size"});
            this.cmbBedType.Location = new System.Drawing.Point(379, 95);
            this.cmbBedType.Name = "cmbBedType";
            this.cmbBedType.Size = new System.Drawing.Size(137, 24);
            this.cmbBedType.TabIndex = 36;
            // 
            // nudChildrenNum
            // 
            this.nudChildrenNum.Location = new System.Drawing.Point(379, 56);
            this.nudChildrenNum.Name = "nudChildrenNum";
            this.nudChildrenNum.Size = new System.Drawing.Size(137, 22);
            this.nudChildrenNum.TabIndex = 35;
            this.nudChildrenNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudBedroomNum
            // 
            this.nudBedroomNum.Location = new System.Drawing.Point(131, 96);
            this.nudBedroomNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBedroomNum.Name = "nudBedroomNum";
            this.nudBedroomNum.Size = new System.Drawing.Size(137, 22);
            this.nudBedroomNum.TabIndex = 34;
            this.nudBedroomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBedroomNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAdultNo
            // 
            this.nudAdultNo.Location = new System.Drawing.Point(131, 56);
            this.nudAdultNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultNo.Name = "nudAdultNo";
            this.nudAdultNo.Size = new System.Drawing.Size(137, 22);
            this.nudAdultNo.TabIndex = 33;
            this.nudAdultNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAdultNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(379, 16);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 22);
            this.txtPrice.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(169, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 33);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "&ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 217);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(501, 85);
            this.txtDescription.TabIndex = 28;
            // 
            // chkCanSmoke
            // 
            this.chkCanSmoke.AutoSize = true;
            this.chkCanSmoke.Location = new System.Drawing.Point(18, 137);
            this.chkCanSmoke.Name = "chkCanSmoke";
            this.chkCanSmoke.Size = new System.Drawing.Size(98, 21);
            this.chkCanSmoke.TabIndex = 27;
            this.chkCanSmoke.Text = "checkBox1";
            this.chkCanSmoke.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 181);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(46, 17);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "label7";
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.Location = new System.Drawing.Point(287, 98);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(46, 17);
            this.lblBedType.TabIndex = 25;
            this.lblBedType.Text = "label6";
            // 
            // lblBedroomNum
            // 
            this.lblBedroomNum.AutoSize = true;
            this.lblBedroomNum.Location = new System.Drawing.Point(15, 98);
            this.lblBedroomNum.Name = "lblBedroomNum";
            this.lblBedroomNum.Size = new System.Drawing.Size(46, 17);
            this.lblBedroomNum.TabIndex = 24;
            this.lblBedroomNum.Text = "label5";
            // 
            // lblChildrenNo
            // 
            this.lblChildrenNo.AutoSize = true;
            this.lblChildrenNo.Location = new System.Drawing.Point(287, 58);
            this.lblChildrenNo.Name = "lblChildrenNo";
            this.lblChildrenNo.Size = new System.Drawing.Size(46, 17);
            this.lblChildrenNo.TabIndex = 23;
            this.lblChildrenNo.Text = "label4";
            // 
            // lblAdultsNo
            // 
            this.lblAdultsNo.AutoSize = true;
            this.lblAdultsNo.Location = new System.Drawing.Point(15, 58);
            this.lblAdultsNo.Name = "lblAdultsNo";
            this.lblAdultsNo.Size = new System.Drawing.Size(46, 17);
            this.lblAdultsNo.TabIndex = 22;
            this.lblAdultsNo.Text = "label3";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(287, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 17);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "label2";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(15, 19);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(46, 17);
            this.lblRoomType.TabIndex = 20;
            this.lblRoomType.Text = "label1";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(131, 16);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(137, 22);
            this.txtRoomType.TabIndex = 31;
            // 
            // frmAddRoomType
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(533, 363);
            this.Controls.Add(this.lblSeparatorLine);
            this.Controls.Add(this.cmbBedType);
            this.Controls.Add(this.nudChildrenNum);
            this.Controls.Add(this.nudBedroomNum);
            this.Controls.Add(this.nudAdultNo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.chkCanSmoke);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBedType);
            this.Controls.Add(this.lblBedroomNum);
            this.Controls.Add(this.lblChildrenNo);
            this.Controls.Add(this.lblAdultsNo);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoomType";
            this.Load += new System.EventHandler(this.frmAddRoomType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudChildrenNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBedroomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeparatorLine;
        private System.Windows.Forms.ComboBox cmbBedType;
        private System.Windows.Forms.NumericUpDown nudChildrenNum;
        private System.Windows.Forms.NumericUpDown nudBedroomNum;
        private System.Windows.Forms.NumericUpDown nudAdultNo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkCanSmoke;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.Label lblBedroomNum;
        private System.Windows.Forms.Label lblChildrenNo;
        private System.Windows.Forms.Label lblAdultsNo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
    }
}