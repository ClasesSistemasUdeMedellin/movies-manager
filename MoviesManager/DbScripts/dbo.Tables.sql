DROP TABLE IF EXISTS [dbo].[Users]
CREATE TABLE [dbo].[Users] (
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    [UserGuid] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

DROP TABLE IF EXISTS [dbo].[Categories]
CREATE TABLE [dbo].[Categories] (
    [Id]   INT   NOT NULL,
    [Name] NTEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

DROP TABLE IF EXISTS [dbo].[MovieStatus]
CREATE TABLE [dbo].[MovieStatus]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NTEXT NOT NULL
);

DROP TABLE IF EXISTS [dbo].[Movies]
CREATE TABLE [dbo].[Movies] (
    [Id]          INT IDENTITY   NOT NULL,
    [Title]       NTEXT NOT NULL,
    [Description] NTEXT NULL,
    [Status]      INT   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Movies_To_MovieStatus] FOREIGN KEY ([Status]) REFERENCES [dbo].[MovieStatus] ([Id])
);

DROP TABLE IF EXISTS [dbo].[Reviews]
CREATE TABLE [dbo].[Reviews] (
    [Id]      INT IDENTITY  NOT NULL,
    [Score]   FLOAT (53) NOT NULL,
    [Comment] NTEXT      NULL,
    [MovieId] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reviews_To_Movie] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

DROP TABLE IF EXISTS [dbo].[UserMovies]
CREATE TABLE [dbo].[UserMovies] (
    [Username] NVARCHAR (50) NOT NULL,
    [MovieId]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC, [Username] ASC),
    CONSTRAINT [FK_UserMovies_To_Users] FOREIGN KEY ([Username]) REFERENCES [dbo].[Users] ([Username]),
    CONSTRAINT [FK_UserMovies_To_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id])
);

DROP TABLE IF EXISTS [dbo].[MoviesByCategory]
CREATE TABLE [dbo].[MoviesByCategory] (
    [MovieId]    INT NOT NULL,
    [CategoryId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC, [CategoryId] ASC),
    CONSTRAINT [FK_MoviesByCategory_To_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([Id]),
    CONSTRAINT [FK_MoviesByCategory_To_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);

