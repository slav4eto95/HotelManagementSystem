using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class SearchCenterControl : UserControl
    {
        private DateTime FromDate, ToDate;
        private Form GetForm;
        private bool SearchForRooms;

        public SearchCenterControl(Form form, bool search)
        {
            InitializeComponent();

            GetForm = form;
            FromDate = new DateTime();
            ToDate = new DateTime();
            SearchForRooms = search;

            if (SearchForRooms)
                lblSearchRoom.Text = "Търси стая";
            else
                lblSearchRoom.Text = "Резервации";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // If the user hasn't selected a value from the combobox,
            // get the values for the dates from the datetimepickers.
            if (cmbCheckIn.SelectedItem == null)
            {
                FromDate = dtpFromDate.Value;
                ToDate = dtpToDate.Value;
            }

            if (SearchForRooms)
            {
                Helpers helpers = new Helpers();
                int addedDays = helpers.CalculateNumberOfNights(FromDate.Date, ToDate.Date);

                RoomsControl rooms = new RoomsControl(FromDate, ToDate, addedDays)
                {
                    Dock = DockStyle.Fill
                };

                Control[] control = GetForm.Controls.Find("panelMainContent", false);
                Panel panel = (Panel)control[0];

                // If the panel already contains "RoomsControl", remove the control from it.
                panel.Controls.Remove(rooms);
                panel.Controls.Clear();

                // Add again the "RoomsControl" control
                panel.Controls.Add(rooms);
                // and show it.
                rooms.Show();
            }
            else
            {
                ReportViewerControl reportViewerControl = new ReportViewerControl("ReservationsReport", FromDate, ToDate)
                {
                    Dock = DockStyle.Fill
                };

                Control[] control = GetForm.Controls.Find("panelMainContent", false);
                Panel panel = (Panel)control[0];

                // If the panel already contains "reportViewerControl", remove the control from it.
                panel.Controls.Remove(reportViewerControl);
                panel.Controls.Clear();

                // Add again the "reportViewerControl" control
                panel.Controls.Add(reportViewerControl);
                // and show it.
                reportViewerControl.Show();
            }
        }

        private void cmbCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromDate = DateTime.Now.Date;
            switch (cmbCheckIn.SelectedIndex)
            {
                case 0:
                    ToDate = FromDate.AddDays(7); // 7 days/ 1 week
                    break;
                case 1:
                    ToDate = FromDate.AddDays(14); // 14 days/ 2 weeks
                    break;
                case 2:
                    ToDate = FromDate.AddMonths(1); // 1 month
                    break;
                case 3:
                    ToDate = FromDate.AddMonths(3); // 3 months
                    break;
                case 4:
                    ToDate = FromDate.AddMonths(6); // 6 months
                    break;
                default:
                    FromDate = dtpFromDate.Value;
                    ToDate = dtpToDate.Value;
                    break;
            }
        }

        private void SearchCenterControl_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now.AddDays(1);
        }
    }
}
