create database mydata--�������ݿ�
on
(
	name='mydata.mdf',
	filename='E:\��ϰ\mydata.mdf',
	size=3mb,
	filegrowth=1mb
)
log on
(
	name='mydata_log.ldf',
	filename='E:\��ϰ\mydata_log.ldf',
	size=1mb,
	filegrowth=10%
)
----------------------------------------------------------
use mydata--�������ݱ�
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
insert into TT (FName,FAge,FSex,FAddress) values('����',12,1,'֣��');--����һ������

insert into TT (FName,FAge,FSex,FAddress) values('����',19,'false','֣�ݾ���·');

insert into TT(FName,FAge,FSex,FAddress) values('����',17,1,'֣�ݾ���·');

insert into TT(FName,FAge,FSex,FAddress) values('����',17,3,'֣�ݾ���·');

insert into TT values('����',17,1,'֣�ݾ���·');

update TT set FName=FName+'����' where Fid=1;--׷�ӿ�ʹ�ã��ֶ�=�ֶ�+ֵ

select * into TTbeifen from TT--���ݱ�ṹ������Լ�����ᱸ��

select *from TT
----------------------ͬT-SQL������Լ��---------------------------------
--1.�����ʱ��ֱ�����
use mydata
go

create table zhujianbiao--����������
(
	id int identity(1,1) primary key,
	FName nvarchar(10)
)

create table yueshu--���������
(
	Fid int identity(1,1) primary key,
	
	FAge int not null,--Ϊage���һ���ǿ�Լ��
	
	FSex nvarchar(1) check(FSex='��' or FSex='Ů'),--Ϊsex���һ�����Լ��
	
	FMoRen nvarchar(10) default('Ĭ��ֵ'),--���һ��Ĭ��Լ��
	
	FWeiY nvarchar(50) unique,--���ΨһԼ��
	
	--���Լ��
	FWaiJian int,--����Ӧ���������id������ͬ
	foreign key(FWaiJian) references zhujianbiao(id) 
)
--2.�޸ı�ṹ�������Լ��
	--alter table drop constraint Լ����   --ɾ��Լ��
	--alter table add constraint Լ���� Լ��������
	alter table add constraint CK_yueshu_FSex check(FSex='��' or FSex='Ů')
	
insert into zhujianbiao values ('���')--���������������

insert into yueshu (FAge,FSex,FWeiY,FWaiJian) values (22,'��','֣��','1')--��������������

delete from zhujianbiao--��������е�����û��ɾ��ǰ,�������е�������ɾ������

delete from yueshu --��������е�����û��ɾ��ǰ,�������е�������ɾ������


select *from sys.objects--�鿴����Լ��
---------------------------------------------------------------------------------
alter table TT add FClass nvarchar(20)--����һ��

alter table TT drop column FClass--ɾ��һ��

alter table TT alter column FClass int--�޸���������

select *from TT
----------------------------Լ����ϰ------------------------------------------
--Teacher����
--tSex  ����ֻ������ Ů��Ĭ���� 
--tAge  ��30-40֮��  Ĭ��30
create table Teacher
(
	tSex nvarchar(1) check(tSex='��' or tSex='Ů') default('��'),
	tAge int check(tAge>=30 and tAge<=40) default(30)
)

insert into Teacher values('��',35)
insert into Teacher (tSex) values('Ů')
insert into Teacher (tAge) values(36)
select *from  Teacher

--Score����
--studentId �����    ��Ҫ��Student���е�sId����Ϊ����
--����1����ѧ����������ɾ���ڳɼ����б����õ�ѧ����¼��
--����2���ɼ��������һ���³ɼ���studentId�� ѧ������û��

create table Student--������
(
	id int identity(1,1) primary key,
	name nvarchar(10),
	age int,
	gender nvarchar(1) check(gender='��' or gender='Ů')
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

insert into Student values('����',18,'��');

insert into Student values('����',17,'��');

insert into Student values('С��',17,'Ů');

insert into Score values(130,85,3);
insert into Score values(70,135,1);

delete from Student where id=1 --�����������û��ɾ֮ǰ���������е������ǲ���ɾ����
 --------------------------------����----------------------------------------------
 select *from TT
 --1.�ֶ� as ����
 select Fid as id,FName as ����,FAge as ����,FSex as �Ա�,FAddress as ��ַ,FClass as �༶ from TT
 --2.ʡ��as
 select Fid  id,FName  ����,FAge  ����,FSex  �Ա�,FAddress  ��ַ,FClass  �༶ from TT--ȥ��asҲ����
 --3.����=�ֶ�
 select  id=Fid,����=FName,����=FAge,�Ա�=FSex,��ַ=FAddress,�༶=FClass from TT
------------------------------------------------------------------------------------
select GETDATE()--��ӡ�ڽ������
print getdate()--��ӡ����Ϣ����
--------------------------����--------------------------------------------
select *from dbo.ScoreShiWan order by english asc--asc���������дĬ�Ͼ���asc
 
select*from dbo.ScoreShiWan order by Math desc--desc��������

select*from dbo.ScoreShiWan order by Chinese ,Zonghe desc

---------------------------top��ʾȡǰ���л�ǰ�ٷ�֮��������-------------------------------------
select top 10* from dbo.ScoreShiWan order by English desc

select top 1 percent *from dbo.ScoreShiWan order by Zonghe desc
----------------------------�ۺϺ���------------------------------------------
--�ۺϺ�������������ֵ��

select MAX(English) from ScoreShiWan--���Ӣ�����ֵ

select MIN(Zonghe) as ���� from ScoreShiWan--����ۺϷ������ٵķ���

select COUNT(*) from dbo.StudentShiWan where FAge=10 --����Ϊ10������

--��AVG����ʱ������null���ݲ���������
select AVG(English),AVG(Math),AVG(Chinese) from ScoreShiWan --�����ƽ��ֵ

----------------------------ģ����ѯ--------------------------------
select * from StudentShiWan where FName like '��%'--��ѯ���������ŵ�ѧ����Ϣ

select*from StudentShiWan where FName like '[�Ű�]%'--��ѯ���������ź��԰���ͬѧ��Ϣ

select *from StudentShiWan where FName not like '[�Ű�]%'--��ѯ�����в����źͰ���ͬѧ����Ϣ
select*from StudentShiWan where FName like '[^�Ű�]%'--��ѯ�����в����źͰ���ͬѧ����Ϣ

select *from StudentShiWan where FName like '_�ܻ�'-- _���ַ�ƥ��
select *from StudentShiWan where FName like '[_]�ܻ�'-- ��ʾƥ��һ���»���

---------------------------��ֵ����------------------------------------------
select*from TT

select COUNT(*)from TT where FSex is null--��ѯ���Ա�Ϊ�յ����ݸ���

select COUNT(*) from TT where FSex is not null--��ѯ���Ա�Ϊ�յ����ݸ���

select FName,FAge,ISNULL(FSex,'0')as �Ա� from TT--����ֶ�Ϊ�����һ��Ĭ�ϵ�ֵ
------------------------����datalength��len-----------------------------------
select DATALENGTH('��ԭ����')--���Ϊ8   datalength���������ֽ���

select LEN('��ԭ����')--���Ϊ4    len���������ַ���
----------------------------���ݷ���------------------------------------
select FGender from StudentShiWan group by FGender--���Ա���з���
select COUNT(*)as ����, FGender from StudentShiWan group by FGender--��ѯ���Ա�Ϊ���С����������Ա�Ϊ��Ů��������

select COUNT(*) ,FAddress from TT group by FAddress having COUNT(*)<3


------------------------------��������----------------------------------------
use Itcast201202
--union���Զ��ϲ��ظ������ݣ�union all�ᱣ���ظ�����

select Fid, FName, cast( FAge as nvarchar(20))as ת��������,FSex, weiyi, [address] from dbo.MyStudent1
union
select * from dbo.MyStudent2
-------------------------��ϰ----------
--Ҫ����һ������в�ѯ��ѧ����Ӣ����߳ɼ�����ͳɼ���ƽ���ɼ�

select top 1 English from dbo.ScoreShiWan order by English desc--�õ����ֵ
select MAX(English) from dbo.ScoreShiWan --�õ����ֵ

select MIN(English) from dbo.ScoreShiWan--�õ���ͷ�

select AVG(English) from dbo.ScoreShiWan--�õ�ƽ����
-------------------
select '��߷�'as ���, MAX(English) as ���� from dbo.ScoreShiWan --�õ����ֵ
union all
select '��ͷ�', MIN(English) from dbo.ScoreShiWan--�õ���ͷ�
union all
select 'ƽ����', AVG(English) from dbo.ScoreShiWan--�õ�ƽ����

---------------------------����������------------------------------------------
select*from dbo.MyStudent2

insert into dbo.MyStudent2(FAge, FSex, FMoRen, FWeiYi, FWaiJian)
select 12,'��','1',6,2 union
select 2,'Ů','1',5,2
------------------------------�����ĺ���-------------------------------------
select LEN('���')--�ַ���
select DATALENGTH('���')--�ֽ���

select LOWER('AsAfgJ'),UPPER('AsAfgJ')--LOWERתСд��UPPERת��д

select LTRIM('     abg'),RTRIM('sda             ')--ȥ���������ߵĿո�

select SUBSTRING('abfxhs',2,3)--(������1��ʼ) ����Ϊ2�Ŀ�ʼλ�ӣ�����Ϊ3   

select GETDATE()--��õ�ǰʱ��
select YEAR(GETDATE())--�����

create table morenshijian--��õ�ǰʱ��
(
	Fname nvarchar(10),
	gettime datetime default(getdate())
)
insert into morenshijian (Fname) values('��ǰʱ��Ϊ')
select *from morenshijian

select DATEDIFF(YEAR,'1990',GETDATE())--���1990ȥ�����žͲ�������Ϊʱ��������

select FAge as ����, COUNT(*)as ���� from dbo.StudentShiWan group by FAge

select DATEADD(yy,-FAge,GETDATE())as ��������,COUNT(*)as ���� from dbo.StudentShiWan group by FAge--��ó�������
 
 
select '1'+'1'--���Ϊ11
select CAST('1' as int)+ CONVERT(int,'1')--���Ϊ2

----------------------------��ϰ----------------------------------------
select*from dbo.CallRecords
--Ҫ���������������ͨ��ʱ�����5����¼
select top 5 *,datediff(ss,StartDateTime,EndDateTime) as ͨ��ʱ�� 
from dbo.CallRecords 
order by datediff(ss,StartDateTime,EndDateTime) desc

--������������в��򳤶Ⱥ��루�Է�������0��ͷ������ʱ��
select *from dbo.CallRecords where TelNum like '0%'--��ѯ�����е���0��ͷ�ĵ绰����

select sum(datediff(ss,StartDateTime,EndDateTime)) from dbo.CallRecords where TelNum like '0%'

--�������ͨ����ʱ������ǰ��������Ա�ı��
select top 3 
	CallerNumber,sum(datediff(ss,StartDateTime,EndDateTime))as ��ʱ��
 from 
	dbo.CallRecords 
 group by 
	CallerNumber
 order by 
	sum(datediff(ss,StartDateTime,EndDateTime)) desc
	
--������²���绰��������ǰ��������Ա�ı��
select*from dbo.CallRecords

select top 3 CallerNumber,COUNT(*)as ͨ������ 
from 
	dbo.CallRecords
where 
	MONTH(EndDateTime)=MONTH('2010-7-30')
group by
	CallerNumber
order by COUNT(*)desc

-----------------------�Ӳ�ѯ-----------------------------------------------
select*from dbo.ScoreShiWan


select top 3 id from dbo.ScoreShiWan order by Math desc--desc��������

select top 10* from dbo.ScoreShiWan order by English desc

select* from dbo.ScoreShiWan 
where id in(select top 3 id from dbo.ScoreShiWan order by English desc)


-----------------------����������-------------------------------------
--����union�ǰ���������
--����union all�ǰ�����������
--left join������
--right join ������
-----------------��ͼ------------------
create view vw_zichaxun
as
select* from dbo.ScoreShiWan 
where id in(select top 3 id from dbo.ScoreShiWan order by English desc)

select * from vw_zichaxun
----------------------------����һ������--------------------------------
declare @n int--����һ������
set @n=10;--��һ�ָ�������ֵ�ķ���
set @n =@n +1;
select @n=@n+2;--�ڶ��ָ�������ֵ�ķ���
print @n--��ӡ��@n��ֵ��ֵΪ13
select @n--��ӡ��@n��ֵ��ֵΪ13


declare @x int
--����������ʹ��ǰ���븳ֵ������Ϊnull��ͨ��null���κ�ֵ����������null(��֪��)
set @x =@x+1;
select @x
--------------ȫ�ֱ���------------------
print @@SERVERNAME--��ӡ�����������
----------����1��100֮���������-------------------------------
--declare @sum int
--set @sum=0
--declare @i int 
--set @i=1

--while(@i<100)
--begin
--	--�ж�@i�Ƿ�Ϊ����
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

-----------------------����1-100֮�����������ĺ�-------------------------------------
declare @sum int
declare @i int
set @sum=0
set @i=0

while(@i<=100)
begin
	--�ж��Ƿ�Ϊ����
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

