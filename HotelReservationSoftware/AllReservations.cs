using HotelReservationSoftware.Reports;
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
    public partial class frmAllReservations : Form
    {
        public long BookingID;
        public string BookingStatus, GuestName, GuestPhone, GuestEGN, GuestEmail, Notes, ReferredBy, HasCar, PostCode, City, Country;
        public int Nights, GuestID, TitleID, BookingStatusID;
        public int UserLevelID;

        public DateTime CheckIn, CheckOut, BookDate;
        public decimal TotalSum, RestSum;

        public bool IsButtonSearchGuestClicked;
        public List<String> List;

        DBHelpers.Rooms Rooms;
        DBHelpers.Bookings Bookings;
        DBHelpers.BookedRooms BookedRooms;
        DBHelpers.BookedServices BookedServices;

        public frmAllReservations(bool searchGuest, int userLevelID)
        {
            InitializeComponent();
            Rooms = new DBHelpers.Rooms();
            Bookings = new DBHelpers.Bookings();
            BookedRooms = new DBHelpers.BookedRooms();
            BookedServices = new DBHelpers.BookedServices();
            IsButtonSearchGuestClicked = searchGuest;
            UserLevelID = userLevelID;
        }

        public frmAllReservations(List<String> list, int userLevelID, bool searchGuest)
        {
            InitializeComponent();
            Rooms = new DBHelpers.Rooms();
            Bookings = new DBHelpers.Bookings();
            BookedRooms = new DBHelpers.BookedRooms();
            BookedServices = new DBHelpers.BookedServices();

            List = list;
            IsButtonSearchGuestClicked = searchGuest;
            UserLevelID = userLevelID;
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dgvAllReservations.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvAllReservations.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAllReservations.Rows[selectedRowIndex];

                BookingID = Convert.ToInt64(selectedRow.Cells["bookingIDDataGridViewTextBoxColumn"].Value);

                Booking booking = Bookings.GetBookingByID(BookingID);
                List<BookedRoom> listRooms = BookedRooms.GetAllBookedRoomsByBookingID(BookingID);
                List<BookedService> listServices = BookedServices.GetAllBookedServicesByBookingID(BookingID);


                ReceiptForm receiptForm = new ReceiptForm(booking, listRooms, listServices);
                receiptForm.Show();
            }
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            Helpers helpers = new Helpers();
            Guests guests = new Guests();
            DateTime dtToday, dtTomorrow;

            dtToday = DateTime.Now;
            dtTomorrow = dtToday.AddDays(1);

            TitleID = 1;
            GuestName = GuestPhone = GuestEGN = GuestEmail = Notes = City = "";
            CheckIn = BookDate = dtToday;
            CheckOut = dtTomorrow;
            Nights = helpers.CalculateNumberOfNights(CheckIn, CheckOut);
            HasCar = "Не";
            PostCode = "0000";
            TotalSum = RestSum = 0;
            ReferredBy = "Не се знае";
            Country = "Bulgaria";
            BookingStatusID = 1;

            bool isAddedGuest = guests.AddGuest(TitleID, "", "", "", "", PostCode, City,
                                    Country, GuestEGN, GuestPhone, GuestEmail, "");
            if (isAddedGuest)
            {
                GuestID = helpers.GetLastInsertedID("Guests", "GuestID");
                Bookings.AddReservation(BookingStatusID, GuestID, CheckIn, CheckOut, Nights, HasCar,
                    BookDate, Notes, "", "", 0, "00/00", "0", "0", TotalSum, RestSum, 1);

                BookingID = helpers.GetLastInsertedID("Bookings", "BookingID");

                using (var db = new HotelManagementSystemEntities())
                {
                    var booking = db.Bookings.Where(b => b.BookingID == BookingID).FirstOrDefault();
                    frmAddReservation frmAddReservation = new frmAddReservation(booking, UserLevelID, true);
                    frmAddReservation.Show();
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Възникна грешка. \nМоля, опитайте отново!", "Грешка", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            if (dgvAllReservations.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvAllReservations.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAllReservations.Rows[selectedRowIndex];

                BookingID = Convert.ToInt64(selectedRow.Cells["bookingIDDataGridViewTextBoxColumn"].Value);

                Booking booking = Bookings.GetBookingByID(BookingID);
                frmAddReservation frmAddReservation = new frmAddReservation(booking, UserLevelID, false); // false for edit button clicked
                frmAddReservation.Show();
            }
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (dgvAllReservations.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvAllReservations.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAllReservations.Rows[selectedRowIndex];

                BookingID = Convert.ToInt64(selectedRow.Cells["bookingIDDataGridViewTextBoxColumn"].Value);

                DialogResult result = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да премахнете резервацията?", "Изтриване на резервация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<BookedRoom> listBookedRooms = BookedRooms.GetAllBookedRoomsByBookingID(BookingID);
                    foreach (var item in listBookedRooms)
                    {
                        if (BookedRooms.DeleteBookedRoom(BookingID, item.RoomID))
                        {
                            // set status - free
                            if (Rooms.UpdateRoomStatus(item.RoomID, 1))
                                continue;
                            else
                                return;
                        }
                    }

                    List<BookedService> listBookedServices = BookedServices.GetAllBookedServicesByBookingID(BookingID);
                    foreach (var item in listBookedServices)
                    {
                        if (BookedServices.DeleteBookedService(BookingID, item.ServiceID))
                        {
                            continue;
                        }
                    }

                    bool isDeletedBooking = Bookings.DeleteReservation(BookingID);
                    if (isDeletedBooking)
                    {
                        MyMessageBox.ShowMessage("Резервацията е изтрита успешно!", "Успешно изтриване на резервация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Възникна грешка при изтриването на резервацията!", "Грешка при изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void frmAllReservations_Load(object sender, EventArgs e)
        {
            if (IsButtonSearchGuestClicked)
            {
                string firstName = List.ElementAt(0);
                string middleName = List.ElementAt(1);
                string lastName = List.ElementAt(2);

                bookingsTableAdapter.FillByGuestName(allReservationsDataSet.Bookings, firstName, middleName, lastName);
                btnNewReservation.Enabled = false;
            }
            else
            {
                // TODO: This line of code loads data into the 'allReservationsDataSet.Bookings' table. You can move, or remove it, as needed.
                bookingsTableAdapter.Fill(allReservationsDataSet.Bookings);
                btnNewReservation.Enabled = true;
            }

            if (dgvAllReservations.RowCount == 0)
            {
                btnEditReservation.Enabled = btnDeleteReservation.Enabled = false;
            }
            else
            {
                btnEditReservation.Enabled = btnDeleteReservation.Enabled = true;
            }

            DateTime dateTimeNow = DateTime.Now.Date;
            string bookingStatus;
            Color backColor = new Color();
            using (var db = new HotelManagementSystemEntities())
            {
                var queryBookedRooms = (from br in db.BookedRooms
                                        join b in db.Bookings on br.BookingID equals b.BookingID
                                        join r in db.Rooms on br.RoomID equals r.RoomID
                                        where r.RoomStatusID == 2 && b.CheckOut < dateTimeNow
                                        select br).ToList();

                // Ако има стаи, които поради някаква причина са останали заети (след като гостът е напуснал),
                // да се промени техният статус на "свободна".
                if (queryBookedRooms.Count > 0)
                {
                    foreach (var item in queryBookedRooms)
                    {
                        Rooms.UpdateRoomStatus(item.RoomID, 1);
                    }
                }

                for (int i = 0; i < dgvAllReservations.Rows.Count; ++i)
                {
                    bookingStatus = Convert.ToString(dgvAllReservations.Rows[i].Cells["bookingStatusNameDataGridViewTextBoxColumn"].Value);
                    
                    var queryBookingStatus = db.BookingStatus
                                                        .Where(bs => bs.BookingStatusName == bookingStatus)
                                                        .ToList();
                    foreach (var item in queryBookingStatus)
                    {
                        backColor = Color.FromArgb((byte)item.BookingStatusColorRed, (byte)item.BookingStatusColorGreen, (byte)item.BookingStatusColorBlue);
                        dgvAllReservations.Rows[i].DefaultCellStyle.BackColor = backColor;
                    }
                }
            }
        }

        private void frmAllReservations_Activated(object sender, EventArgs e)
        {
            if (IsButtonSearchGuestClicked)
            {
                string firstName = List.ElementAt(0);
                string middleName = List.ElementAt(1);
                string lastName = List.ElementAt(2);

                bookingsTableAdapter.FillByGuestName(allReservationsDataSet.Bookings, firstName, middleName, lastName);
            }
            else
            {
                // TODO: This line of code loads data into the 'allReservationsDataSet.Bookings' table. You can move, or remove it, as needed.
                this.bookingsTableAdapter.Fill(this.allReservationsDataSet.Bookings);
            }

            if (dgvAllReservations.RowCount == 0)
            {
                btnEditReservation.Enabled = btnDeleteReservation.Enabled = false;
            }
            else
            {
                btnEditReservation.Enabled = btnDeleteReservation.Enabled = true;
            }

            string bookingStatus;
            Color backColor = new Color();
            using (var db = new HotelManagementSystemEntities())
            {
                for (int i = 0; i < dgvAllReservations.Rows.Count; ++i)
                {
                    bookingStatus = Convert.ToString(dgvAllReservations.Rows[i].Cells["bookingStatusNameDataGridViewTextBoxColumn"].Value);
                    
                    var queryBookingStatus = db.BookingStatus
                                                        .Where(bs => bs.BookingStatusName == bookingStatus)
                                                        .ToList();
                    foreach (var item in queryBookingStatus)
                    {
                        backColor = Color.FromArgb((byte)item.BookingStatusColorRed, (byte)item.BookingStatusColorGreen, (byte)item.BookingStatusColorBlue);
                        dgvAllReservations.Rows[i].DefaultCellStyle.BackColor = backColor;
                    }
                }
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            frmExportFormats frmExportFormats = new frmExportFormats(dgvAllReservations);
            frmExportFormats.Show();
        }
    }
}