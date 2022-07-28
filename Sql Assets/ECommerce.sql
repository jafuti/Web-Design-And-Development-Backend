create database EcommerceDatabase
go

use EcommerceDatabase
go

create table Categories(
CategoryID bigint primary key identity(1,1),
CategoryName varchar(40))
go

create table Brands(
BrandID bigint primary key identity(1,1),
BrandName varchar(40))
go

create table Products(
ProductID bigint primary key identity(1,1),
ProductName varchar(50),
Price decimal(15,2),
DateOfPurchase datetime,
AvailabilityStatus varchar(50),
CategoryID bigint references Categories(CategoryID) on delete set null,
BrandID bigint references Brands(BrandID) on delete set null,
Active bit default(1))
go


insert into Categories values('Electronics')
insert into Categories values('Home Appliances')
go

insert into Brands values('Samsung')
insert into Brands values('Apple')
insert into Brands values('Sony')
insert into Brands values('HP')
go

insert into Products values('Samsung Galaxy S10', 84290, '2022-7-1', 'InStock', 1, 1, 1)
insert into Products values('Samsung Refrigerator', 27000, '2021-6-15', 'OutOfStock', 2, 1, 1)
insert into Products values('iPhone X', 99999, '2019-6-10', 'InStock', 1, 2, 1)
insert into Products values('HP Laptop', 34700, '2018-3-4', 'InStock', 1, 4, 1)
insert into Products values('Sony Home Theatre 5.1', 8700, '20120-5-18', 'InStock', 1, 3, 1)
insert into Products values('Sony Bravia 40 LED', 67000, '2021-7-19', 'InStock', 2, 3, 1)
go

select * from Products
go
