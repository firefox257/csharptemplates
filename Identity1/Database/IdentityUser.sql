CREATE TABLE [dbo].[IdentityUser]
(
	[Id] BIGINT NOT NULL IDENTITY PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [PasswordHash] VARCHAR(100) NOT NULL, 
    [Created] DATETIME NOT NULL
)
