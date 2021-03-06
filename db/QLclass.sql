USE [QLclass]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 5/23/2020 11:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[Course_Id] [char](10) NOT NULL,
	[Course_name] [nchar](10) NULL,
	[Is_Base_Course] [bit] NULL,
	[State_Id] [int] NULL,
	[Course_Price] [int] NULL,
	[Course_Start_Day] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Course_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Course_State]    Script Date: 5/23/2020 11:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_State](
	[State_Id] [int] IDENTITY(1,1) NOT NULL,
	[State_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[State_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [State_course] FOREIGN KEY([State_Id])
REFERENCES [dbo].[Course_State] ([State_Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [State_course]
GO
