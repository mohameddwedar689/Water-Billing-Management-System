--creating database
create database waterbillproject
use waterbillproject
-- table for New Customer
create table CustomerInfo
(UserName	varchar(50) not null,
passwords	varchar(50) not null,
NationalID	int not null,
SerialID	int not null primary key,
Address	    varchar(50) not null )

-- admin login 
create table adminpass
(pass varchar(30) not null)

insert into adminpass values ('admin')
-- create table for cunsumption and segment number
create table consumption
(SerialID		     int ,
months				 date primary key ,
consumptionamount	 numeric(9,3),
segmentNumber		 int,
price				 money,
foreign key (SerialID) references CustomerInfo (SerialID) )
-- stored procedure for inserting into consumption table without the price
--and update price when we write amount of consumption
create proc usp_insert
(@id				 int ,
 @months			date ,
 @consumptionamount numeric(9,3) ,
 @segmentNumber		int)
as 
insert into consumption(SerialID,months,consumptionamount,segmentNumber) values (@id,@months,@consumptionamount,@segmentNumber) 
update consumption set price = @consumptionamount *3.75 where SerialID =@id and months = @months



-- Debts table
create table Debts
(SerialID	int,
months date,
foreign key (months) references consumption(months),
foreign key (SerialID) references CustomerInfo(SerialID) )

--technical support 
create table techsupport
(discreption varchar(900) )




























