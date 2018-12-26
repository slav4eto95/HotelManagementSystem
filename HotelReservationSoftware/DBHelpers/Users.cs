using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public class Users
    {
        public bool AddUser(User user)
        {
            bool isAdded = false;
            try
            {
                using (var db = new HotelManagementSystemEntities())
                {
                    db.Users.Add(user);
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

        public bool UpdateUser(int id, string newName, string newUsername, string newPassword, int newUserLevel)
        {
            bool isUpdated = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var user = db.Users.Where(u => u.UserID == id).FirstOrDefault();

                user.Name = newName;
                user.Username = newUsername;

                if (newPassword != "" && !newPassword.Contains(" "))
                {
                    user.Password = newPassword;
                }
                user.UserLevelID = (byte)newUserLevel;
                db.SaveChanges();
                isUpdated = true;
            }
            return isUpdated;
        }

        public bool DeleteUser(int id)
        {
            bool isDeleted = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var userToDelete = db.Users.Where(u => u.UserID == id).FirstOrDefault();

                db.Users.Remove(userToDelete);
                db.SaveChanges();
                isDeleted = true;
            }
            return isDeleted;
        }

        public bool ChangeUserPassword(int userID, string pass)
        {
            bool isChanged = false;
            using (var db = new HotelManagementSystemEntities())
            {
                var user = db.Users.Where(u => u.UserID == userID).FirstOrDefault();

                string ePass = Cryptography.GenerateSHA256String(pass);
                user.Password = ePass;
                db.SaveChanges();
                isChanged = true;
            }

            return isChanged;
        }

        public bool CheckIfUserAlreadyExists(User user)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                List<User> usersList = db.Users.ToList();
                foreach (var item in usersList)
                {
                    if (item.Username == user.Username && item.Password == user.Password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
