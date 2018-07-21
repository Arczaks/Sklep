Create table Sprzedawcy(
	id int not null,
	Imie varchar(20) not null,
	Nazwisko varchar(40) not null,
	Primary Key (id)
);

Create table Placowki(
	id int not null,
	Nazwa varchar(20) not null,
	Primary Key (id)
);

Create table Lodowki(
	id int not null,
	Nazwa varchar(20) not null,
	Cena int not null,
	Primary Key (id)
);

Create table Rachunek(
	id int not null,
	id_placowki int not null,
	id_sprzedawcy int not null,
	data_wystawienia varchar(10) not null,
	Primary Key (id),
	Foreign key (id_placowki) References Placowki(id),
	Foreign key (id_sprzedawcy) References Sprzedawcy(id)
);

Create table pozycja_na_rachunku(
	id int not null,
	id_lodowki int not null,
	id_rachunku int not null,
	ilosc int not null,
	Primary Key (id),
	Foreign key (id_lodowki) References Lodowki(id),
	Foreign key (id_rachunku) References Rachunek(id)
);