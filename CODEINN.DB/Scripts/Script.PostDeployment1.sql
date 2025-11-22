/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [dbo].[Guest] (LastName, FirstName, MiddleInitial, Age, Birthdate, Gender, Email, PhoneNumber)
VALUES
('Smith', 'John', 'A', 34, '1991-06-15', 'Male', 'john.smith@example.com', '555-123-4567'),
('Johnson', 'Emily', 'B', 29, '1996-02-24', 'Female', 'emily.johnson@example.com', '555-234-5678'),
('Williams', 'Michael', 'C', 41, '1984-11-02', 'Male', 'michael.williams@example.com', '555-345-6789'),
('Brown', 'Sarah', 'D', 37, '1988-08-19', 'Female', 'sarah.brown@example.com', '555-456-7890'),
('Jones', 'David', 'E', 26, '1999-03-10', 'Male', 'david.jones@example.com', '555-567-8901'),
('Garcia', 'Laura', 'F', 32, '1993-12-05', 'Female', 'laura.garcia@example.com', '555-678-9012'),
('Miller', 'James', 'G', 45, '1980-07-08', 'Male', 'james.miller@example.com', '555-789-0123'),
('Davis', 'Olivia', 'H', 28, '1997-04-17', 'Female', 'olivia.davis@example.com', '555-890-1234'),
('Rodriguez', 'Daniel', 'I', 36, '1989-09-30', 'Male', 'daniel.rodriguez@example.com', '555-901-2345'),
('Martinez', 'Sophia', 'J', 30, '1995-01-20', 'Female', 'sophia.martinez@example.com', '555-012-3456'),
('Hernandez', 'Ethan', 'K', 31, '1994-05-11', 'Male', 'ethan.hernandez@example.com', '555-111-2222'),
('Lopez', 'Ava', 'L', 27, '1998-10-28', 'Female', 'ava.lopez@example.com', '555-222-3333'),
('Gonzalez', 'Matthew', 'M', 39, '1986-06-06', 'Male', 'matthew.gonzalez@example.com', '555-333-4444'),
('Wilson', 'Isabella', 'N', 35, '1990-12-14', 'Female', 'isabella.wilson@example.com', '555-444-5555'),
('Anderson', 'Liam', 'O', 33, '1992-03-25', 'Male', 'liam.anderson@example.com', '555-555-6666'),
('Thomas', 'Mia', 'P', 24, '2001-09-05', 'Female', 'mia.thomas@example.com', '555-666-7777'),
('Taylor', 'Noah', 'Q', 42, '1983-01-30', 'Male', 'noah.taylor@example.com', '555-777-8888'),
('Moore', 'Amelia', 'R', 38, '1987-07-22', 'Female', 'amelia.moore@example.com', '555-888-9999'),
('Jackson', 'Benjamin', 'S', 40, '1985-02-16', 'Male', 'benjamin.jackson@example.com', '555-999-0000'),
('Martin', 'Charlotte', 'T', 25, '2000-05-09', 'Female', 'charlotte.martin@example.com', '555-000-1111'),
('Lee', 'Logan', 'U', 31, '1994-08-12', 'Male', 'logan.lee@example.com', '555-123-0000'),
('Perez', 'Abigail', 'V', 28, '1997-03-04', 'Female', 'abigail.perez@example.com', '555-234-1111'),
('Thompson', 'Lucas', 'W', 29, '1996-06-01', 'Male', 'lucas.thompson@example.com', '555-345-2222'),
('White', 'Harper', 'X', 34, '1991-09-13', 'Female', 'harper.white@example.com', '555-456-3333'),
('Harris', 'Jackson', 'Y', 27, '1998-02-27', 'Male', 'jackson.harris@example.com', '555-567-4444'),
('Sanchez', 'Ella', 'Z', 30, '1995-11-19', 'Female', 'ella.sanchez@example.com', '555-678-5555'),
('Clark', 'Alexander', 'A', 33, '1992-04-01', 'Male', 'alexander.clark@example.com', '555-789-6666'),
('Ramirez', 'Grace', 'B', 26, '1999-07-23', 'Female', 'grace.ramirez@example.com', '555-890-7777'),
('Lewis', 'Henry', 'C', 36, '1989-01-18', 'Male', 'henry.lewis@example.com', '555-901-8888'),
('Robinson', 'Chloe', 'D', 29, '1996-06-07', 'Female', 'chloe.robinson@example.com', '555-012-9999'),
('Walker', 'Sebastian', 'E', 37, '1988-10-01', 'Male', 'sebastian.walker@example.com', '555-123-1212'),
('Young', 'Avery', 'F', 32, '1993-03-03', 'Female', 'avery.young@example.com', '555-234-2323'),
('Allen', 'Jack', 'G', 31, '1994-09-27', 'Male', 'jack.allen@example.com', '555-345-3434'),
('King', 'Scarlett', 'H', 30, '1995-02-02', 'Female', 'scarlett.king@example.com', '555-456-4545'),
('Wright', 'Levi', 'I', 35, '1990-11-11', 'Male', 'levi.wright@example.com', '555-567-5656'),
('Scott', 'Victoria', 'J', 33, '1992-07-29', 'Female', 'victoria.scott@example.com', '555-678-6767'),
('Torres', 'Wyatt', 'K', 28, '1997-05-15', 'Male', 'wyatt.torres@example.com', '555-789-7878'),
('Nguyen', 'Lily', 'L', 27, '1998-08-18', 'Female', 'lily.nguyen@example.com', '555-890-8989'),
('Hill', 'Owen', 'M', 39, '1986-01-07', 'Male', 'owen.hill@example.com', '555-901-9090'),
('Flores', 'Zoey', 'N', 26, '1999-10-11', 'Female', 'zoey.flores@example.com', '555-012-1010'),
('Green', 'Gabriel', 'O', 34, '1991-05-05', 'Male', 'gabriel.green@example.com', '555-123-2121'),
('Adams', 'Nora', 'P', 29, '1996-12-08', 'Female', 'nora.adams@example.com', '555-234-3232'),
('Nelson', 'Carter', 'Q', 30, '1995-06-19', 'Male', 'carter.nelson@example.com', '555-345-4343'),
('Baker', 'Riley', 'R', 28, '1997-01-13', 'Female', 'riley.baker@example.com', '555-456-5454'),
('Hall', 'Julian', 'S', 32, '1993-09-03', 'Male', 'julian.hall@example.com', '555-567-6565'),
('Rivera', 'Hannah', 'T', 25, '2000-04-14', 'Female', 'hannah.rivera@example.com', '555-678-7676'),
('Campbell', 'Jayden', 'U', 31, '1994-10-20', 'Male', 'jayden.campbell@example.com', '555-789-8787'),
('Mitchell', 'Layla', 'V', 27, '1998-03-08', 'Female', 'layla.mitchell@example.com', '555-890-9898'),
('Carter', 'Isaac', 'W', 35, '1990-07-01', 'Male', 'isaac.carter@example.com', '555-901-0909');

INSERT INTO Users(username, password) VALUES
('Denver','Reyes')