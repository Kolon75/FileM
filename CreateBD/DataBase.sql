USE [master]
GO
/****** Object:  Database [FileMeneger]    Script Date: 06.05.2023 23:27:28 ******/
CREATE DATABASE [FileMeneger]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FileMeneger', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FileMeneger.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FileMeneger_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FileMeneger_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FileMeneger] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FileMeneger].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FileMeneger] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FileMeneger] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FileMeneger] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FileMeneger] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FileMeneger] SET ARITHABORT OFF 
GO
ALTER DATABASE [FileMeneger] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FileMeneger] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FileMeneger] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FileMeneger] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FileMeneger] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FileMeneger] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FileMeneger] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FileMeneger] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FileMeneger] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FileMeneger] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FileMeneger] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FileMeneger] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FileMeneger] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FileMeneger] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FileMeneger] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FileMeneger] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FileMeneger] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FileMeneger] SET RECOVERY FULL 
GO
ALTER DATABASE [FileMeneger] SET  MULTI_USER 
GO
ALTER DATABASE [FileMeneger] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FileMeneger] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FileMeneger] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FileMeneger] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FileMeneger] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FileMeneger] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FileMeneger', N'ON'
GO
ALTER DATABASE [FileMeneger] SET QUERY_STORE = OFF
GO
USE [FileMeneger]
GO
/****** Object:  Table [dbo].[FileInfo]    Script Date: 06.05.2023 23:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileInfo](
	[Key] [int] NOT NULL,
	[FileName] [varchar](50) NULL,
	[Link] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [FileMeneger] SET  READ_WRITE 
GO
