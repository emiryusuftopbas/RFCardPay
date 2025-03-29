USE [master]
GO
/****** Object:  Database [RFCardPay]    Script Date: 4/23/2023 7:06:35 PM ******/
CREATE DATABASE [RFCardPay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RFCardPay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RFCardPay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RFCardPay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RFCardPay_0.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RFCardPay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RFCardPay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RFCardPay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RFCardPay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RFCardPay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RFCardPay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RFCardPay] SET ARITHABORT OFF 
GO
ALTER DATABASE [RFCardPay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RFCardPay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RFCardPay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RFCardPay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RFCardPay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RFCardPay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RFCardPay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RFCardPay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RFCardPay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RFCardPay] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RFCardPay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RFCardPay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RFCardPay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RFCardPay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RFCardPay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RFCardPay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RFCardPay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RFCardPay] SET RECOVERY FULL 
GO
ALTER DATABASE [RFCardPay] SET  MULTI_USER 
GO
ALTER DATABASE [RFCardPay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RFCardPay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RFCardPay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RFCardPay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RFCardPay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RFCardPay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RFCardPay', N'ON'
GO
ALTER DATABASE [RFCardPay] SET QUERY_STORE = OFF
GO
USE [RFCardPay]
GO
/****** Object:  Table [dbo].[Cards]    Script Date: 4/23/2023 7:06:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cards](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[NameSurname] [varchar](60) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Balance] [float] NOT NULL,
	[CardID] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operations]    Script Date: 4/23/2023 7:06:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operations](
	[OperationID] [int] IDENTITY(1,1) NOT NULL,
	[CardID] [varchar](11) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Amount] [float] NOT NULL,
	[ProductID] [int] NULL,
	[OperationTime] [datetime] NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[OperationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 4/23/2023 7:06:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Operations] ADD  CONSTRAINT [DF_Operations_OperationTime]  DEFAULT (getdate()) FOR [OperationTime]
GO
/****** Object:  StoredProcedure [dbo].[SP_CleanTables]    Script Date: 4/23/2023 7:06:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CleanTables]  
AS   
BEGIN   
 DELETE FROM Operations;  
 DELETE FROM Cards;  
 DELETE FROM Products;  
END   
GO
USE [master]
GO
ALTER DATABASE [RFCardPay] SET  READ_WRITE 
GO
