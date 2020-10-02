/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


:r ".\PostDeployment\000_Positions.sql"
:r ".\PostDeployment\001_SalaryCategories.sql"
:r ".\PostDeployment\002_Employees.sql"
:r ".\PostDeployment\003_SatisfactoryScores.sql"