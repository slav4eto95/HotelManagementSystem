-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Slavena Koleva
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE BookedRoomsInformation 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Rooms.RoomID, RoomTypes.RoomType, Customers.FirstName + ' ' + Customers.MiddleName + ' ' + Customers.LastName AS GuestName, Customers.Phone, RoomTypes.RoomPrice
	FROM BookedRooms INNER JOIN
                  Bookings ON BookedRooms.BookingID = Bookings.BookingID INNER JOIN
                  Customers ON Bookings.CustomerID = Customers.CustomerID INNER JOIN
                  Rooms ON BookedRooms.RoomID = Rooms.RoomID INNER JOIN
                  RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID
END
GO
