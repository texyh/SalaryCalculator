CREATE TABLE [dbo].[SalaryCategories]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PositionId] UNIQUEIDENTIFIER NOT NULL, 
    [Salary] INT NOT NULL, 
    [YearsRange] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_SalaryCategory_Position] FOREIGN KEY ([PositionId]) REFERENCES [Positions]([Id])
)
