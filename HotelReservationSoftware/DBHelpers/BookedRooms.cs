using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware.DBHelpers
{
    public class BookedRooms
    {
        public bool AddBookedRoom(long bookingID, int roomID, string guestName, string guestPhone, int numOfAdults, int numOfChildren)
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
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return isEdited;
        }

        public BookedRoom GetBookedRoomByID(long bookingID)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return (db.BookedRooms.Where(br=>br.BookingID == bookingID).FirstOrDefault());
            }
        }

        public List<BookedRoom> GetAllBookedRoomsByBookingID(long bookingID)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return ((from br in db.BookedRooms
                         where br.BookingID == bookingID
                         select br).ToList());
            }
        }
    }
}
