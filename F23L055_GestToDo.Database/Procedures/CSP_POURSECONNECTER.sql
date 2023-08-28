CREATE PROCEDURE [dbo].[CSP_POURSECONNECTER]
	@email nvarchar(362),
	@MotDePasse NVARCHAR(50)
AS
BEGIN
     DECLARE @Pepper NVARCHAR(128)=N'%#hdhdhPeper456@'
    DECLARE @hashedPasswd NVARCHAR(1024)
    SET @hashedPasswd = CONVERT(NVARCHAR,HASHBYTES('SHA2_512',   @MotDePasse + @Pepper))

	if(Exists(SELECT * 	FROM [User] WHERE Email=@email))
	BEGIN
		SELECT Id, Email, Role
		FROM [User]
		WHERE Email=@email AND MotDePasse = @hashedPasswd
	END 
END
 
