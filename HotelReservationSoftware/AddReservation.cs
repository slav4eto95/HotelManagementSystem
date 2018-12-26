using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAddReservation : Form
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public DateTime dtDateCheckIn;
        public DateTime dtDateCheckOut;
        public DateTime dtBookTime;
        public Helpers Helpers;
        public Guests Guests;
        private DBHelpers.Rooms Rooms;
        private DBHelpers.Bookings Bookings;
        private DBHelpers.BookedRooms BookedRooms;
        private DBHelpers.BookedServices BookedServices;
        private DBHelpers.Payments Payments;
        private KeyPressValidation KeyPressValidation;
        private Booking BookingObject;

        public long bookingID;
        public int guestID, bookedServiceID, serviceID, roomID,
            adultsNo, childrenNo, numberOfNights, creditCardSecurityCode,
            paymentMethodID, paymentID;
        public string serviceName, roomType, bookingStatus, hasCar,
            guestName, guestPhone, guestEmail, Notes, referredBy,
            guestEGN, guestTitle, guestAddress, guestPostCode, guestCity,
            guestCountry, guestFirmName,
            creditCardName, creditCardExpireDate, creditCardNumber,
            referenceNumber, invoiceNumber;

        public decimal servicePrice, roomPrice, totalSum, restSum, paymentSum;
        public DateTime checkIn, checkOut, bookDate, paymentDate;
        public bool IsButtonAddClicked, IsCTRLPlusFPressed = false;

        public int UserLevelID;

        public frmAddReservation(Booking booking, int userLevelID, bool isButtonAddClicked)
        {
            InitializeComponent();

            dtDateCheckIn = new DateTime();
            dtDateCheckOut = new DateTime();
            dtBookTime = new DateTime();
            Helpers = new Helpers();
            Guests = new Guests();
            Rooms = new DBHelpers.Rooms();
            Bookings = new DBHelpers.Bookings();
            BookedRooms = new DBHelpers.BookedRooms();
            BookedServices = new DBHelpers.BookedServices();
            Payments = new DBHelpers.Payments();
            KeyPressValidation = new KeyPressValidation();
            BookingObject = new Booking();

            BookingObject = booking;
            LoadData(BookingObject);

            IsButtonAddClicked = isButtonAddClicked;
            UserLevelID = userLevelID;
        }

        private void LoadData(Booking booking)
        {
            bookingID = booking.BookingID;
            using (var db = new HotelManagementSystemEntities())
            {
                var res = db.BookingStatus
                                    .Where(bs => bs.BookingStatusID == booking.BookingStatusID)
                                    .FirstOrDefault();
                bookingStatus = res.BookingStatusName;

                // Guest Information
                var res2 = db.Guests
                                    .Where(g => g.GuestID == booking.GuestID)
                                    .FirstOrDefault();
                var res3 = db.Titles
                                    .Where(t => t.TitleID == res2.TitleID)
                                    .FirstOrDefault();

                guestID = res2.GuestID;
                guestTitle = res3.TitleDesc;
                guestName = res2.FirstName + " " + res2.MiddleName + " " + res2.LastName;
                guestAddress = res2.Address;
                guestPostCode = res2.PostCode;
                guestCity = res2.City;
                guestCountry = res2.Country;
                guestEGN = res2.EGN;
                guestPhone = res2.Phone;
                guestEmail = res2.Email;
                guestFirmName = res2.FirmName;

                var res4 = db.ReferredBies
                                        .Where(rb => rb.ReferredByID == booking.ReferredByID)
                                        .FirstOrDefault();
                referredBy = res4.ReferredBy1;

                var res5 = db.Payments
                                      .Where(p => p.BookingID == bookingID)
                                      .ToList();
                foreach (var item in res5)
                {
                    paymentSum += (decimal)item.PaymentSum;
                }
            }

            checkIn = booking.CheckIn;
            checkOut = booking.CheckOut;
            numberOfNights = booking.Nights;
            hasCar = booking.HasCar;
            bookDate = booking.BookDate;
            Notes = booking.Notes;
            totalSum = (decimal)booking.TotalSum;
            txtTotal.Text = totalSum.ToString() + " лв.";
            restSum = (decimal)booking.RestSum;
            txtRestSum.Text = restSum.ToString() + " лв.";
            creditCardName = booking.CreditCardName;
            creditCardNumber = booking.CreditCardNo;
            creditCardSecurityCode = (int)booking.CreditCardSecurityCode;
            creditCardExpireDate = booking.CreditCardExpiry;
            referenceNumber = booking.ReferenceNumber;
            invoiceNumber = booking.InvoiceNumber;
        }

        // https://stackoverflow.com/questions/6016224/from-where-i-can-get-the-country-combo-box-in-c
        // http://atikpassion.blogspot.bg/2011/02/wpf-get-all-country-in-combobox.html
        public static List<string> GetCountryList()
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }
            return cultureList;
        }

        private void frmAddReservation_Load(object sender, EventArgs e)
        {
            DateTime dtToday;
            dtToday = DateTime.Now;

            // group boxes
            this.Text = Properties.Resources.strFormAddReservation;
            grpBoxGeneralInfo.Text = Properties.Resources.strGeneralInformation;
            grpBoxPaymentInfo.Text = Properties.Resources.strPaymentInformation;
            grpBoxGuestInfo.Text = Properties.Resources.strGuestInformation;
            grpBoxRoomsAndGuestInfo.Text = Properties.Resources.strRoomsAndGuestInfo;
            grpBoxServicesInfo.Text = Properties.Resources.strServicesInfo;

            // labels
            lblBookingID.Text = "No на резервация";
            lblStatus.Text = "Статус *";
            lblCheckIn.Text = "Настаняване *";
            lblCheckOut.Text = "Напускане *";
            lblNumNights.Text = "Нощувки";
            lblHasCar.Text = "Кола";
            lblBookTime.Text = "Дата на резервация";
            lblNotes.Text = "Забележки";
            lblPayMethod.Text = "Начин на плащане *";
            lblNameOnCard.Text = "Име върху картата";
            lblCardNumber.Text = "No на карта";
            lblSecurityCode.Text = "Код за сигурност";
            lblExpirationDate.Text = "Валидност до";
            lblReferenceNo.Text = "Референтен No";
            lblInvoiceNumber.Text = "No на фактура";
            lblSubtotal.Text = "Междинна сума";
            lblDiscount.Text = "Отстъпка (в %)";
            lblTotal.Text = "Общо";
            lblPaid.Text = "Платено";
            lblRestSum.Text = "Остатък";
            lblTitle.Text = "Обръщение *";
            lblFirstName.Text = "Име *";
            lblMiddleName.Text = "Презиме";
            lblLastName.Text = "Фамилия *";
            lblFirmName.Text = "Име на фирмата";
            lblAddress1.Text = "Адрес";
            lblCity.Text = "Град";
            lblCountry.Text = "Държава";
            lblPostCode.Text = "Пощенски код";
            lblEGN.Text = "ЕГН";
            lblPhone.Text = "Телефон";
            lblEmail.Text = "Имейл";
            lblRefferedBy.Text = "Посочен от";

            // buttons
            btnAddRoomInfo.Text = btnAddServiceInfo.Text = Properties.Resources.strAddButton;
            btnEditRoomInfo.Text = btnEditServiceInfo.Text = Properties.Resources.strEditButton;
            btnDeleteRoomInfo.Text = btnDeleteServiceInfo.Text = Properties.Resources.strDeleteButton;
            btnOk.Enabled = false;

            // LoadData(BookingObject);

            if (IsButtonAddClicked)
                this.Text = "Добави резервация";
            else
                this.Text = "Редактирай резервация";

            fillComboBoxes();
            fillFieldsWithProperInformation();

            // TODO: This line of code loads data into the 'bookedServiceDataSet.BookedServices' table. You can move, or remove it, as needed.
            this.bookedServicesTableAdapter.FillAccordingToBookingID(this.bookedServiceDataSet.BookedServices, bookingID);

            // TODO: This line of code loads data into the 'bookedRooms._BookedRooms' table. You can move, or remove it, as needed.
            this.bookedRoomsTableAdapter.Fill(this.bookedRoomsDataSet.BookedRooms, bookingID);
        }

        public void fillFieldsWithProperInformation()
        {
            txtBookingID.Text = bookingID.ToString();
            cmbPayMethod.SelectedItem = "в брой";
            txtPaid.Text = "0.00 лв.";
            // If is clicked, perform add operations. In other case we will perform edit operations.
            if (IsButtonAddClicked)
            {
                dtpCheckIn.Text = dtpBookTime.Text = checkIn.ToString();
                dtpCheckOut.Text = checkOut.ToString();
                cmbHasCar.SelectedIndex = 0; // default value for 'has car' - No
                txtSubtotal.Text = txtTotal.Text.ToString();// = totalSum.ToString() + " лв.";
                txtRestSum.Text = restSum.ToString() + " лв.";
                cmbRefferedBy.SelectedIndex = 0; // 'Не се знае'
                cmbCountry.SelectedItem = "Bulgaria";
                cmbStatus.SelectedIndex = 0; // 'Без статус'
            }
            else
            {
                cmbStatus.SelectedItem = bookingStatus;
                dtpCheckIn.Text = checkIn.ToString();
                dtpCheckOut.Text = checkOut.ToString();
                txtNumberOfNigths.Text = numberOfNights.ToString();
                cmbHasCar.SelectedItem = hasCar;
                dtpBookTime.Text = bookDate.ToString();
                txtNotes.Text = Notes;

                txtNameOnCard.Text = creditCardName;
                txtCardNumber.Text = creditCardNumber;
                txtSecurityCode.Text = creditCardSecurityCode.ToString();
                string[] expireDate = creditCardExpireDate.Split('/');
                cmbMonth.SelectedItem = expireDate[0];
                cmbYear.SelectedItem = expireDate[1];
                txtReferenceNo.Text = referenceNumber;
                txtInvoiceNumber.Text = invoiceNumber;
                txtSubtotal.Text = txtTotal.Text.ToString() + " лв.";

                txtRestSum.Text = restSum.ToString() + " лв.";

                cmbTitle.SelectedItem = guestTitle;
                string[] name = guestName.Split(' ');
                txtFirstName.Text = name[0];
                txtMiddleName.Text = name[1];
                txtLastName.Text = name[2];
                txtFirmName.Text = guestFirmName;
                txtAddress.Text = guestAddress;
                txtCity.Text = guestCity;
                cmbCountry.SelectedItem = guestCountry;
                txtPostCode.Text = guestPostCode;
                txtEGN.Text = guestEGN;
                txtPhone.Text = guestPhone;
                txtEmail.Text = guestEmail;
                cmbRefferedBy.SelectedItem = referredBy;
            }
        }

        public void fillComboBoxes()
        {
            for (int index = 1; index < 13; index++)
            {
                cmbMonth.Items.Add(index);
            }

            for (int index = 2018; index <= 2050; index++)
            {
                cmbYear.Items.Add(index);
            }

            List<string> listCountry = GetCountryList();
            IEnumerable<string> nameAdded = listCountry.OrderBy(names => names).Distinct();
            foreach (string item in nameAdded)
            {
                cmbCountry.Items.Add(item);
            }

            using (var db = new HotelManagementSystemEntities())
            {
                var querySelectBookingStatus = db.BookingStatus.ToList();
                foreach (var item in querySelectBookingStatus)
                {
                    cmbStatus.Items.Add(item.BookingStatusName);
                }

                var querySelectPaymentMethods = db.PaymentMethods.ToList();
                foreach (var item in querySelectPaymentMethods)
                {
                    // payment method description
                    cmbPayMethod.Items.Add(item.PaymentMethod1);
                }

                var querySelectTitles = db.Titles.ToList();
                foreach (var item in querySelectTitles)
                {
                    cmbTitle.Items.Add(item.TitleDesc);
                }

                var querySelectReferredBy = db.ReferredBies.ToList();
                foreach (var item in querySelectReferredBy)
                {
                    // referred by description
                    cmbRefferedBy.Items.Add(item.ReferredBy1);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            if (!validation.isValidTextField(txtFirstName.Text) || !validation.isValidTextField(txtLastName.Text))
            {
                MessageBox.Show("Името, презимето или фамилията съдържат непозволени символи!", "Грешно име", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Select(0, txtFirstName.Text.Length);
                txtFirstName.Focus();
                return;
            }
            if (txtEmail.Text.ToString() != "" && !validation.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Въведете валиден имейл!", "Грешен имейл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Select(0, txtEmail.Text.Length);
                txtEmail.Focus();
                return;
            }
            if (txtPhone.Text.ToString() != "" && !validation.isValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Въведете валиден телефонен номер!", "Грешен телефонен номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Select(0, txtPhone.Text.Length);
                txtPhone.Focus();
            }
            if (txtPostCode.Text.ToString() != "" && !validation.isValidNumberField(txtPostCode.Text))
            {
                MessageBox.Show("Въведете валиден пощенски код!", "Грешен пощенски код", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Select(0, txtPostCode.Text.Length);
                txtPostCode.Focus();
                return;
            }
            // Validate fields for card number and security code only when they are enabled.
            if (cmbPayMethod.SelectedItem != null && cmbPayMethod.SelectedItem.ToString() == "с карта")
            {
                if (!validation.isValidCardNumber(txtCardNumber.Text.ToString()))
                {
                    MessageBox.Show("Въведете валиден номер на картата!", "Грешен номер на карта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCardNumber.Select(0, txtCardNumber.Text.Length);
                    txtCardNumber.Focus();
                    return;
                }
                // if the security code is different than 3 numbers
                if (!Regex.IsMatch(txtSecurityCode.Text.ToString(), @"^\d{3}$"))
                {
                    MessageBox.Show("Въведеният security code е грешен!", "Грешен security card", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSecurityCode.Select(0, txtSecurityCode.Text.Length);
                    txtSecurityCode.Focus();
                    return;
                }
            }

            if (cmbCountry.SelectedItem != null && cmbCountry.SelectedItem.ToString() == "Bulgaria")
            {
                if (!validation.isValidEGN(txtEGN.Text))
                {
                    MessageBox.Show("Въведеният ЕГН е грешен!", "Грешно ЕГН", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEGN.Select(0, txtEGN.Text.Length);
                    txtEGN.Focus();
                    return;
                }
            }

            checkForNullFields();

            addReservation();
        }

        public void addReservation()
        {
            string bookingStatus = cmbStatus.SelectedItem.ToString();
            string hasCar = cmbHasCar.SelectedItem.ToString();

            dtBookTime = dtpBookTime.Value;
            dtDateCheckIn = dtpCheckIn.Value;
            dtDateCheckOut = dtpCheckOut.Value;

            DateTime bookTime = dtBookTime.Date;
            DateTime checkIn = dtDateCheckIn.Date;
            DateTime checkOut = dtDateCheckOut.Date;

            int nights = short.Parse(txtNumberOfNigths.Text.ToString());
            string notes = txtNotes.Text.ToString();
            string payMethod = cmbPayMethod.SelectedItem.ToString();
            string nameOnCard = "";
            string cardNumber = "";
            int securityCode = 0;
            int expireMonth = 0;
            int expireYear = 0;

            decimal subTotal = price(txtSubtotal.Text.ToString());
            decimal discount = decimal.Parse(nudDiscount.Value.ToString());
            decimal total = price(txtTotal.Text.ToString());
            decimal paid = price(txtPaid.Text.ToString());
            restSum = price(txtRestSum.Text.ToString());

            string referNo = txtReferenceNo.Text.ToString();
            string invoiceNo = txtInvoiceNumber.Text.ToString();

            string title = cmbTitle.SelectedItem.ToString();
            string firstName = txtFirstName.Text.ToString();
            string middleName = txtMiddleName.Text.ToString();
            if (middleName.Length == 0)
                middleName = "";
            string lastName = txtLastName.Text.ToString();
            string addr = txtAddress.Text.ToString();
            string firmName = txtFirmName.Text.ToString();
            if (firmName.Length == 0)
                firmName = "";

            string city = txtCity.Text.ToString();
            string country = cmbCountry.SelectedItem.ToString();
            string EGN = txtEGN.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string email = txtEmail.Text.ToString();

            string postCode = txtPostCode.Text.ToString();

            if (cmbPayMethod.SelectedItem != null && cmbPayMethod.SelectedItem.ToString() == "с карта")
            {
                nameOnCard = txtNameOnCard.Text.ToString();
                cardNumber = txtCardNumber.Text.ToString();
                securityCode = int.Parse(txtSecurityCode.Text.ToString());
                expireMonth = int.Parse(cmbMonth.SelectedItem.ToString());
                expireYear = int.Parse(cmbYear.SelectedItem.ToString());
            }

            int bookingStatusID = 0;
            int titleID = 0;
            int referredByID = 0;
            string referredBy = cmbRefferedBy.SelectedItem.ToString();
            using (var db = new HotelManagementSystemEntities())
            {
                var queryBSID = db.BookingStatus
                                            .Where(bs => bs.BookingStatusName == bookingStatus)
                                            .FirstOrDefault();
                bookingStatusID = queryBSID.BookingStatusID;

                var queryTitleID = db.Titles
                                            .Where(t => t.TitleDesc == title)
                                            .FirstOrDefault();
                titleID = queryTitleID.TitleID;

                var queryRefID = db.ReferredBies
                                                .Where(rb => rb.ReferredBy1 == referredBy)
                                                .FirstOrDefault();
                referredByID = queryRefID.ReferredByID;
            }

            if (IsButtonAddClicked)
            {
                guestID = Helpers.GetLastInsertedID("Guests", "GuestID");
            }

            bool isUpdatedGuest = Guests.UpdateGuest(guestID, titleID, firstName, middleName, lastName, addr, postCode,
                                                        city, country, EGN, phone, email, firmName);

            if (isUpdatedGuest)
            {
                bool isUpdateReservation = Bookings.UpdateReservation(bookingID, bookingStatusID, guestID, checkIn, checkOut, nights,
                                                                    hasCar, bookTime, notes, nameOnCard, cardNumber, securityCode,
                                                                expireMonth + "/" + expireYear, referNo, invoiceNo, total, restSum, referredByID);
                if (isUpdateReservation)
                {
                    if (dgvRooms.RowCount > 0)
                    {
                        for (int i = 0; i < dgvRooms.Rows.Count; ++i)
                        {
                            roomID = (int)dgvRooms.Rows[i].Cells["roomIDDataGridViewTextBoxColumn"].Value;
                            // update RoomStatus -> from 1 to 2 based on RoomID
                            Rooms.UpdateRoomStatus(roomID, 2);
                        }
                    }

                    if (dgvRooms.RowCount > 0 || dgvServices.RowCount > 0)
                    {
                        string paymentMethod = cmbPayMethod.SelectedItem.ToString();
                        using (var db = new HotelManagementSystemEntities())
                        {
                            var queryPaymentMethod = db.PaymentMethods
                                                                     .Where(p => p.PaymentMethod1 == paymentMethod)
                                                                     .FirstOrDefault();
                            paymentMethodID = queryPaymentMethod.PaymentMethodID;
                        }
                        paymentDate = DateTime.Now;
                        paymentSum = paid;

                        if (paymentSum != 0)
                            Payments.AddPayment(bookingID, paymentMethodID, paymentDate, paymentSum);
                    }

                    if (IsButtonAddClicked)
                        MessageBox.Show("Резервацията е успешна!!", "Успешна резервация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Промените бяха запаметени успешно!!", "Успешно направени промени", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Резервацията е неуспешна!", "Неуспешна резервация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Възникна грешка при добавянето на клиента в базата!", "Грешка при добавяне", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void checkForNullFields()
        {
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Моля въведете статусът на резервацията!", "Невъведен статус", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }
            if (cmbPayMethod.SelectedItem == null)
            {
                MessageBox.Show("Моля въведете начин на плащане!", "Невъведен начин на плащане", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPayMethod.Focus();
                return;
            }
            if (cmbMonth.Enabled && cmbMonth.SelectedItem == null)
            {
                MessageBox.Show("Моля въведете месец на изтичане на картата!", "Невъведен месец", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMonth.Focus();
                return;
            }
            if (cmbYear.Enabled && cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Моля въведете година на изтичане на картата!", "Невъведена година", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYear.Focus();
                return;
            }
            if (cmbTitle.SelectedItem == null)
            {
                MessageBox.Show("Моля въведете обръщение!", "Невъведено обръщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTitle.Focus();
                return;
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            totalSum = price(txtTotal.Text.ToString());
            paymentSum = price(txtPaid.Text.ToString());
            if (paymentSum != 0)
                restSum = totalSum - paymentSum;

            txtRestSum.Text = restSum.ToString() + " лв.";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = new DialogResult();

            if (IsButtonAddClicked)
            {
                dlgResult = MessageBox.Show("Сигурни ли сте, че искате да откажете резервацията?", "Отказване на резервацията", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult.ToString() == "Yes")
                {
                    if (dgvRooms.RowCount > 0)
                    {
                        for (int i = 0; i < dgvRooms.Rows.Count; ++i)
                        {
                            roomID = (int)dgvRooms.Rows[i].Cells["roomIDDataGridViewTextBoxColumn"].Value;
                            BookedRooms.DeleteBookedRoom(bookingID, roomID);
                        }
                    }
                    if (dgvServices.RowCount > 0)
                    {
                        for (int i = 0; i < dgvServices.Rows.Count; ++i)
                        {
                            bookedServiceID = (int)dgvServices.Rows[i].Cells["bookedServiceIDDataGridViewTextBoxColumn1"].Value;
                            BookedServices.DeleteBookedService(bookingID, bookedServiceID);
                        }
                    }
                    if (Bookings.DeleteReservation(bookingID))
                    {
                        if (Guests.DeleteGuest(guestID))
                        {
                            Close();
                        }
                    }
                }
            }
            else
            {
                dlgResult = MessageBox.Show("Сигурни ли сте, че искате да отхвърлите промените?", "Отказване на промени", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult.ToString() == "Yes")
                {
                    Thread.Sleep(1000);
                    Close();
                }
            }
        }

        private void frmAddReservation_KeyDown(object sender, KeyEventArgs e)
        {
            if (!txtFirstName.Text.Equals(""))
            {
                string firstname = txtFirstName.Text.ToString();

                Booking booking = Bookings.GetBookingByID(bookingID);

                if (KeyIsDown(Keys.ControlKey) && KeyIsDown(Keys.F))
                {
                    IsCTRLPlusFPressed = true; // the variable is used only on this line

                    frmAllGuests frmAllGuests = new frmAllGuests(booking, firstname, UserLevelID);
                    Close();
                    frmAllGuests.Show();
                }
            }
        }

        private void cmbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            string currentItem = cmbCountry.SelectedItem.ToString();
            if (currentItem.Equals("Bulgaria"))
            {
                txtEGN.Enabled = true;
            }
            else
            {
                txtEGN.Enabled = false;
            }
        }

        private bool KeyIsDown(Keys key)
        {
            return (GetAsyncKeyState(key) < 0);
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpCheckOut.Value, dtpCheckIn.Value) < 0)
            {
                MessageBox.Show("Датата на настаняване не може да бъде след датата на напускане!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // When the dates are changed, change also the number of nights
                dtDateCheckIn = dtpCheckIn.Value;
                dtDateCheckOut = dtpCheckOut.Value;
                int difference = Helpers.CalculateNumberOfNights(dtDateCheckIn, dtDateCheckOut);
                txtNumberOfNigths.Text = difference.ToString();
            }
        }

        private void dtpCheckIn_GotFocus(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT 1}");
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpCheckIn.Value, dtpCheckOut.Value) > 0)
            {
                MessageBox.Show("Датата на напускане не може да бъде преди датата на настаняване!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dtDateCheckIn = dtpCheckIn.Value;
                dtDateCheckOut = dtpCheckOut.Value;
                int difference = Helpers.CalculateNumberOfNights(dtDateCheckIn, dtDateCheckOut);
                txtNumberOfNigths.Text = difference.ToString();
            }
        }

        private void dtpCheckOut_GotFocus(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT 1}");
        }

        // Enable or disable text fields according to what is selected like pay method.
        private void cmbPayMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            string currentItem = cmbPayMethod.SelectedItem.ToString();
            if (currentItem.Equals("с карта"))
            {
                txtNameOnCard.Enabled = txtCardNumber.Enabled = txtSecurityCode.Enabled = cmbMonth.Enabled = cmbYear.Enabled = true;
            }
            else
            {
                txtNameOnCard.Enabled = txtCardNumber.Enabled = txtSecurityCode.Enabled = cmbMonth.Enabled = cmbYear.Enabled = false;
            }
        }

        public decimal price(string price)
        {
            decimal sum = 0;

            price = price.Replace(',', '.');
            int spacePosition = price.IndexOf(' ');
            if (spacePosition >= 0)
                sum = decimal.Parse(price.Substring(0, spacePosition));

            return sum;
        }

        private void btnAddServiceInfo_Click(object sender, EventArgs e)
        {
            frmAddService frmAddService = new frmAddService(-1, bookingID, -1, "", 0, 0, UserLevelID, false, true); // disable button ok
            frmAddService.Show();
        }

        private void btnAddRoomInfo_Click(object sender, EventArgs e)
        {
            guestName = txtFirstName.Text.ToString() + " ";
            guestName += txtMiddleName.Text.ToString() + " ";
            guestName += txtLastName.Text.ToString();

            guestPhone = txtPhone.Text.ToString();
            guestEmail = txtEmail.Text.ToString();

            frmAddRoomGuest frmAddRoomGuest = new frmAddRoomGuest(bookingID, 1, "",
                                    guestName, guestPhone, guestEmail,
                                    1, 0, true); // true for button Add clicked
            frmAddRoomGuest.Show();
        }

        private void btnEditRoomInfo_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvRooms.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvRooms.Rows[selectedRowIndex];

                roomID = Convert.ToInt16(selectedRow.Cells["roomIDDataGridViewTextBoxColumn"].Value);
                roomType = Convert.ToString(selectedRow.Cells["RoomTypeDesc"].Value);
                guestName = Convert.ToString(selectedRow.Cells["guestNameDataGridViewTextBoxColumn"].Value);
                guestPhone = Convert.ToString(selectedRow.Cells["guestPhoneDataGridViewTextBoxColumn"].Value);
                guestEmail = txtEmail.Text.ToString();
                adultsNo = Convert.ToInt16(selectedRow.Cells["adultsNoDataGridViewTextBoxColumn"].Value);
                childrenNo = Convert.ToInt16(selectedRow.Cells["childNoDataGridViewTextBoxColumn"].Value);
                roomPrice = Convert.ToDecimal(selectedRow.Cells["roomPriceDataGridView"].Value);

                frmAddRoomGuest frmAddRoomGuest = new frmAddRoomGuest(bookingID, roomID, roomType, guestName,
                    guestPhone, guestEmail, adultsNo, childrenNo, false); // false for button Edit clicked
                frmAddRoomGuest.Show();
            }
        }

        private void btnDeleteRoomInfo_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvRooms.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvRooms.Rows[selectedRowIndex];

                roomID = Convert.ToInt16(selectedRow.Cells["roomIDDataGridViewTextBoxColumn"].Value);

                DialogResult result;
                result = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?", "Изтриване на запис", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = BookedRooms.DeleteBookedRoom(bookingID, roomID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Записът е изтрит успешно!", "Успешно изтрит запис", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Възникна грешка при изтриването на записа!", "Грешка при изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            btnEditServiceInfo.Enabled = true;
            btnDeleteServiceInfo.Enabled = true;
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            btnEditRoomInfo.Enabled = true;
            btnDeleteRoomInfo.Enabled = true;
        }

        private void btnEditServiceInfo_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvServices.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvServices.Rows[selectedRowIndex];

                bookedServiceID = Convert.ToInt16(selectedRow.Cells["bookedServiceIDDataGridViewTextBoxColumn1"].Value);
                serviceID = Convert.ToInt16(selectedRow.Cells["serviceIDDataGridViewTextBoxColumn2"].Value);
                serviceName = Convert.ToString(selectedRow.Cells["serviceNameDataGridViewTextBoxColumn"].Value);
                decimal serviceTotal = Convert.ToDecimal(selectedRow.Cells["totalDataGridViewTextBoxColumn"].Value);

                using (var db = new HotelManagementSystemEntities())
                {
                    var result = db.Services
                                        .Where(s => s.ServiceID == serviceID)
                                        .ToList();
                    if (result.Count() > 0)
                    {
                        Service service = result.First();
                        servicePrice = (decimal)service.ServicePrice;
                    }
                }
                frmAddService frmAddService = new frmAddService(bookedServiceID, bookingID, serviceID, serviceName, servicePrice, serviceTotal, UserLevelID, true, false);
                frmAddService.Show();
            }
        }

        private void btnDeleteServiceInfo_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvServices.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvServices.Rows[selectedRowIndex];

                bookedServiceID = Convert.ToInt16(selectedRow.Cells["bookedServiceIDDataGridViewTextBoxColumn1"].Value);

                DialogResult result;
                result = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?", "Изтриване на запис", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = BookedServices.DeleteBookedService(bookingID, bookedServiceID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Записът е изтрит успешно!", "Успешно изтрит запис", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Възникна грешка при изтриването на записа!", "Грешка при изтриване", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void frmAddReservation_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookedServiceDataSet.BookedServices' table. You can move, or remove it, as needed.
            this.bookedServicesTableAdapter.FillAccordingToBookingID(this.bookedServiceDataSet.BookedServices, bookingID);

            // TODO: This line of code loads data into the 'bookedRooms._BookedRooms' table. You can move, or remove it, as needed.
            this.bookedRoomsTableAdapter.Fill(this.bookedRoomsDataSet.BookedRooms, bookingID);

            fillFieldsWithProperInformation();

            LoadData(BookingObject);

            assignTotalSumToTextFields();
        }

        private void dgvRooms_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            assignTotalSumToTextFields();
        }

        private void dgvRooms_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            assignTotalSumToTextFields();
        }

        private void dgvServices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            assignTotalSumToTextFields();
        }

        private void dgvServices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            assignTotalSumToTextFields();
        }

        public void assignTotalSumToTextFields()
        {
            decimal total = calculateTotalSumOfTheReservation();

            txtSubtotal.Text = txtTotal.Text = total.ToString() + " лв.";
            restSum = totalSum;
            txtRestSum.Text = restSum.ToString() + " лв.";
        }

        public decimal calculateTotalSumOfTheReservation()
        {
            decimal sumOfAllBookedRooms = 0;
            decimal sumOfAllBookedServices = 0;
            numberOfNights = short.Parse(txtNumberOfNigths.Text.ToString());

            if (dgvRooms.RowCount > 0)
            {
                for (int i = 0; i < dgvRooms.Rows.Count; ++i)
                {
                    sumOfAllBookedRooms += Convert.ToDecimal(dgvRooms.Rows[i].Cells["roomPriceDataGridView"].Value);
                }
            }

            if (dgvServices.RowCount > 0)
            {
                for (int i = 0; i < dgvServices.Rows.Count; ++i)
                {
                    sumOfAllBookedServices += Convert.ToDecimal(dgvServices.Rows[i].Cells["totalDataGridViewTextBoxColumn"].Value);
                }
            }

            return ((numberOfNights * sumOfAllBookedRooms) + sumOfAllBookedServices);
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            decimal discount = decimal.Parse(nudDiscount.Value.ToString());
            totalSum = price(txtTotal.Text.ToString());

            if (discount != 0)
            {
                totalSum = totalSum - (totalSum * (discount / 100));
                totalSum = Math.Round(totalSum, 2);
            }

            txtTotal.Text = totalSum.ToString() + " лв.";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem != null && cmbPayMethod.SelectedItem != null
                                                && cmbTitle.SelectedItem != null
                                                && txtFirstName.Text != "")
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        #region KeyPressEvents
        private void txtEGN_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigits(e);
        }

        private void txtPostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigits(e);
        }

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigits(e);
        }

        private void txtSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigits(e);
        }

        private void txtReferenceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigits(e);
        }

        private void txtInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigits(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyDigitsAndPlusSign(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.dontAcceptWhiteSpace(e);
        }

        private void txtNameOnCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyLettersAndBackSpace(e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyAllKindOfLettersAndBackSpace(e);
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyAllKindOfLettersAndBackSpace(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyAllKindOfLettersAndBackSpace(e);
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation.acceptOnlyAllKindOfLettersAndBackSpace(e);
        }
        #endregion
    }
}