CREATE TABLE [dbo].[Hodnoceni]
(
    [IdStudent] INT NOT NULL, 
    [ZkratkaPredmet] NVARCHAR(10) NOT NULL, 
    [Datum] DATE NOT NULL, 
   	[Znamka] FLOAT NOT NULL, 
    --CONSTRAINT [FK_Hodnoceni_ToTable] FOREIGN KEY ([IdStudent],[ZkratkaPredmet]) REFERENCES [StudentPredmet]([IdStudent],[ZkratkaPredmet])
	--plus nejaku primary key
    PRIMARY KEY CLUSTERED ([IdStudent] ASC, [ZkratkaPredmet] ASC),
	CONSTRAINT [FK_Hodnoceni_Student] FOREIGN KEY ([IdStudent]) REFERENCES [Student]([Id]), 
    CONSTRAINT [FK_Hodnoceni_Predmet] FOREIGN KEY ([ZkratkaPredmet]) REFERENCES [Predmet]([Zkratka])
	--PRIMARY KEY CLUSTERED ([IdStudent],[ZkratkaPredmet])
)
