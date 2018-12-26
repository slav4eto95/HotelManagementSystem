namespace HotelReservationSoftware
{
    partial class frmCustomMessageBoxYesNo
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTextMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOpen.Location = new System.Drawing.Point(328, 118);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(93, 48);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&ДА";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(472, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 48);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&НЕ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTextMessage
            // 
            this.lblTextMessage.AutoSize = true;
            this.lblTextMessage.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextMessage.Location = new System.Drawing.Point(210, 29);
            this.lblTextMessage.Name = "lblTextMessage";
            this.lblTextMessage.Size = new System.Drawing.Size(293, 38);
            this.lblTextMessage.TabIndex = 1;
            this.lblTextMessage.Text = "Експортването на файла беше успешно!\r\nЖелаете ли да го отворите за преглед?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservationSoftware.Properties.Resources.question_mark;
            this.pictureBox1.Location = new System.Drawing.Point(26, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmCustomMessageBoxYesNo
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(640, 190);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTextMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomMessageBoxYesNo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поздравления";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTextMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}