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
    
    public partial class DataForBookingReceipt_Result
    {
        public long BookingID { get; set; }
        public string GuestName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EGN { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public System.DateTime CheckIn { get; set; }
        public System.DateTime CheckOut { get; set; }
        public int Nights { get; set; }
        public Nullable<decimal> TotalSum { get; set; }
        public Nullable<decimal> RestSum { get; set; }
        public string RoomTypeDesc { get; set; }
    }
}
