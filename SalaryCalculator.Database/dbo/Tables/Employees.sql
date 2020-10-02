CREATE TABLE [dbo].[Employees]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(125) NOT NULL, 
    [Email] NVARCHAR(125) NOT NULL, 
    [PositionId] UNIQUEIDENTIFIER NOT NULL, 
    [SalaryCategoryId] UNIQUEIDENTIFIER NOT NULL, 
    [ManagerId] UNIQUEIDENTIFIER NULL, 
    [Experience] INT NOT NULL, 
    CONSTRAINT [FK_Employee_Position] FOREIGN KEY ([PositionId]) REFERENCES [Positions]([Id]), 
    CONSTRAINT [FK_Employee_SalaryCategory] FOREIGN KEY ([SalaryCategoryId]) REFERENCES [SalaryCategories]([Id]), 
    CONSTRAINT [FK_Employee_Employee] FOREIGN KEY ([ManagerId]) REFERENCES [Employees]([Id]) 
)
