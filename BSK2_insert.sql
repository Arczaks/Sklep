insert into users (id, nazwa, haslo, clear)
values (1, 'Grzegorz', '123', 1);

insert into users (id, nazwa, haslo, clear)
values (2, 'Donald', '123', 3);

insert into users (id, nazwa, haslo, clear)
values (3, 'Janusz', '123', 3);

insert into users (id, nazwa, haslo, clear)
values (4, 'Pawel', '123', 4);

insert into users (id, nazwa, haslo, clear)
values (5, 'Jaroslaw', '123', 5);

insert into tabele (id, nazwa, class)
values (1, 'lodowki', 2);

insert into tabele (id, nazwa, class)
values (2, 'rachunek', 4);

insert into tabele (id, nazwa, class)
values (3, 'pozycja_na_rachunku', 4);

insert into tabele (id, nazwa, class)
values (4, 'placowki', 1);

insert into tabele (id, nazwa, class)
values (5, 'sprzedawcy', 3);

insert into tabele (id, nazwa, class)
values (6, 'tabele', 6);

insert into tabele (id, nazwa, class)
values (7, 'users', 6);

insert into Sprzedawcy(id, Imie, Nazwisko)
values (1, 'Stefan', 'Rowecki');

insert into Sprzedawcy(id, Imie, Nazwisko)
values (2, 'Tadeusz', 'Komorowski');

insert into Sprzedawcy(id, Imie, Nazwisko)
values (3, 'Wladyslaw', 'Anders');

insert into Sprzedawcy(id, Imie, Nazwisko)
values (4, 'Aleksander', 'Krzyzanowski');

insert into Sprzedawcy(id, Imie, Nazwisko)
values (5, 'Mikolaj', 'Boltuc');

insert into Placowki(id, Nazwa)
values (1, 'Jablon');

insert into Placowki(id, Nazwa)
values (2, 'Pinsk');

insert into Placowki(id, Nazwa)
values (3, 'Milanow');

insert into Lodowki(id, Nazwa, Cena)
values (1, 'Sten', 1500);

insert into Lodowki(id, Nazwa, Cena)
values (2, 'Blyskawica', 1499);

insert into Lodowki(id, Nazwa, Cena)
values (3, 'Bechowiec-1', 1300);

insert into Lodowki(id, Nazwa, Cena)
values (4, 'Bechowiec-2', 2500);

insert into Lodowki(id, Nazwa, Cena)
values (5, 'Kis', 1000);

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (1, 1, 1, '10-10-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (2, 2, 2, '11-11-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (3, 3, 3, '10-10-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (4, 3, 4, '12-10-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (5, 1, 5, '11-11-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (6, 3, 5, '12-12-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (7, 1, 5, '1-1-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (8, 2, 2, '9-1-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (9, 2, 2, '8-8-2010');

insert into Rachunek(id, id_placowki, id_sprzedawcy, data_wystawienia)
values (10, 2, 2, '7-7-2010');

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (1, 1, 3, 111);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (2, 1, 4, 10);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (3, 2, 1, 5);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (4, 2, 2, 60);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (5, 2, 3, 10);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (6, 3, 1, 10);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (7, 4, 1, 101);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (8, 4, 2, 1);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (9, 4, 3, 2);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (10, 4, 4, 3);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (11, 4, 5, 40);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (12, 5, 1, 1);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (13, 5, 2, 2);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (14, 5, 3, 3);

insert into pozycja_na_rachunku(id, id_lodowki, id_rachunku, ilosc)
values (15, 5, 4, 4);