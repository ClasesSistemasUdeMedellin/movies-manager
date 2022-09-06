CREATE TABLE [dbo].[UserMovies] (
    [Username] NVARCHAR (50) NOT NULL,
    [MovieId]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC, [Username] ASC),
    CONSTRAINT [FK_UserMovies_To_Users] FOREIGN KEY ([Username]) REFERENCES [dbo].[Users] ([Username]),
    CONSTRAINT [FK_UserMovies_To_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

