using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmChangePassword : Form
    {
        public int UserID;

        public frmChangePassword(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            string pass = txtPassword.Text.ToString();
            string pass2 = txtPassword2.Text.ToString();

            if (pass.Length < 4)
            {
                MyMessageBox.ShowMessage("Паролата трябва да съдържа поне 4 символа!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Select(0, txtPassword.Text.Length);
                txtPassword.Focus();
            }
            else if (!validation.isPasswordMatch(pass, pass2))
            {
                MyMessageBox.ShowMessage("Паролите не съвпадат", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword2.Select(0, txtPassword2.Text.Length);
                txtPassword2.Focus();
            }
            else
            {
                Users users = new Users();
                if (users.ChangeUserPassword(UserID, pass))
                {
                    MyMessageBox.ShowMessage("Паролата е сменена успешно!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(1000);
                    Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Възникна грешка при промяната на паролата!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да излезете?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
