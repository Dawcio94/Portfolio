select * 
from ankieta
--01.Dla kazdej osovy podac srednie wynagrodzenie w danej grupie wyksztalcenia
select A.*
,(select avg(b.wynagrodzenie)
  from ankieta as B
  where A.wykszta³cenie=b.wykszta³cenie
) as SrednieWynagrodzenieWDanejGrupieZawodowej
from ankieta as A
--02.Osoby o najnizszym wynagrodzeniu w kazdej z grup wyksztalcenia
select A.*
from ankieta as A
where wynagrodzenie=(select min(wynagrodzenie)
						from ankieta as B
						where b.wykszta³cenie=a.wykszta³cenie)
--------------------------------------------------------
--Zlaczenia
--------------------------------------------------------

select *
from klienci

select *
from szczegolyTransakcji

select *
from towary

select *
from transakcje
--01.klienci i ich transkacje
select K.*,T.*
from klienci as K
left join transakcje as T
on k.IdKlienta=t.KlientId

select K.IdKlienta,K.Nazwisko,k.Imie,T.IdTransakcji
from klienci as K
left join transakcje as T
on k.IdKlienta=t.KlientId

--02.Szczegoly transakcji wraz z nazwa towaru
select *
from szczegolyTransakcji as ST
left join towary as T
on st.TowarID=t.IdTowaru

--03.Szczegoly transakcji dla ktorych nie da sie okreslic nazwy towaru
select *
from szczegolyTransakcji as ST
left join towary as T
on st.TowarID=t.IdTowaru
where T.NazwaTowaru is null
--04.Wartosc kazdej transakcji
select t.IdTransakcji,sum(st.Ilosc*Tow.CenaJednostkowa) as WartoscpozycjiTransakcji
from transakcje as T
join szczegolyTransakcji as ST
on t.IdTransakcji=st.TransakcjaId
join towary as Tow
on st.TowarID=tow.IdTowaru
group by t.IdTransakcji
--05.
select st.*,t.*
from szczegolyTransakcji as st
full join towary as T
on st.TowarID=t.IdTowaru
--06.
select k.*,t.*
from klienci as k
right join transakcje as T
on k.IdKlienta=t.KlientId