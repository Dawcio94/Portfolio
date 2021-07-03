select *
from pracownicy

--001.
select *
from pracownicy
where dodatek is null

--002.
select *
from pracownicy
where dodatek is not null and premia is null

--003.Dodatkowe skladniki pensji lacznie
--Zle rozwiazanie
select *,dodatek+premia as 'Dodatkowe wynagrodzenie'
from pracownicy

--Dobre
select *,(ISNULL(dodatek,0)+Isnull (premia,0) )as 'Dodatkowe wynagrodzenie'
from pracownicy

--004.Srednia premia wsrod pracownikow na s2
select AVG(premia) as Srednia
from pracownicy
where stanowisko='s2'
group by stanowisko

--005.Srednia premia wsrod pracownikow na s1
select
avg(premia)
,sum(isnull(premia,100000))
from pracownicy
where stanowisko='s1'
group by stanowisko

--006.Oblicz srednia calkowitego wynagrodzenia na poszczegolnych stanowiskach
select stanowisko
,round(avg((isnull(wynagrodzenie_zasadnicze,0)+isnull(dodatek,0)+isnull(premia,0))),2) as Srednia
from pracownicy
where stanowisko is not null
group by stanowisko
order by Srednia
