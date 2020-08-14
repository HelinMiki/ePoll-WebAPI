CREATE TABLE [dbo].[Polls] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

