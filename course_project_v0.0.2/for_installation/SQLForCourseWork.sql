create database SQL_course_work;
GO

CREATE TABLE Film(
filmID int  NOT NULL identity(1,1),
filmName nvarchar(50)  NOT NULL,
year int NOT NULL,
poster image,
plotDescription nvarchar(3000)  NOT NULL,
genres nvarchar(50)  NOT NULL,
rating real  NOT NULL,
countries nvarchar(60)  NOT NULL,
director nvarchar(60) NOT NULL,
actors nvarchar(600)  NOT NULL,
duration int  NOT NULL,
premiereDate nvarchar(20)  NOT NULL,
PRIMARY KEY (filmID)
);

CREATE TABLE UsersBD(
userID int  NOT NULL identity(1,1),
login nchar(30)  NOT NULL,
password nchar(50)  NOT NULL,
EmailBD nchar(40)  NOT NULL,
admin bit  NOT NULL,
PRIMARY KEY (userID)
);

CREATE TABLE Feedback(
feedbackID int NOT NULL identity(1,1),
userID int NOT NULL,
login nchar(30)  NOT NULL,
feedback nvarchar(3000) NOT NULL,
dateFeedback date NOT NULL,
PRIMARY KEY (feedbackID),
FOREIGN KEY (userID)
REFERENCES UsersBD (userID)
);

CREATE TABLE Hall(
hallID int NOT NULL identity(1,1),
row int NOT NULL,
place int NOT NULL,
PRIMARY KEY (hallID)
);

CREATE TABLE Session(
sessionID int NOT NULL identity(1,1),
filmID int NOT NULL,
hallID int NOT NULL,
date date NOT NULL,
time time(0) NOT NULL,
End_time time(0) NOT NULL,
End_date date NOT NULL,
number_of_free_seats int NOT NULL,
price_for_place int NOT NULL,
PRIMARY KEY (sessionID),
FOREIGN KEY (filmID)
REFERENCES Film (filmID),
FOREIGN KEY (hallID)
REFERENCES Hall (hallID)
);

CREATE TABLE Ticket(
ticketID int NOT NULL identity(1,1),
sessionID int NOT NULL,
userID int NOT NULL,
filmName nvarchar(50) NOT NULL,
price int NOT NULL,
date date NOT NULL,
time time(0) NOT NULL,
row int NOT NULL,
place int NOT NULL,
PRIMARY KEY (ticketID),
FOREIGN KEY (sessionID)
REFERENCES Session (sessionID),
FOREIGN KEY (userID)
REFERENCES UsersBD (userID)
);


INSERT INTO Hall (row, place) 
VALUES (5, 18);
