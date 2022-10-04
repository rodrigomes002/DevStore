create database DevStore;
use DevStore;

create table Product(
	Id int IDENTITY(1,1) NOT NULL,
	Name varchar(255) NOT NULL,
	Price decimal(18,2),
	CONSTRAINT PK_PRODUCT PRIMARY KEY(Id)
);

insert into Product (Name, Price) values ('Teste', 19.55);
insert into Product (Name, Price) values ('Teste', 19.55);