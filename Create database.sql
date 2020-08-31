--CREATE DATABASE passaro;

CREATE TABLE Oferta (
    Id int not null,
	DataCadastro datetime not null,
	DataAlteracao datetime,
	DataRemocao datetime,
	Titulo varchar(100),
	Descricao varchar(500),
	Anuciante varchar(100),
	Valor decimal,
	Destaque bit,
	IdComoUsar int,
	IdOndeFica int,
	);