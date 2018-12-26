using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public class Guests
    {
        public bool AddGuest(int titleID,
            string firstName, string middleName, string lastName,
            string address, string postCode, string city, string country,
            string egn, string phone, string email, string firmName)
        {
            bool isAdded = false;

            using (var db = new HotelManagementSystemEntities())
            {
                Guest guest = new Guest()
                {
                    TitleID = titleID,
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    Address = address,
                    PostCode = postCode,
                    City = city,
                    Country = country,
                    EGN = egn,
                    Phone = phone,
                    Email = email,
                    FirmName = firmName
                };
                try
                {
                    db.Guests.Add(guest);
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

        public bool UpdateGuest(int guestID, int titleID,
            string firstName, string middleName, string lastName,
            string address, string postCode, string city, string country,
            string egn, string phone, string email, string firmName)
        {
            bool isUpdated = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var guest = (from g in db.Guests
                                where g.GuestID == guestID
                                select g).Single();

                try
                {
                    guest.TitleID = titleID;
                    guest.FirstName = firstName;
                    guest.MiddleName = middleName;
                    guest.LastName = lastName;
                    guest.Address = address;
                    guest.PostCode = postCode;
                    guest.City = city;
                    guest.Country = country;
                    guest.EGN = egn;
                    guest.Phone = phone;
                    guest.Email = email;
                    guest.FirmName = firmName;

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

        public bool DeleteGuest(int id)
        {
            bool isDeleted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var result = from g in db.Guests
                              where g.GuestID == id
                              select g;
                if (result.Count() > 0)
                {
                    Guest guest = result.First();
                    db.Guests.Remove(guest);
                    db.SaveChanges();

                    isDeleted = true;
                }
            }

            return isDeleted;
        }
    }
}
