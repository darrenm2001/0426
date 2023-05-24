CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [Number] NCHAR(10) NOT NULL, 
    [Email] NCHAR(50) NOT NULL
)
