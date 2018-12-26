using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmMain : Form
    {
        // Field for enable/disable buttons in the DBBackupRestore form
        public static bool IsButtonBackupClicked { get; internal set; }
        // Field that checks whether the X button or the logout button is clicked
        public static bool IsLogoutButtonClicked { get; internal set; }
        public int UserID, UserLevelID;

        public frmMain(int userID, string strName, int userlevelID)
        {
            InitializeComponent();
            lblLoggedUser.Text = "Потребител: " + strName;
            UserID = userID;
            UserLevelID = userlevelID;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (UserLevelID == 2) // manager
                rbBackup.Enabled = rbRestore.Enabled = false; 
            else if(UserLevelID == 3) // reception
                rbUsers.Enabled = rbChangePassword.Enabled = rbBackup.Enabled = rbRestore.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString();
        }

        private void rbUsers_Click(object sender, EventArgs e)
        {
            frmAllUsers frmAllUsers = new frmAllUsers(UserLevelID);
            /*frmAllUsers.Dock = DockStyle.Fill;
            frmAllUsers.TopLevel = false;
            frmAllUsers.AutoScroll = true;
            panelMainContent.Controls.Add(frmAllUsers);*/
            frmAllUsers.Show();
        }

        private void rbLogout_Click(object sender, EventArgs e)
        {
            IsLogoutButtonClicked = true;

            DialogResult result;
            result = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да излезете?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                Close();
            }
        }

        private void rbChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword(UserID);
            changePassword.Show();
        }

        private void rbBackup_Click(object sender, EventArgs e)
        {
            IsButtonBackupClicked = true;

            frmDBBackupRestore backupRestore = new frmDBBackupRestore();
            backupRestore.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    if (!IsLogoutButtonClicked)
                    {
                        DialogResult result;
                        result = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да излезете?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    break;
            }
        }

        private void rbRestore_Click(object sender, EventArgs e)
        {
            IsButtonBackupClicked = false;
            frmDBBackupRestore backupRestore = new frmDBBackupRestore();
            backupRestore.Show();
        }

        private void rbReservations_Click(object sender, EventArgs e)
        {
            frmAllReservations frmAllReservations = new frmAllReservations(false, UserLevelID);
            frmAllReservations.Show();
        }

        private void rbCheckin_Click(object sender, EventArgs e)
        {
            frmCheckInCheckOutGuests frmCheckInCheckOutGuests = new frmCheckInCheckOutGuests(true);
            frmCheckInCheckOutGuests.Show();
        }

        private void rbCheckout_Click(object sender, EventArgs e)
        {
            frmCheckInCheckOutGuests frmCheckInCheckOutGuests = new frmCheckInCheckOutGuests(false);
            frmCheckInCheckOutGuests.Show();
        }

        private void rbServices_Click(object sender, EventArgs e)
        {
            frmAllServices frmAllServices = new frmAllServices(-1, true, UserLevelID);
            frmAllServices.Show();
        }

        private void rbRoomTypes_Click(object sender, EventArgs e)
        {
            frmAllRoomTypes frmAllRoomTypes = new frmAllRoomTypes(UserLevelID, true);
            frmAllRoomTypes.Show();
        }

        private void rbRooms_Click(object sender, EventArgs e)
        {
            frmAllRooms frmAllRooms = new frmAllRooms(UserLevelID);
            frmAllRooms.Show();
        }

        private void rbAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void rbRoomSearch_Click(object sender, EventArgs e)
        {/*
            frmRooms frmRooms = new frmRooms();
            frmRooms.Show();
            */
            panelMainContent.Controls.Clear();

            SearchCenterControl control1 = new SearchCenterControl(this, true);

            panelLeft.Controls.Remove(control1);
            panelLeft.Controls.Clear();

            control1.Dock = DockStyle.Fill;
            panelLeft.Controls.Add(control1);
            control1.Show();
        }

        private void rbGuestsReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();

            ReportViewerControl reportViewerControl = new ReportViewerControl("Guests")
            {
                Dock = DockStyle.Fill
            };

            panelMainContent.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }

        private void rbReservationReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            SearchCenterControl control1 = new SearchCenterControl(this, false);

            panelLeft.Controls.Remove(control1);
            panelLeft.Controls.Clear();

            control1.Dock = DockStyle.Fill;
            
            panelLeft.Controls.Add(control1);
            control1.Show();
        }

        private void ClearPanelContent()
        {
            if (panelMainContent.Controls.Count > 0)
            {
                panelMainContent.Controls.Clear();
            }
        }

        private void rbCountryReport_Click(object sender, EventArgs e)
        {
            Countries countries = new Countries();
            countries.Show();
        }

        private void rbSearchGuest_Click(object sender, EventArgs e)
        {
            frmSearchGuest searchGuest = new frmSearchGuest(UserLevelID);
            searchGuest.Show();
        }

        private void rbMonths_Click(object sender, EventArgs e)
        {
            MonthsGuests monthsGuests = new MonthsGuests();
            monthsGuests.Show();
        }

        private void rbRoomsReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            ReportViewerControl reportViewerControl = new ReportViewerControl("RoomsReport")
            {
                Dock = DockStyle.Fill
            };
            panelMainContent.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }

        private void rbServiceReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            ReportViewerControl reportViewerControl = new ReportViewerControl("Services")
            {
                Dock = DockStyle.Fill
            };
            panelMainContent.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }

        private void rbCheckInReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            ReportViewerControl reportViewerControl = new ReportViewerControl("CheckInReport")
            {
                Dock = DockStyle.Fill
            };
            panelMainContent.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }

        private void rbCheckOutReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            ReportViewerControl reportViewerControl = new ReportViewerControl("CheckOutReport")
            {
                Dock = DockStyle.Fill
            };
            panelMainContent.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }

        private void rbDailyOccupancy_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            ReportViewerControl reportViewerControl = new ReportViewerControl("DailyOccupancyReport")
            {
                Dock = DockStyle.Fill
            };
            panelMainContent.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }
    }
}