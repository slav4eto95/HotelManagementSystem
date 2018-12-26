using System;
using System.Data;
using System.Security.Cryptography;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Text;

namespace HotelReservationSoftware
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                // Зареди всички потребителски нива, освен "Администратор".
                var userLevels = db.UserLevels
                                        .Where(ul => ul.UserLevelID != 1)
                                        .ToList();

                foreach (var item in userLevels)
                {
                    cmbUserLevel.Items.Add(item.UserLevelDesc);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbUserLevel.SelectedItem == null)
            {
                MessageBox.Show("Моля изберете потребителско ниво!", "Невъведено ниво", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserLevel.Focus();
                return;
            }
            if (txtName.Text.Equals("") || txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Моля попълнете Вашето име, потребителско име и/или парола!", "Невъведени полета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else
            {
                checkForValidFields();
            }

            string name = txtName.Text.ToString();
            string username = txtUsername.Text.ToString();
            string ePass = Cryptography.GenerateSHA256String(txtPassword.Text).ToLower();
            string userleveldesc = cmbUserLevel.SelectedItem.ToString();

            using (var db = new HotelManagementSystemEntities())
            {
                var userLevel = db.UserLevels
                                    .Where(ul => ul.UserLevelDesc == userleveldesc)
                                    .FirstOrDefault();

                Users users = new Users();
                User user = new User
                {
                    Name = name,
                    Username = username,
                    Password = ePass,
                    UserLevelID = userLevel.UserLevelID
                };

                bool userExists = users.CheckIfUserAlreadyExists(user);
                if (userExists)
                {
                    MessageBox.Show("Потребител с тези данни вече съществува! \n", "Съществуващ потребител", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool isAddedUser = users.AddUser(user);
                    if (isAddedUser)
                    {
                        MessageBox.Show("Успешно се регистрирахте. \n Ще бъдете пренасочени към login формата.", "Успешна регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread.Sleep(1000);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Възникна грешка при регистрацията! \n Моля опитайте пак.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Сигурни ли сте, че искате да прекратите регистрацията?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        public void checkForValidFields()
        {
            Validation validation = new Validation();
            if (!validation.isValidTextField(txtName.Text.ToString()))
            {
                MessageBox.Show("Името трябва да съдържа само букви на кирилица или латиница!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Select(0, txtUsername.Text.Length);
                txtName.Focus();
                return;
            }

            if (!validation.isPasswordMatch(txtPassword.Text.ToString(), txtPassword2.Text.ToString()))
            {
                MessageBox.Show("Паролите не съвпадат", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword2.Select(0, txtPassword2.Text.Length);
                txtPassword2.Focus();
                return;
            }
        }

        private void cbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}