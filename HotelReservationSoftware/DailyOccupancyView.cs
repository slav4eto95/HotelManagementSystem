//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservationSoftware
{
    using System;
    using System.Collections.Generic;
    
    public partial class DailyOccupancyView
    {
        public int RoomID { get; set; }
        public string GuestName { get; set; }
        public System.DateTime CheckIn { get; set; }
        public System.DateTime CheckOut { get; set; }
        public Nullable<int> AdultsNo { get; set; }
        public Nullable<int> ChildNo { get; set; }
    }
}
