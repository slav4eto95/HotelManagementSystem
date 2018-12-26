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
    public partial class RoomsControl : UserControl
    {
        private DateTime FromDate, ToDate;
        private string GuestName;
        private int AddedDays;

        public RoomsControl(DateTime fromDate, DateTime toDate, int addedDays)
        {
            InitializeComponent();

            FromDate = fromDate;
            ToDate = toDate;
            AddedDays = addedDays;
        }

        private void RoomsControl_Load(object sender, EventArgs e)
        {
            RemoveData();
            LoadRooms();

            DateTime currentDay;

            for (int i = 0; i <= AddedDays; i++)
            {
                currentDay = new DateTime(FromDate.Year, FromDate.Month, FromDate.Day);
                currentDay = currentDay.AddDays(i);

                CreateColumn(currentDay.Date.ToShortDateString(), currentDay.DayOfWeek);
                LoadData();
            }
        }

        private void dgvRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                DataGridViewCell cell = dgvRooms.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (e.ColumnIndex == 0)
                {
                    // Display the Room Number
                    cell.ToolTipText = dgvRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void RemoveData()
        {
            dgvRooms.DataSource = null;
            dgvRooms.Rows.Clear();
            dgvRooms.Columns.Clear();
        }

        // Function which loads only the room numbers to the first column in the gridview.
        private void LoadRooms()
        {
            int row = 0;

            dgvRooms.Columns.Add("RoomID", "Стая No");

            using (var db = new HotelManagementSystemEntities())
            {
                var rooms = db.Rooms.ToList();

                foreach (var room in rooms)
                {
                    row = dgvRooms.Rows.Add();
                    dgvRooms.Rows[row].Cells[0].Value = room.RoomID.ToString();
                }
            }
        }

        private void CreateColumn(string currentDay, DayOfWeek dayOfWeek)
        {
            string day = dayOfWeek.ToString();
            int columnIndex = dgvRooms.Columns.Add(dayOfWeek.ToString(),
                                    currentDay + "\n" + day.Remove(3, day.Length - 3));

            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                dgvRooms.Columns[columnIndex].DefaultCellStyle.BackColor = ControlPaint.Light(Color.LightGray);
            }
        }

        // Function for loading data to the gridview.
        private void LoadData()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var bookings = (from b in db.Bookings
                                join br in db.BookedRooms on b.BookingID equals br.BookingID
                                join g in db.Guests on b.GuestID equals g.GuestID
                                select new
                                {
                                    BookingID = b.BookingID,
                                    RoomID = br.RoomID,
                                    CheckIn = b.CheckIn,
                                    CheckOut = b.CheckOut,
                                    Nights = b.Nights,
                                    GuestName = g.FirstName + " " + g.MiddleName + " " + g.LastName
                                }).ToList();

                for (int i = 0; i < dgvRooms.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvRooms.Columns.Count; j++)
                    {
                        foreach (var booking in bookings)
                        {
                            string dateCheckIn = booking.CheckIn.ToShortDateString();
                            string dateCheckOut = booking.CheckOut.ToShortDateString();

                            // Get only the date from the header text - without the day of the week
                            string columnDate = (dgvRooms.Columns[j].HeaderText.ToString()).Remove(9);

                            if (booking.RoomID == Int16.Parse(dgvRooms.Rows[i].Cells[0].Value.ToString()))
                            {
                                if (IsBetween(columnDate, dateCheckIn, dateCheckOut))
                                {
                                    DataGridViewCell cell = dgvRooms[j, i];
                                    GuestName = booking.GuestName;
                                    cell.Value = GuestName;
                                    cell.ToolTipText = GuestName;
                                    cell.Style.ForeColor = Color.DarkRed;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Function that checks if a given date is between two other dates.
        private bool IsBetween(string dateToCheck, string startDate, string endEndDate)
        {
            bool isBetween = false;

            DateTime date = Convert.ToDateTime(dateToCheck);
            DateTime start = Convert.ToDateTime(startDate);
            DateTime end = Convert.ToDateTime(endEndDate);

            if (date >= start && date <= end)
            {
                isBetween = true;
            }

            return isBetween;
        }
    }
}
