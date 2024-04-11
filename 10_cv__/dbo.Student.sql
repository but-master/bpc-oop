CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Jmeno] NVARCHAR(50) NOT NULL, 
    [Prijmeni] NVARCHAR(50) NOT NULL, 
    [DatumNarozeni] DATE NOT NULL
)
