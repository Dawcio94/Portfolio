--01.
select Ord.Id
from Orders as Ord
join OrderItem as OI
on ord.Id=OI.OrderId
group by ord.ID
having count(oi.ProductId)>=5
--02.
select Cus.Id,Cus.FirstName,Cus.LastName,Ord.Id as OrderNumber,count(oi.ProductId) as AmounOfProductInOrder
from Orders as Ord
join OrderItem as OI
on ord.Id=OI.OrderId
join Customer as Cus
on ord.CustomerId=cus.Id
group by Cus.Id,Cus.FirstName,Cus.LastName,Ord.Id
having count(oi.ProductId)>=5
order by count(oi.ProductId)
--03.--Nie dzia³a
select Cus.Id,Cus.FirstName,Cus.LastName,COUNT(Ord.Id)
from Orders as Ord
join OrderItem as OI
on ord.Id=OI.OrderId
join Customer as Cus
on ord.CustomerId=cus.Id
group by Cus.Id,Cus.FirstName,Cus.LastName
having count(oi.ProductId)>=5
order by count(oi.ProductId)
--04.
select Cus.Id,Cus.FirstName,Cus.LastName
from Customer as Cus
join Orders as Ord
on Cus.Id=Ord.CustomerId
join OrderItem as OI
on ord.Id=OI.OrderId
join Product as Pr
on OI.ProductId=pr.Id
where pr.ProductName='Boston Crab Meat'
group by Cus.Id,Cus.FirstName,Cus.LastName
--05.
select 
	Pr.ProductName
	,count(pr.SupplierId) as AmountOfSuppliers
from Product as Pr
join Supplier as Sup
on pr.SupplierId=Sup.Id
group by Pr.ProductName
having count(pr.SupplierId)>1
--06.
select pr.Id,Pr.ProductName,Sum(oi.Quantity) as Amount
from Product as Pr
join OrderItem as oi
on pr.Id=oi.ProductId
join Orders as Ord
on oi.OrderId=Ord.Id
group by pr.ProductName,pr.Id
order by Amount
--07.
select *
from Product
where not exists (select *
				 from OrderItem
				 where Product.Id=OrderItem.ProductId
				 )
--08.
select Cus.Id,Cus.FirstName,Cus.LastName,Sum(Ord.TotalAmount) as TotalAmount
from Customer as Cus
left join Orders as Ord
on Cus.Id=Ord.CustomerId
group by Cus.Id,Cus.FirstName,Cus.LastName
order by TotalAmount
--09.
select Cus.Id,Cus.FirstName,Cus.LastName,count(ord.Id) as AmountOfOrders
from Customer as Cus
left join Orders as Ord
on cus.Id=Ord.CustomerId
group by Cus.Id,Cus.FirstName,Cus.LastName
order by AmountOfOrders
--10.
select DATEPART(year,ord.OrderDate) as Years,DATEPART(quarter,ord.OrderDate) as Quarters,SUM(ord.TotalAmount) as TotalAmount
from Orders as ord
group by DATEPART(year,ord.OrderDate),DATEPART(quarter,ord.OrderDate)
order by TotalAmount
--11.--Nie dzia³a
with cte_Product
as
(select count(ord.Id) as AmountOfOrders,DATEPART(year,ord.OrderDate) as Years,DATEPART(quarter,ord.OrderDate) as Quarters,pr.ProductName
from Product as Pr
join OrderItem as Oi
on pr.Id=oi.ProductId
join Orders as ord
on oi.OrderId=ord.Id
group by DATEPART(year,ord.OrderDate),DATEPART(quarter,ord.OrderDate),pr.ProductName
--order by count(oi.ProductId) desc
)
select  top 3 pr.*,cte.AmountOfOrders,cte.Years,cte.Quarters
from Product as Pr
join OrderItem as Oi
on pr.Id=oi.ProductId
join Orders as ord
on oi.OrderId=ord.Id
join cte_Product as cte
on pr.ProductName=cte.ProductName and DATEPART(year,ord.OrderDate)=cte.Years and DATEPART(quarter,ord.OrderDate)=cte.Quarters
order by cte.AmountOfOrders desc
--12.
select avg(ord.TotalAmount) as AverageAmountOfCost
from orders as ord
join customer as cus
on ord.CustomerId=cus.Id
where cus.Country='USA'
--13.
--#1
select cus.Id,cus.FirstName,cus.LastName,avg(Ord.TotalAmount)
from Customer as cus
join Orders as ord
on cus.Id=ord.CustomerId
where avg(ord.TotalAmount)>(select avg(ord.TotalAmount) as AverageAmountOfCost
						from orders as ord
						)
group by cus.Id,cus.FirstName,cus.LastName
--#2
select
	Cus.Id
	,Cus.FirstName
	,cus.LastName
	,avg(Ord.TotalAmount)
from Customer as Cus
left join Orders as Ord on Cus.Id=Ord.CustomerId
group by Cus.Id, Cus.FirstName, Cus.LastName
having avg(Ord.TotalAmount)>	(select 
									avg(Orders.TotalAmount) 
								from Orders
								)
--14.
select sup.CompanyName,COUNT(pr.id) as AmountOfProducts
from Product as pr
join Supplier as sup
on pr.SupplierId=sup.Id
group by sup.CompanyName
--15.
select pr.ProductName
from Product as pr
join Supplier as sup
on pr.SupplierId=sup.Id
where pr.Package like '%bott%'
--16.
select sum(oi.Quantity) as Amount,Pr.ProductName,DATEPART(year,ord.OrderDate) as Years,DATEPART(quarter,ord.OrderDate) as Quarters
from OrderItem as oi
join Product as pr
on oi.ProductId=pr.Id
join Orders as ord
on oi.OrderId=ord.Id
where pr.UnitPrice=(select max(UnitPrice)
					from Product
					)
group by DATEPART(year,ord.OrderDate),DATEPART(quarter,ord.OrderDate),pr.UnitPrice,Pr.ProductName
--17.
select avg(oi.Quantity) as Amount,Pr.ProductName,DATEPART(year,ord.OrderDate) as Years,DATEPART(quarter,ord.OrderDate) as Quarters
from OrderItem as oi
join Product as pr
on oi.ProductId=pr.Id
join Orders as ord
on oi.OrderId=ord.Id
where pr.UnitPrice=(select max(UnitPrice)
					from Product
					)
group by DATEPART(year,ord.OrderDate),DATEPART(quarter,ord.OrderDate),pr.UnitPrice,Pr.ProductName
--18.--Nie dzia³a
select cus.Id--,count(pr.Id)
from Customer as cus
join Orders as ord
on cus.Id=ord.CustomerId
join OrderItem as oi
on ord.Id=oi.OrderId
join Product as pr
on pr.Id=oi.ProductId
where pr.Id=(select Id
					from Product
					where UnitPrice=(select max(UnitPrice)
										from Product
									)
					)
group by cus.Id
having 

--19.
select * 

--20.
select top 10 cus.Id,cus.FirstName,cus.LastName
from Customer as cus
join Orders as ord
on cus.Id=ord.CustomerId
group by cus.Id,cus.FirstName,cus.LastName
order by sum(ord.TotalAmount) desc
--21.--Nie dzia³a
select cus.Id,cus.FirstName,cus.LastName,datepart(year,ord.OrderDate)
from Customer as cus
join Orders as ord
on cus.Id=ord.CustomerId
group by datepart(year,ord.OrderDate),cus.Id,cus.FirstName,cus.LastName
having count(ord.Id)>=1

select *
from Orders

--22.
select cus.*
from Customer as cus
join Orders as ord
on cus.id=ord.CustomerId
join OrderItem as OI
on ord.Id=oi.OrderId
join Product as pr
on oi.ProductId=pr.Id
where year(ord.OrderDate)=2013 and pr.ProductName='Tofu'
--23.
select cus.Id,cus.FirstName,cus.LastName,sum(oi.Quantity) as AmountofPurchase
from Customer as cus
join Orders as ord
on cus.id=ord.CustomerId
join OrderItem as OI
on ord.Id=oi.OrderId
join Product as pr
on oi.ProductId=pr.Id
where year(ord.OrderDate)=2013 and pr.ProductName='Tofu'
group by cus.Id,cus.FirstName,cus.LastName
having sum(oi.Quantity)>3
--24.
select top 5 pr.ProductName,sum(oi.Quantity) as AmountofPurchaseIn2012
from Customer as cus
join Orders as ord
on cus.id=ord.CustomerId
join OrderItem as OI
on ord.Id=oi.OrderId
join Product as pr
on oi.ProductId=pr.Id
where year(ord.OrderDate)=2012 and cus.Country='Usa'
group by pr.ProductName
order by sum(oi.Quantity) desc
--25.
select sum(oi.UnitPrice*oi.Quantity) as AmountOfProducts,MONTH(ord.OrderDate) as Months,Case
	when pr.UnitPrice<=20 then 'Price is equal or lower than 20'
	when pr.UnitPrice>20 then 'Price is higher than 20'
End
from Customer as cus
join Orders as ord
on cus.id=ord.CustomerId
join OrderItem as OI
on ord.Id=oi.OrderId
join Product as pr
on oi.ProductId=pr.Id
where year(ord.OrderDate)=2012
group by month(ord.OrderDate),(Case
							when pr.UnitPrice<=20 then 'Price is equal or lower than 20'
							when pr.UnitPrice>20 then 'Price is higher than 20'
								End)
--26.--Nie dzia³a
select cus.Country,sum(oi.UnitPrice*oi.Quantity) as Amount,pr.ProductName
from Customer as cus
join Orders as ord
on cus.id=ord.CustomerId
join OrderItem as OI
on ord.Id=oi.OrderId
join Product as pr
on oi.ProductId=pr.Id
group by pr.ProductName,cus.Country
having sum(oi.UnitPrice*oi.Quantity)=(select max(UnitPrice*Quantity)
											from OrderItem
											group by ProductId)

--27.
select format(max(ord.OrderDate),'dd/MM/yyyy'),pr.ProductName
from Customer as cus
join Orders as ord
on cus.id=ord.CustomerId
join OrderItem as OI
on ord.Id=oi.OrderId
join Product as pr
on oi.ProductId=pr.Id
where pr.IsDiscontinued=1
group by pr.ProductName
--28.
select ProductName,Case
	when UnitPrice<=20 then 'Price is equal or lower than 20'
	when UnitPrice>20 then 'Price is higher than 20'
End
from Product
where IsDiscontinued=1
group by ProductName,(Case
				when UnitPrice<=20 then 'Price is equal or lower than 20'
				when UnitPrice>20 then 'Price is higher than 20'
		  End)
