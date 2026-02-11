USE [master]
GO
/****** Object:  Database [MasterDetails]    Script Date: 11.02.2026 10:26:11 ******/
CREATE DATABASE [MasterDetails1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MasterDetails1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\MasterDetails1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MasterDetails1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\MasterDetails1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MasterDetails1] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasterDetails1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasterDetails1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasterDetails1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasterDetails1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasterDetails1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasterDetails1] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasterDetails1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasterDetails1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasterDetails1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasterDetails1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasterDetails1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasterDetails1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasterDetails1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasterDetails1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasterDetails1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasterDetails1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasterDetails1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasterDetails1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasterDetails1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasterDetails1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasterDetails1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasterDetails1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasterDetails1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasterDetails1] SET RECOVERY FULL 
GO
ALTER DATABASE [MasterDetails1] SET  MULTI_USER 
GO
ALTER DATABASE [MasterDetails1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasterDetails1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasterDetails1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasterDetails1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MasterDetails1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MasterDetails1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MasterDetails1] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [MasterDetails1] SET QUERY_STORE = ON
GO
ALTER DATABASE [MasterDetails1] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MasterDetails1]
GO
/****** Object:  Table [dbo].[Masters]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Sum] [decimal](18, 2) NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Masters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MastersView]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MastersView]
AS
SELECT        Id, Number, Date, Sum, Note
FROM            dbo.Masters
GO
/****** Object:  Table [dbo].[Details]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MasterId] [int] NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Sum] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DetailsView]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DetailsView]
AS
SELECT        Id, MasterId AS MasterViewId, Name, Sum
FROM            dbo.Details
GO
/****** Object:  Table [dbo].[Errors]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Errors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[User] [nchar](30) NOT NULL,
	[Error] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Errors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Details]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Masters] FOREIGN KEY([MasterId])
REFERENCES [dbo].[Masters] ([Id])
GO
ALTER TABLE [dbo].[Details] CHECK CONSTRAINT [FK_Detail_Masters]
GO
/****** Object:  StoredProcedure [dbo].[DetailAdd]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetailAdd] 
	@masterId int,
	@name nvarchar(100),
	@sum decimal(18,2),
	@err nvarchar(100) OUTPUT
AS
BEGIN
	SET NOCOUNT OFF;
	IF EXISTS (SELECT Id FROM Details WHERE [Name]=@name)
		BEGIN
		SET @err='Спецификация с таким именем уже существует.'
		EXECUTE ErrorAdd @err;
		RETURN
	END
	BEGIN TRY
		BEGIN TRANSACTION;
			INSERT INTO Details ([MasterId], [Name], [Sum])
				VALUES (@masterId,@name,@sum)
			UPDATE Masters SET Sum = (SELECT Sum(Sum) FROM Details WHERE Details.MasterId=@masterId)  
				WHERE (Id = @masterId)
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION;
		SET @err=ERROR_MESSAGE();
		EXECUTE ErrorAdd @err;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[DetailChange]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetailChange] 
	@Id int,
	@name nvarchar(100),
	@sum decimal(18,2),
	@err nvarchar(100) OUTPUT
AS
BEGIN
	SET NOCOUNT OFF;
	IF EXISTS (SELECT Id FROM Details WHERE [Name]=@name AND Id!=@Id)
		BEGIN
		SET @err='Спецификация с таким именем уже существует.'
		EXECUTE ErrorAdd @err;
		RETURN
	END 
	BEGIN TRY
		BEGIN TRANSACTION;
			DECLARE @masterId int=(SELECT MasterId FROM Details WHERE Id=@Id);
			UPDATE Details SET [Name] =@name, [Sum] =@sum
			WHERE [Id]=@Id

			UPDATE Masters SET Sum = (SELECT Sum(Sum) FROM Details WHERE Details.MasterId=@masterId)  
				WHERE (Id = @masterId)
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION;
		SET @err=ERROR_MESSAGE();
		EXECUTE ErrorAdd @err;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[DetailDelete]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetailDelete] 
	@Id int,
	@err nvarchar(100) OUTPUT
AS
BEGIN
	SET NOCOUNT OFF;
	BEGIN TRY
		BEGIN TRANSACTION;
	
			DECLARE @masterId int=(SELECT MasterId FROM Details WHERE Id=@Id);
			DELETE FROM Details WHERE [Id]=@id
	
			UPDATE Masters SET [Sum] = (SELECT ISNULL(Sum([Sum]),0) FROM Details WHERE Details.MasterId=@masterId)  
				WHERE (Id = @masterId)
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
	IF @@TRANCOUNT>0
			ROLLBACK TRANSACTION;
		SET @err=ERROR_MESSAGE();
		EXECUTE ErrorAdd @err;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[ErrorAdd]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ErrorAdd] 
	@err nvarchar(100) 
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO Errors ([Date],[User],[Error]) VALUES (GETDATE(),ORIGINAL_LOGIN(),@err)
END
GO
/****** Object:  StoredProcedure [dbo].[MasterAdd]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MasterAdd] 
	@number nvarchar(50), 
	@date Date,
	@note nvarchar(100)=null,
	@err nvarchar(100) OUTPUT
AS
BEGIN
	SET NOCOUNT OFF;
	BEGIN TRY
		IF EXISTS (SELECT Id FROM Masters WHERE [Number]=@number)
		BEGIN
			SET @err='Документ с таким именем уже существует.'
			EXECUTE ErrorAdd @err;
			RETURN
		END 
		INSERT INTO Masters ([Number], [Date], [Sum], [Note])
			VALUES        (@number,@date,0,@note)
	END TRY
	BEGIN CATCH
		SET @err=ERROR_MESSAGE();
		EXECUTE ErrorAdd @err;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MasterChange]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MasterChange]
	@id int,
	@number nvarchar(50), 
	@date Date,
	@note nvarchar(100)=null,
	@err nvarchar(100) OUTPUT
AS
BEGIN
	SET NOCOUNT OFF;
	IF EXISTS (SELECT Id FROM Masters WHERE [Number]=@number AND Id!=@id)
		BEGIN
		SET @err='Документ с таким именем уже существует.'
		EXECUTE ErrorAdd @err;
		RETURN
	END 
	BEGIN TRY
	UPDATE  Masters SET Number =@number, Date =@date, Note =@note WHERE Id=@id
	END TRY
	BEGIN CATCH
		SET @err=ERROR_MESSAGE();
		EXECUTE ErrorAdd @err;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[MasterDelete]    Script Date: 11.02.2026 10:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MasterDelete] 
	@id int,
	@err nvarchar(100) OUTPUT
AS
BEGIN
	SET NOCOUNT OFF;
	BEGIN TRY
		DELETE FROM Masters WHERE Id=@id
	END TRY
	BEGIN CATCH
		SET @err=ERROR_MESSAGE();
		EXECUTE ErrorAdd @err;
	END CATCH
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Errors', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата и веремя ошибки' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Errors', @level2type=N'COLUMN',@level2name=N'Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Пользователь ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Errors', @level2type=N'COLUMN',@level2name=N'User'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Текст ошибки' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Errors', @level2type=N'COLUMN',@level2name=N'Error'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DetailsView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MastersView'
GO
USE [master]
GO
ALTER DATABASE [MasterDetails1] SET  READ_WRITE 
GO
