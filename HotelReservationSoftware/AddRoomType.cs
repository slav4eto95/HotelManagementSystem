using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAddRoomType : Form
    {
        public int roomTypeID, adultsNum, bedsNum, childrenNum, canSmoke;
        public string roomType, bedType, roomDescription;
        public decimal roomPrice;

        public frmAddRoomType()
        {
            InitializeComponent();
        }

        private void frmAddRoomType_Load(object sender, EventArgs e)
        {
            // labels
            Text = "Добави тип на стая";
            lblRoomType.Text = "Тип стая";
            lblAdultsNo.Text = "Брой възрастни";
            lblBedroomNum.Text = "Брой легла";
            lblPrice.Text = "Цена";
            lblChildrenNo.Text = "Брой деца";
            lblBedType.Text = "Тип легло";
            chkCanSmoke.Text = "Пушене";
            lblDescription.Text = "Допълнително описание:";
            lblSeparatorLine.Height = 2;

            // numeric up-down
            nudAdultNo.Value = 1;
            nudAdultNo.Minimum = 1;
            nudAdultNo.Maximum = 10;

            nudBedroomNum.Value = 1;
            nudBedroomNum.Minimum = 1;
            nudBedroomNum.Maximum = 6;

            nudChildrenNum.Value = 0;
            nudChildrenNum.Minimum = 0;
            nudChildrenNum.Maximum = 6;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBHelpers.RoomTypes RoomTypes = new DBHelpers.RoomTypes();
            roomType = txtRoomType.Text.ToString();
            string price = txtPrice.Text.ToString().Replace(',', '.');
            roomPrice = decimal.Parse(price);
            adultsNum = short.Parse(nudAdultNo.Value.ToString());
            bedsNum = short.Parse(nudBedroomNum.Value.ToString());
            childrenNum = short.Parse(nudChildrenNum.Value.ToString());
            bedType = cmbBedType.SelectedItem.ToString();
            if (chkCanSmoke.Checked)
            {
                canSmoke = 1; // yes
            }
            else
            {
                canSmoke = 0; // no
            }
            roomDescription = txtDescription.Text.ToString();

            bool isAdded = RoomTypes.AddRoomType(roomType, roomPrice, adultsNum, bedsNum, childrenNum, bedType, canSmoke, roomDescription);
            if (isAdded)
            {
                MyMessageBox.ShowMessage("Успешно добавихте тип стая!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MyMessageBox.ShowMessage("Възникна грешка при добавянето на типа стая", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = new DialogResult();
            dlgResult = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да откажете промените?", "Отказване на промените", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult.ToString() == "Yes")
            {
                Close();
            }
        }

        private void ClearFields()
        {
            txtRoomType.Text = txtPrice.Text = txtDescription.Text = "";
            nudAdultNo.Value = nudBedroomNum.Value = 1;
            nudChildrenNum.Value = 0;
            chkCanSmoke.Checked = false;
            cmbBedType.SelectedItem = null;
        }
    }
}
