using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware.DBHelpers
{
    public class Bookings
    {
        public bool AddReservation(int bookingStatusID, int guestID,
            DateTime dtCheckIn, DateTime dtCheckOut,
            int nights, string hasCar,
            DateTime dtBookDate, string notes,
            string creditCardName, string creditCartNumber,
            int creditCardSecurityCode, string creditCardExpiry,
            string referenceNo, string invoiceNo, decimal totalSum, decimal restSum, int referredByID)
        {
            bool isAdded = false;

            using (var db = new HotelManagementSystemEntities())
            {
                Booking booking = new Booking()
                {
                    BookingStatusID = bookingStatusID,
                    GuestID = guestID,
                    CheckIn = dtCheckIn,
                    CheckOut = dtCheckOut,
                    Nights = nights,
                    HasCar = hasCar,
                    BookDate = dtBookDate,
                    Notes = notes,
                    CreditCardName = creditCardName,
                    CreditCardNo = creditCartNumber,
                    CreditCardSecurityCode = creditCardSecurityCode,
                    CreditCardExpiry = creditCardExpiry,
                    ReferenceNumber = referenceNo,
                    InvoiceNumber = invoiceNo,
                    TotalSum = totalSum,
                    RestSum = restSum,
                    ReferredByID = referredByID
                };
                try
                {
                    db.Bookings.Add(booking);
                    db.SaveChanges();
                    isAdded = true;
                }
                catch (DbEntityValidationException dbValidationEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbValidationEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return isAdded;
        }

        public bool UpdateReservation(long bookingID, int bookingStatusID, int guestID,
            DateTime dtCheckIn, DateTime dtCheckOut,
            int nights, string hasCar,
            DateTime dtBookDate, string notes,
            string creditCardName, string creditCartNumber,
            int creditCardSecurityCode, string creditCardExpiry,
            string referenceNo, string invoiceNo, decimal totalSum, decimal restSum, int referredByID)
        {
            bool isUpdated = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var booking = (from b in db.Bookings
                               where b.BookingID == bookingID
                               select b).Single();

                try
                {
                    booking.BookingStatusID = bookingStatusID;
                    booking.GuestID = guestID;
                    booking.CheckIn = dtCheckIn;
                    booking.CheckOut = dtCheckOut;
                    booking.Nights = nights;
                    booking.HasCar = hasCar;
                    booking.BookDate = dtBookDate;
                    booking.Notes = notes;
                    booking.CreditCardName = creditCardName;
                    booking.CreditCardNo = creditCartNumber;
                    booking.CreditCardSecurityCode = creditCardSecurityCode;
                    booking.CreditCardExpiry = creditCardExpiry;
                    booking.ReferenceNumber = referenceNo;
                    booking.InvoiceNumber = invoiceNo;
                    booking.TotalSum = totalSum;
                    booking.RestSum = restSum;
                    booking.ReferredByID = referredByID;
                    db.SaveChanges();
                    isUpdated = true;
                }
                catch (DbEntityValidationException dbValidationEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbValidationEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            return isUpdated;
        }

        public bool DeleteReservation(long id)
        {
            bool isDeleted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var result = from b in db.Bookings
                             where b.BookingID == id
                             select b;
                if (result.Count() > 0)
                {
                    Booking booking = result.First();
                    db.Bookings.Remove(booking);
                    db.SaveChanges();

                    isDeleted = true;
                }
            }

            return isDeleted;
        }

        public Booking GetBookingByID(long bookingID)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return (db.Bookings.Where(b=>b.BookingID == bookingID).FirstOrDefault());
            }
        }
    }
}
