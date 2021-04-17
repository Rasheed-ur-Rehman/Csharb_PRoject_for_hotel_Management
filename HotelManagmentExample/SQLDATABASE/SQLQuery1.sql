create database customer


use customer

create table  customer1(
id int primary key  not null,
C_Name varchar(30),
C_Address varchar(40),
C_Phone  varchar(50),
C_Dob varchar(40),
C_Email varchar(30),
)
select * from customer1

insert into customer1 values(1801,'Rasheed','abc chitral','03485496769','aug/05/1996','rasheed1612e@aptechgdn.net')



create table registration(
id int primary key identity, 
Firstname varchar(30),
LastName varchar(30),
contect varchar(30),
Address varchar(30),
Email varchar(30),
country varchar(30),
jobtitle varchar(30)
)

create table BillDetail(
id int primary key,
Gust_Name varchar(30),
cuntury varchar(30),
Phone varchar(30),
Address varchar(30),
Gender varchar(30),
 RoomType varchar(30),
 RoomNo varchar(30),
No_Person varchar(30),
Childern  varchar(30),
staying_Day int,
total int ,
Other_Charges varchar(30),
Sub_Total varchar(30),
date varchar(30),
)
create table staffdetail(
id int primary key identity,
Name varchar(30),
Address varchar(30),
Education varchar(30),
Salary varchar(30),
joining_date varchar(30),
)

select * from staffdetail


create table GustInformation(
id int primary key,

Name Varchar(20),

Country varchar(20),

P_No int,

Address varchar(30),
Gender varchar(30),
Room_type varchar(20),

Roon_no int,
No_Person int,
Children varchar(20),

Chectin varchar(30),
Stayin int,
Chect_Out varchar(30),
)

select * from GustInformation

