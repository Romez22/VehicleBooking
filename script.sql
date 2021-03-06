USE [VehicleService]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 2021/03/09 13:59:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](15) NOT NULL,
	[CustomerNumber] [numeric](18, 0) NOT NULL,
	[VehicleMake] [varchar](10) NOT NULL,
	[VehicleModel] [varchar](10) NOT NULL,
	[VehicleRegistration] [varchar](10) NOT NULL,
	[BookingDate] [date] NOT NULL,
	[BookingNotes] [varchar](25) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([ID], [CustomerName], [CustomerNumber], [VehicleMake], [VehicleModel], [VehicleRegistration], [BookingDate], [BookingNotes]) VALUES (10, N'Romeo', CAST(11 AS Numeric(18, 0)), N'corsa', N'Opel', N'CF', CAST(N'2021-03-01' AS Date), N'Service')
INSERT [dbo].[Bookings] ([ID], [CustomerName], [CustomerNumber], [VehicleMake], [VehicleModel], [VehicleRegistration], [BookingDate], [BookingNotes]) VALUES (11, N'Megan', CAST(11 AS Numeric(18, 0)), N'Astra', N'Opel', N'CF', CAST(N'2021-03-01' AS Date), N'Service')
INSERT [dbo].[Bookings] ([ID], [CustomerName], [CustomerNumber], [VehicleMake], [VehicleModel], [VehicleRegistration], [BookingDate], [BookingNotes]) VALUES (12, N'Liena', CAST(155 AS Numeric(18, 0)), N'Polo', N'VW', N'CY', CAST(N'2021-03-08' AS Date), N'Turbo')
INSERT [dbo].[Bookings] ([ID], [CustomerName], [CustomerNumber], [VehicleMake], [VehicleModel], [VehicleRegistration], [BookingDate], [BookingNotes]) VALUES (13, N'Megan', CAST(11 AS Numeric(18, 0)), N'Astra', N'Opel', N'CF', CAST(N'2021-03-01' AS Date), N'Service')
SET IDENTITY_INSERT [dbo].[Bookings] OFF
GO
