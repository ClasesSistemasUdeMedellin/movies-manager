CREATE TABLE [dbo].[Users] (
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

