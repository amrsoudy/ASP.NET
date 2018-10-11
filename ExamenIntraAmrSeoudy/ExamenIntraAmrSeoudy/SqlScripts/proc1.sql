CREATE PROCEDURE [dbo].[InsertVoyage]
	@nom  varchar(50),
	@prenom varchar(50),
	@date varchar(50),
	@kilo int,
	@ville varchar(50),
	@frais real ,
	@postalcoe varchar(50),
	@email varchar(50)


AS
Begin
	insert into Info Values(@nom,@prenom,@date,@kilo,@ville,@frais,@postalcoe,@email)
End
Go