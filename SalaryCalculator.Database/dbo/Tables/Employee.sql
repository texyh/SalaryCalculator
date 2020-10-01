CREATE TABLE [dbo].[Employee]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(125) NOT NULL, 
    [Email] NVARCHAR(125) NOT NULL, 
    [PositionId] UNIQUEIDENTIFIER NOT NULL, 
    [Salary] BIGINT NOT NULL, 
    [SalaryCategoryId] UNIQUEIDENTIFIER NOT NULL, 
    [ManagerId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_Employee_Position] FOREIGN KEY ([PositionId]) REFERENCES [Position]([Id]), 
    CONSTRAINT [FK_Employee_SalaryCategory] FOREIGN KEY ([SalaryCategoryId]) REFERENCES [SalaryCategory]([Id]), 
    CONSTRAINT [FK_Employee_Employee] FOREIGN KEY ([ManagerId]) REFERENCES [Employee]([Id]) 
)
