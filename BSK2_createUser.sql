Create table Users(
	id int not null,
	nazwa varchar(20) not null,
	haslo varchar(40) not null,
	clear int not null,
	Primary Key (id)
);

create table Tabele(
	id int not null,
	nazwa varchar(50) not null,
	class int not null,
	Primary Key (id)
)
