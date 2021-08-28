CREATE DATABASE [DBExam]
GO
USE [DBExam]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, 1, CAST(N'2021-08-27T10:55:03.253' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, 1, CAST(N'2021-08-26T10:56:06.320' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (3, 1, CAST(N'2021-08-26T10:58:11.313' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, 1, CAST(N'2021-08-27T10:59:23.690' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, 1, CAST(N'2021-08-27T11:50:04.550' AS DateTime), CAST(N'2021-08-27T12:14:04.967' AS DateTime), 0)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (6, 1, CAST(N'2021-08-27T11:58:16.100' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (7, 1, CAST(N'2021-08-27T11:59:18.893' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (8, 2, CAST(N'2021-08-26T12:00:28.807' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (9, 2, CAST(N'2021-08-27T12:05:55.570' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Ticket] ([Id], [UserId], [CreatedDate], [UpdatedDate], [Status]) VALUES (12, 1, CAST(N'2021-08-27T12:17:25.553' AS DateTime), NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [Name], [LastName], [Email], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, N'Alan', N'Rios', N'alanrb92@gmail.com', CAST(N'2021-08-25T00:00:00.000' AS DateTime), NULL, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [LastName], [Email], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, N'Juan', N'Perez', N'jperez@gmail.com', CAST(N'2021-08-25T00:00:00.000' AS DateTime), NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_User]
