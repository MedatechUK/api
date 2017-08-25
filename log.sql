USE [system]
GO
/****** Object:  Table [dbo].[apiLog]    Script Date: 21/08/2017 14:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[apiLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[apiLog](
	[BubbleID] [varchar](64) NOT NULL,
	[logDate] [datetime] NOT NULL CONSTRAINT [DF_apiLog_logDate]  DEFAULT (getdate()),
	[environment] [varchar](50) NOT NULL,
	[method] [nchar](10) NOT NULL,
	[endpoint] [varchar](250) NOT NULL,
	[severity] [int] NOT NULL,
	[logXml] [xml] NULL,
	[logText] [varchar](max) NULL,
	[logYear]  AS (datepart(year,[logDate])),
	[logMonth]  AS (datepart(month,[logDate])),
	[logDay]  AS (datepart(day,[logDate])),
 CONSTRAINT [PK_apiLog] PRIMARY KEY CLUSTERED 
(
	[BubbleID] ASC,
	[logDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
