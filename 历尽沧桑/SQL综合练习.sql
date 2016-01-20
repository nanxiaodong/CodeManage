create database mydata--创建数据库
on
(
	name='mydata.mdf',
	filename='E:\练习\mydata.mdf',
	size=3mb,
	filegrowth=1mb
)
log on
(
	name='mydata_log.ldf',
	filename='E:\练习\mydata_log.ldf',
	size=1mb,
	filegrowth=10%
)
----------------------------------------------------------
use mydata--创建数据表
go
create table TT
(
	Fid int identity(1,1) primary key,
	FName nvarchar(50),
	FAge int,
	FSex bit,
	FAddress nvarchar(100)
)
---------------------------------------------------------------
insert into TT (FName,FAge,FSex,FAddress) values('张三',12,1,'郑州');--插入一条数据

insert into TT (FName,FAge,FSex,FAddress) values('冯三',19,'false','郑州经五路');

insert into TT(FName,FAge,FSex,FAddress) values('冯四',17,1,'郑州经五路');

insert into TT(FName,FAge,FSex,FAddress) values('冯四',17,3,'郑州经五路');

insert into TT values('冯六',17,1,'郑州经五路');

update TT set FName=FName+'曼曼' where Fid=1;--追加可使用：字段=字段+值

select * into TTbeifen from TT--备份表结构，对于约束不会备份

select *from TT
----------------------同T-SQL语句添加约束---------------------------------
--1.建表的时候直接添加
use mydata
go

create table zhujianbiao--这是主键表
(
	id int identity(1,1) primary key,
	FName nvarchar(10)
)

create table yueshu--这是外键表
(
	Fid int identity(1,1) primary key,
	
	FAge int not null,--为age添加一个非空约束
	
	FSex nvarchar(1) check(FSex='男' or FSex='女'),--为sex添加一个检查约束
	
	FMoRen nvarchar(10) default('默认值'),--添加一个默认约束
	
	FWeiY nvarchar(50) unique,--添加唯一约束
	
	--外键约束
	FWaiJian int,--类型应与主键表的id类型相同
	foreign key(FWaiJian) references zhujianbiao(id) 
)
--2.修改表结构进行添加约束
	--alter table drop constraint 约束名   --删除约束
	--alter table add constraint 约束名 约束条件等
	alter table add constraint CK_yueshu_FSex check(FSex='男' or FSex='女')
	
insert into zhujianbiao values ('濮阳')--先添加主键表数据

insert into yueshu (FAge,FSex,FWeiY,FWaiJian) values (22,'男','郑州','1')--再添加外键表数据

delete from zhujianbiao--在外键表中的数据没有删除前,主键表中的数据是删不掉的

delete from yueshu --在外键表中的数据没有删除前,主键表中的数据是删不掉的


select *from sys.objects--查看已有约束
---------------------------------------------------------------------------------
alter table TT add FClass nvarchar(20)--增加一列

alter table TT drop column FClass--删除一列

alter table TT alter column FClass int--修改数据类型

select *from TT
----------------------------约束练习------------------------------------------
--Teacher表中
--tSex  控制只能是男 女，默认男 
--tAge  在30-40之间  默认30
create table Teacher
(
	tSex nvarchar(1) check(tSex='男' or tSex='女') default('男'),
	tAge int check(tAge>=30 and tAge<=40) default(30)
)

insert into Teacher values('男',35)
insert into Teacher (tSex) values('女')
insert into Teacher (tAge) values(36)
select *from  Teacher

--Score表中
--studentId 是外键    先要把Student表中的sId设置为主键
--测试1：在学生表（主表）中删除在成绩表中被引用的学生记录。
--测试2：成绩表中添加一条新成绩，studentId在 学生表中没有

create table Student--主键表
(
	id int identity(1,1) primary key,
	name nvarchar(10),
	age int,
	gender nvarchar(1) check(gender='男' or gender='女')
)

create table Score
(
	Sourceid int identity(1,1) primary key,
	English int,
	Math int,
	StudentId int,
	foreign key(StudentId) references Student(id)
)

select *from Score
select*from Student

insert into Student values('张三',18,'男');

insert into Student values('李四',17,'男');

insert into Student values('小兰',17,'女');

insert into Score values(130,85,3);
insert into Score values(70,135,1);

delete from Student where id=1 --在外键表数据没有删之前，主键表中的数据是不能删除的
 --------------------------------别名----------------------------------------------
 select *from TT
 --1.字段 as 别名
 select Fid as id,FName as 姓名,FAge as 年龄,FSex as 性别,FAddress as 地址,FClass as 班级 from TT
 --2.省略as
 select Fid  id,FName  姓名,FAge  年龄,FSex  性别,FAddress  地址,FClass  班级 from TT--去掉as也可以
 --3.别名=字段
 select  id=Fid,姓名=FName,年龄=FAge,性别=FSex,地址=FAddress,班级=FClass from TT
------------------------------------------------------------------------------------
select GETDATE()--打印在结果里面
print getdate()--打印在消息里面
--------------------------排序--------------------------------------------
select *from dbo.ScoreShiWan order by english asc--asc升序，如果不写默认就是asc
 
select*from dbo.ScoreShiWan order by Math desc--desc降序排列

select*from dbo.ScoreShiWan order by Chinese ,Zonghe desc

---------------------------top表示取前几行或前百分之几的数据-------------------------------------
select top 10* from dbo.ScoreShiWan order by English desc

select top 1 percent *from dbo.ScoreShiWan order by Zonghe desc
----------------------------聚合函数------------------------------------------
--聚合函数就是用来求值的

select MAX(English) from ScoreShiWan--求出英语最大值

select MIN(Zonghe) as 分数 from ScoreShiWan--求出综合分数最少的分数

select COUNT(*) from dbo.StudentShiWan where FAge=10 --年龄为10的人数

--用AVG计算时，对于null数据不计入总数
select AVG(English),AVG(Math),AVG(Chinese) from ScoreShiWan --求出的平局值

----------------------------模糊查询--------------------------------
select * from StudentShiWan where FName like '张%'--查询出所有行张的学生信息

select*from StudentShiWan where FName like '[张安]%'--查询出所有性张和性安的同学信息

select *from StudentShiWan where FName not like '[张安]%'--查询出所有不性张和安的同学的信息
select*from StudentShiWan where FName like '[^张安]%'--查询出所有不性张和安的同学的信息

select *from StudentShiWan where FName like '_绍辉'-- _单字符匹配
select *from StudentShiWan where FName like '[_]绍辉'-- 表示匹配一个下划线

---------------------------空值处理------------------------------------------
select*from TT

select COUNT(*)from TT where FSex is null--查询出性别为空的数据个数

select COUNT(*) from TT where FSex is not null--查询出性别不为空的数据个数

select FName,FAge,ISNULL(FSex,'0')as 性别 from TT--如果字段为空填充一个默认的值
------------------------关于datalength与len-----------------------------------
select DATALENGTH('中原油田')--结果为8   datalength用来计算字节数

select LEN('中原油田')--结果为4    len用来计算字符数
----------------------------数据分组------------------------------------
select FGender from StudentShiWan group by FGender--按性别进行分组
select COUNT(*)as 人数, FGender from StudentShiWan group by FGender--查询出性别为‘男’的人数和性别为‘女’的人数

select COUNT(*) ,FAddress from TT group by FAddress having COUNT(*)<3


------------------------------两表联合----------------------------------------
use Itcast201202
--union会自动合并重复的数据，union all会保留重复数据

select Fid, FName, cast( FAge as nvarchar(20))as 转换类型了,FSex, weiyi, [address] from dbo.MyStudent1
union
select * from dbo.MyStudent2
-------------------------练习----------
--要求在一个表格中查询出学生的英语最高成绩、最低成绩、平均成绩

select top 1 English from dbo.ScoreShiWan order by English desc--得到最大值
select MAX(English) from dbo.ScoreShiWan --得到最大值

select MIN(English) from dbo.ScoreShiWan--得到最低分

select AVG(English) from dbo.ScoreShiWan--得到平均分
-------------------
select '最高分'as 类别, MAX(English) as 分数 from dbo.ScoreShiWan --得到最大值
union all
select '最低分', MIN(English) from dbo.ScoreShiWan--得到最低分
union all
select '平均分', AVG(English) from dbo.ScoreShiWan--得到平均分

---------------------------插入多个数据------------------------------------------
select*from dbo.MyStudent2

insert into dbo.MyStudent2(FAge, FSex, FMoRen, FWeiYi, FWaiJian)
select 12,'男','1',6,2 union
select 2,'女','1',5,2
------------------------------常见的函数-------------------------------------
select LEN('濮阳')--字符数
select DATALENGTH('濮阳')--字节数

select LOWER('AsAfgJ'),UPPER('AsAfgJ')--LOWER转小写，UPPER转大写

select LTRIM('     abg'),RTRIM('sda             ')--去掉左右两边的空格

select SUBSTRING('abfxhs',2,3)--(索引从1开始) 索引为2的开始位子，长度为3   

select GETDATE()--获得当前时间
select YEAR(GETDATE())--获得年

create table morenshijian--获得当前时间
(
	Fname nvarchar(10),
	gettime datetime default(getdate())
)
insert into morenshijian (Fname) values('当前时间为')
select *from morenshijian

select DATEDIFF(YEAR,'1990',GETDATE())--如果1990去掉引号就不把它作为时间来看了

select FAge as 年龄, COUNT(*)as 人数 from dbo.StudentShiWan group by FAge

select DATEADD(yy,-FAge,GETDATE())as 出生年月,COUNT(*)as 人数 from dbo.StudentShiWan group by FAge--获得出生年月
 
 
select '1'+'1'--结果为11
select CAST('1' as int)+ CONVERT(int,'1')--结果为2

----------------------------练习----------------------------------------
select*from dbo.CallRecords
--要求：输出所有数据中通话时间最长的5条记录
select top 5 *,datediff(ss,StartDateTime,EndDateTime) as 通话时长 
from dbo.CallRecords 
order by datediff(ss,StartDateTime,EndDateTime) desc

--输出所有数据中拨打长度号码（对方号码以0开头）的总时长
select *from dbo.CallRecords where TelNum like '0%'--查询出所有的以0开头的电话号码

select sum(datediff(ss,StartDateTime,EndDateTime)) from dbo.CallRecords where TelNum like '0%'

--输出本月通话总时长最多的前三个呼叫员的编号
select top 3 
	CallerNumber,sum(datediff(ss,StartDateTime,EndDateTime))as 总时长
 from 
	dbo.CallRecords 
 group by 
	CallerNumber
 order by 
	sum(datediff(ss,StartDateTime,EndDateTime)) desc
	
--输出本月拨打电话字数最多的前三个呼叫员的编号
select*from dbo.CallRecords

select top 3 CallerNumber,COUNT(*)as 通话次数 
from 
	dbo.CallRecords
where 
	MONTH(EndDateTime)=MONTH('2010-7-30')
group by
	CallerNumber
order by COUNT(*)desc

-----------------------子查询-----------------------------------------------
select*from dbo.ScoreShiWan


select top 3 id from dbo.ScoreShiWan order by Math desc--desc降序排列

select top 10* from dbo.ScoreShiWan order by English desc

select* from dbo.ScoreShiWan 
where id in(select top 3 id from dbo.ScoreShiWan order by English desc)


-----------------------连接与联合-------------------------------------
--连接union是把列连起来
--联合union all是把行连接起来
--left join左外联
--right join 右外联
-----------------视图------------------
create view vw_zichaxun
as
select* from dbo.ScoreShiWan 
where id in(select top 3 id from dbo.ScoreShiWan order by English desc)

select * from vw_zichaxun
----------------------------定义一个变量--------------------------------
declare @n int--定义一个变量
set @n=10;--第一种给变量赋值的方法
set @n =@n +1;
select @n=@n+2;--第二种给变量赋值的方法
print @n--打印出@n的值，值为13
select @n--打印出@n的值，值为13


declare @x int
--声明变量在使用前必须赋值，否则为null，通过null和任何值计算结果还是null(不知道)
set @x =@x+1;
select @x
--------------全局变量------------------
print @@SERVERNAME--打印出计算机名称
----------计算1到100之间的奇数和-------------------------------
--declare @sum int
--set @sum=0
--declare @i int 
--set @i=1

--while(@i<100)
--begin
--	--判断@i是否为奇数
--	if(@i%2=0)
--		begin
--			set @i=@i+1;
--			continue;
--		end
--	else
--		begin
--			set @sum=@sum+@i;
--		end
--	set @i=@i+1;
	
--end
--select @sum

-----------------------计算1-100之间所有奇数的和-------------------------------------
declare @sum int
declare @i int
set @sum=0
set @i=0

while(@i<=100)
begin
	--判断是否为奇数
	if(@i%2=0)
		begin
			set @i=@i+1;
			continue;
		end
	else
		begin
			set @sum=@sum+@i;
		end
	set @i=@i+1
end
select @sum


begin tran

