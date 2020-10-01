CREATE TABLE [dbo].[SalaryCategory]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PositionId] UNIQUEIDENTIFIER NOT NULL, 
    [Salary] INT NOT NULL, 
    CONSTRAINT [FK_SalaryCategory_Position] FOREIGN KEY ([PositionId]) REFERENCES [Position]([Id])
)
