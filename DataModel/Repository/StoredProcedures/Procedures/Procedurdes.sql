IF EXISTS (SELECT * FROM sys.objects where object_id = OBJECT_ID(N'spGetUser') AND type IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[spGetUser];
GO

CREATE PROCEDURE [dbo].[spGetUser]
	@Id uniqueidentifier
AS
BEGIN
	
  SELECT [Id]
      ,[InternalToken]
      ,[Username]
      ,[PasswordHash]
      ,[PhoneNumber]
      ,[Firstname]
      ,[Lastname]
      ,[Pesel]
      ,[VacationDays]
      ,[Roles]
      ,[Company_Id]
      ,[Address_Id]
      ,[X_CreatedDate]
      ,[X_LastUpdateDate]
      ,[X_ArchivedDate]
      ,[X_Archived]
  FROM [dbo].[Users]
  WHERE Id = @Id

END
GO

IF EXISTS (SELECT * FROM sys.objects where object_id = OBJECT_ID(N'spDeleteUser') AND type IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[spDeleteUser];
GO

CREATE PROCEDURE [dbo].[spDeleteUser]
	@Id uniqueidentifier
AS
BEGIN
	
DELETE FROM [dbo].[Users] WHERE Id = @Id

END
GO