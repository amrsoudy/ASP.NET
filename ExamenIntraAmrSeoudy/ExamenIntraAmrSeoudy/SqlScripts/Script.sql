CREATE TABLE [dbo].[Info]
(
	[nom] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [prenom] VARCHAR(50) NOT NULL, 
    [date] VARCHAR(50) NOT NULL , 
    [kilo] INT NOT NULL, 
    [Ville] VARCHAR(50) NOT NULL, 
    [fraisResturant] REAL NULL, 
    [postalCode] NCHAR(10) NOT NULL, 
    [email] VARCHAR(50) NULL, 
    CONSTRAINT [CK_Info_kilo] CHECK (kilo > 5 and kilo <200)
)
