using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class ReportViewerControl : UserControl
    {
        private string ReportName;
        private DateTime StartDate, EndDate;
        private Booking Booking;
        private List<BookedRoom> ListRooms;
        private List<BookedService> ListServices;

        public ReportViewerControl(string reportName)
        {
            InitializeComponent();
            ReportName = reportName;
            crystalReportViewer.ReportSource = null;
        }

        public ReportViewerControl(string reportName, DateTime start, DateTime end)
        {
            InitializeComponent();
            crystalReportViewer.ReportSource = null;
            ReportName = reportName;
            StartDate = start;
            EndDate = end;
        }

        // TODO: 20180819
        public ReportViewerControl(string reportName, Booking booking, List<BookedRoom> listRooms, List<BookedService> listServices)
        {
            InitializeComponent();
            crystalReportViewer.ReportSource = null;
            ReportName = reportName;
            Booking = booking;
            ListRooms = listRooms;
            ListServices = listServices;
        }

        private void ReportViewerControl_Load(object sender, EventArgs e)
        {
            switch (ReportName)
            {
                case "ReservationsReport":
                    {
                        ReservationsDataSetTableAdapters.ReservationsViewTableAdapter reservationsViewTableAdapter =
                            new ReservationsDataSetTableAdapters.ReservationsViewTableAdapter();
                        ReservationsDataSet reservationsDataSet = new ReservationsDataSet();
                        Reports.Reservations reservationsReport = new Reports.Reservations();

                        string start = StartDate.ToShortDateString();
                        string end = EndDate.ToShortDateString();

                        reservationsViewTableAdapter.FillByDates(reservationsDataSet.ReservationsView, start, end);
                        reservationsReport.SetDataSource(reservationsDataSet);
                        reservationsReport.SetParameterValue("From date", start);
                        reservationsReport.SetParameterValue("To date", end);
                        crystalReportViewer.ReportSource = reservationsReport;
                        break;
                    }
                case "Guests":
                    {
                        GuestsDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter =
                            new GuestsDataSetTableAdapters.GuestsTableAdapter();
                        GuestsDataSet guestsDataSet = new GuestsDataSet();
                        Reports.Guests guests = new Reports.Guests();

                        guestsTableAdapter.Fill(guestsDataSet.Guests);
                        guests.SetDataSource(guestsDataSet);
                        crystalReportViewer.ReportSource = guests;
                        break;
                    }
                case "CountriesReport":
                    {
                        StatisticForCountriesDataSetTableAdapters.StatisticForCountriesTableAdapter tableAdapter = new StatisticForCountriesDataSetTableAdapters.StatisticForCountriesTableAdapter();
                        StatisticForCountriesDataSet countriesDataSet = new StatisticForCountriesDataSet();
                        Reports.CountriesGuests countries = new Reports.CountriesGuests();

                        tableAdapter.Fill(countriesDataSet.StatisticForCountries);
                        countries.SetDataSource(countriesDataSet);
                        crystalReportViewer.ReportSource = countries;
                        break;
                    }
                case "MonthsGuestsReport":
                    {
                        StatisticForMonthsAndGuestsDataSetTableAdapters.StatisticForMonthsAndGuestsTableAdapter tableAdapter = new StatisticForMonthsAndGuestsDataSetTableAdapters.StatisticForMonthsAndGuestsTableAdapter();
                        StatisticForMonthsAndGuestsDataSet statisticForMonthsAndGuestsDataSet = new StatisticForMonthsAndGuestsDataSet();
                        Reports.MonthsGuests monthsGuests = new Reports.MonthsGuests();

                        tableAdapter.Fill(statisticForMonthsAndGuestsDataSet.StatisticForMonthsAndGuests);
                        monthsGuests.SetDataSource(statisticForMonthsAndGuestsDataSet);
                        crystalReportViewer.ReportSource = monthsGuests;
                        break;
                    }
                case "RoomsReport":
                    {
                        RoomsWithTheirTypeDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter = new RoomsWithTheirTypeDataSetTableAdapters.RoomsTableAdapter();
                        RoomsWithTheirTypeDataSet roomsWithTheirTypeDataSet = new RoomsWithTheirTypeDataSet();
                        Reports.RoomsReport roomsReport = new Reports.RoomsReport();

                        roomsTableAdapter.Fill(roomsWithTheirTypeDataSet.Rooms);
                        roomsReport.SetDataSource(roomsWithTheirTypeDataSet);
                        crystalReportViewer.ReportSource = roomsReport;
                        break;
                    }
                case "Services":
                    {
                        ServicesDataSetTableAdapters.ServicesViewTableAdapter tableAdapter = new ServicesDataSetTableAdapters.ServicesViewTableAdapter();
                        ServicesDataSet servicesDataSet = new ServicesDataSet();
                        Reports.ServicesReport servicesReport = new Reports.ServicesReport();

                        tableAdapter.Fill(servicesDataSet.ServicesView);
                        servicesReport.SetDataSource(servicesDataSet);
                        crystalReportViewer.ReportSource = servicesReport;
                        break;
                    }
                case "CheckInReport":
                    {
                        CheckInCheckOutTodayTableAdapters.TodayCheckInTableAdapter todayCheckIn = new CheckInCheckOutTodayTableAdapters.TodayCheckInTableAdapter();
                        CheckInCheckOutToday todayCheckInOutDataSet = new CheckInCheckOutToday();
                        Reports.CheckInReport checkInReport = new Reports.CheckInReport();

                        todayCheckIn.Fill(todayCheckInOutDataSet.TodayCheckIn);
                        checkInReport.SetDataSource(todayCheckInOutDataSet);
                        crystalReportViewer.ReportSource = checkInReport;
                        break;
                    }
                case "CheckOutReport":
                    {
                        CheckInCheckOutTodayTableAdapters.TodayCheckOutTableAdapter todayCheckOut = new CheckInCheckOutTodayTableAdapters.TodayCheckOutTableAdapter();
                        CheckInCheckOutToday todayCheckInOutDataSet = new CheckInCheckOutToday();
                        Reports.CheckOutReport checkOutReport = new Reports.CheckOutReport();

                        todayCheckOut.Fill(todayCheckInOutDataSet.TodayCheckOut);
                        checkOutReport.SetDataSource(todayCheckInOutDataSet);
                        crystalReportViewer.ReportSource = checkOutReport;
                        break;
                    }
                case "DailyOccupancyReport":
                    {
                        DailyOccupancyDataSetTableAdapters.DailyOccupancyViewTableAdapter dailyOccupancyTableAdapter = new DailyOccupancyDataSetTableAdapters.DailyOccupancyViewTableAdapter();
                        DailyOccupancyDataSet dailyOccupancyDataSet = new DailyOccupancyDataSet();
                        Reports.DailyOccupancyReport dailyOccupancyReport = new Reports.DailyOccupancyReport();

                        dailyOccupancyTableAdapter.Fill(dailyOccupancyDataSet.DailyOccupancyView);
                        dailyOccupancyReport.SetDataSource(dailyOccupancyDataSet);
                        crystalReportViewer.ReportSource = dailyOccupancyReport;
                        break;
                    }
                case "Receipt":
                    {
                        //AllReservationsDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter = new AllReservationsDataSetTableAdapters.BookingsTableAdapter();
                        //AllReservationsDataSet allReservationsDataSet = new AllReservationsDataSet();
                        Reports.Receipt receiptReport = new Reports.Receipt();

                        //bookingsTableAdapter.Fill(allReservationsDataSet.Bookings);
                        //receiptReport.SetDataSource(allReservationsDataSet);

                        string guestName;
                        string guestAddress;
                        string guestCity;
                        DateTime date = DateTime.Now.Date;
                        
                        using (var db = new HotelManagementSystemEntities())
                        {
                            var guest = db.Guests.Where(g => g.GuestID == Booking.GuestID).FirstOrDefault();
                            guestName = guest.FirstName + " " + guest.MiddleName + " " + guest.LastName;
                            guestAddress = guest.Address;
                            guestCity = guest.City + ", " + guest.Country;
                            
                        }

                        receiptReport.SetParameterValue("GuestName", guestName);
                        receiptReport.SetParameterValue("GuestAddress", guestAddress);
                        receiptReport.SetParameterValue("GuestCity", guestCity);
                        receiptReport.SetParameterValue("CurrentDate", date.ToShortDateString());
                        receiptReport.SetParameterValue("CheckIn", Booking.CheckIn.ToShortDateString());
                        receiptReport.SetParameterValue("CheckOut", Booking.CheckOut.ToShortDateString());
                        receiptReport.SetParameterValue("ReservationDate", Booking.BookDate.ToShortDateString());

                        decimal bookedRoomsSum = 1;
                        
                        using (var db = new HotelManagementSystemEntities())
                        {
                            foreach (var item in ListRooms)
                            {
                                var room = db.Rooms.Where(r => r.RoomID == item.RoomID).FirstOrDefault();

                                bookedRoomsSum = room.RoomType.RoomPrice;
                                receiptReport.SetParameterValue("Name", room.RoomType.RoomTypeDesc);
                                receiptReport.SetParameterValue("Price", bookedRoomsSum + " лв.");
                            }
                        }
                        receiptReport.SetParameterValue("Nights", Booking.Nights);
                        receiptReport.SetParameterValue("BookedRoomSum", (Booking.Nights * bookedRoomsSum) + " лв.");
                        receiptReport.SetParameterValue("TotalSum", Booking.TotalSum + " лв.");
                        receiptReport.SetParameterValue("PaidSum", (Booking.TotalSum - Booking.RestSum) + " лв.");
                        receiptReport.SetParameterValue("RestSum", Booking.RestSum + " лв.");

                        crystalReportViewer.ReportSource = receiptReport;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}