using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public class Helpers
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
                        MessageBox.Show("Error: " + error.ErrorMessage, "Error");
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
                var bookedService = (from bs in db.BookedServices
                                     where bs.BookedServiceID == bookedServiceID
                                     select bs).Single();

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

        public bool DeleteBookedService(int id)
        {
            bool isDeleted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var result = from bs in db.BookedServices
                             where bs.BookedServiceID == id
                             select bs;
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

        public bool AddRoomType(string roomType, decimal roomPrice, int adultsNum, int bedsNum, int childrenNum, string bedType, int canSmoke, string roomDescription)
        {
            bool isAdded = false;

            RoomType roomTypeObject = new RoomType()
            {
                RoomType1 = roomType,
                RoomPrice = roomPrice,
                NumberOfAdults = adultsNum,
                NumberOfBeds = bedsNum,
                NumberOfChildren = childrenNum,
                BedType = bedType,
                CanSmoke = (byte)canSmoke,
                RoomAddDescription = roomDescription
            };

            try
            {
                using (var db = new HotelManagementSystemEntities())
                {
                    db.RoomTypes.Add(roomTypeObject);
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
                        MessageBox.Show("Error: " + error.ErrorMessage, "Error");
                    }
                }
            }


            return isAdded;
        }

        public int GetLastInsertedID(string tableName, string fieldID)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelManagementSystemConnectionString);
            SqlCommand command = new SqlCommand("SELECT TOP(1) " + fieldID + " FROM " + tableName + " ORDER BY 1 DESC", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // if there is no rows, i.e. the table is empty
            long lastInsertedID = 0;
            //won't need a while, since it will only retrieve one row
            reader.Read();
            if (reader.HasRows)
                //here is your data
                lastInsertedID = Int16.Parse(reader[fieldID].ToString());

            reader.Close();
            connection.Close();

            /*
            long lastInsertedID = 0;
            using (var db = new HotelManagementSystemEntities())
            {
                var query = db.Bookings.SqlQuery("SELECT TOP(1) " + fieldID + " FROM " + tableName + " ORDER BY 1 DESC");
                
                foreach (var item in query)
                {
                    lastInsertedID = item.BookingID;
                }
            }
            */
            return (int)lastInsertedID;
        }

        

        public bool AddReservation(int bookingStatusID, int customerID,
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
                    CustomerID = customerID,
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
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error");
                        }
                    }
                }
            }

            return isAdded;
        }

        public bool UpdateReservation(long bookingID, int bookingStatusID, int customerID,
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
                    booking.CustomerID = customerID;
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
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error");
                        }
                    }
                }

            }
            return isUpdated;
        }

        public bool DeleteReservation(int id)
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

        public bool UpdateRoomStatus(int roomID, int status)
        {
            bool isUpdated = false;
            using (var db = new HotelManagementSystemEntities())
            {
                var room = (from r in db.Rooms
                            where r.RoomID == roomID
                            select r).Single();
                try
                {
                    room.RoomStatusID = status;
                    db.SaveChanges();
                    isUpdated = true;
                }
                catch (DbEntityValidationException dbValidationEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbValidationEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error");
                        }
                    }
                }
            }
            return isUpdated;
        }

        public bool InsertBookedRoom(long bookingID, int roomID, string guestName, string guestPhone, int numOfAdults, int numOfChildren)
        {
            bool isInserted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                BookedRoom bookedRoom = new BookedRoom()
                {
                    BookingID = bookingID,
                    RoomID = roomID,
                    GuestName = guestName,
                    GuestPhone = guestPhone,
                    AdultsNo = numOfAdults,
                    ChildNo = numOfChildren
                };
                try
                {
                    db.BookedRooms.Add(bookedRoom);
                    db.SaveChanges();
                    isInserted = true;
                }
                catch (DbEntityValidationException dbValidationEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbValidationEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error");
                        }
                    }
                }
            }

            return isInserted;
        }

        public bool DeleteBookedRoom(long bookingID, int roomID)
        {
            bool isDeleted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var result = from br in db.BookedRooms
                             where br.BookingID == bookingID && br.RoomID == roomID
                             select br;
                if (result.Count() > 0)
                {
                    BookedRoom bookedRoom = result.First();
                    db.BookedRooms.Remove(bookedRoom);
                    db.SaveChanges();

                    isDeleted = true;
                }
            }
            return isDeleted;
        }

        public bool EditBookedRoom(long bookingID, int roomID, string guestName, string guestPhone, int numOfAdults, int numOfChildren)
        {
            bool isEdited = false;
            using (var db = new HotelManagementSystemEntities())
            {
                var bookedRoom = (from br in db.BookedRooms
                                  where br.BookingID == bookingID && br.RoomID == roomID
                                  select br).Single();
                try
                {
                    bookedRoom.RoomID = roomID;
                    bookedRoom.GuestName = guestName;
                    bookedRoom.GuestPhone = guestPhone;
                    bookedRoom.AdultsNo = numOfAdults;
                    bookedRoom.ChildNo = numOfChildren;

                    db.SaveChanges();
                    isEdited = true;
                }
                catch (DbEntityValidationException dbValidationEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbValidationEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error");
                        }
                    }
                }
            }
            return isEdited;
        }
    }
}