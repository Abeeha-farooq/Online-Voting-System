/* ONLINE VOTING SYSTEM – DML (REAL DATA) */

-- CONSTITUENCY (Parent FIRST)
INSERT INTO CONSTITUENCY VALUES
(1,'NA-120','Lahore','Punjab',1500,'NA120'),
(2,'NA-121','Lahore','Punjab',1400,'NA121'),
(3,'NA-122','Lahore','Punjab',1300,'NA122'),
(4,'NA-245','Karachi','Sindh',1600,'NA245'),
(5,'NA-246','Karachi','Sindh',1550,'NA246'),
(6,'NA-247','Karachi','Sindh',1500,'NA247'),
(7,'NA-55','Rawalpindi','Punjab',1450,'NA55'),
(8,'NA-56','Rawalpindi','Punjab',1350,'NA56'),
(9,'NA-57','Rawalpindi','Punjab',1250,'NA57'),
(10,'NA-30','Peshawar','KPK',1200,'NA30');

-- USERS (Admins + Voters)
INSERT INTO USERS VALUES
(1,'Admin One','admin1@gmail.com','123','ADMIN',GETDATE()),
(2,'Admin Two','admin2@gmail.com','123','ADMIN',GETDATE()),
(3,'Ali Khan','ali@gmail.com','123','VOTER',GETDATE()),
(4,'Sara Ahmed','sara@gmail.com','123','VOTER',GETDATE()),
(5,'Usman Ali','usman@gmail.com','123','VOTER',GETDATE()),
(6,'Ayesha Noor','ayesha@gmail.com','123','VOTER',GETDATE()),
(7,'Hassan Raza','hassan@gmail.com','123','VOTER',GETDATE()),
(8,'Fatima Khan','fatima@gmail.com','123','VOTER',GETDATE()),
(9,'Bilal Ahmed','bilal@gmail.com','123','VOTER',GETDATE()),
(10,'Zain Ali','zain@gmail.com','123','VOTER',GETDATE()),
(11,'Omar Khan','omar@gmail.com','123','VOTER',GETDATE()),
(12,'Noor Fatima','noor@gmail.com','123','VOTER',GETDATE()),
(13,'Hamza Ali','hamza@gmail.com','123','VOTER',GETDATE()),
(14,'Iqra Khan','iqra@gmail.com','123','VOTER',GETDATE()),
(15,'Saad Ahmed','saad@gmail.com','123','VOTER',GETDATE()),
(16,'Hina Ali','hina@gmail.com','123','VOTER',GETDATE()),
(17,'Tariq Khan','tariq@gmail.com','123','VOTER',GETDATE()),
(18,'Kiran Noor','kiran@gmail.com','123','VOTER',GETDATE()),
(19,'Ahmed Raza','ahmed@gmail.com','123','VOTER',GETDATE()),
(20,'Sana Khan','sana@gmail.com','123','VOTER',GETDATE());

-- ADMIN
INSERT INTO ADMIN VALUES
(1,'SuperAdmin',GETDATE()),
(2,'ElectionOfficer',GETDATE());

-- VOTER
INSERT INTO VOTER VALUES
(3,'35201-1111111-1',1),
(4,'35201-1111111-2',2),
(5,'35201-1111111-3',3),
(6,'42101-2222222-1',4),
(7,'42101-2222222-2',5),
(8,'42101-2222222-3',6),
(9,'37401-3333333-1',7),
(10,'37401-3333333-2',8),
(11,'37401-3333333-3',9),
(12,'17301-4444444-1',10),
(13,'35201-5555555-1',1),
(14,'35201-5555555-2',2),
(15,'35201-5555555-3',3),
(16,'42101-6666666-1',4),
(17,'42101-6666666-2',5),
(18,'42101-6666666-3',6),
(19,'37401-7777777-1',7),
(20,'37401-7777777-2',8);

-- PARTY
INSERT INTO PARTY VALUES
(1,'PTI','Bat','Imran Khan',1996,'Islamabad'),
(2,'PML-N','Lion','Nawaz Sharif',1993,'Lahore'),
(3,'PPP','Arrow','Bilawal Bhutto',1967,'Karachi'),
(4,'MQM','Kite','Khalid Maqbool',1984,'Karachi'),
(5,'ANP','Lantern','Asfandyar Wali',1986,'Peshawar'),
(6,'JUI-F','Book','Fazlur Rehman',1988,'Quetta'),
(7,'TLP','Crane','Saad Rizvi',2015,'Lahore'),
(8,'PML-Q','Bicycle','Chaudhry Shujaat',2002,'Lahore'),
(9,'JI','Scale','Siraj ul Haq',1941,'Lahore'),
(10,'BNP','Star','Akhtar Mengal',1996,'Quetta');

-- ELECTION
INSERT INTO ELECTION VALUES
(1,'General Election 2024','2024-02-08','2024-02-08 08:00','2024-02-08 17:00','Completed'),
(2,'Local Election 2025','2025-06-10','2025-06-10 08:00','2025-06-10 17:00','Upcoming'),
(3,'By Election 2023','2023-05-10','2023-05-10 08:00','2023-05-10 17:00','Completed'),
(4,'Senate Election 2022','2022-03-15','2022-03-15 08:00','2022-03-15 17:00','Completed'),
(5,'Local Election 2022','2022-12-20','2022-12-20 08:00','2022-12-20 17:00','Completed'),
(6,'By Election 2022','2022-07-15','2022-07-15 08:00','2022-07-15 17:00','Completed'),
(7,'Local Election 2021','2021-09-10','2021-09-10 08:00','2021-09-10 17:00','Completed'),
(8,'By Election 2021','2021-03-12','2021-03-12 08:00','2021-03-12 17:00','Completed'),
(9,'General Election 2018','2018-07-25','2018-07-25 08:00','2018-07-25 17:00','Completed'),
(10,'General Election 2013','2013-05-11','2013-05-11 08:00','2013-05-11 17:00','Completed');

-- CANDIDATE
INSERT INTO CANDIDATE VALUES
(1,'Ali Raza',35,'Reform',1,1,1),
(2,'Ahmed Gillani',45,'Development',2,1,1),
(3,'Zain Asif',40,'Education',3,1,2),
(4,'Usman Gulzar',38,'Health',4,1,2),
(5,'Bilal Shafi',42,'Economy',5,1,3),
(6,'Kashif Nazir',36,'Youth',1,2,1),
(7,'Adnan Khan',50,'Growth',2,2,2),
(8,'Salman Raof',44,'Jobs',3,2,3),
(9,'Rizwan Randhawa',39,'Law',4,2,4),
(10,'Farhan Khan',41,'Trade',5,2,5),
(11,'Imran Tariq',37,'Youth',6,3,4),
(12,'Saifullah',48,'Economy',7,3,5),
(13,'Rashid Minhas',52,'Education',8,4,6),
(14,'Adeel Shah',33,'Health',9,4,7),
(15,'Waqas Malik',41,'Jobs',10,5,8),
(16,'Nabeel Ahmed',36,'Growth',1,6,9),
(17,'Danish Ali',43,'Law',2,7,10),
(18,'Junaid Khan',39,'Trade',3,8,1),
(19,'Shahid Hussain',47,'Transport',4,9,2),
(20,'Faisal Rehman',44,'Energy',5,10,3);

-- RESULT
INSERT INTO RESULT VALUES
(1,4,1,'Won',1,1),
(2,3,2,'Lost',2,1),
(3,2,3,'Lost',3,1),
(4,6,1,'Won',4,1),
(5,5,2,'Lost',5,1),
(6,7,1,'Won',6,2),
(7,4,2,'Lost',7,2),
(8,8,1,'Won',8,3),
(9,3,2,'Lost',9,3),
(10,9,1,'Won',10,4),
(11,2,2,'Lost',11,4),
(12,6,1,'Won',12,5),
(13,4,2,'Lost',13,5),
(14,7,1,'Won',14,6),
(15,5,2,'Lost',15,6),
(16,8,1,'Won',16,7);

-- VOTE
INSERT INTO VOTE (vote_time,status,voter_id,candidate_id,election_id) VALUES
(GETDATE(),'Cast',3,1,1),
(GETDATE(),'Cast',4,2,1),
(GETDATE(),'Cast',5,3,1),
(GETDATE(),'Cast',6,4,1),
(GETDATE(),'Cast',7,5,1),
(GETDATE(),'Cast',8,1,1),
(GETDATE(),'Cast',9,2,1),
(GETDATE(),'Cast',10,3,1),
(GETDATE(),'Cast',11,4,1),
(GETDATE(),'Cast',12,5,1);