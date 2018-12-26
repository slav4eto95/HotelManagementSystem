using System;

namespace HotelReservationSoftware
{
    public class UsersDTO
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte? UserLevelID { get; set; }
    }
}
