CREATE TABLE [dbo].[tblStorage] (
    [prekesId]          INT             IDENTITY (1, 1) NOT NULL,
    [pavadinimas] VARCHAR (50)    NOT NULL,
    [kaina]       DECIMAL (18, 2) NOT NULL,
    [kiekis]      INT             DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([prekesId] ASC)
);

