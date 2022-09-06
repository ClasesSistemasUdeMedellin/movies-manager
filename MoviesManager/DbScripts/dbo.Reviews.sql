CREATE TABLE [dbo].[Reviews] (
    [Id]      INT        NOT NULL,
    [Score]   FLOAT (53) NOT NULL,
    [Comment] NTEXT      NULL,
    [MovieId] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reviews_To_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

