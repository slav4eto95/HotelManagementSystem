using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSoftware
{
    public class BookedServicesDTO
    {
        public int BookedServiceID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
