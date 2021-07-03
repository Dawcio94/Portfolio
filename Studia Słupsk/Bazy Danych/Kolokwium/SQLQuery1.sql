--01.
select p.IDPracownika,p.Imie,p.Nazwisko
from tblPracownicy as p
left join tblSprzedaz as s
on p.IDPracownika=s.Pracownik_ID
where s.Pracownik_ID is null
--02.
select k.NazwaFirmy as NazwaFirmy,k.NIP as NIPFirmy
from tblKlienci as K
where k.Telefon1 is not null and k.Telefon2 is not null and k.Miasto='Warszawa'
--03.
select t.NazwaTowaru as Nazwa,t.CenaKatalogowa as Cena,k.NazwaKategorii as Kategoria
from tblTowary as t
join tblKategorie as k
on k.ID_Kategoria=t.Kategoria_ID
where t.CenaKatalogowa<6 and (t.Kategoria_ID!=1 or t.Kategoria_ID!=4)
--04.
select t.Kategoria_ID ,sum(o.Ilosc*o.CenaSprzedazy) as SumaWartosci
from tblOpisSprzedazy as o
join tblTowary as t
on t.ID_Towar=o.Towar_ID
group by t.Kategoria_ID
--05.
select p.IDPracownika,p.Imie,p.Nazwisko,SUM(o.Ilosc) as IloscSprzedanegoKefiru
from tblPracownicy as p
join tblSprzedaz as s
on p.IDPracownika=s.Pracownik_ID
join tblOpisSprzedazy as o
on s.ID_Sprzedaz=o.Sprzedaz_ID
join tblTowary as t
on o.Towar_ID=t.ID_Towar
where t.NazwaTowaru='Kefir naturalny'
group by p.IDPracownika,p.Imie,p.Nazwisko
order by SUM(o.Ilosc) desc
--06.
select k.NazwaFirmy,sum(o.Ilosc*o.CenaSprzedazy) as WartoscSprzedazy
from tblKlienci as k
join tblSprzedaz as s
on s.Klient_ID=k.ID_Klient
join tblOpisSprzedazy as o
on o.Sprzedaz_ID=s.ID_Sprzedaz
where datepart(year,s.DataSprzedazy)=2012 and DATEPART(QUARTER,s.DataSprzedazy)=4
group by k.NazwaFirmy
having sum(o.Ilosc*o.CenaSprzedazy)>500
--07.niedziala
select kk.NazwaKategorii,t.NazwaTowaru,t.CenaKatalogowa 
from tblTowary as t
,(select MIN(CenaKatalogowa) as CenaMinimalna,Kategoria_ID
						from tblTowary
						group by Kategoria_ID) as K
join tblKategorie as KK
on kk.ID_Kategoria=t.
where t.Kategoria_ID=k.Kategoria_ID and t.CenaKatalogowa=k.CenaMinimalna
--08.
select p.Imie,p.Nazwisko,count(s.ID_Sprzedaz)
from tblPracownicy as p
join tblSprzedaz as s
on p.IDPracownika=s.Pracownik_ID
group by p.Imie,p.Nazwisko
having  count(s.ID_Sprzedaz) between 15 and 25
--09.niedziala
select k.NazwaFirmy,sum(o.Ilosc)
from tblKlienci as k
join tblSprzedaz as s
on k.ID_Klient=s.Klient_ID
join tblOpisSprzedazy as o
on s.ID_Sprzedaz=o.Sprzedaz_ID
join tblTowary as t
on o.Towar_ID=t.ID_Towar
where k.NazwaFirmy like'%ex%' and t.NazwaTowaru like '%p³atki%'
group by k.NazwaFirmy

use db_kolokwium_callcenter;
--11.
select count(NrTelefonu)
from callcenter
where DATEDIFF(minute,RozpoczecieRozmowy,ZakonczenieRozmowy)>10

select datename(WEEKDAY,RozpoczecieRozmowy) as DzienTygodnia,round(avg(cast(DATEDIFF(minute,RozpoczecieRozmowy,ZakonczenieRozmowy)as real)),2)
from callcenter
group by datename(WEEKDAY,RozpoczecieRozmowy)
order by (
case 
when datename(WEEKDAY,RozpoczecieRozmowy) ='Monday' then 1
when datename(WEEKDAY,RozpoczecieRozmowy)='Tuesday' then 2
when datename(WEEKDAY,RozpoczecieRozmowy)='Wednesday' then 3
when datename(WEEKDAY,RozpoczecieRozmowy)='Thursday' then 4
when datename(WEEKDAY,RozpoczecieRozmowy)='Friday' then 5
when datename(WEEKDAY,RozpoczecieRozmowy)='Saturday' then 6
when datename(WEEKDAY,RozpoczecieRozmowy)='Sunday' then 7
End)




