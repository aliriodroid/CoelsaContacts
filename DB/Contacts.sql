CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](100) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[PhoneNumber] [nchar](50) NOT NULL
) ON [PRIMARY]
GO


