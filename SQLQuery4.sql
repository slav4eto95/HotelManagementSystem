IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = 
   OBJECT_ID(N'[dbo].[GetUserLevelID]') AND type in (N'P', N'PC'))

BEGIN
	EXEC dbo.sp_executesql @statement = N'
		CREATE PROCEDURE [dbo].[GetUserLevelID]
		@UserLevelDesc varchar(15)
		AS
		Select UserLevelID
		From UserLevels Where UserLevelDesc = @UserLevelDesc
	'
END
GO