using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAllRoomTypes : Form
    {
        private string roomType;
        private int roomTypeID;
        private bool IsAllRoomTypesButtonClicked;
        private int UserLevelID;

        public frmAllRoomTypes(int userLevelID, bool isClicked)
        {
            InitializeComponent();
            UserLevelID = userLevelID;
            IsAllRoomTypesButtonClicked = isClicked;
        }

        private void AllRoomTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomTypesDataSet.RoomTypes' table. You can move, or remove it, as needed.
            this.roomTypesTableAdapter.Fill(this.roomTypesDataSet.RoomTypes);

            if (UserLevelID > 2)
            {
                btnAddNewRoomType.Enabled = false;
            }

            if (IsAllRoomTypesButtonClicked)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;
        }

        private void btnAddNewRoomType_Click(object sender, EventArgs e)
        {
            frmAddRoomType frmAddRoomType = new frmAddRoomType();
            frmAddRoomType.Show();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsAllRoomTypesButtonClicked)
            {
                if (dgvAllRoomTypes.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvAllRoomTypes.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAllRoomTypes.Rows[selectedRowIndex];

                    roomTypeID = Convert.ToInt16(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value);
                    roomType = Convert.ToString(selectedRow.Cells["roomTypeDescDataGridViewTextBoxColumn"].Value);
                }
            }
            Close();
        }

        private void frmAllRoomTypes_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomTypesDataSet.RoomTypes' table. You can move, or remove it, as needed.
            this.roomTypesTableAdapter.Fill(this.roomTypesDataSet.RoomTypes);

            if (IsAllRoomTypesButtonClicked)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var query = db.RoomTypes.Where(rt => rt.RoomTypeDesc.StartsWith(txtFilter.Text)).ToList();

                dgvAllRoomTypes.DataSource = null;
                dgvAllRoomTypes.Rows.Clear();
                foreach (var item in query)
                {
                    dgvAllRoomTypes.Rows.Add(item.RoomTypeID, item.RoomTypeDesc, item.RoomPrice,
                        item.NumberOfAdults, item.NumberOfBeds, item.NumberOfChildren,
                        item.BedType, item.CanSmoke, item.RoomAddDescription);
                }
            }
        }
    }
}
