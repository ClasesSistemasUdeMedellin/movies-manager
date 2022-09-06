CREATE TABLE [dbo].[MoviesByCategory] (
    [MovieId]    INT NOT NULL,
    [CategoryId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC, [CategoryId] ASC),
    CONSTRAINT [FK_MoviesByCategory_To_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]),
    CONSTRAINT [FK_MoviesByCategory_To_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);

