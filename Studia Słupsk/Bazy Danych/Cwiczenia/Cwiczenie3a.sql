--01.
Update pacjenci
set plec='MʯCZYZNA'
where pesel=38012109293

select * 
from pacjenci where pesel=38012109293

--02.Zmiana plci na Nulla i nfz na cokolwiek
Update pacjenci
set plec=null ,nfz='cokolwiek'
where pesel=38012109293

select * 
from pacjenci where pesel=38012109293

--03.aktualizacja wszystkich rekordow
select *
from pacjenci


Update pacjenci
set plec=null

--04.Konkatenacja
select 'Ala '+'ma '+'psa'

--05.
select * 
,nazwisko+' '+imie as ImieNazwisko
from pacjenci

--06.Deklaracja zmiennych
declare @width int
set @width=30
select @width+5

--08.Deklaracja zmiennych
declare @width int=40
select @width+5

--09.Zadeklarowac dwie zmienne width i height i obliczy obwod prostokata wyswietlajac teksto tresci: Obwod prostokata o dlugosci X i szerokosci Y wynosi Z
declare @width int=20,@height int=15
select 'Obwod prostokata o dlugosci '+cast(@width as varchar)+' i szerokosci '+cast(@height as varchar)+' wynosi '+cast((2*@width+2*@height)as varchar) as Odpowiedz

--10.Aktualna data i czas
select GETDATE();
--11.DOdanie 10 dni do daty
select GETDATE()+10
--12.wydobycie roku
select Year(GETDATE())
--13.wydobycia miesiaca
select MONTH(GETDATE())
--14.
select DATEPART(DAYOFYEAR,getDate())
--15.
select DATEPART(WEEKDAY,getDate())
select DATEPART(WEEK,getDate())
select DATEPART(QUARTER,getDate())
select DATEPART(MINUTE,getDate())
--16.nazwa dnia tygodnia
select DATENAME(WEEKDAY,GETDATE())
select DATENAME(MONTH,GETDATE())
--17.Dodawanie
select dateadd(day,2,GETDATE())
select dateadd(MINUTE,10,GETDATE())
select dateadd(day,2,'2019-10-15 12:35')

--18.Odejmowanie
select DATEDIFF(Hour,'2019-10-25',Getdate())

--19.
select DATEADD(day,-1,getdate())
