CREATE TABLE [dbo].[SatisfactoryScores]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Score] INT NOT NULL, 
    [Year] DATETIME2 NOT NULL, 
    [EmployeeId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_SatisfactoryScores_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([Id])
)
