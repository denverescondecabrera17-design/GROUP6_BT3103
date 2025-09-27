CREATE TABLE [dbo].[Guest]
(
	[GuestID] INT IDENTITY(1,1) PRIMARY KEY,
	LastName VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	MiddleInitial CHAR(1) NULL,
	Age INT CHECK (Age > 0),
	BirthDate DATE NOT NULL,
	Gender VARCHAR (10) CHECK (Gender IN ('Male', 'Female', 'Other')),
	Email VARCHAR(100) UNIQUE,
	PhoneNumber VARCHAR (20)


);

