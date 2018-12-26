using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware.DBHelpers
{
    public class Rooms
    {
        public bool AddRoom(int roomID, int roomTypeID, int roomStatusID)
        {
            bool isAdded = false;

            using (var db = new HotelManagementSystemEntities())
            {
                Room room = new Room()
                {
                    RoomID = roomID,
                    RoomTypeID = roomTypeID,
                    RoomStatusID = roomStatusID
                };

                try
                {
                    db.Rooms.SqlQuery("SET IDENTITY_INSERT Rooms ON");
                    db.Rooms.Add(room);
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

        public bool UpdateRoomType(int roomID, int roomTypeID)
        {
            bool isUpdated = false;

            using (var db = new HotelManagementSystemEntities())
            {
                var room = (from r in db.Rooms
                            where r.RoomID == roomID
                            select r).Single();
                try
                {
                    room.RoomTypeID = roomTypeID;
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

        public bool UpdateRoomStatus(int roomID, int status)
        {
            bool isUpdated = false;
            using (var db = new HotelManagementSystemEntities())
            {
                var room = db.Rooms.Where(r => r.RoomID == roomID).FirstOrDefault();
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
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return isUpdated;
        }

        public bool DeleteRoom(int roomID)
        {
            bool isDeleted = false;
            using (var db = new HotelManagementSystemEntities())
            {
                var room = (from r in db.Rooms
                            where r.RoomID == roomID
                            select r).Single();
                try
                {
                    db.Rooms.Remove(room);
                    db.SaveChanges();

                    isDeleted = true;
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
            return isDeleted;
        }

        public Room GetRoomByID(int roomID)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                return db.Rooms.Where(r => r.RoomID == roomID).FirstOrDefault();
            }
        }
    }
}
