USE [master]
GO
/****** Object:  Database [Movies]    Script Date: 2015-03-05 14:24:36 ******/
CREATE DATABASE [Movies]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Movies', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Movies.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Movies_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Movies_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Movies] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Movies].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Movies] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Movies] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Movies] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Movies] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Movies] SET ARITHABORT OFF 
GO
ALTER DATABASE [Movies] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Movies] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Movies] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Movies] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Movies] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Movies] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Movies] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Movies] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Movies] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Movies] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Movies] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Movies] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Movies] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Movies] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Movies] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Movies] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Movies] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Movies] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Movies] SET RECOVERY FULL 
GO
ALTER DATABASE [Movies] SET  MULTI_USER 
GO
ALTER DATABASE [Movies] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Movies] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Movies] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Movies] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Movies', N'ON'
GO
USE [Movies]
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteMovie]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteMovie] @MovieID int
AS
BEGIN
SET NOCOUNT ON
IF EXISTS(SELECT * FROM Movies WHERE MovieID=@MovieID)
	BEGIN
		UPDATE MovieStatus
		SET [Status]= 0, Price = 0
		WHERE MovieID = @MovieID
		SELECT 1
	END
ELSE
	BEGIN
		SELECT 0
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertMovie]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[usp_InsertMovie]
@Title nchar(30), @Director nchar(30), @Year int, @Length int,
@Genre nchar(10), @Status smallint, @Price int
AS
BEGIN
SET NOCOUNT ON
DECLARE @MovieID int
INSERT INTO Movies([Title], [Director], [Year], [Length(Min)], [Genre])
VALUES(@Title, @Director, @Year, @Length, @Genre)
SET @MovieID = SCOPE_IDENTITY()
INSERT INTO MovieStatus(MovieID, [Status], Price)
VALUES (@MovieID, @Status, @Price)
END

GO
/****** Object:  StoredProcedure [dbo].[usp_ReadMovie]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ReadMovie] @Title nvarchar (50)
AS
BEGIN
SET NOCOUNT ON
SELECT [M].[MovieID],[Title],[Director],[Year],[Length(Min)],[Genre],[Status],[Price] 
FROM [Movies] AS M INNER JOIN [MovieStatus] AS MS 
ON M.MovieID = MS.MovieID
WHERE Title LIKE '%' + @Title + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdatePrice]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdatePrice]
	(
		@MovieID AS int,
		@Price AS smallint
	)
AS
BEGIN
	SET NOCOUNT ON
	IF EXISTS(SELECT * FROM Movies WHERE MovieID=@MovieID)
		BEGIN
			UPDATE MovieStatus
			SET
				[Price] = @Price
			FROM MovieStatus
			WHERE 
				MovieID = @MovieID
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateStatus]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateStatus]
	(
		@MovieID AS int,
		@Status AS smallint
	)
AS
BEGIN
	SET NOCOUNT ON
	IF EXISTS(SELECT * FROM Movies WHERE MovieID=@MovieID)
		BEGIN
			UPDATE MovieStatus
			SET
				[Status] = @Status
			FROM MovieStatus
			WHERE 
				MovieID = @MovieID
				SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END
END
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Director] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[Length(Min)] [int] NOT NULL,
	[Genre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MovieStatus]    Script Date: 2015-03-05 14:24:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieStatus](
	[MovieID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_MovieStatus] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[MovieStatus]  WITH CHECK ADD  CONSTRAINT [FK_MovieStatus_Movies] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[MovieStatus] CHECK CONSTRAINT [FK_MovieStatus_Movies]
GO
USE [master]
GO
ALTER DATABASE [Movies] SET  READ_WRITE 
GO
