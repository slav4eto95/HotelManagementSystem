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

        // When the dates are changed, change also the number of nights
        public int CalculateNumberOfNights(DateTime dtFromDate, DateTime dtToDate)
        {
            TimeSpan difference;

            try
            {
                difference = dtToDate - dtFromDate;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MyMessageBox.ShowMessage(ex.ToString(), "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return difference.Days;
        }
    }
}