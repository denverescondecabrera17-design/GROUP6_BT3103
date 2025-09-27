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

INSERT INTO Guest (LastName, FirstName, MiddleInitial, Age, BirthDate, Gender, Email, PhoneNumber) VALUES
('Anderson','Logan','A',32,'1993-04-12','Male','logan.anderson@example.com','09170000001'),
('Bennett','Olivia','B',27,'1998-07-21','Female','olivia.bennett@example.com','09170000002'),
('Carter','Ethan','C',29,'1996-02-18','Male','ethan.carter@example.com','09170000003'),
('Diaz','Sophia','D',24,'2001-09-15','Female','sophia.diaz@example.com','09170000004'),
('Evans','Mason','E',30,'1995-11-20','Male','mason.evans@example.com','09170000005'),
('Foster','Isabella','F',28,'1997-06-25','Female','isabella.foster@example.com','09170000006'),
('Garcia','James','G',33,'1992-03-10','Male','james.garcia@example.com','09170000007'),
('Harris','Amelia','H',22,'2003-01-05','Female','amelia.harris@example.com','09170000008'),
('Iverson','Liam','I',26,'1999-12-11','Male','liam.iverson@example.com','09170000009'),
('Johnson','Mia','J',23,'2002-05-14','Female','mia.johnson@example.com','09170000010'),
('Kim','Noah','K',27,'1998-07-02','Male','noah.kim@example.com','09170000011'),
('Lopez','Ava','L',25,'2000-04-18','Female','ava.lopez@example.com','09170000012'),
('Martinez','Carter','M',31,'1994-02-09','Male','carter.martinez@example.com','09170000013'),
('Nguyen','Ella','N',24,'2001-08-22','Female','ella.nguyen@example.com','09170000014'),
('Owens','William','O',29,'1996-09-30','Male','william.owens@example.com','09170000015'),
('Patel','Harper','P',22,'2003-12-13','Female','harper.patel@example.com','09170000016'),
('Quinn','Alexander','Q',28,'1997-03-27','Male','alexander.quinn@example.com','09170000017'),
('Robinson','Scarlett','R',26,'1999-06-06','Female','scarlett.robinson@example.com','09170000018'),
('Scott','Benjamin','S',30,'1995-05-05','Male','benjamin.scott@example.com','09170000019'),
('Turner','Zoe','T',23,'2002-10-17','Female','zoe.turner@example.com','09170000020'),
('Underwood','Henry','U',34,'1991-08-09','Male','henry.underwood@example.com','09170000021'),
('Vasquez','Lily','V',21,'2004-11-28','Female','lily.vasquez@example.com','09170000022'),
('White','Samuel','W',25,'2000-07-19','Male','samuel.white@example.com','09170000023'),
('Xu','Natalie','X',27,'1998-02-14','Female','natalie.xu@example.com','09170000024'),
('Young','David','Y',32,'1993-01-21','Male','david.young@example.com','09170000025'),
('Zimmerman','Chloe','Z',24,'2001-04-30','Female','chloe.zimmerman@example.com','09170000026'),
('Adams','Joseph','A',29,'1996-12-05','Male','joseph.adams@example.com','09170000027'),
('Baker','Victoria','B',26,'1999-10-08','Female','victoria.baker@example.com','09170000028'),
('Clark','Matthew','C',31,'1994-06-23','Male','matthew.clark@example.com','09170000029'),
('Davis','Aria','D',23,'2002-02-16','Female','aria.davis@example.com','09170000030'),
('Edwards','Michael','E',28,'1997-03-29','Male','michael.edwards@example.com','09170000031'),
('Fisher','Grace','F',22,'2003-08-14','Female','grace.fisher@example.com','09170000032'),
('Gonzalez','Jacob','G',27,'1998-09-09','Male','jacob.gonzalez@example.com','09170000033'),
('Hall','Aurora','H',25,'2000-12-24','Female','aurora.hall@example.com','09170000034'),
('Ingram','Lucas','I',30,'1995-05-02','Male','lucas.ingram@example.com','09170000035'),
('Jacobs','Emily','J',21,'2004-07-07','Female','emily.jacobs@example.com','09170000036'),
('King','Andrew','K',29,'1996-08-30','Male','andrew.king@example.com','09170000037'),
('Lewis','Madison','L',24,'2001-09-01','Female','madison.lewis@example.com','09170000038'),
('Mitchell','Christopher','M',33,'1992-11-03','Male','christopher.mitchell@example.com','09170000039'),
('Nelson','Sofia','N',22,'2003-02-25','Female','sofia.nelson@example.com','09170000040'),
('Ortiz','Daniel','O',28,'1997-07-22','Male','daniel.ortiz@example.com','09170000041'),
('Parker','Layla','P',23,'2002-06-19','Female','layla.parker@example.com','09170000042'),
('Reed','Anthony','R',27,'1998-05-28','Male','anthony.reed@example.com','09170000043'),
('Sanders','Penelope','S',25,'2000-03-15','Female','penelope.sanders@example.com','09170000044'),
('Taylor','Ryan','T',30,'1995-10-01','Male','ryan.taylor@example.com','09170000045'),
('Upton','Claire','U',24,'2001-01-12','Female','claire.upton@example.com','09170000046'),
('Vargas','Isaac','V',26,'1999-06-20','Male','isaac.vargas@example.com','09170000047'),
('Walker','Anna','W',22,'2003-12-29','Female','anna.walker@example.com','09170000048'),
('Xavier','Joshua','X',28,'1997-09-14','Male','joshua.xavier@example.com','09170000049'),
('York','Stella','Y',21,'2004-05-18','Female','stella.york@example.com','09170000050');
