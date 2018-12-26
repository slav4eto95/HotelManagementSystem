using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmSearchGuest : Form
    {
        private static string EnterFirstName = "Въведете име...";
        private static string EnterMiddleName = "Въведете презиме...";
        private static string EnterLastName = "Въведете фамилия...";
        public string FirstName, MiddleName, LastName;
        public int UserLevelID;

        public frmSearchGuest(int userLevelID)
        {
            InitializeComponent();
            UserLevelID = userLevelID;
        }

        private void frmSearchGuest_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = EnterFirstName;
            txtFirstName.ForeColor = Color.Gray;

            txtMiddleName.Text = EnterMiddleName;
            txtMiddleName.ForeColor = Color.Gray;

            txtLastName.Text = EnterLastName;
            txtLastName.ForeColor = Color.Gray;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == EnterFirstName)
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = EnterFirstName;
                txtFirstName.ForeColor = Color.Gray;
            }
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == EnterMiddleName)
            {
                txtMiddleName.Text = "";
                txtMiddleName.ForeColor = Color.Black;
            }
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == "")
            {
                txtMiddleName.Text = EnterMiddleName;
                txtMiddleName.ForeColor = Color.Gray;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == EnterLastName)
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = EnterLastName;
                txtLastName.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.ToString();
            MiddleName = txtMiddleName.Text.ToString();
            LastName = txtLastName.Text.ToString();
            List<String> list = new List<string>();

            list.Add(FirstName);
            list.Add(MiddleName);
            list.Add(LastName);

            frmAllReservations allReservations = new frmAllReservations(list, UserLevelID, true);
            allReservations.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MyMessageBox.ShowMessage("Сигурни ли сте, че не искате да продължите?", "Отказ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
