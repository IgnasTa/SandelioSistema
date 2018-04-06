CREATE TABLE [dbo].[tblLogin] (
    [userId]       INT          IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NOT NULL,
    [level]    INT          DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([userId] ASC)
);

