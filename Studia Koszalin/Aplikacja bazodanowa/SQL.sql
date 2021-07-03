/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     05.04.2016 08:25:14                          */
/*==============================================================*/


if exists (select 1
            from  sysindexes
           where  id    = object_id('Autokar')
            and   name  = 'Jedzie_FK'
            and   indid > 0
            and   indid < 255)
   drop index Autokar.Jedzie_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Autokar')
            and   type = 'U')
   drop table Autokar
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Kierowca')
            and   name  = 'Kieruje_FK'
            and   indid > 0
            and   indid < 255)
   drop index Kierowca.Kieruje_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Kierowca')
            and   type = 'U')
   drop table Kierowca
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Kurs')
            and   name  = 'Zawiera_FK'
            and   indid > 0
            and   indid < 255)
   drop index Kurs.Zawiera_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Kurs')
            and   type = 'U')
   drop table Kurs
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Miejscowoœci')
            and   type = 'U')
   drop table Miejscowoœci
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Przebieg')
            and   name  = 'Sk³ada_sie_FK'
            and   indid > 0
            and   indid < 255)
   drop index Przebieg.Sk³ada_sie_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Przebieg')
            and   name  = 'Nalezy_FK'
            and   indid > 0
            and   indid < 255)
   drop index Przebieg.Nalezy_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Przebieg')
            and   type = 'U')
   drop table Przebieg
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Trasa')
            and   name  = 'Poczatek_trasy_FK'
            and   indid > 0
            and   indid < 255)
   drop index Trasa.Poczatek_trasy_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Trasa')
            and   name  = 'Koniec_trasy_FK'
            and   indid > 0
            and   indid < 255)
   drop index Trasa.Koniec_trasy_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Trasa')
            and   type = 'U')
   drop table Trasa
go

/*==============================================================*/
/* Table: Autokar                                               */
/*==============================================================*/
create table Autokar (
   Id_autokaru          numeric(2)           identity,
   Id_kursu             numeric(2)           not null,
   Nr_rejestr           varchar(9)           null,
   Marka                varchar(15)          null,
   Model                varchar(15)          null,
   Liczba_miejsc        numeric(2)           null,
   constraint PK_AUTOKAR primary key nonclustered (Id_autokaru)
)
go

/*==============================================================*/
/* Index: Jedzie_FK                                             */
/*==============================================================*/
create index Jedzie_FK on Autokar (
Id_kursu ASC
)
go

/*==============================================================*/
/* Table: Kierowca                                              */
/*==============================================================*/
create table Kierowca (
   Id_kierowcy          numeric(2)           identity,
   Id_kursu             numeric(2)           null,
   Imie_Nazwisko        varchar(50)          null,
   constraint PK_KIEROWCA primary key nonclustered (Id_kierowcy)
)
go

/*==============================================================*/
/* Index: Kieruje_FK                                            */
/*==============================================================*/
create index Kieruje_FK on Kierowca (
Id_kursu ASC
)
go

/*==============================================================*/
/* Table: Kurs                                                  */
/*==============================================================*/
create table Kurs (
   Id_kursu             numeric(2)           identity,
   Id_trasy             numeric(2)           not null,
   Oznaczenie           varchar(10)          null,
   Data_kursu           datetime             null,
   Iloœæ_pasa¿erów      numeric(3)           null,
   Godzina_rozpoczecia  datetime             null,
   constraint PK_KURS primary key nonclustered (Id_kursu)
)
go

/*==============================================================*/
/* Index: Zawiera_FK                                            */
/*==============================================================*/
create index Zawiera_FK on Kurs (
Id_trasy ASC
)
go

/*==============================================================*/
/* Table: Miejscowoœci                                          */
/*==============================================================*/
create table Miejscowoœci (
   Id_miejscowosci      numeric(2)           identity,
   Nazwa_miejscowosci   varchar(20)          null,
   constraint PK_MIEJSCOWOŒCI primary key nonclustered (Id_miejscowosci)
)
go

/*==============================================================*/
/* Table: Przebieg                                              */
/*==============================================================*/
create table Przebieg (
   Id_przebiegu         numeric(2)           identity,
   Id_miejscowosci      numeric(2)           not null,
   Id_trasy             numeric(2)           not null,
   Roznica_czasu        datetime             null,
   Kolejnosc            numeric(2)           null,
   constraint PK_PRZEBIEG primary key nonclustered (Id_przebiegu)
)
go

/*==============================================================*/
/* Index: Nalezy_FK                                             */
/*==============================================================*/
create index Nalezy_FK on Przebieg (
Id_trasy ASC
)
go

/*==============================================================*/
/* Index: Sk³ada_sie_FK                                         */
/*==============================================================*/
create index Sk³ada_sie_FK on Przebieg (
Id_miejscowosci ASC
)
go

/*==============================================================*/
/* Table: Trasa                                                 */
/*==============================================================*/
create table Trasa (
   Id_trasy             numeric(2)           identity,
   Id_miejscowosci_poczatek numeric(2)           not null,
   Id_miejscowosci_koniec numeric(2)           not null,
   Oznaczenie_trasy     varchar(15)          null,
   constraint PK_TRASA primary key nonclustered (Id_trasy)
)
go

/*==============================================================*/
/* Index: Koniec_trasy_FK                                       */
/*==============================================================*/
create index Koniec_trasy_FK on Trasa (
Id_miejscowosci_koniec ASC
)
go

/*==============================================================*/
/* Index: Poczatek_trasy_FK                                     */
/*==============================================================*/
create index Poczatek_trasy_FK on Trasa (
Id_miejscowosci_poczatek ASC
)
go

