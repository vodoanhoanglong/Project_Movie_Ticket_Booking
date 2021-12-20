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
	isActive bit default 0,
	AccountID varchar(10),

	PRIMARY KEY (DiscountID),
	FOREIGN KEY (AccountID) REFERENCES  ACCOUNT(AccountID)
)

Create table MOVIE
(
	MovieID int identity(1,1),
	[Name] nvarchar(max),
	[Time] varchar(8),
	[Des] nvarchar(MAX),
	Price decimal,
	[Type] nvarchar(MAX),
	
	PRIMARY KEY (MovieID),
)


Create table ROOM 
(
	RoomID int identity(1,1),
	RoomName nvarchar(10),
	ChairQuantity int,

	PRIMARY KEY(RoomID)
)

Create table SHOWTIME
(
	ShowTimeID varchar(14),
	MovieShowTime datetime,
	MovieEndTime datetime,
	RoomID int,
	MovieID int,

	PRIMARY KEY (ShowTimeID),
	FOREIGN KEY (RoomID) REFERENCES  ROOM(RoomID),
	FOREIGN KEY (MovieID) REFERENCES  MOVIE(MovieID)
)


Create table TICKET
(
	TicketID varchar(50),
	BookingDate datetime,
	DiscountPercent int,
	SubTotalPrice decimal,
	TotalPrice decimal,
	AccountID varchar(10),
	ShowTimeID varchar(14),

	PRIMARY KEY (TicketID),
	FOREIGN KEY (AccountID) REFERENCES ACCOUNT(AccountID),
	FOREIGN KEY (ShowTimeID) REFERENCES SHOWTIME(ShowTimeID),
)
GO

Create table CHAIR
(
	ChairID varchar(50),
	ChairName varchar(10),
	[Type] int,
	Price decimal,
	haveBooked bit default 0,
	RoomID int,
	TicketID varchar(50),

	PRIMARY KEY(ChairID),
	FOREIGN KEY (RoomID) REFERENCES  ROOM(RoomID),
	FOREIGN KEY (TicketID) REFERENCES  TICKET(TicketID)
)

-- TAO QUYEN THEM, SUA XOA CHO NHOM NGUOI QUAN LY
CREATE ROLE [Manager]
GO

--Ngoai ra, con co quyen sao luu vao khoi phuc du lieu.
alter role db_backupoperator ADD MEMBER [Manager]
alter role db_datawriter ADD MEMBER [Manager]
alter role db_datareader ADD MEMBER [Manager]
GO

-- TAO QUYEN DOC DU LIEU CHO NHOM NGUOI DUNG
CREATE ROLE [Standard]
GO

-- Note: Dòng này từ từ chạy sau vì KH có thể đặt vé nên cần có quyền chèn vào các table
--alter role db_datareader ADD MEMBER [Standard]
--GO

--PROC

CREATE PROC sp_SetAccountRole(@AccountID varchar(11), @Password varchar(max), 
								@FullName nvarchar(30), @Role varchar(10)='Standard',
								@Balance decimal=100000)
AS
	declare @sql nvarchar(max)
	set @AccountID = 'A' + @AccountID
	set @sql = 'use MTB' + ';' +
           'create login ' + @AccountID + 
               ' with password = ''' + @Password + '''; ' +
           'create user ' + @AccountID + ';'
exec (@sql)
if @AccountID = 'A0932765080'
	set @Role = 'Manager'
if @Role = 'Manager'
	exec sp_addrolemember 'Manager', @AccountID
else exec sp_addrolemember 'Standard', @AccountID
SET @AccountID = SUBSTRING(@AccountID,2,10)
INSERT into ACCOUNT VALUES(@AccountID,@Password,@FullName,@Balance, @Role)
GO


-- TRIGGER


-- Insert admin account
EXEC sp_SetAccountRole '0932765080', '1', N'Võ Đoàn Hoàng Long'
-- Insert user account
EXEC sp_SetAccountRole '0909230102', '1', N'Tiểu Lợi'
-- Insert room
INSERT INTO ROOM(RoomName, ChairQuantity)
VALUES (N'Y1', 80),
	   (N'Y2', 80),
	   (N'Y3', 80)
