using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware.DBHelpers
{
    public class BookedServices
    {
        public bool AddBookedService(long bookingID, int serviceID, int quantity, decimal total, DateTime date)
        {
            bool isAdded = false;

            BookedService bookedService = new BookedService
            {
                BookingID = bookingID,
                ServiceID = serviceID,
                Quantity = quantity,
                Total = total,
                Date = date
            };

            try
            {
                using (var db = new HotelManagementSystemEntities())
                {
                    db.BookedServices.Add(bookedService);
                    db.SaveChanges();
                    isAdded = true;
                }
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

            return isAdded;
        }

        public bool EditBookedService(int bookedServiceID, long bookingID, int serviceid, int quantity, decimal total, DateTime date)
        {
            bool isUpdated = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var bookedService = db.BookedServices.Where(bs => bs.BookedServiceID == bookedServiceID).FirstOrDefault();

                bookedService.BookingID = bookingID;
                bookedService.ServiceID = serviceid;
                bookedService.Quantity = quantity;
                bookedService.Total = total;
                bookedService.Date = date;
                db.SaveChanges();
                isUpdated = true;
            }
            return isUpdated;
        }

        public bool DeleteBookedService(long bookingID, int serviceID)
        {
            bool isDeleted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var result = db.BookedServices
                                .Where(bs => bs.BookingID == bookingID && bs.ServiceID == serviceID)
                                .ToList();
                if (result.Count() > 0)
                {
                    BookedService bookedService = result.First();
                    db.BookedServices.Remove(bookedService);
                    db.SaveChanges();

                    isDeleted = true;
                }
            }

            return isDeleted;
        }

        public List<BookedService> GetAllBookedServicesByBookingID(long bookingID)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return (db.BookedServices.Where(bs => bs.BookingID == bookingID).ToList());
            }
        }
    }
}
