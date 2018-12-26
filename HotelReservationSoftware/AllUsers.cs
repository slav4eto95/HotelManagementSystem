using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAllUsers : Form
    {
        HotelManagementSystemEntities db = new HotelManagementSystemEntities();
        public Users Users = new Users();
        public int UserID, UserLevel, UserLevelID;
        public string strUserName, strName;

        public frmAllUsers(int userLevelID)
        {
            InitializeComponent();

            UserLevelID = userLevelID;
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoResizeColumns();
            dgvUsers.AutoResizeRows();
            DisplayUserInfo();

            if (UserLevelID != 1)
            {
                btnNewRecord.Enabled = btnEdit.Enabled = btnDeleteUser.Enabled = false;
            }
        }

        // Display Method is a common method to bind the Users details in datagridview
        // after save, update and delete operation perform.
        public void DisplayUserInfo()
        {
            using (var db = new HotelManagementSystemEntities())
            {
                dgvUsers.DataSource = db.Users.ToList();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            // Get the userID of the current selected row
            UserID = Int16.Parse(row.Cells[4].Value.ToString());

            DialogResult result;
            result = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да изтриете този запис?", "Изтриване на запис", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = Users.DeleteUser(UserID);
                if (isDeleted)
                {
                    MyMessageBox.ShowMessage("Записът е изтрит успешно!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayUserInfo();
                }
                else
                {
                    MyMessageBox.ShowMessage("Възникна грешка при изтриването на записа!", "Грешка при изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmAllUsers_Activated(object sender, EventArgs e)
        {
            dgvUsers.AutoResizeColumns();
            dgvUsers.AutoResizeRows();
            DisplayUserInfo();

            if (UserLevelID != 1)
            {
                btnNewRecord.Enabled = btnEdit.Enabled = btnDeleteUser.Enabled = false;
            }
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser(-1, "", "", "", 1);
            frmEditUser.Show();
        }

        // Function that prevents moving of the form
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvUsers.Rows[selectedRowIndex];

                UserID = Convert.ToInt16(selectedRow.Cells["dgvtxtUserID"].Value);
                strUserName = Convert.ToString(selectedRow.Cells["dgvtxtUserName"].Value);
                strName = Convert.ToString(selectedRow.Cells["dgvtxtName"].Value);

                UserLevel = Convert.ToInt16(selectedRow.Cells["dgvtxtUserLevelID"].Value);

                frmEditUser frmEditUser = new frmEditUser(UserID, strUserName, strName, "", UserLevel);
                frmEditUser.Show();
            }
        }
    }
}