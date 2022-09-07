CREATE TABLE [dbo].[Users] (
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    [UserGuid] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

CREATE TABLE [dbo].[Categories] (
    [Id]   INT   NOT NULL,
    [Name] NTEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[MovieStatus]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NTEXT NOT NULL
);

CREATE TABLE [dbo].[Movies] (
    [Id]          INT   NOT NULL,
    [Title]       NTEXT NOT NULL,
    [Description] NTEXT NULL,
    [Status]      INT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Movies_To_MovieStatus] FOREIGN KEY ([Status]) REFERENCES [dbo].[MovieStatus] ([Id])
);

CREATE TABLE [dbo].[Reviews] (
    [Id]      INT        NOT NULL,
    [Score]   FLOAT (53) NOT NULL,
    [Comment] NTEXT      NULL,
    [MovieId] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reviews_To_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

CREATE TABLE [dbo].[UserMovies] (
    [Username] NVARCHAR (50) NOT NULL,
    [MovieId]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC, [Username] ASC),
    CONSTRAINT [FK_UserMovies_To_Users] FOREIGN KEY ([Username]) REFERENCES [dbo].[Users] ([Username]),
    CONSTRAINT [FK_UserMovies_To_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

CREATE TABLE [dbo].[MoviesByCategory] (
    [MovieId]    INT NOT NULL,
    [CategoryId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC, [CategoryId] ASC),
    CONSTRAINT [FK_MoviesByCategory_To_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]),
    CONSTRAINT [FK_MoviesByCategory_To_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);

