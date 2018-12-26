using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace HotelReservationSoftware.DBHelpers
{
    public class RoomTypes
    {
        public bool AddRoomType(string roomType, decimal roomPrice, int adultsNum, int bedsNum, int childrenNum, string bedType, int canSmoke, string roomDescription)
        {
            bool isAdded = false;

            RoomType roomTypeObject = new RoomType()
            {
                RoomTypeDesc = roomType,
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
                        MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            return isAdded;
        }

    }
}
