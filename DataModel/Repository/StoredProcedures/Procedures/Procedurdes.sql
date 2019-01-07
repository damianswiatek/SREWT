IF EXISTS (SELECT * FROM sys.objects where object_id = OBJECT_ID(N'test') AND type IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[test];
GO

CREATE PROCEDURE [dbo].[test]
	@Id uniqueidentifier
AS
BEGIN
	
  SELECT Id, Username
  FROM [dbo].[Users]
  where Id = @Id

END
GO