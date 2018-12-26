IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = 
   OBJECT_ID(N'[dbo].[GetUserLevel]') AND type in (N'P', N'PC'))

BEGIN
	EXEC dbo.sp_executesql @statement = N'
		CREATE PROCEDURE [dbo].[GetUserLevel]
		@UserLevelID int
		AS
		Select UserLevelDesc
		From UserLevels Where UserLevelID = @UserLevelID
	'
END
GO