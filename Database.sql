CREATE DATABASE MTB
GO
USE MTB
GO


Create table ACCOUNT
(
	AccountID varchar(10),
	[Password] varchar(max),
	FullName nvarchar(30),
	Balance decimal,
	[Role] varchar(10),

	PRIMARY KEY (AccountID)
);

Create table DISCOUNT
(
	DiscountID int identity(1,1),
	Code varchar(10),
	[Percent] int,
	AccountID varchar(10),

	PRIMARY KEY (DiscountID),
	FOREIGN KEY (AccountID) REFERENCES  ACCOUNT(AccountID)
)

Create table MOVIE
(
	MovieID int identity(1,1),
	[Name] nvarchar(max),
	[Time] time,
	[Des] nvarchar(MAX),
	Price decimal,
	
	PRIMARY KEY (MovieID),
)

Create table ROOM 
(
	RoomID int identity(1,1),
	RoomName nvarchar(10),
	ChairQuantity int,

	PRIMARY KEY(RoomID)
)

Create table CHAIR
(
	ChairID int identity(1,1),
	[Type] int,
	Price decimal,
	RoomID int,

	PRIMARY KEY(ChairID),
	FOREIGN KEY (RoomID) REFERENCES  ROOM(RoomID)
)

Create table SHOWTIME
(
	ShowTimeID int identity(1,1),
	MovieShowTime time,
	RoomID int,
	MovieID int,

	PRIMARY KEY (ShowTimeID, RoomID, MovieID),
	FOREIGN KEY (RoomID) REFERENCES  ROOM(RoomID),
	FOREIGN KEY (MovieID) REFERENCES  MOVIE(MovieID)
)

Create table TICKET
(
	TicketID int identity(1,1),
	BookingDate datetime,
	SubTotalPrice decimal,
	TotalPrice decimal,
	AccountID varchar(10),
	ShowTimeID int,
	RoomID int,
	MovieID int,
	ChairID int,

	PRIMARY KEY (TicketID, ShowTimeID, AccountID, RoomID, MovieID),
	FOREIGN KEY (AccountID) REFERENCES ACCOUNT(AccountID),
	FOREIGN KEY (ChairID) REFERENCES CHAIR(ChairID),
	FOREIGN KEY (ShowTimeID, RoomID, MovieID) REFERENCES SHOWTIME(ShowTimeID, RoomID, MovieID),
)



