use master
go

if DB_ID('QuanLyBanHang') is not null
drop database QuanLyBanHang
create database QuanLyBanHang
go

use QuanLyBanHang
go

create table Users
(
id int identity(1,1),
userid varchar(10) primary key,
username nvarchar(50),
userpassword varchar(30),
roleid varchar(10)
)

create table Roles
(
id int identity(1,1),
roleid varchar(10) primary key,
rolename nvarchar(30),
roledes nvarchar(100),
rfull bit,
raccess bit,
radd bit,
redit bit,
rdelete bit,
rprint bit,
rwrite bit,
rread bit
)

alter table Users
add
foreign key (roleid)
references Roles(roleid)


insert into Roles values('1','Administrator','abcxyt',1,1,1,1,1,1,1,1)
insert into Roles values('2','Staff','abcczxca',0,0,0,1,0,1,0,1)
insert into Users values('001','pvqui','123','1')
insert into Users values('002','admin','1','1')

select * from Users where username='pvqui' and userpassword='123'

select * from Users
select * from Roles

