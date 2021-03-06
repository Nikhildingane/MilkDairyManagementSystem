USE [mdmsDB]
GO
/****** Object:  Table [dbo].[Bank_Account_Master]    Script Date: 14-03-2019 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank_Account_Master](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Cust_Id] [numeric](18, 0) NOT NULL,
	[Bank_Name] [nvarchar](100) NOT NULL,
	[Account_No] [numeric](18, 0) NOT NULL,
	[IFSC_Code] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bank_Account_Master] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_Master]    Script Date: 14-03-2019 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Master](
	[Bill_Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Cust_Id] [numeric](18, 0) NOT NULL,
	[From_Date] [date] NOT NULL,
	[To_Date] [date] NOT NULL,
	[Bill_Date] [nchar](10) NULL,
	[Days] [int] NOT NULL,
	[Litter] [int] NOT NULL,
	[Ammount] [numeric](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cattle_Master]    Script Date: 14-03-2019 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cattle_Master](
	[Cattle_Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Fat_Rate] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collection_Master]    Script Date: 14-03-2019 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collection_Master](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Cust_Id] [numeric](18, 0) NOT NULL,
	[Timing] [nvarchar](50) NOT NULL,
	[Litter] [numeric](18, 0) NOT NULL,
	[Fat] [numeric](18, 0) NOT NULL,
	[Price] [numeric](18, 0) NOT NULL,
	[Collection_Date] [date] NOT NULL,
	[Status] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Master]    Script Date: 14-03-2019 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Master](
	[Cust_Id] [numeric](18, 0) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Contact_No] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Cattle] [int] NOT NULL,
	[Payment_Mode] [varchar](30) NOT NULL,
	[Reg_Date] [date] NOT NULL,
 CONSTRAINT [PK_Customer_Master] PRIMARY KEY CLUSTERED 
(
	[Cust_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14-03-2019 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[PWord] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bank_Account_Master] ON 

INSERT [dbo].[Bank_Account_Master] ([ID], [Cust_Id], [Bank_Name], [Account_No], [IFSC_Code]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'Bank of India', CAST(243478637467823 AS Numeric(18, 0)), N'BKID24347')
INSERT [dbo].[Bank_Account_Master] ([ID], [Cust_Id], [Bank_Name], [Account_No], [IFSC_Code]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'HDFC Bank', CAST(24778347283 AS Numeric(18, 0)), N'asdf432434')
SET IDENTITY_INSERT [dbo].[Bank_Account_Master] OFF
SET IDENTITY_INSERT [dbo].[Bill_Master] ON 

INSERT [dbo].[Bill_Master] ([Bill_Id], [Cust_Id], [From_Date], [To_Date], [Bill_Date], [Days], [Litter], [Ammount]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14' AS Date), CAST(N'2019-03-14' AS Date), NULL, 1, 4, CAST(120 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Bill_Master] OFF
INSERT [dbo].[Cattle_Master] ([Cattle_Id], [Name], [Fat_Rate]) VALUES (0, N'Buffalow', CAST(6 AS Numeric(18, 0)))
INSERT [dbo].[Cattle_Master] ([Cattle_Id], [Name], [Fat_Rate]) VALUES (1, N'Cow', CAST(4 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Collection_Master] ON 

INSERT [dbo].[Collection_Master] ([Id], [Cust_Id], [Timing], [Litter], [Fat], [Price], [Collection_Date], [Status]) VALUES (CAST(55 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Evening', CAST(4 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(120 AS Numeric(18, 0)), CAST(N'2019-03-14' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Collection_Master] OFF
INSERT [dbo].[Customer_Master] ([Cust_Id], [First_Name], [Surname], [Contact_No], [Address], [Cattle], [Payment_Mode], [Reg_Date]) VALUES (CAST(1 AS Numeric(18, 0)), N'sangram', N'patil', N'9746346736', N'dasfdasf', 0, N'Bank', CAST(N'2019-03-14' AS Date))
INSERT [dbo].[Customer_Master] ([Cust_Id], [First_Name], [Surname], [Contact_No], [Address], [Cattle], [Payment_Mode], [Reg_Date]) VALUES (CAST(2 AS Numeric(18, 0)), N'Akash', N'Pol', N'2342738647', N'sfdsfas', 0, N'Cash', CAST(N'2019-03-14' AS Date))
INSERT [dbo].[Customer_Master] ([Cust_Id], [First_Name], [Surname], [Contact_No], [Address], [Cattle], [Payment_Mode], [Reg_Date]) VALUES (CAST(3 AS Numeric(18, 0)), N'rohit', N'kapse', N'6786786435', N'fadsf', 1, N'Bank', CAST(N'2019-03-14' AS Date))
INSERT [dbo].[Customer_Master] ([Cust_Id], [First_Name], [Surname], [Contact_No], [Address], [Cattle], [Payment_Mode], [Reg_Date]) VALUES (CAST(4 AS Numeric(18, 0)), N'nikhil', N'lokare', N'4535345345', N'ajfkladsjlf', 1, N'Cash', CAST(N'2019-03-14' AS Date))
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [First_Name], [Last_Name], [UName], [PWord]) VALUES (3, N'akash', N'pol', N'a', N'a')
INSERT [dbo].[Users] ([Id], [First_Name], [Last_Name], [UName], [PWord]) VALUES (5, N'sangram', N'patil', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
