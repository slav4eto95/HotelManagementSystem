using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class ReceiptForm : Form
    {
        private Booking Booking;
        private List<BookedRoom> ListRooms;
        private List<BookedService> ListServices;

        public ReceiptForm(Booking booking, List<BookedRoom> listRooms, List<BookedService> listServices)
        {
            InitializeComponent();
            Booking = booking;
            ListRooms = listRooms;
            ListServices = listServices;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            ReportViewerControl reportViewerControl = new ReportViewerControl("Receipt", Booking, ListRooms, ListServices)
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }
    }
}
