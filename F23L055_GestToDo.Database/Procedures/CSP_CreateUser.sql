CREATE PROCEDURE [dbo].[CSP_CreateUser]
	 @Email nvarchar(362),@MotDePasse nvarchar(1024),@Role NVARCHAR(50) 
AS
BEGIN
	 

	DECLARE @Pepper NVARCHAR(128)=N'%#hdhdhPeper456@'
    DECLARE @hashedPasswd NVARCHAR(max)
    SET @hashedPasswd = CONVERT(NVARCHAR,HASHBYTES('SHA2_512',   @MotDePasse + @Pepper))
	

	--INSERT INTO [User]
	--(Email, MotDePasse, Role)
	--VALUES(@Email,HASHBYTES('SHA2_512', @hashedPasswd ), @Role)
	INSERT INTO [User]
	(Email, MotDePasse, Role)
	VALUES(@Email,  @hashedPasswd , @Role)

	select  @@identity

	-- scoped_identity
	-- d'utiliser le output dans les insert
END
 
