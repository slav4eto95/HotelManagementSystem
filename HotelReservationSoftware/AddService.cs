using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAddService : Form
    {
        public int serviceId, BookedServiceID;
        public long bookingID;
        public string serviceName;
        public decimal totalSum;

        // If true, the form will be with empty controls.
        // In other case, the form will fill the controls with proper information. 
        public bool IsEmpty = true;

        public bool ShouldAddRecord;

        public int UserLevelID;

        public frmAddService(int bookedserviceID, long bookingid, int serviceID, string service, decimal price, decimal total, int userLevelID, bool isButtonOkEnabled, bool shouldAdd)
        {
            InitializeComponent();
            BookedServiceID = bookedserviceID;
            bookingID = bookingid;
            serviceId = serviceID;
            txtService.Text = service;
            serviceName = service;
            txtPrice.Text = price.ToString();
            totalSum = total;
            txtTotal.Text = totalSum.ToString();

            UserLevelID = userLevelID;
            btnOk.Enabled = isButtonOkEnabled;
            ShouldAddRecord = shouldAdd;
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            txtService.Enabled = txtPrice.Enabled = txtTotal.Enabled = false;
            DateTime dtToday = DateTime.Now;
            dtpDate.Text = dtToday.ToShortDateString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBHelpers.BookedServices BookedServices = new DBHelpers.BookedServices();

            decimal servicePrice = Decimal.Parse(txtPrice.Text.ToString());
            int quantity = Int16.Parse(nudQuantity.Value.ToString());
            decimal total = Decimal.Parse(txtTotal.Text.ToString());

            DateTime date = DateTime.Parse(dtpDate.Value.ToShortDateString());

            if (ShouldAddRecord)
            {
                bool isAdded = BookedServices.AddBookedService(bookingID, serviceId, quantity, total, date);
                if (isAdded)
                {
                    MessageBox.Show("Успешно резервирахте услуга!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Промените не бяха запаметени!", "Незапазени промени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                bool isEdited = BookedServices.EditBookedService(BookedServiceID, bookingID, serviceId, quantity, total, date);
                if (isEdited)
                {
                    MessageBox.Show("Успешно променихте записа!", "Поздравления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Промените не бяха запаметени!", "Незапазени промени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = new DialogResult();
            dlgResult = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да отхвърлите промените?", "Отхвърляне на промени", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult.ToString() == "Yes")
            {
                Close();
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAllServices frmAllServices = new frmAllServices(bookingID, false, UserLevelID);
            frmAllServices.Show();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal price = Decimal.Parse(txtPrice.Text.ToString());
            int quantity = Int16.Parse(nudQuantity.Value.ToString());

            totalSum = price * quantity;
            txtTotal.Text = totalSum.ToString();
        }
    }
}
