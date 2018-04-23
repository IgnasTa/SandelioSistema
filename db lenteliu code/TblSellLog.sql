CREATE TABLE [dbo].[tblSellLog] (
    [prekesId]   INT             NOT NULL,
    [kiekis]     INT             NOT NULL,
    [nuolaida]   DECIMAL (18, 2) NOT NULL,
    [suma]       DECIMAL (18, 2) NOT NULL,
    [data] DATETIME NOT NULL DEFAULT CONVERT(VARCHAR(20), GETDATE(), 100) 
);

