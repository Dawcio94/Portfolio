select top 10 *
from ankieta
order by wynagrodzenie
--01.Osoby o najnizszy wynagrodzeniu
select *
from ankieta
where wynagrodzenie=(
					select MIN(wynagrodzenie)
					from ankieta
					)
--02.Wszystkie najmlodsze osoby
select *
from ankieta
where wiek=(
			select MIN(wiek)
			from ankieta
			)
--03.Osoby zarabiajace powyzej sredniej
select *
from ankieta
where wynagrodzenie>(select AVG(wynagrodzenie)
					from ankieta)
--04.Najmlodsze kobiet
select *
from ankieta
where plec='K' and wiek=(select MIN(wiek)from ankieta
where plec='K')

--05.Kobiety w wieku najstarszego mezczyzny
select *
from ankieta
where plec='K' and wiek=(select max(wiek) from ankieta
where plec='M')

--06.Osoby z wynagrodzeniem wiekszym od najwyzszego wynagrodzenia osob ktore nie maja wiedzy
select *
from ankieta
where wynagrodzenie>(select MAX(wynagrodzenie) 
						from ankieta 
						where wiedza='nie mam wiedzy')
order by wynagrodzenie

--07.Osoby ktore zarabiaja conajmniej 2 razy wiecej niz najgorzej wynagradzana osoba z wyksztalceniem podstawowym
select distinct wykszta�cenie 
from ankieta
select *
from ankieta
where wynagrodzenie>=2*(select min(wynagrodzenie)
						from ankieta
						where wykszta�cenie='Podstawowe')

--08.Osoby o najnizszym wynagrodzeniu kazdej grupie wyksztalcenia
select distinct wykszta�cenie 
from ankieta
select *
from ankieta

select A.*
from ankieta as A
,(select wykszta�cenie,
		min(wynagrodzenie) as MinimalneWynagrodzenieWDanejGrupie
	from ankieta
	group by wykszta�cenie) as B
	where a.wykszta�cenie=b.wykszta�cenie and a.wynagrodzenie=b.MinimalneWynagrodzenieWDanejGrupie
	--09.
select b.wykszta�cenie,COUNT(a.wynagrodzenie)
from ankieta as A
,(select wykszta�cenie,
		min(wynagrodzenie) as MinimalneWynagrodzenieWDanejGrupie
	from ankieta
	group by wykszta�cenie) as B
where a.wykszta�cenie=b.wykszta�cenie and a.wynagrodzenie=b.MinimalneWynagrodzenieWDanejGrupie
group by b.wykszta�cenie
--10.osoby ktorych wynagrodzenie jest wieksze od wynagrodzenia wszystkich osob o wyksztalceniu podstawowym
select *
from ankieta
where wynagrodzenie>(select max(wynagrodzenie)
						from ankieta
						where wykszta�cenie='Podstawowe')
--11.Osoby o najwyzszym wynagrodzeniu w danej grupie wyksztalcenia
select A.*
from ankieta as A
,(select wykszta�cenie,
		max(wynagrodzenie) as MinimalneWynagrodzenieWDanejGrupie
	from ankieta
	group by wykszta�cenie) as B
	where a.wykszta�cenie=b.wykszta�cenie and a.wynagrodzenie=b.MinimalneWynagrodzenieWDanejGrupie
--12.WYnagrodzenie najstarszego mezczyzny
select wynagrodzenie
from ankieta
where plec='M' and wiek=(select max(wiek)
									from ankieta
									where plec='M')
--13.Znalezc wszystkie grupy wiekowe w ktorych nie ma rowiesnikow
select wiek
from ankieta
group by wiek
having count(wiek)=1
order by wiek

--14.osoby ktore nie posiaduja rowiesnikow
select *
from ankieta
where wiek in (select wiek
from ankieta
group by wiek
having count(wiek)=1)
order by wiek

--15.Lista kobiet i mezczyzn zarabiajacych 1.2 razy wiecej niz srednia w grupie kobiet i odpowiednio w grupie mezczyzn
select *
from ankieta as A
where wynagrodzenie>=1.2*(select avg(wynagrodzenie) 
							from ankieta as B 
							where B.plec=A.plec)
--16.Osoby ktore sa mlodsze od najstarszej osoby o nie wiecej niz 5 lat
select *
from ankieta
where wiek >= (select 
					max(wiek)
					from ankieta)-5


--TODO

--17.Te osoby ktore zarabiaja wiecej niz najstarszy mezczyzna
select * 
from ankieta 
where wynagrodzenie>(select wynagrodzenie
					from ankieta
					where wiek=(select max(wiek)
								from ankieta
								where plec='M'))
order by wynagrodzenie
--18.Osoby posiadajace takie samo wyksztalcenie jak wiekszosc osob z miasta
--select * 
--from ankieta
--where wykszta�cenie=

--select max(IloscOsobODanymWyksztalceniu),b.wykszta�cenie
--from ankieta as A,(
--					select count(wykszta�cenie) as IloscOsobODanymWyksztalceniu,wykszta�cenie
--					from ankieta 
--					where zamieszkanie='Miasto'
--					group by wykszta�cenie) as B
--group by b.wykszta�cenie
-- b.IloscOsobODanymWyksztalceniu=max(b.IloscOsobODanymWyksztalceniu) and a.wykszta�cenie=b.wykszta�cenie


