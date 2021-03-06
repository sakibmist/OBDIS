USE [master]
GO
/****** Object:  Database [OBDIS_db]    Script Date: 11/19/2017 12:04:24 PM ******/
CREATE DATABASE [OBDIS_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OBDIS_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\OBDIS_db.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OBDIS_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\OBDIS_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OBDIS_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OBDIS_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OBDIS_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OBDIS_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OBDIS_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OBDIS_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OBDIS_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [OBDIS_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OBDIS_db] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [OBDIS_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OBDIS_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OBDIS_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OBDIS_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OBDIS_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OBDIS_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OBDIS_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OBDIS_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OBDIS_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OBDIS_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OBDIS_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OBDIS_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OBDIS_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OBDIS_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OBDIS_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OBDIS_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OBDIS_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OBDIS_db] SET  MULTI_USER 
GO
ALTER DATABASE [OBDIS_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OBDIS_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OBDIS_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OBDIS_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [OBDIS_db]
GO
/****** Object:  Table [dbo].[AdminInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdminInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [varchar](50) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Photo] [image] NOT NULL,
	[Email] [varchar](60) NOT NULL,
	[AdminId] [varchar](50) NOT NULL,
	[Passwords] [varchar](32) NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_AdminInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BldOrganizationInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BldOrganizationInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrganizationName] [varchar](50) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[Mobile] [varchar](60) NOT NULL,
	[Email] [varchar](60) NULL,
	[DivisionInfoId] [int] NOT NULL,
	[DistrictInfoId] [int] NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_BldOrganizationInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BloodInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BloodInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BloodGroupName] [varchar](5) NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_BloodInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DistrictInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DistrictInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DistrictName] [varchar](50) NOT NULL,
	[DivisionInfoId] [int] NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_DistrictInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DivisionInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DivisionInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DivisionName] [varchar](50) NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_DivisionInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonorInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonorInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DonorName] [varchar](50) NOT NULL,
	[DonorType] [int] NOT NULL,
	[FatherName] [varchar](50) NOT NULL,
	[MotherName] [varchar](50) NOT NULL,
	[BloodInfoId] [int] NOT NULL,
	[Gender] [int] NOT NULL,
	[Dob] [date] NOT NULL,
	[Mobile] [varchar](15) NOT NULL,
	[AlterMobile] [varchar](15) NULL,
	[Email] [varchar](60) NOT NULL,
	[DivisionInfoId] [int] NOT NULL,
	[DistrictInfoId] [int] NOT NULL,
	[SubDistrictInfoId] [int] NOT NULL,
	[City] [varchar](50) NOT NULL,
	[DonorUserId] [varchar](50) NOT NULL,
	[DonorPassword] [varchar](32) NOT NULL,
	[AbilityToDonate] [int] NOT NULL,
 CONSTRAINT [PK_DonorInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubDistrictInfo]    Script Date: 11/19/2017 12:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubDistrictInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubDistrictName] [varchar](50) NOT NULL,
	[DistrictInfoId] [int] NOT NULL,
	[CreatedAt] [date] NOT NULL,
 CONSTRAINT [PK_SubDistrictInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[AdminInfo] ON 

INSERT [dbo].[AdminInfo] ([Id], [AdminName], [Designation], [Photo], [Email], [AdminId], [Passwords], [CreatedAt]) VALUES (1, N'sak', N'Admin', 0x7E2F496D616765426F782F53616B69622050502E6A7067, N's@gmail.com', N'sa', N'123', CAST(0x7F3D0B00 AS Date))
INSERT [dbo].[AdminInfo] ([Id], [AdminName], [Designation], [Photo], [Email], [AdminId], [Passwords], [CreatedAt]) VALUES (2, N'sal', N'drt', 0x7E2F496D616765426F782F62696261686F486F6C6F666E616D612E504E47, N's@gmail.com', N'st', N'014', CAST(0x803D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[AdminInfo] OFF
SET IDENTITY_INSERT [dbo].[BldOrganizationInfo] ON 

INSERT [dbo].[BldOrganizationInfo] ([Id], [OrganizationName], [Address], [Mobile], [Email], [DivisionInfoId], [DistrictInfoId], [CreatedAt]) VALUES (1, N'BADHAN', N'TSC(Ground Floor), D/U, Dhaka.', N'+880-2-8629042', N'central@badhan.org', 2010, 1004, CAST(0x883D0B00 AS Date))
INSERT [dbo].[BldOrganizationInfo] ([Id], [OrganizationName], [Address], [Mobile], [Email], [DivisionInfoId], [DistrictInfoId], [CreatedAt]) VALUES (2, N'BANGLADESH RED CRESCENT BLOOD BANK', N'7/5, Aurongzeb Road, Mohammadpur, Dhaka.', N'+880-02-8121497, +880-02-9116563', N'', 2019, 1006, CAST(0x883D0B00 AS Date))
INSERT [dbo].[BldOrganizationInfo] ([Id], [OrganizationName], [Address], [Mobile], [Email], [DivisionInfoId], [DistrictInfoId], [CreatedAt]) VALUES (1002, N'FATEMA BEGUM RED CRESCENT BLOOD CENTRE', N'395, Anderkilla, Chittagong.', N'031 620685, 612395, 620926', N'', 2011, 3006, CAST(0x893D0B00 AS Date))
INSERT [dbo].[BldOrganizationInfo] ([Id], [OrganizationName], [Address], [Mobile], [Email], [DivisionInfoId], [DistrictInfoId], [CreatedAt]) VALUES (1003, N'Modern Clinic & Blood Center', N'House 5, Road-11, Gulshan-1', N'+880-2- 9883948', N'', 2010, 3005, CAST(0x893D0B00 AS Date))
INSERT [dbo].[BldOrganizationInfo] ([Id], [OrganizationName], [Address], [Mobile], [Email], [DivisionInfoId], [DistrictInfoId], [CreatedAt]) VALUES (1004, N'BADHAN', N'TSC(Ground Floor), D/U', N'+880-2-8629042', N'central@badhan.org', 2010, 3005, CAST(0x893D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[BldOrganizationInfo] OFF
SET IDENTITY_INSERT [dbo].[BloodInfo] ON 

INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3051, N'O+', CAST(0x863D0B00 AS Date))
INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3052, N'O-', CAST(0x863D0B00 AS Date))
INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3053, N'A+', CAST(0x863D0B00 AS Date))
INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3054, N'A-', CAST(0x863D0B00 AS Date))
INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3056, N'AB-', CAST(0x863D0B00 AS Date))
INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3057, N'B+', CAST(0x863D0B00 AS Date))
INSERT [dbo].[BloodInfo] ([Id], [BloodGroupName], [CreatedAt]) VALUES (3059, N'AB+', CAST(0x883D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[BloodInfo] OFF
SET IDENTITY_INSERT [dbo].[DistrictInfo] ON 

INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (1004, N'Gazipur', 2010, CAST(0x843D0B00 AS Date))
INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (1006, N'Sylhet', 2019, CAST(0x843D0B00 AS Date))
INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (2004, N'Jamalpur', 4005, CAST(0x883D0B00 AS Date))
INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (3004, N'Narsingdi', 2010, CAST(0x893D0B00 AS Date))
INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (3005, N'Dhaka', 2010, CAST(0x893D0B00 AS Date))
INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (3006, N'Chittagong', 2011, CAST(0x893D0B00 AS Date))
INSERT [dbo].[DistrictInfo] ([Id], [DistrictName], [DivisionInfoId], [CreatedAt]) VALUES (3007, N'Dinajpur', 5005, CAST(0x893D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[DistrictInfo] OFF
SET IDENTITY_INSERT [dbo].[DivisionInfo] ON 

INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (2010, N'Dhaka', CAST(0x843D0B00 AS Date))
INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (2011, N'Chittagong', CAST(0x843D0B00 AS Date))
INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (2019, N'Sylhet', CAST(0x843D0B00 AS Date))
INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (3005, N'Barisal', CAST(0x863D0B00 AS Date))
INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (4005, N'Mymensingh', CAST(0x883D0B00 AS Date))
INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (5005, N'Rangpur', CAST(0x893D0B00 AS Date))
INSERT [dbo].[DivisionInfo] ([Id], [DivisionName], [CreatedAt]) VALUES (5006, N'Rajshahi', CAST(0x893D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[DivisionInfo] OFF
SET IDENTITY_INSERT [dbo].[DonorInfo] ON 

INSERT [dbo].[DonorInfo] ([Id], [DonorName], [DonorType], [FatherName], [MotherName], [BloodInfoId], [Gender], [Dob], [Mobile], [AlterMobile], [Email], [DivisionInfoId], [DistrictInfoId], [SubDistrictInfoId], [City], [DonorUserId], [DonorPassword], [AbilityToDonate]) VALUES (1, N's', 1, N'g', N'f', 3051, 1, CAST(0x893D0B00 AS Date), N'01982879339', N'', N's@gmail.com', 2019, 1006, 2002, N'kaligonj', N'sakib', N'123456', 123456)
INSERT [dbo].[DonorInfo] ([Id], [DonorName], [DonorType], [FatherName], [MotherName], [BloodInfoId], [Gender], [Dob], [Mobile], [AlterMobile], [Email], [DivisionInfoId], [DistrictInfoId], [SubDistrictInfoId], [City], [DonorUserId], [DonorPassword], [AbilityToDonate]) VALUES (2, N'Md. Rakib Mia', 1, N'Md. Rauf Mia', N'Miss. Rahima Begum', 3053, 1, CAST(0x863D0B00 AS Date), N'01968279336', N'', N'sa@gmail.com', 4005, 2004, 2005, N'Shibpur', N'user', N'12345', 12345)
SET IDENTITY_INSERT [dbo].[DonorInfo] OFF
SET IDENTITY_INSERT [dbo].[SubDistrictInfo] ON 

INSERT [dbo].[SubDistrictInfo] ([Id], [SubDistrictName], [DistrictInfoId], [CreatedAt]) VALUES (2002, N'Biswanath', 1006, CAST(0x863D0B00 AS Date))
INSERT [dbo].[SubDistrictInfo] ([Id], [SubDistrictName], [DistrictInfoId], [CreatedAt]) VALUES (2003, N'Kapasia', 1004, CAST(0x863D0B00 AS Date))
INSERT [dbo].[SubDistrictInfo] ([Id], [SubDistrictName], [DistrictInfoId], [CreatedAt]) VALUES (2004, N'Khaliakoir', 1004, CAST(0x863D0B00 AS Date))
INSERT [dbo].[SubDistrictInfo] ([Id], [SubDistrictName], [DistrictInfoId], [CreatedAt]) VALUES (2005, N'Melandha', 2004, CAST(0x883D0B00 AS Date))
INSERT [dbo].[SubDistrictInfo] ([Id], [SubDistrictName], [DistrictInfoId], [CreatedAt]) VALUES (3005, N'Shibpur', 3004, CAST(0x893D0B00 AS Date))
INSERT [dbo].[SubDistrictInfo] ([Id], [SubDistrictName], [DistrictInfoId], [CreatedAt]) VALUES (3006, N'Belabo', 3004, CAST(0x893D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[SubDistrictInfo] OFF
ALTER TABLE [dbo].[BldOrganizationInfo]  WITH CHECK ADD  CONSTRAINT [FK_BldOrganizationInfo_DistrictInfo] FOREIGN KEY([DistrictInfoId])
REFERENCES [dbo].[DistrictInfo] ([Id])
GO
ALTER TABLE [dbo].[BldOrganizationInfo] CHECK CONSTRAINT [FK_BldOrganizationInfo_DistrictInfo]
GO
ALTER TABLE [dbo].[BldOrganizationInfo]  WITH CHECK ADD  CONSTRAINT [FK_BldOrganizationInfo_DivisionInfo] FOREIGN KEY([DivisionInfoId])
REFERENCES [dbo].[DivisionInfo] ([Id])
GO
ALTER TABLE [dbo].[BldOrganizationInfo] CHECK CONSTRAINT [FK_BldOrganizationInfo_DivisionInfo]
GO
ALTER TABLE [dbo].[DistrictInfo]  WITH CHECK ADD  CONSTRAINT [FK_DistrictInfo_DivisionInfo] FOREIGN KEY([DivisionInfoId])
REFERENCES [dbo].[DivisionInfo] ([Id])
GO
ALTER TABLE [dbo].[DistrictInfo] CHECK CONSTRAINT [FK_DistrictInfo_DivisionInfo]
GO
ALTER TABLE [dbo].[DonorInfo]  WITH CHECK ADD  CONSTRAINT [FK_DonorInfo_BloodInfo] FOREIGN KEY([BloodInfoId])
REFERENCES [dbo].[BloodInfo] ([Id])
GO
ALTER TABLE [dbo].[DonorInfo] CHECK CONSTRAINT [FK_DonorInfo_BloodInfo]
GO
ALTER TABLE [dbo].[DonorInfo]  WITH CHECK ADD  CONSTRAINT [FK_DonorInfo_DistrictInfo] FOREIGN KEY([DistrictInfoId])
REFERENCES [dbo].[DistrictInfo] ([Id])
GO
ALTER TABLE [dbo].[DonorInfo] CHECK CONSTRAINT [FK_DonorInfo_DistrictInfo]
GO
ALTER TABLE [dbo].[DonorInfo]  WITH CHECK ADD  CONSTRAINT [FK_DonorInfo_DivisionInfo] FOREIGN KEY([DivisionInfoId])
REFERENCES [dbo].[DivisionInfo] ([Id])
GO
ALTER TABLE [dbo].[DonorInfo] CHECK CONSTRAINT [FK_DonorInfo_DivisionInfo]
GO
ALTER TABLE [dbo].[DonorInfo]  WITH CHECK ADD  CONSTRAINT [FK_DonorInfo_SubDistrictInfo] FOREIGN KEY([SubDistrictInfoId])
REFERENCES [dbo].[SubDistrictInfo] ([Id])
GO
ALTER TABLE [dbo].[DonorInfo] CHECK CONSTRAINT [FK_DonorInfo_SubDistrictInfo]
GO
ALTER TABLE [dbo].[SubDistrictInfo]  WITH CHECK ADD  CONSTRAINT [FK_SubDistrictInfo_DistrictInfo] FOREIGN KEY([DistrictInfoId])
REFERENCES [dbo].[DistrictInfo] ([Id])
GO
ALTER TABLE [dbo].[SubDistrictInfo] CHECK CONSTRAINT [FK_SubDistrictInfo_DistrictInfo]
GO
USE [master]
GO
ALTER DATABASE [OBDIS_db] SET  READ_WRITE 
GO
