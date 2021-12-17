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
	[Time] varchar(8),
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
	haveBooked bit default 0,
	RoomID int,

	PRIMARY KEY(ChairID),
	FOREIGN KEY (RoomID) REFERENCES  ROOM(RoomID)
)


Create table SHOWTIME
(
	ShowTimeID varchar(14),
	MovieShowTime datetime,
	MovieEndTime datetime,
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
	ShowTimeID varchar(14),
	RoomID int,
	MovieID int,
	ChairID int,

	PRIMARY KEY (TicketID, ShowTimeID, AccountID, RoomID, MovieID),
	FOREIGN KEY (AccountID) REFERENCES ACCOUNT(AccountID),
	FOREIGN KEY (ChairID) REFERENCES CHAIR(ChairID),
	FOREIGN KEY (ShowTimeID, RoomID, MovieID) REFERENCES SHOWTIME(ShowTimeID, RoomID, MovieID),
)
GO


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

CREATE PROC sp_AddChairByType(@Type int, @RoomID int)
AS
	DECLARE @Price DECIMAL
	IF @Type = 0
		SET @Price = 10000
	ELSE IF @Type = 1
		SET @Price = 15000
	ELSE
		SET @Price = 20000
INSERT INTO CHAIR([Type], Price, RoomID) VALUES (@Type, @Price, @RoomID)
GO

-- TRIGGER


-- Insert admin account
EXEC sp_SetAccountRole '0932765080', '1', N'Võ Đoàn Hoàng Long'
-- Insert user account
EXEC sp_SetAccountRole '0909230102', '1', N'Tiểu Lợi'
-- Insert room
INSERT INTO ROOM(RoomName, ChairQuantity)
VALUES (N'Y1', 10),
	   (N'Y2', 10),
	   (N'Y3', 10)
-- Insert chair 
-- room 1: 10 chair - 4 medium - 4 vjp - 2 couple
EXEC sp_AddChairByType 0, 1
EXEC sp_AddChairByType 0, 1
EXEC sp_AddChairByType 0, 1
EXEC sp_AddChairByType 0, 1
EXEC sp_AddChairByType 1, 1
EXEC sp_AddChairByType 1, 1
EXEC sp_AddChairByType 1, 1
EXEC sp_AddChairByType 1, 1
EXEC sp_AddChairByType 2, 1
EXEC sp_AddChairByType 2, 1
-- room 2: 10 chair - 4 medium - 4 vjp - 2 couple
EXEC sp_AddChairByType 0, 2
EXEC sp_AddChairByType 0, 2
EXEC sp_AddChairByType 0, 2
EXEC sp_AddChairByType 0, 2
EXEC sp_AddChairByType 1, 2
EXEC sp_AddChairByType 1, 2
EXEC sp_AddChairByType 1, 2
EXEC sp_AddChairByType 1, 2
EXEC sp_AddChairByType 2, 2
EXEC sp_AddChairByType 2, 2
-- room 3: 10 chair - 4 medium - 4 vjp - 2 couple
EXEC sp_AddChairByType 0, 3
EXEC sp_AddChairByType 0, 3
EXEC sp_AddChairByType 0, 3
EXEC sp_AddChairByType 0, 3
EXEC sp_AddChairByType 1, 3
EXEC sp_AddChairByType 1, 3
EXEC sp_AddChairByType 1, 3
EXEC sp_AddChairByType 1, 3
EXEC sp_AddChairByType 2, 3
EXEC sp_AddChairByType 2, 3