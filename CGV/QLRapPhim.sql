CREATE DATABASE QLCGV
--DROP DATABASE QLCGV
GO

USE QLCGV
GO

SET DATEFORMAT DMY
GO



CREATE TABLE Staff
(
	IDStaff VARCHAR(20) PRIMARY KEY,
	NameStaff NVARCHAR(50) NOT NULL,
	BirthdayStaff DATE NOT NULL,
	AddressStaff NVARCHAR(100),
	NumberPhoneStaff VARCHAR(20),
	IDCard INT NOT NULL Unique
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(50) PRIMARY KEY,
	Pass VARCHAR(100) NOT NULL,
	AccounType INT NOT NULL DEFAULT 1, -- 0: Admin, 1: Staff, 2: Client
	IDStaff VARCHAR(20) NOT NULL,

	FOREIGN KEY (IDStaff) REFERENCES dbo.Staff(IDStaff)
)
GO

CREATE TABLE MovieFormat
(
	IDMovieFormat VARCHAR(10) PRIMARY KEY,
	MovieFormatName NVARCHAR(50) --2D || 3D || IMax || ScreenX
)
GO

CREATE TABLE Room
(
	IDRoom VARCHAR(20) PRIMARY KEY,
	RoomName NVARCHAR(50) NOT NULL,
	IDMovieFormat VARCHAR(10),
	TotalSeats INT NOT NULL,
	Condition INT NOT NULL DEFAULT 0, -- 0: Active || 1: Passive
	TotalRowsSeats int not null,
	TotalSeatsPerRow int not null,

	FOREIGN KEY (IDMovieFormat) REFERENCES dbo.MovieFormat(IDMovieFormat)
)
GO


CREATE TABLE Movie
(
	IDMovie varchar(20) PRIMARY KEY,
	MovieName nvarchar(100) NOT NULL,
	DescriptionFilm nvarchar(1000) NULL,
	TotalTime float NOT NULL,
	PremiereDate date NOT NULL,
	Productor nvarchar(100) NOT NULL,
	Director nvarchar(50) NULL,
	ProductionYear int NOT NULL,
	Posters image
)
GO

CREATE TABLE FormatDetails  
(
	IDFormat varchar(20) NOT NULL PRIMARY KEY,
	IDMovie VARCHAR(20) NOT NULL,
	IDMovieFormat VARCHAR(10) NOT NULL,

	FOREIGN KEY (IDMovie) REFERENCES dbo.Movie(IDMovie),
	FOREIGN KEY (IDMovieFormat) REFERENCES dbo.MovieFormat(IDMovieFormat),
)
GO

CREATE TABLE FilmGenre
(
	IDCategory VARCHAR(20) PRIMARY KEY,
	CategoryName NVARCHAR(50) NOT NULL,
	Descriptions NVARCHAR(100)
)
GO

CREATE TABLE MovieDetails
(
	IDMovie VARCHAR(20) NOT NULL,
	IDCategory VARCHAR(20) NOT NULL,

	FOREIGN KEY (IDMovie) REFERENCES dbo.Movie(IDMovie),
	FOREIGN KEY (IDCategory) REFERENCES dbo.FilmGenre(IDCategory),

	CONSTRAINT PK_MovieDetails PRIMARY KEY(IDMovie,IDCategory)
)
GO

CREATE TABLE Showtimes
(
	IDShowtimes VARCHAR(20) PRIMARY KEY,
	ShowTime DATETIME NOT NULL,
	IDRoom VARCHAR(20) NOT NULL,
	IDFormat VARCHAR(20) NOT NULL,
	Fare Money NOT NULL,
	Statues INT NOT NULL DEFAULT '0', --0: Ticket not created yet || 1: Ticket created

	FOREIGN KEY (IDRoom) REFERENCES dbo.Room(IDRoom),
	FOREIGN KEY (IDFormat) REFERENCES dbo.FormatDetails(IDFormat),
)
GO

CREATE TABLE Client
(
	IDClient VARCHAR(20) PRIMARY KEY,
	NameClient NVARCHAR(50) NOT NULL,
	BirthdayClient DATE NOT NULL,
	AddressClient NVARCHAR(100),
	NumberPhoneClient VARCHAR(20),
	IDCardClient INT NOT NULL Unique,
	PlushPoints int

	
)
GO


CREATE TABLE Ticket
(
	IDTicket int identity(1,1) PRIMARY KEY,
	LoaiVe INT  DEFAULT '0', --0: Adults || 1: Student || 2: children
	IDShowTimes VARCHAR(20),
	MaGheNgoi VARCHAR(20),
	IDClient VARCHAR(20),
	TrangThai INT NOT NULL DEFAULT '0', --0: 'not sold yet' || 1: 'Sold'
	TienBanVe MONEY DEFAULT '0'

	FOREIGN KEY (IDShowTimes) REFERENCES dbo.ShowTimes(IDShowTimes),
	FOREIGN KEY (IDClient) REFERENCES dbo.Client(IDClient)

)

--Trigger
CREATE TRIGGER INSERT_CheckDateShowTimes
ON dbo.ShowTimes
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IDFormat VARCHAR(50), @ShowTime DATE, @PremiereDate DATE

	SELECT @IDFormat = IDFormat, @ShowTime = CONVERT(DATE, ShowTime) from INSERTED

	SELECT @PremiereDate = M.PremiereDate
	FROM dbo.Movie M, dbo.FormatDetails FD
	WHERE @IDFormat = FD.IDFormat AND FD.IDMovie = M.IDMovie

	IF (@ShowTime < @PremiereDate)
	BEGIN
		ROLLBACK TRAN
		Raiserror('Lịch chiếu đượctạp phải lớn hơn Ngày Công Chiếu ',16,1)
		Return
    END
END
GO

CREATE TRIGGER CheckTimeShowTime
ON dbo.ShowTimes
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @Count1 INT = 0, @Count2 INT = 0, @ShowTime DATETIME, @IDRoom VARCHAR(50), @IDFormat VARCHAR(50)

	SELECT @IDRoom = IDRoom, @ShowTime = ShowTime, @IDFormat = IDFormat from INSERTED

	SELECT @Count1 = COUNT(*)
	FROM dbo.Showtimes ST, dbo.FormatDetails FD, dbo.Movie M
	WHERE ST.IDRoom = @IDRoom AND ST.IDFormat = FD.IDFormat AND FD.IDMovie = M.IDMovie 
	AND (@ShowTime >= ST.ShowTime AND @ShowTime <= DATEADD(MINUTE, M.TotalTime, ST.ShowTime))

	SELECT @Count2 = COUNT(*)
	FROM dbo.Showtimes ST, dbo.FormatDetails FD, dbo.Movie M
	WHERE @IDRoom = ST.IDRoom AND ST.IDFormat = FD.IDFormat AND FD.IDMovie = M.IDMovie  
	AND (ST.ShowTime >= @ShowTime AND ST.ShowTime <= DATEADD(MINUTE, M.TotalTime, @ShowTime))

	IF (@Count1 > 1 OR @Count2 > 1)
	BEGIN
		ROLLBACK TRAN
		Raiserror('Thời Gian Chiếu đã trùng với một lịch chiếu khác cùng Phòng Chiếu',16,1)
		Return
	END
END
GO



CREATE PROC UpdatePasswordForAccount
@username NVARCHAR(100), @pass VARCHAR(1000), @newPass VARCHAR(1000)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName = @username AND Pass = @pass

	IF (@isRightPass = 1)
	BEGIN
		UPDATE dbo.Account SET Pass = @newPass WHERE UserName = @username
    END
END
GO

CREATE PROC USP_Login
@userName NVARCHAR(1000), @pass VARCHAR(1000)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND Pass = @pass
END

GO

--Insert Dữ Liệu
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL01', N'Hành Động', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL02', N'Hoạt Hình', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL03', N'Kinh Dị', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL04', N'Khoa học - Viễn Tưởng', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL05', N'Phiêu lưu', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL06', N'Chinh Thám', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL07', N'Tình Cảm', NULL)
INSERT dbo.FilmGenre (IDCategory, CategoryName, Descriptions) VALUES (N'TL08', N'Tâm Lý', NULL)


INSERT dbo.Staff (IDStaff, NameStaff, BirthdayStaff, AddressStaff, NumberPhoneStaff, IDCard) VALUES (N'NV01', N'Đào Thanh Tiến', CAST(N'2001-08-13' AS Date), N'Cao Bằng', NULL, 123456789)
INSERT dbo.Staff (IDStaff, NameStaff, BirthdayStaff, AddressStaff, NumberPhoneStaff, IDCard) VALUES (N'NV02', N'Hoàng Tiến Việt Dũng', CAST(N'2001-09-07' AS Date), N'Cao Bằng', NULL, 987654321)
INSERT dbo.Staff (IDStaff, NameStaff, BirthdayStaff, AddressStaff, NumberPhoneStaff, IDCard) VALUES (N'NV03', N'Lê Công Tiến', CAST(N'2001-10-18' AS Date), N'Cao Bằng', 113, 678954321)
INSERT dbo.Staff (IDStaff, NameStaff, BirthdayStaff, AddressStaff, NumberPhoneStaff, IDCard) VALUES (N'NV04', N'La Trung Hòa', CAST(N'2001-01-01' AS Date), N'Cao Bằng', NULL, 98761234)


INSERT dbo.Account (UserName, Pass, AccounType, IDStaff) VALUES (N'Đòa Thanh Tiến', N'12345', 1, N'NV01')
INSERT dbo.Account (UserName, Pass, AccounType, IDStaff) VALUES (N'Lê Công Tiến', N'12345', 2, N'NV03')


INSERT dbo.Client (IDClient, NameClient, BirthdayClient, AddressClient, NumberPhoneClient, IDCardClient, PlushPoints) VALUES (N'KH01', N'Phùng Xuân Đoan (khách hàng đen)', CAST(N'2001-06-08' AS Date), N'Cao Bằng', N'113', 12345, 0)
INSERT dbo.Client (IDClient, NameClient, BirthdayClient, AddressClient, NumberPhoneClient, IDCardClient, PlushPoints) VALUES (N'KH02', N'Nguyễn Mai Hương (khách hàng thân thiết )', CAST(N'2001-03-04' AS Date), N'Bắc Ninh', N'114', 56789, 0)
INSERT dbo.Client (IDClient, NameClient, BirthdayClient, AddressClient, NumberPhoneClient, IDCardClient, PlushPoints) VALUES (N'KH03', N'Đoàn Phương Hằng', CAST(N'2001-05-10' AS Date), N'Cao Bằng', N'115', 23456, 0)

INSERT dbo.MovieFormat (IDMovieFormat, MovieFormatName) VALUES (N'DD01', N'2D')
INSERT dbo.MovieFormat (IDMovieFormat, MovieFormatName) VALUES (N'DD02', N'3D')
INSERT dbo.MovieFormat (IDMovieFormat, MovieFormatName) VALUES (N'DD03', N'IMAX')
INSERT dbo.MovieFormat (IDMovieFormat, MovieFormatName) VALUES (N'DD04', N'SCREẼN')


GO

INSERT dbo.Room (IDRoom, RoomName, IDMovieFormat, TotalSeats, Condition, TotalRowsSeats, TotalSeatsPerRow) VALUES (N'R01', N'ROOM 01', N'DD01', 56, 1, 7, 8)
INSERT dbo.Room (IDRoom, RoomName, IDMovieFormat, TotalSeats, Condition, TotalRowsSeats, TotalSeatsPerRow) VALUES (N'R02', N'ROOM 02', N'DD01', 56, 1, 7, 8)
INSERT dbo.Room (IDRoom, RoomName, IDMovieFormat, TotalSeats, Condition, TotalRowsSeats, TotalSeatsPerRow) VALUES (N'R03', N'ROOM 03', N'DD03', 56, 1, 7, 8)
INSERT dbo.Room (IDRoom, RoomName, IDMovieFormat, TotalSeats, Condition, TotalRowsSeats, TotalSeatsPerRow) VALUES (N'R04', N'ROOM 04', N'DD01', 56, 1, 7, 8)
INSERT dbo.Room (IDRoom, RoomName, IDMovieFormat, TotalSeats, Condition, TotalRowsSeats, TotalSeatsPerRow) VALUES (N'R05', N'ROOM 05', N'DD01', 56, 0, 7, 8)
INSERT dbo.Room (IDRoom, RoomName, IDMovieFormat, TotalSeats, Condition, TotalRowsSeats, TotalSeatsPerRow) VALUES (N'R06', N'ROOM 06', N'DD01', 56, 0, 7, 8)

INSERT dbo.Movie (IDMovie, MovieName, DescriptionFilm, TotalTime, PremiereDate, Productor, Director, ProductionYear) VALUES (N'M01', N'SpỉderMan: No Way Home', N'Phim Marvel', 150, CAST(N'2021-05-01' AS Date), N'đâu đó trên nước Mỹ', N'Anthony Russo,  Joe Russo', 2021)
INSERT dbo.Movie (IDMovie, MovieName, DescriptionFilm, TotalTime, PremiereDate, Productor, Director, ProductionYear) VALUES (N'M02', N'Cô Dâu 8 tuổi', N'Phim ngắn', 1000, CAST(N'2020-06-01' AS Date), N'Indian', N'Chưa rõ', 2015)
INSERT dbo.Movie (IDMovie, MovieName, DescriptionFilm, TotalTime, PremiereDate, Productor, Director, ProductionYear) VALUES (N'M03', N'Thủy Thủ Mặt Biển', N'Phim dành cho người trên 16 tuổi', 100, CAST(N'2020-07-18' AS Date), N'Việt Nam', N'Đào Thanh Tiến', 2020)
INSERT dbo.Movie (IDMovie, MovieName, DescriptionFilm, TotalTime, PremiereDate, Productor, Director, ProductionYear) VALUES (N'M04', N'Avengers: Cuộc Chiến Vô Cực', N'Khá hay', 91, CAST(N'2018-05-01' AS Date), N'Mỹ', N'Christopher Jenkins', 2020)


INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M01', N'TL01')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M01', N'TL04')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M01', N'TL05')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M02', N'TL01')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M02', N'TL07')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M02', N'TL08')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M03', N'TL03')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M03', N'TL07')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M03', N'TL08')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M04', N'TL02')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M04', N'TL03')
INSERT dbo.MovieDetails (IDMovie, IDCategory) VALUES (N'M04', N'TL05')

INSERT dbo.FormatDetails (IDFormat, IDMovie, IDMovieFormat) VALUES (N'FD01', N'M01', N'DD01')
INSERT dbo.FormatDetails (IDFormat, IDMovie, IDMovieFormat) VALUES (N'FD02', N'M01', N'DD03')
INSERT dbo.FormatDetails (IDFormat, IDMovie, IDMovieFormat) VALUES (N'FD03', N'M02', N'DD01')
INSERT dbo.FormatDetails (IDFormat, IDMovie, IDMovieFormat) VALUES (N'FD04', N'M03', N'DD02')


INSERT DBO.Showtimes (IDShowtimes, ShowTime, IDRoom, IDFormat, Fare, Statues) VALUES (N'LC01', CAST(N'2021-10-21T08:50:00.000' AS DateTime), N'R01', N'FD01', 100000.0000, 1)
INSERT DBO.Showtimes (IDShowtimes, ShowTime, IDRoom, IDFormat, Fare, Statues) VALUES (N'LC02', CAST(N'2021-10-22T08:05:00.000' AS DateTime), N'R02', N'FD01', 100000.0000, 0)
INSERT DBO.Showtimes (IDShowtimes, ShowTime, IDRoom, IDFormat, Fare, Statues) VALUES (N'LC03', CAST(N'2021-10-23T08:10:00.000' AS DateTime), N'R03', N'FD02', 100000.0000, 0)
INSERT DBO.Showtimes (IDShowtimes, ShowTime, IDRoom, IDFormat, Fare, Statues) VALUES (N'LC04', CAST(N'2021-10-24T09:20:00.000' AS DateTime), N'R04', N'FD03', 100000.0000, 0)

--SET IDENTITY_INSERT [dbo].Ticket ON
GO


INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES ( 0, N'LC01', N'A1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES ( 0, N'LC01', N'A2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES ( 0, N'LC01', N'A3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES ( 0, N'LC01', N'A4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'A5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'A6', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'A7', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'A8', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B6', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B7', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'B8', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C6', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C7', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'C8', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D6', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D7', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'D8', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'E1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'E2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'E3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (1, N'LC01', N'E4', NULL, 1, 85000.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (1, N'LC01', N'E5', NULL, 1, 85000.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (2, N'LC01', N'E6', NULL, 1, 68000.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (2, N'LC01', N'E7', NULL, 1, 68000.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'E8', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'F1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'F2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'F3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'F4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'F5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (2, N'LC01', N'F6', NULL, 1, 59500.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (2, N'LC01', N'F7', NULL, 1, 68000.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (2, N'LC01', N'F8', NULL, 1, 59500.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'G1', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'G2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'G3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'G4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'G5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (2, N'LC01', N'G6', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (1, N'LC01', N'G7', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'G8', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J1', NULL, 0, 0.0000)
GO
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J2', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J3', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J4', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J5', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J6', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J7', NULL, 0, 0.0000)
INSERT [dbo].Ticket ([LoaiVe], IDShowTimes, [MaGheNgoi], IDClient, [TrangThai], [TienBanVe]) VALUES (0, N'LC01', N'J8', NULL, 0, 0.0000)
--SET IDENTITY_INSERT dbo.Ticket OFF
GO


select * from ticket
--drop table ticket