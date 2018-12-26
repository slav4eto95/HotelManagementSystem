using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAddRoom : Form
    {
        private static bool IsButtonAddClicked { get; set; }
        private DBHelpers.Rooms Rooms = new DBHelpers.Rooms();
        private Helpers Helpers = new Helpers();
        private Room Room = new Room();

        public frmAddRoom(Room room, bool isClicked)
        {
            InitializeComponent();
            Room = room;
            IsButtonAddClicked = isClicked;
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomTypesDataSet.RoomTypes' table. You can move, or remove it, as needed.
            this.roomTypesTableAdapter.Fill(this.roomTypesDataSet.RoomTypes);

            if (IsButtonAddClicked)
            {
                Text = "Добави стая";
                btnOk.Enabled = false;
                //txtMaxAdultsNo.Text = txtMaxChildNo.Text = "0";
                //cmbSmokingAllowed.SelectedItem = "Не";
                cmbRoomType.SelectedIndex = 0;
            }
            else
            {
                Text = "Редактирай стая";
                btnOk.Enabled = true;

                txtRoomNo.Text = Room.RoomID.ToString();
                cmbRoomType.SelectedItem = Room.RoomTypeID;
                using (var db = new HotelManagementSystemEntities())
                {
                    var roomtype = (from rt in db.RoomTypes
                                    where rt.RoomTypeID == Room.RoomTypeID
                                    select rt).Single();
                    txtMaxAdultsNo.Text = roomtype.NumberOfAdults.ToString();
                    txtMaxChildNo.Text = roomtype.NumberOfChildren.ToString();
                    cmbBedType.SelectedItem = roomtype.BedType;
                    if (roomtype.CanSmoke == 0)
                    {
                        cmbSmokingAllowed.SelectedItem = "Не";
                    }
                    else
                    {
                        cmbSmokingAllowed.SelectedItem = "Да";
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int roomID = Int16.Parse(txtRoomNo.Text.ToString());
            string roomType = cmbRoomType.SelectedValue.ToString();
            int roomTypeID;
            using (var db = new HotelManagementSystemEntities())
            {
                var room = (from rt in db.RoomTypes
                            where rt.RoomTypeDesc == roomType
                            select rt).Single();
                roomTypeID = room.RoomTypeID;
            }

            if (IsButtonAddClicked)
            {
                if (Rooms.AddRoom(roomID, roomTypeID, 1)) // 1 for status free
                {
                    MyMessageBox.ShowMessage("Стаята е добавена успешно!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Възникна грешка \nпри добавянето на стаята!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (Rooms.UpdateRoomType(roomID, roomTypeID))
                {
                    MyMessageBox.ShowMessage("Информацията за стаята е променена успешно!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Възникна грешка \nпри промяната иа информацията за стаята!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = new DialogResult();
            dlgResult = MessageBox.Show("Сигурни ли сте, че искате да отхвърлите промените?", "Отхвърляне на промени", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult.ToString() == "Yes")
            {
                Close();
            }
        }

        private void cmbRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            string roomType;
            if (cmbRoomType.SelectedValue != null)
            {
                btnOk.Enabled = true;

                roomType = cmbRoomType.SelectedValue.ToString();

                using (var db = new HotelManagementSystemEntities())
                {
                    var room = (from rt in db.RoomTypes
                                where rt.RoomTypeDesc == roomType
                                select rt).Single();

                    txtMaxAdultsNo.Text = room.NumberOfAdults.ToString();
                    txtMaxChildNo.Text = room.NumberOfChildren.ToString();
                    cmbBedType.SelectedItem = room.BedType;
                    cmbSmokingAllowed.SelectedIndex = room.CanSmoke;
                }
            }
        }
    }
}