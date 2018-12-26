using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmEditUser : Form
    {
        HotelManagementSystemEntities db;
        Helpers helpers;
        frmAllUsers frmAllUsers;
        Users Users;

        // If true, the form will be with empty controls.
        // In other case, the form will fill the controls with proper information. 
        public bool isEmpty = true;

        // Get the user id of the selected row.
        public int UserID;

        public frmEditUser(int userID, string username, string name, string pass, int userLevel)
        {
            InitializeComponent();

            db = new HotelManagementSystemEntities();
            helpers = new Helpers();
            frmAllUsers = new frmAllUsers(userLevel);
            Users = new Users();

            // TODO: This line of code loads data into the 'userLevelsDataSet.UserLevels' table. You can move, or remove it, as needed.
            this.userLevelsTableAdapter1.Fill(this.userLevelsDataSet.UserLevels);

            UserID = userID;
            txtUserName.Text = username;
            txtName.Text = name;
            txtPassword.Text = "";
            foreach (DataRowView item in cmbUserLevel.Items)
            {
                if (((UserLevelsDataSet.UserLevelsRow)(item.Row)).UserLevelID == userLevel)
                {
                    cmbUserLevel.SelectedItem = item;
                    break;
                }
            }
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals("") || !txtUserName.Text.Equals("") || !txtPassword.Text.Equals(""))
            {
                isEmpty = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEmpty)
            {
                AddUserToDatabase();
            }
            else
            {
                UpdateUserInDatabase();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да откажете промените?", "Отказ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        public void AddUserToDatabase()
        {
            if (cmbUserLevel.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("Моля изберете потребителско ниво!", "Невъведено ниво", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserLevel.Focus();
                return;
            }
            if (txtName.Text.Equals("") || txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MyMessageBox.ShowMessage("Моля попълнете Вашето име, потребителско име и/или парола!", "Невъведени полета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else
            {
                string name = txtName.Text.ToString();
                string userName = txtUserName.Text.ToString();
                string password = Cryptography.GenerateSHA256String(txtPassword.Text.ToString());

                byte newUserLevel = 0;
                DataRowView selectedItem = (DataRowView)cmbUserLevel.SelectedItem;
                newUserLevel = ((UserLevelsDataSet.UserLevelsRow)selectedItem.Row).UserLevelID;

                User user = new User
                {
                    Name = name,
                    Username = userName,
                    Password = password,
                    UserLevelID = newUserLevel
                };


                bool isAdded = Users.AddUser(user);
                if (isAdded)
                {
                    frmAllUsers.DisplayUserInfo();
                    MyMessageBox.ShowMessage("Потребителят е добавен успешно!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Промените не бяха запаметени!", "Незапазени промени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        public void UpdateUserInDatabase()
        {
            int localUserID = UserID;
            string newName = txtName.Text.ToString();
            string newUserName = txtUserName.Text.ToString();
            string pass = txtPassword.Text.ToString();
            string newPassword = "";

            if (pass != "")
                newPassword = Cryptography.GenerateSHA256String(pass);

            DataRowView selectedItem = (DataRowView)cmbUserLevel.SelectedItem;
            int newUserLevel = ((UserLevelsDataSet.UserLevelsRow)selectedItem.Row).UserLevelID;

            bool isUpdated = Users.UpdateUser(localUserID, newName, newUserName, newPassword, newUserLevel);
            if (isUpdated)
            {
                frmAllUsers.DisplayUserInfo();
                MyMessageBox.ShowMessage("Промените бяха запаметени успешно!", "Успешно запазени промени", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
            else
            {
                MyMessageBox.ShowMessage("Промените не бяха запаметени!", "Незапазени промени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
