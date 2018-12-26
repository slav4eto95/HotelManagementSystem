using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAddRoomGuest : Form
    {
        public long bookingID;
        public int roomID;
        public string roomType, guestName, guestPhone;
        public decimal roomPrice;
        public int adultsNo, childrenNo;
        public DBHelpers.BookedRooms BookedRooms = new DBHelpers.BookedRooms();

        public bool buttonAddWasClicked = false;

        public frmAddRoomGuest(long BookingID, int RoomID, string RoomType, string GuestName, string GuestPhone,
            string GuestEmail, int NumberOfAdults, int NumberOfChildren, bool isClicked)
        {
            InitializeComponent();

            // TODO: This line of code loads data into the 'roomsDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);

            bookingID = BookingID;
            roomID = RoomID;
            roomType = RoomType;

            txtGuestName.Text = guestName = GuestName;
            txtPhone.Text = guestPhone = GuestPhone;
            txtEmail.Text = GuestEmail;
            adultsNo = NumberOfAdults;
            childrenNo = NumberOfChildren;

            buttonAddWasClicked = isClicked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            roomID = Int16.Parse(cmbRooms.Text.ToString());
            roomType = cmbRoomType.Text.ToString();
            using (var db = new HotelManagementSystemEntities())
            {
                var room = (from r in db.RoomTypes
                            where r.RoomTypeDesc== roomType
                            select r).First();
                roomPrice = room.RoomPrice;
            }
            adultsNo = Int16.Parse(nudNumAdults.Value.ToString());
            childrenNo = Int16.Parse(nudNumChilds.Value.ToString());

            // Add 
            if (buttonAddWasClicked)
            {
                /// insert BookingID and RoomID in BookedRooms
                if (BookedRooms.AddBookedRoom(bookingID, roomID, guestName, guestPhone, adultsNo, childrenNo))
                {
                    buttonAddWasClicked = false;
                    //MyMessageBox.ShowMessage("Успешно резервирахте стая!", "Успешна резервация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Възникна грешка при резервирането на стаята!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                // Edit
                bool isEdited = BookedRooms.EditBookedRoom(bookingID, roomID, guestName, guestPhone, adultsNo, childrenNo);
                if (isEdited)
                {
                    //MyMessageBox.ShowMessage("Успешно променихте записа!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Промените не бяха запаметени!", "Незапазени промени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = new DialogResult();
            dlgResult = MyMessageBox.ShowMessage("Сигурни ли сте, \nче искате да отхвърлите промените?", "Отхвърляне на промени", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult.ToString() == "Yes")
            {
                Close();
            }
        }

        private void frmAddRoomGuest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);

            this.Text = "Добави гост в стая";

            // labels
            lblRoomID.Text = "Стая No";
            lblRoomType.Text = "Тип на стаята";
            lblGuestName.Text = "Име на госта";
            lblPhone.Text = "Телефон";
            lblEmail.Text = "Имейл";
            lblNumOfAdults.Text = "Брой възрастни";
            lblNumOfChilds.Text = "Брой деца";

            nudNumAdults.Value = adultsNo;
            nudNumChilds.Value = childrenNo;

            if (buttonAddWasClicked)
            {
                if (cmbRooms.Items.Count > 0)
                {
                    roomID = cmbRooms.SelectedIndex;
                }
                else
                {
                    MyMessageBox.ShowMessage("Няма останали свободни стаи!\nМоля първо освободете стая!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (DataRowView item in cmbRooms.Items)
                {
                    if (((RoomsDataSet.RoomsRow)(item.Row)).RoomID == roomID)
                    {
                        cmbRooms.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }
}
