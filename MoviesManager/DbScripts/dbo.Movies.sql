CREATE TABLE [dbo].[Movies] (
    [Id]          INT   NOT NULL,
    [Title]       NTEXT NOT NULL,
    [Description] NTEXT NULL,
    [Status]      INT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Movies_To_MovieStatus] FOREIGN KEY ([Status]) REFERENCES [dbo].[MovieStatus] ([Id])
);

