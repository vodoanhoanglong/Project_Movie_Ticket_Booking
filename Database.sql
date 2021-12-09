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

CREATE PROC sp_SetAccountRole(@AccountID varchar(11), @Password varchar(max), 
								@FullName nvarchar(30), @Role varchar(10)='Standard',
								@Balance decimal=100000)
AS
	declare @sql nvarchar(max)
	set @sql = 'use MTB' + ';' +
           'create login ' + @AccountID + 
               ' with password = ''' + @Password + '''; ' +
           'create user ' + @AccountID + ';'
exec (@sql)
if @Role = 'Manager'
	exec sp_addrolemember 'Manager', @AccountID
else exec sp_addrolemember 'Standard', @AccountID
SET @AccountID = SUBSTRING(@AccountID,2,10)
INSERT into ACCOUNT VALUES(@AccountID,@Password,@FullName,@Balance, @Role)
GO
 
CREATE TRIGGER tr_CheckAccount ON ACCOUNT
FOR INSERT
AS
	DECLARE @AccountID varchar(11),
			@Password varchar(max),
			@FullName nvarchar(30)
	SELECT @AccountID = I.AccountID, @Password = I.[Password], @FullName = I.FullName 
	FROM INSERTED I

	SET @AccountID = 'A' + @AccountID
	IF @AccountID = 'A0932765080' 
			EXEC sp_SetAccountRole @AccountID, @Password, @FullName, 'Manager'
	ELSE EXEC sp_SetAccountRole @AccountID, @Password, @FullName
GO

-- Insert admin account
INSERT INTO ACCOUNT(AccountID,[Password],FullName) VALUES('0932765080', '1', N'Võ Đoàn Hoàng Long')
-- Insert user account
INSERT INTO ACCOUNT(AccountID,[Password],FullName) VALUES('0909230102', '1', N'Tiểu Lợi')


