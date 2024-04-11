CREATE TABLE [dbo].[StudentPredmet]
(
	[IdStudent] INT NOT NULL, 
    [ZkratkaPredmet] NVARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_StudentPredmet_ToTable] FOREIGN KEY ([IdStudent]) REFERENCES [Student]([Id]), 
    CONSTRAINT [FK_StudentPredmet_ToTable_1] FOREIGN KEY ([ZkratkaPredmet]) REFERENCES [Predmet]([Zkratka]),
	PRIMARY KEY CLUSTERED ([IdStudent],[ZkratkaPredmet])
)
