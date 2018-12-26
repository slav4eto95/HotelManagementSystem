namespace HotelReservationSoftware
{
    partial class SearchCenterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCheckIn = new System.Windows.Forms.ComboBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblSearchRoom = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(17, 241);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Потърси";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(126, 197);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(106, 26);
            this.dtpToDate.TabIndex = 12;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(126, 150);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 26);
            this.dtpFromDate.TabIndex = 11;
            // 
            // cmbCheckIn
            // 
            this.cmbCheckIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckIn.FormattingEnabled = true;
            this.cmbCheckIn.Items.AddRange(new object[] {
            "7 дни",
            "14 дни",
            "1 месец",
            "3 месеца",
            "6 месеца"});
            this.cmbCheckIn.Location = new System.Drawing.Point(126, 68);
            this.cmbCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCheckIn.Name = "cmbCheckIn";
            this.cmbCheckIn.Size = new System.Drawing.Size(106, 26);
            this.cmbCheckIn.TabIndex = 10;
            this.cmbCheckIn.SelectedIndexChanged += new System.EventHandler(this.cmbCheckIn_SelectedIndexChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToDate.Location = new System.Drawing.Point(13, 202);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(34, 19);
            this.lblToDate.TabIndex = 9;
            this.lblToDate.Text = "До:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromDate.Location = new System.Drawing.Point(13, 153);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(33, 19);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "От:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCheckIn.Location = new System.Drawing.Point(13, 64);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(106, 38);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "Настаняване \r\nв рамките на:";
            // 
            // lblSearchRoom
            // 
            this.lblSearchRoom.AutoSize = true;
            this.lblSearchRoom.BackColor = System.Drawing.Color.Aquamarine;
            this.lblSearchRoom.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchRoom.Location = new System.Drawing.Point(17, 10);
            this.lblSearchRoom.Name = "lblSearchRoom";
            this.lblSearchRoom.Size = new System.Drawing.Size(122, 29);
            this.lblSearchRoom.TabIndex = 14;
            this.lblSearchRoom.Text = "Търси стая";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(94, 120);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(36, 19);
            this.lblOr.TabIndex = 15;
            this.lblOr.Text = "или";
            // 
            // SearchCenterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblSearchRoom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cmbCheckIn);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.lblCheckIn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SearchCenterControl";
            this.Size = new System.Drawing.Size(370, 416);
            this.Load += new System.EventHandler(this.SearchCenterControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbCheckIn;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblSearchRoom;
        private System.Windows.Forms.Label lblOr;
    }
}
