CREATE TABLE [dbo].[TblSellLog]
(
	[uzsakymoId] INT IDENTITY (1, 1) NOT NULL,
    [prekesId] INT NOT NULL, 
    [kiekis] INT NOT NULL, 
    [nuolaida] DECIMAL(18, 2) NOT NULL
	PRIMARY KEY CLUSTERED ([uzsakymoId] ASC)
)
