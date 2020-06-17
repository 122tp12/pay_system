USE [master]
GO

/****** Object:  Database [MiniBank]    Script Date: 15.06.2020 19:20:29 ******/
CREATE DATABASE [MiniBank]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniBank', FILENAME = N'C:\Program Files\MSSQL14.SQLEXPRESS\MSSQL\DATA\MiniBank.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MiniBank_log', FILENAME = N'C:\Program Files\MSSQL14.SQLEXPRESS\MSSQL\DATA\MiniBank_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniBank].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MiniBank] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MiniBank] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MiniBank] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MiniBank] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MiniBank] SET ARITHABORT OFF 
GO

ALTER DATABASE [MiniBank] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MiniBank] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MiniBank] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MiniBank] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MiniBank] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MiniBank] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MiniBank] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MiniBank] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MiniBank] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MiniBank] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MiniBank] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MiniBank] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MiniBank] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MiniBank] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MiniBank] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MiniBank] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MiniBank] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MiniBank] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [MiniBank] SET  MULTI_USER 
GO

ALTER DATABASE [MiniBank] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MiniBank] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MiniBank] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MiniBank] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [MiniBank] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MiniBank] SET QUERY_STORE = OFF
GO

ALTER DATABASE [MiniBank] SET  READ_WRITE 
GO
