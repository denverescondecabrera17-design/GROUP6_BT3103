CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [username] NCHAR(99) NULL, 
    [password] NCHAR(199) NULL

)
