using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSoftware 
{
    public class UsersDTO// : IEquatable<User>
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<byte> UserLevelID { get; set; }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj as User);
        //}
        //public bool Equals(User other)
        //{
        //    if (other == null)
        //        return false;

        //    return
        //        (object.ReferenceEquals(this.Name, other.Name) || this.Name != null && this.Name.Equals(other.Name)) &&
        //        (object.ReferenceEquals(this.Username, other.Username) || this.Username != null && this.Username.Equals(other.Username)) &&
        //        (object.ReferenceEquals(this.Password, other.Password) || this.Password != null && this.Password.Equals(other.Password)) &&
        //        (this.UserLevelID.Equals(other.UserLevelID));
        //}
    }
}
