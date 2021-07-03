use db01_badania_rtg;

--001.Wybor wszystkiego
select *
from pacjenci
--002.Wybor okreslonych pol
select imie,nazwisko,plec
from pacjenci
--003.Liczba rekordow
select COUNT(*)
from pacjenci

--004.
select *
from pacjenci
where nfz='Opolski'

--005.
select * 
from pacjenci
where nfz='Opolski' or nfz='Slaski'

select *
from pacjenci 
where nfz in ('Opolski','Slaski')

--006.
select *
from pacjenci 
where plec='KOBIETA'and ( nfz='Opolski' or nfz='Pomorski')

--007.
select  imie,pesel 
from pacjenci
where imie='Monika' or imie='Julia'

--008.
SELECT imie,pesel 
from pacjenci
where imie='Monika' or imie='Julia'
order by imie --asc-rosnaco--desc-malejaco

--009.
select distinct nfz
from pacjenci
order by nfz

--010.
select 1+3
select 7-2
select 2*3
select POWER(2,3)
select 7%2
select 6/3
select 8/3
select CAST(8 as float)/3--rzutowanie
select round (4.76,1)
select floor (4.76)
 --011.
 select *
 from pacjenci
 where nazwisko like '_a%'

 --012.
 select *
 from pacjenci
 where nazwisko like '%a'

 --013.
 select * 
 from pacjenci
 where nazwisko like '__[c-k]%'

 --014.
 select *
 from pacjenci
 where nazwisko like '___[azr]%'
 order by nazwisko

 --015.
 select * 
 from pacjenci 
 where pesel like '____1[0-9]%' or pesel like '____20%'

 --016.
 select SUBSTRING('wszystkorobiacy',7,3)

 --017.
 select * 
 from pacjenci
 where Cast(SUBSTRING(pesel,10,1) as int)%2=0

 --018.
 select * 
 from pacjenci
 where imie not like '_[a-k]%'
 order by imie

 select *
 from pacjenci
 where imie like '_[^a-k]%'

 --019.
 select *
 from pacjenci
 where imie like '_[^c-g]%'

 select *
 from pacjenci
 where imie not like '_[c-g]%'

 use db24_varia;
 select*
 from pracownicy