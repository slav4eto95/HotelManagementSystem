using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAllRooms : Form
    {
        private DBHelpers.Rooms Rooms = new DBHelpers.Rooms();
        private Room Room;
        private int RoomID;
        private int UserLevelID;

        public frmAllRooms(int userLevelId)
        {
            InitializeComponent();
            UserLevelID = userLevelId;
        }

        private void frmAllRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsWithTheirTypeDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.roomsWithTheirTypeDataSet.Rooms);

            if (UserLevelID > 2)
                btnAddRoom.Enabled = btnEditRoom.Enabled = btnDeleteRoom.Enabled = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddRoom frmAddRoom = new frmAddRoom(Room, true);
            frmAddRoom.Show();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvAllRooms.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvAllRooms.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAllRooms.Rows[selectedRowIndex];

                RoomID = Convert.ToInt16(selectedRow.Cells["roomIDDataGridViewTextBoxColumn"].Value);

                Room = Rooms.GetRoomByID(RoomID);

                frmAddRoom frmAddRoom = new frmAddRoom(Room, false);
                frmAddRoom.Show();
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvAllRooms.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvAllRooms.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAllRooms.Rows[selectedRowIndex];

                RoomID = Convert.ToInt16(selectedRow.Cells["roomIDDataGridViewTextBoxColumn"].Value);

                DialogResult result = MyMessageBox.ShowMessage("Сигурни ли сте, \nче искате да премахнете стаята?", "Изтриване на стая", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = Rooms.DeleteRoom(RoomID);
                    if (isDeleted)
                    {
                        MyMessageBox.ShowMessage("Стаята е изтрита успешно!", "Успешно изтриване на стая", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Възникна грешка при изтриването на стаята!", "Грешка при изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void frmAllRooms_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsWithTheirTypeDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.roomsWithTheirTypeDataSet.Rooms);
        }
    }
}