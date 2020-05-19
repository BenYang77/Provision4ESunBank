CREATE TABLE [dbo].[PersonalInfo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [security_id] NVARCHAR(50) NOT NULL, 
    [name] NVARCHAR(50) NOT NULL, 
    [birthdate] DATE NOT NULL, 
    [add_date] DATETIME NOT NULL DEFAULT getdate(), 
    [upd_date] DATETIME NULL
)
