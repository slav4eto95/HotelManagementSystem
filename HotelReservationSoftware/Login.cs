using System;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Text = Properties.Resources.strWelcome;
            lblUsername.Text = Properties.Resources.strUserName;
            lblPassword.Text = Properties.Resources.strPassword;
            btnLogin.Text = Properties.Resources.strButtonLogin;
            btnExit.Text = Properties.Resources.strButtonExit;

            StartSQLService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToString() == "" || txtPassword.Text.ToString() == "")
            {
                MessageBox.Show(Properties.Resources.strEmptyUserNameOrPassword, Properties.Resources.strError,
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Select(0, txtUsername.Text.Length);
                txtUsername.Focus();
                return;
            }
            else
            {
                StartMainForm();
            }
        }

        public void StartMainForm()
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            string hashedPassword = Cryptography.GenerateSHA256String(password).ToLower();

            try
            {
                using (var db = new HotelManagementSystemEntities())
                {
                    var query = db.Users
                                    .Where(u => u.Username == username && u.Password == hashedPassword)
                                    .FirstOrDefault();

                    if (query == null)
                    {
                        MessageBox.Show("Не съществува потребител с такова име и/или парола!", "Несъществуващ потребител", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Select(0, txtUsername.Text.Length);
                        txtUsername.Focus();
                        return;
                    }
                    else
                    {
                        // Show the main form based on the user level.
                        frmMain frmMain = new frmMain(query.UserID, query.Name, query.UserLevelID);
                        Hide();
                        frmMain.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to start service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void StartSQLService()
        {
            ServiceController service = new ServiceController("MSSQL$SQLEXPRESS", ".");
            //if service is Stopped or StopPending, you can run it with the following code.
            if (service.Status.Equals(ServiceControllerStatus.Stopped) | service.Status.Equals(ServiceControllerStatus.StopPending))
            {
                try
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while trying to start service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
                StartMainForm();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
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