CREATE TABLE [dbo].[Options] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [PollId]   INT           NOT NULL,
    [OptionNo] INT           DEFAULT ((0)) NOT NULL,
    [Title]    NVARCHAR (50) NOT NULL,
    [Votes]    INT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Options_Polls] FOREIGN KEY ([PollId]) REFERENCES [dbo].[Polls] ([Id]) ON DELETE CASCADE
);