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
    
    public partial class BookedService
    {
        public int BookedServiceID { get; set; }
        public long BookingID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Service Service { get; set; }
    }
}