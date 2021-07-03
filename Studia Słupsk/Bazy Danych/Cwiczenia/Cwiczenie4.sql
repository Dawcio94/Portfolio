select * from dbT_12

--01.
select count(*)
from dbT_12
where datepart(day,DataUrodzenia)=13

--02.
select *
from dbT_12
where datepart(day,getdate())=datepart(day,DataUrodzenia) and datepart(MONTH,getdate())=datepart(MONTH,DataUrodzenia)

--03.
select *
from dbT_12
where datepart(day,DataUrodzenia)=13
--04.
select count(*) as LiczbaOsob,
datename(month,DataUrodzenia) as Miesiac
from dbT_12
where datepart(day,DataUrodzenia)=13
group by datename(month,DataUrodzenia),DATEPART(month,DataUrodzenia)
order by DATEPART(month,DataUrodzenia)
--05.
select count(*) as LiczbaOsob,
DATEPART(quarter,DataUrodzenia)
from dbT_12
group by DATEPART(quarter,DataUrodzenia)
order by DATEPART(quarter,DataUrodzenia)
--06.
select count(*) as LiczbaOsob
,round(avg(cast(datediff(year,DataUrodzenia,GETDATE())as real)),3) as SredniaWieku
from dbT_12
where DATEPart(weekDAY,DataUrodzenia)=6

--07.
select count(*) as LiczbaOsob
,DATEName(weekDAY,DataUrodzenia) as DzienTygodnia
from dbT_12
group by DATEName(weekDAY,DataUrodzenia)
order by LiczbaOsob Desc

--08.
select count(*) as LiczbaOsobWGrupach
,round(cast(count (*) as real)/(select count(*) from dbT_12 where DATENAME(weekday,DataUrodzenia)='Sunday')*100,2)
from dbT_12
where DATENAME(weekday,DataUrodzenia)='Sunday'
group by Plec

--09.
select count(*)
from dbT_12
where datepart(month,DataUrodzenia)=12
--10.
select count(*)
from dbT_12
where datepart(month,DataUrodzenia)=datepart(month,(dateadd(MONTH,1,GETDATE())))
--11.
select count(*)
from dbT_12
where datepart(month,DataUrodzenia)=datepart(month,(dateadd(MONTH,1,GETDATE()))) and datediff(year,DataUrodzenia,GETDATE())=50
--12.
select
Case 
when datepart(day,DataUrodzenia) between 1 and 10 then 'poczatek'
when datepart(day,DataUrodzenia) between 11 and 20 then 'srodek'
else 'Koniec'
end as OkresyMiesiaca,
count(*) as LiczbaOsobWGrupach
,round(cast(count (*) as real)/(select count(*) from dbT_12 where DATEpart(month,DataUrodzenia)=12and Plec='Kobieta')*100,2) as UdzialProcentowy
from dbT_12
where datepart(month,DataUrodzenia)=12 and Plec='Kobieta'
group by(Case 
when datepart(day,DataUrodzenia) between 1 and 10 then 'poczatek'
when datepart(day,DataUrodzenia) between 11 and 20 then 'srodek'
else 'Koniec'
end)
order by LiczbaOsobWGrupach desc
--13.
select count(*),DATename(month,DataUrodzenia)
from dbT_12
where DATEPART(day,DataUrodzenia)=1
group by DATEPART(month,DataUrodzenia),DATename(month,DataUrodzenia)
order by DATEPART(month,DataUrodzenia)
--14.
select count(*),DATename(month,DataUrodzenia)
from dbT_12
where DataUrodzenia=EOMONTH(DataUrodzenia)
group by DATEPART(month,DataUrodzenia),DATename(month,DataUrodzenia)
order by DATEPART(month,DataUrodzenia)
--15.
declare @roznica int
set @roznica=DATEdiff(year,getdate(),(select DataUrodzenia from dbT_12)) as B
if @roznica>=20 and @roznica<=25
select *
from dbT_12






--16.
select *
from dbT_12
where DATEPART(month,DataUrodzenia)=10 and DATEPART(year,DataUrodzenia)%10=(2019%10)
--17.
select *
from dbT_12
where datediff(year,DataUrodzenia,GETDATE())=40 and datepart(month,GETDATE())-DATEPART(month,DataUrodzenia)=6
--18.
select *
from dbT_12
where datediff(year,DataUrodzenia,GETDATE())=40 and datepart(month,GETDATE())-DATEPART(month,DataUrodzenia)=7
--19.
select Plec,count(*) as LiczbaOsobWGrupach
,round(cast(count (*) as real)/(select count(*) from dbT_12 
where 
(datepart(YEAR,GETDATE())-datepart(year,DataUrodzenia)+((DATEPART(month,DataUrodzenia)/cast(datepart(month,GetDate())as real))))>=50.58
and 
(datepart(YEAR,GETDATE())-datepart(year,DataUrodzenia)+(DATEPART(month,DataUrodzenia)/cast(datepart(month,GetDate())as real)))<=60.17)*100,2) as UdzialProcentowy
from dbT_12
where 
(datepart(YEAR,GETDATE())-datepart(year,DataUrodzenia)+((DATEPART(month,DataUrodzenia)/cast(datepart(month,GetDate())as real))))>=50.58
and 
(datepart(YEAR,GETDATE())-datepart(year,DataUrodzenia)+(DATEPART(month,DataUrodzenia)/cast(datepart(month,GetDate())as real)))<=60.17
group by Plec

--20.
select plec,count(*) as IloscOsobUrodzonaWPi¹tek13
from dbT_12
where datepart(DAY,DataUrodzenia)=13 and DATENAME(weekday,DataUrodzenia)='Friday'
group by Plec



