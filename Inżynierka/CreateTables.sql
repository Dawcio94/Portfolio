use CarRepairService;
create table Cars(
	CarId int IDENTITY(1,1) Not null,
	CarName varchar(255),
	CarModel varchar(255),
	CarNumber varchar(10),
	VIN varchar(17),
	CarType varchar(255),
	CONSTRAINT PK_Cars PRIMARY KEY (CarId)
)

create table Addresses (
	AddresId int IDENTITY(1,1) not null,
	City varchar(255),
	Street varchar(255),
	HouseNumber int,
	FlatNumber int,
	ZIP varchar(6),
	CONSTRAINT PK_Addresses PRIMARY KEY (AddresId)
)

create table Serviceses(
	ServiceId int IDENTITY(1,1) not null,
	Specification varchar(255),
	Cost int
	CONSTRAINT PK_Service PRIMARY KEY (ServiceId),
)


create table Orders (
	OrderId int IDENTITY(1,1) not null,
	FirstName varchar(255),
	SecondName varchar(255),
	CarId int,
	ServiceId int,
	PhoneNumber varchar(9),
	DataTime Date,
	CONSTRAINT PK_Orders PRIMARY KEY (OrderId),
	Constraint FK_CarOrder Foreign Key(CarId)
	References Cars(CarId),
	Constraint FK_ServiceOrder Foreign Key(ServiceId)
	References Serviceses(ServiceId)
)

create table Clients(
	ClientId int IDENTITY(1,1) not null,
	FirstName varchar(255),
	LastName varchar(255),
	PhoneNumber varchar(9),
	CONSTRAINT PK_Client PRIMARY KEY (ClientId),
)

create table Products(
	ProductId int IDENTITY(1,1) not null,
	Specification varchar(255),
	Quantity int,
	CONSTRAINT PK_Product PRIMARY KEY (ProductId),
)