select *
from ankieta

--01.Oznaczenie przynaleznosci wynogrodzeniowej
select *
,Case 
when wynagrodzenie <=3000 Then 'g1'
when wynagrodzenie >3000 then 'g2'
else 'nieznaneWynagrodzenie'
End as GrupaWynagrodzeniowa
from ankieta
order by GrupaWynagrodzeniowa

--02.
select 
Case 
when wynagrodzenie <=3000 Then 'g1'
when wynagrodzenie >3000 then 'g2'
else 'nieznaneWynagrodzenie'
End as GrupaWynagrodzeniowa
,count(*) as liczbaosob
from ankieta
group by (
Case 
when wynagrodzenie <=3000 Then 'g1'
when wynagrodzenie >3000 then 'g2'
else 'nieznaneWynagrodzenie'
End
)

--03.na podstawie wieku utworzyc grupy wiekowe
--Mlodzi-do 30 lat wlacznie,dojrzali-od 30 do 50 wlacznie,starsi-pozostali
select *
,Case 
when wiek <=30 Then 'Mlodzi'
when wiek between 30 and 50 then 'Dojrzali'
else 'Starsi'
End as GrupaWiekowa
from ankieta
order by wiek


--04.policzyc ile jest w kazdej grupie wiekowej
select
Case 
when wiek <=30 Then 'Mlodzi'
when wiek between 30 and 50 then 'Dojrzali'
else 'Starsi'
End as GrupaWiekowa
,count(*) as LiczbaOsobWGrupach
,round((cast(count(*) as real)/(
			select count(wiek) from ankieta))*100,2)
as UdzialProcentowy
from ankieta
group by(
Case 
when wiek <=30 Then 'Mlodzi'
when wiek between 30 and 50 then 'Dojrzali'
else 'Starsi'
End 
)





