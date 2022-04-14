USE [ATM]
GO

/****** Object:  Table [dbo].[Cards]    Script Date: 4/14/2022 4:29:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cards](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[CardNumber] [nvarchar](50) NOT NULL,
	[ExpMonth] [int] NOT NULL,
	[ExpYear] [int] NOT NULL,
	[SecurityCode] [int] NOT NULL,
	[Pin] [int] NOT NULL,
	[Balance] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cards] ADD  DEFAULT ((0)) FOR [Balance]
GO

ALTER TABLE [dbo].[Cards]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO

ALTER TABLE [dbo].[Cards]  WITH CHECK ADD CHECK  (([SecurityCode]>=(100)))
GO


