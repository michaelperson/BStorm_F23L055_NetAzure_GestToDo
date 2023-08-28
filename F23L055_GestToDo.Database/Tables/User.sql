CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	Email nvarchar(362) NOT NULL,
	MotDePasse nvarchar(1024)  NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL DEFAULT User 
)
