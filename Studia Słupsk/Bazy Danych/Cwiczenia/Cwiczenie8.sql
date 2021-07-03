with cte_AnkietyKobiety
as
(
select 
wynagrodzenie
,wiek
wiedza
from ankieta
where plec='K'
)

select 
wynagrodzenie
from cte_AnkietyKobiety
where wynagrodzenie>2200

--01.Osoby o najnizszym wynagrodzeniu w kazdej grupie wyksztalceniowej

with cte_MinimalneWynagrodzenieWGrupachWyksztalcenia
as
(
select 
wykszta³cenie
,min(wynagrodzenie) as MinimalneWynagrodzenie
from ankieta
group by wykszta³cenie
)

select A.*
from ankieta as A
join cte_MinimalneWynagrodzenieWGrupachWyksztalcenia as MW on
A.wykszta³cenie=MW.wykszta³cenie and
A.wynagrodzenie=MW.MinimalneWynagrodzenie

--02.Widok kobiety ze wsi
alter View VKobietyWies
as 
(
select 
wiek
,plec
,zamieszkanie
,wykszta³cenie
,wiedza
from ankieta
where plec='K' and zamieszkanie='Wieœ'
)

select
*
from VKobietyWies

drop view VKobietyWies


--03.Widok - wynagrodzenie i wyksztalcenie-brak mozliwosci orderowania

create view vWynagrodzenieWyksztalcenie
as 
(
select 
wynagrodzenie
,wykszta³cenie
from ankieta
order by wynagrodzenie
)

select * 
from vWynagrodzenieWyksztalcenie
order by wynagrodzenie

--04.Sortowanie w widoku
create view vWynagrodzenieWyksztalceniezSortowaniem
as 
(
select top 99.99999999 percent
wynagrodzenie
,wykszta³cenie
from ankieta
order by wynagrodzenie
)

select * 
from vWynagrodzenieWyksztalceniezSortowaniem
order by wynagrodzenie

--05.Spr czy istnieje widok
if OBJECT_ID ('vWynagrodzenieWyksztalcenie','v') is not null
drop view vWynagrodzenieWyksztalcenie
go

create view vWynagrodzenieWyksztalcenie
as 
(
select 
wynagrodzenie
,wykszta³cenie
,plec
from ankieta
)

--Procedury
--06.Wejscie:0 Wyjscie:0
create procedure pAktualnyCzas
as
(
select GETDATE()
)

exec pAktualnyCzas
--07.Procedura z danymi wejsciowymi
alter procedure pLiczbaLosowaZPrzedzialu
--Generowanie liczby losowej z przedzialu od a do b
--Wejscie:2 Wyjscie:0
@a int,
@b int
as
	select round((@b-@a)*RAND()+@a,0)


exec pLiczbaLosowaZPrzedzialu 5,10 

--08.Procedura z parametrami wyjsciowymi
--Wejscie:0 Wyjscie:2
--Zwracanie daty i czas
alter procedure pDataCzas
@aktualnadata date out,
@aktualnyczas time output
as
set @aktualnadata=convert(date,getdate())
set @aktualnyczas=CONVERT(time,getdate())

select @aktualnadata,@aktualnyczas
go
--Wywolanie procedury 08
--Rozw.1
declare @d date
declare @c time

exec pDataCzas @aktualnadata=@d out,@aktualnyczas=@c out

--Rozw.2
declare @d date
declare @c time
exec pDataCzas @d out,@c out

--09.Procedura z parametrami wejsciowymi i wyjsciowymi
--Wejscie:2 Wyjscie:2
--Generowanie dwoch liczb liczb losowych od a do b zakresie
create procedure pDwieLiczbyLosowe
@a int,
@b int,
@pierliczba real out,
@drugaliczba real out
as
	set @pierliczba=(@b-@a)*RAND()+@a
	set @drugaliczba=(@b-@a)*RAND()+@a
select @pierliczba as 'Pierwsza liczba losowa',
	   @drugaliczba as 'Druga liczba losowa'
go

declare @x1 as real
declare @x2 as real
exec pDwieLiczbyLosowe 20,40,@x1 out,@x2 out

--10.INformacja o rezultacie dzialania procedury
alter procedure pRezultatDzialaniaProcedury
@a as real,
@b as real
as
declare @temp real
	begin
		begin try
			set @temp= @a/@b
			return 1
		end try
		begin catch
		return 0
		end catch
	end
go
--#1
exec pRezultatDzialaniaProcedury 3,0

--#2
declare @resultCode int
exec @resultCode=pRezultatDzialaniaProcedury 3,0
print @resultCode

--11.Tabela ankieta. Procedura aktualizujaca wynagrodzenie(podniesienie wynagrodzenia o podana wartosc)
alter procedure pAktualizujWynagrodzenie
	@wysokoscpodwyzki real
as
	begin
		begin try
				Update ankieta
				set wynagrodzenie=wynagrodzenie+(@wysokoscpodwyzki/0)
				return 1
		end try

		begin catch
				return 0
		end catch
	end
go
declare @resultCode int
exec @resultCode=pAktualizujWynagrodzenie 10000
print @resultCode
select wynagrodzenie
from ankieta