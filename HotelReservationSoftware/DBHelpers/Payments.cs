using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware.DBHelpers
{
    public class Payments
    {
        public bool AddPayment(long bookingID, int paymethodID, DateTime paymentDate, decimal paymentSum)
        {
            bool isAdded = true;

            using (var db = new HotelManagementSystemEntities())
            {
                Payment payment = new Payment
                {
                    BookingID = bookingID,
                    PaymentMethodID = paymethodID,
                    PaymentDate = paymentDate,
                    PaymentSum = paymentSum
                };

                try
                {
                    db.Payments.Add(payment);
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

        public bool UpdatePayment(int paymentID, long bookingID, int paymethodID, DateTime payDate, decimal paySum)
        {
            bool isUpdated = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var payment = (from p in db.Payments
                               where p.PaymentID == paymentID
                               select p).Single();
                try
                {
                    payment.BookingID = bookingID;
                    payment.PaymentMethodID = paymethodID;
                    payment.PaymentDate = payDate;
                    payment.PaymentSum = paySum;

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
    }
}
