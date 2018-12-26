using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmCheckInCheckOutGuests : Form
    {
        public static bool IsCheckInClicked { get; internal set; }

        public frmCheckInCheckOutGuests(bool isCheckIn)
        {
            InitializeComponent();

            IsCheckInClicked = isCheckIn;
            if (IsCheckInClicked)
            {
                Icon = Properties.Resources.checkin;
                Text = "Пристигащи";
            }
            else
            {
                Icon = Properties.Resources.checkout;
                Text = "Заминаващи";
            }
        }

        private void frmCheckInCheckOutGuests_Load(object sender, EventArgs e)
        {
            todayCheckInCheckOutDataGridView.DataSource = null;
            if (IsCheckInClicked)
            {
                // TODO: This line of code loads data into the 'checkInCheckOutToday.TodayCheckIn' table. 
                // You can move, or remove it, as needed.
                this.todayCheckInTableAdapter.Fill(this.checkInCheckOutToday.TodayCheckIn);
                todayCheckInCheckOutDataGridView.DataSource = todayCheckInBindingSource1;
            }
            else
            {
                // TODO: This line of code loads data into the 'checkInCheckOutToday.TodayCheckOut' table. 
                // You can move, or remove it, as needed.
                this.todayCheckOutTableAdapter.Fill(this.checkInCheckOutToday.TodayCheckOut);
                todayCheckInCheckOutDataGridView.DataSource = todayCheckOutBindingSource1;
            }
        }
    }
}
