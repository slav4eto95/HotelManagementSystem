﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelManagementSystemEntities : DbContext
    {
        public HotelManagementSystemEntities()
            : base("name=HotelManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookedRoom> BookedRooms { get; set; }
        public virtual DbSet<BookedService> BookedServices { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingStatu> BookingStatus { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ReferredBy> ReferredBies { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomStatu> RoomStatus { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<UserLevel> UserLevels { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TodayCheckIn> TodayCheckIns { get; set; }
        public virtual DbSet<TodayCheckOut> TodayCheckOuts { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<RoomsView> RoomsViews { get; set; }
        public virtual DbSet<RoomTypesView> RoomTypesViews { get; set; }
        public virtual DbSet<ReservationsView> ReservationsViews { get; set; }
        public virtual DbSet<DailyOccupancyView> DailyOccupancyViews { get; set; }
    
        public virtual ObjectResult<BookedRoomsInformation_Result> BookedRoomsInformation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BookedRoomsInformation_Result>("BookedRoomsInformation");
        }
    
        public virtual ObjectResult<GetUserLevelDescription_Result> GetUserLevelDescription(Nullable<int> userLevelIDParam)
        {
            var userLevelIDParamParameter = userLevelIDParam.HasValue ?
                new ObjectParameter("UserLevelIDParam", userLevelIDParam) :
                new ObjectParameter("UserLevelIDParam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserLevelDescription_Result>("GetUserLevelDescription", userLevelIDParamParameter);
        }
    
        public virtual ObjectResult<GetUserLevelID_Result> GetUserLevelID(string userLevelDesc)
        {
            var userLevelDescParameter = userLevelDesc != null ?
                new ObjectParameter("UserLevelDesc", userLevelDesc) :
                new ObjectParameter("UserLevelDesc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserLevelID_Result>("GetUserLevelID", userLevelDescParameter);
        }
    
        public virtual ObjectResult<DataForBookingReceipt_Result> DataForBookingReceipt(Nullable<long> bookingID)
        {
            var bookingIDParameter = bookingID.HasValue ?
                new ObjectParameter("BookingID", bookingID) :
                new ObjectParameter("BookingID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DataForBookingReceipt_Result>("DataForBookingReceipt", bookingIDParameter);
        }
    
        public virtual ObjectResult<StatisticForCountries_Result> StatisticForCountries()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StatisticForCountries_Result>("StatisticForCountries");
        }
    
        public virtual ObjectResult<StatisticForMonthsAndGuests_Result> StatisticForMonthsAndGuests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StatisticForMonthsAndGuests_Result>("StatisticForMonthsAndGuests");
        }
    }
}
