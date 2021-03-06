USE [VehicleInfoApp1]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 10/28/2013 22:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicle](
	[DatabaseId] [int] IDENTITY(1,1) NOT NULL,
	[RegNo] [varchar](50) NOT NULL,
	[EngineNo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[DatabaseId] ASC,
	[RegNo] ASC,
	[EngineNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shift]    Script Date: 10/28/2013 22:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shift](
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Shift] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 10/28/2013 22:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[DatabaseId] [int] IDENTITY(1,1) NOT NULL,
	[VehicleId] [int] NULL,
	[Date] [varchar](50) NULL,
	[Shift] [varchar](50) NULL,
	[BookedBy] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[DatabaseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
