select *
from ankieta

--001.
select plec
,Round(AVG(wynagrodzenie),2) as SrednieWynagrodzenie
,MIN(wynagrodzenie) as MinimalneWynagrodzenie
,MAX(wynagrodzenie) as MaksymalneWynagrodzenie
,SUM(wynagrodzenie) as SumaWszystkichPensji
,COUNT(wynagrodzenie) as LiczbaDanychOPensji
from ankieta
group by plec


--002.Srednie wynagrodzenie w podziale na plec oraz wyksztalcenie
select wykszta�cenie 
,plec
,round(AVG(wynagrodzenie),2) as SrednieWYnagrodzenie

from ankieta
group by plec,wykszta�cenie
order by wykszta�cenie,plec


--003.srednie wynagrodzenie w podziale zamieszkanie i wyksztalcenie w grupie osob,ktore nie maja wiedzy ekonomicznej
select zamieszkanie,wykszta�cenie 
,round(avg(wynagrodzenie),2) As SrednieWynagrodzenie
from ankieta
where wiedza = 'Nie mam wiedzy'
group by zamieszkanie,wykszta�cenie

--004.Srednie wynagrodzenie oraz minimalne w grupie osob ktore na oszczednosci przeznaczaja conajmniej 10% dochodow w podziale na wyksztalcenie i zamieszkanie
select wykszta�cenie,zamieszkanie,
round(avg(wynagrodzenie),2) as SrednieWynagrodzenie,
MIN(wynagrodzenie) as MinimalneWynagrodzenie
from ankieta
where substring(oszczednosci,1,1)='1' or substring(oszczednosci,1,1)='P'
group by wykszta�cenie,zamieszkanie

--005.
select *
from ankieta
where wiek<=30

--006.ankietowani w wieku od 30 do 40
select * 
from ankieta
where wiek between 30 and 40

--007.ankietowani w wieku do 30 lat lub w wieku pomiedzy 40 a 45 i zarabiajacy ponizej 2850 i mieszkajacy na wsi i bedacy kobieta
select *
from ankieta
where (wiek<30 or (wiek between 40 and 45)) and wynagrodzenie<2850 and zamieszkanie='Wie�' and plec='K'

--008.Podac info na ktorym poziomie wyksztalcenia srednie wynagrodzenie jest wieksze niz 2750
select wykszta�cenie
from ankieta
group by wykszta�cenie
having avg(wynagrodzenie)>2750

--009.Podac te grupy wyksztalcenia w ktorych sredni wiek jest z zakresu od 30 do 50 lat
select wykszta�cenie,
round(avg(cast(wiek as float)),2) as SredniaWIeku
from ankieta
group by wykszta�cenie
having avg(cast(wiek as float)) between 30 and 50 

--010.Podac liczbe osob w danym wieku
select wiek,
COUNT(wiek) as Liczba
from ankieta
group by wiek
order by wiek

--011.
select wiek,
COUNT(wiek) as Liczba
from ankieta
group by wiek
having count(wiek)>=5
order by wiek

--012.
