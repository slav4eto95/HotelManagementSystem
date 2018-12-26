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
    public partial class frmAllGuests : Form
    {
        private string FirstName;
        private Booking Booking;
        private int UserLevelID;

        public frmAllGuests(Booking booking, string firstName, int userLevelID)
        {
            InitializeComponent();

            Booking = booking;
            FirstName = firstName;
            UserLevelID = userLevelID;
        }

        private void AllGuests_Load(object sender, EventArgs e)
        {
            this.guestsTableAdapter.Fill(this.guestsDataSet.Guests);

            using (var db = new HotelManagementSystemEntities())
            {
                var guests = db.Guests
                                .Where(g => g.FirstName.StartsWith(FirstName))
                                .OrderBy(g => g.FirstName).ThenBy(g => g.MiddleName).ThenBy(g => g.LastName)
                                .ToList();
                dgvGuests.DataSource = null;

                foreach (var item in guests)
                {
                    dgvGuests.Rows.Add(item.GuestID, item.TitleID, item.FirstName, item.MiddleName, item.LastName);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvGuests.Rows.Count > 0)
            {
                int selectedRowIndex = dgvGuests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvGuests.Rows[selectedRowIndex];

                Guest guest = new Guest();

                guest.TitleID = Convert.ToInt16(selectedRow.Cells["titleIDDataGridViewTextBoxColumn"].Value);
                guest.FirstName = Convert.ToString(selectedRow.Cells["firstNameDataGridViewTextBoxColumn"].Value);
                guest.MiddleName = Convert.ToString(selectedRow.Cells["middleNameDataGridViewTextBoxColumn"].Value);
                guest.LastName = Convert.ToString(selectedRow.Cells["lastNameDataGridViewTextBoxColumn"].Value);
                guest.Address = Convert.ToString(selectedRow.Cells["addressDataGridViewTextBoxColumn"].Value);
                guest.PostCode = Convert.ToString(selectedRow.Cells["postCodeDataGridViewTextBoxColumn"].Value);
                guest.City = Convert.ToString(selectedRow.Cells["cityDataGridViewTextBoxColumn"].Value);
                guest.Country = Convert.ToString(selectedRow.Cells["countryDataGridViewTextBoxColumn"].Value);
                guest.EGN = Convert.ToString(selectedRow.Cells["eGNDataGridViewTextBoxColumn"].Value);
                guest.Phone = Convert.ToString(selectedRow.Cells["phoneDataGridViewTextBoxColumn"].Value);
                guest.Email = Convert.ToString(selectedRow.Cells["emailDataGridViewTextBoxColumn"].Value);
                guest.FirmName = Convert.ToString(selectedRow.Cells["firmNameDataGridViewTextBoxColumn"].Value);

                using (var db = new HotelManagementSystemEntities())
                {
                    Booking.GuestID = Convert.ToInt16(selectedRow.Cells["guestIDDataGridViewTextBoxColumn"].Value);
                    db.SaveChanges();
                }

                Helpers helpers = new Helpers();
                Guests guests = new Guests();

                int guestIDForDeleting = helpers.GetLastInsertedID("Guests", "GuestID");
                using (var db = new HotelManagementSystemEntities())
                {
                    var query = (from g in db.Guests
                                 where g.GuestID == guestIDForDeleting
                                 select g).Single();

                    if (query.FirstName.Equals(""))
                    {
                        guests.DeleteGuest(guestIDForDeleting);
                    }
                }

                frmAddReservation frmAddReservation = new frmAddReservation(Booking, UserLevelID, false); /// or true
                frmAddReservation.Show();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
