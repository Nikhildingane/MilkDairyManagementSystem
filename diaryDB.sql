USE [master]
GO

/****** Object:  Database [mdmsDB]    Script Date: 14-03-2019 18:17:50 ******/
CREATE DATABASE [mdmsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mdmsDB', FILENAME = N'C:\Users\NICK\mdmsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mdmsDB_log', FILENAME = N'C:\Users\NICK\mdmsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [mdmsDB] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mdmsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [mdmsDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [mdmsDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [mdmsDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [mdmsDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [mdmsDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [mdmsDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [mdmsDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [mdmsDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [mdmsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [mdmsDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [mdmsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [mdmsDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [mdmsDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [mdmsDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [mdmsDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [mdmsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [mdmsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [mdmsDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [mdmsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [mdmsDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [mdmsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [mdmsDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [mdmsDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [mdmsDB] SET  MULTI_USER 
GO

ALTER DATABASE [mdmsDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [mdmsDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [mdmsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [mdmsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [mdmsDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [mdmsDB] SET QUERY_STORE = OFF
GO

USE [mdmsDB]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [mdmsDB] SET  READ_WRITE 
GO


