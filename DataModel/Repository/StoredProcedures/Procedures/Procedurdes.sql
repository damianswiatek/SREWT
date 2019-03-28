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



IF EXISTS (SELECT * FROM sys.objects where object_id = OBJECT_ID(N'spCreateUserWithAddress') AND type IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[spCreateUserWithAddress];
GO

CREATE PROCEDURE [dbo].[spCreateUserWithAddress]
	 @Username	nvarchar(MAX)	
	,@PasswordHash	nvarchar(MAX)	
	,@PhoneNumber	nvarchar(20)	
	,@Firstname	nvarchar(MAX)	
	,@Lastname	nvarchar(MAX)	
	,@Pesel	nvarchar(MAX)	
	,@VacationDays	int	
	,@Roles	nvarchar(MAX) = null	
	,@PostalCode	nvarchar(MAX)	
	,@City	nvarchar(MAX)	
	,@Street	nvarchar(MAX)	
	,@Polity	nvarchar(MAX)	
	,@Company_Id	uniqueidentifier = null	
	,@X_CreatedDate	datetime	
	,@X_LastUpdateDate	datetime	
AS
BEGIN
	DECLARE @identityAddress uniqueidentifier
	SET @identityAddress = NEWID()

	INSERT INTO [dbo].[Addresses] ([Id], [PostalCode], [City], [Street], [Polity], [X_CreatedDate], [X_LastUpdateDate], [X_ArchivedDate], [X_Archived])
		 VALUES ( @identityAddress, @PostalCode, @City, @Street, @Polity, @X_CreatedDate, @X_LastUpdateDate, null, 0)

	DECLARE @identity uniqueidentifier
	SET @identity = NEWID()
	DECLARE @identityInternalToken uniqueidentifier
	SET @identityInternalToken = NEWID()

	INSERT INTO [dbo].[Users] ([Id], [InternalToken], [Username], [PasswordHash], [PhoneNumber], [Firstname], [Lastname], [Pesel], [VacationDays], [Roles], [Company_Id], [Address_Id], [X_CreatedDate], [X_LastUpdateDate], [X_ArchivedDate], [X_Archived])
     VALUES (@identity, @identityInternalToken, @Username, @PasswordHash, @PhoneNumber, @Firstname, @Lastname, @Pesel, @VacationDays, @Roles, @Company_Id, @identityAddress, @X_CreatedDate, @X_LastUpdateDate, null, 0)

	 SELECT @identity AS Id, @Username AS Username, @PhoneNumber AS PhoneNumber, @Firstname AS Firstname, @Lastname AS Lastname, @Pesel AS Pesel, @VacationDays AS VacationDays, @PostalCode AS PostalCode, @City AS City, @Street AS Street, @Polity AS Polity
END
GO

