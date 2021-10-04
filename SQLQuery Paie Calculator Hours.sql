create database	Paie
use Paie

create table Paie_initial(
Id_Table nvarchar(max) not null,
Matricule nvarchar(max) not null,
FullName varchar(max) not null,
The_Date date null,
Entree_01 time null,
Sortie_01 time null,
Entree_02 time null,
Sortie_02 time null,
Entree_03 time null,
Sortie_03 time null,
Original_Time_Minutes time null,
The_Time DateTime default getdate() null
);

create table Paie_total(
Id_Table nvarchar(max) not null,
Matricule nvarchar(max) not null,
FullName varchar(max) not null,
The_Date varchar(max) not null,
Entree_01 nvarchar(max) null,
Sortie_01 nvarchar(max) null,
Entree_02 nvarchar(max) null,
Sortie_02 nvarchar(max) null,
Entree_03 nvarchar(max) null,
Sortie_03 nvarchar(max) null,
Original_Time_Minutes nvarchar(max) null,
Total nvarchar(max) null,
Temps_Sortie nvarchar(max) null,
The_Time DateTime default getdate() null
);

create table section(
id int not null
);

create table cibel_liste(
value nvarchar(max) not null,
matricule nvarchar(max) not null,
name varchar(max) not null,
persnl_time nvarchar(max) not null
);

create table archiv_liste(
value nvarchar(max) not null,
matricule nvarchar(max) not null,
name varchar(max) not null,
persnl_time nvarchar(max) not null
);

create table Final_Total(
Id_Table nvarchar(max) not null,
Matricule nvarchar(max) not null,
FullName varchar(max) not null,
H_Cibel time null,
H_Blue time null,
The_Time DateTime default getdate() null
);

create table Final_Total_Calculated(
Id_Table nvarchar(max) not null,
Matricule nvarchar(max) not null,
FullName varchar(max) not null,
H_Cibel nvarchar(max) null,
H_Blue nvarchar(max) null,
NH_Cibel float null,
NH_Blue float null,
Prime nvarchar(max) null,
H_All nvarchar(max) null,
H_Blue_100 float null,
H_Blue_125 float null,
The_Time DateTime default getdate() null
);

create table QZ_Convert_Hours(
Id_Table nvarchar(max) not null,
matricule nvarchar(max) not null,
name varchar(max) not null,
Total_hours float not null
);

create table QZ_Calcul(
Id_Table nvarchar(max) not null,
matricule nvarchar(max) not null,
name varchar(max) not null,
Total_hours float not null,
H_Cibel float not null,
H_Blue float not null
);

create table HoursCreation(
Id_Table nvarchar(max) not null,
Matricule nvarchar(max) not null,
FullName varchar(max) not null,
TotalHours nvarchar(max) not null,
The_Date varchar(max) not null,
TheDay nvarchar(max) not null,
TimeOfEntry nvarchar(max) null,
TimeOfExit nvarchar(max) null,
HoursType nvarchar(max) not null,
Company nvarchar(max) not null
);

create table WK_Hours(
Id_Table nvarchar(max) not null,
matricule nvarchar(max) not null,
name varchar(max) not null,
H_Cibel float not null,
H_Blue float not null
);





insert into section values(100111),(100112),(100113),(2000),(10012)


select * from Paie_initial where Id_Table='99' order by Matricule

select * from Paie_total

delete Paie_total where Id_Table='t01'

update Paie_initial set Sortie_03='05:10' where Id_Table='99' and Matricule='005127FSOS'

insert into Paie_initial values ('test01','000068por','mr','20/07/2020','08:00','12:00','15:20','22:45')

select distinct Matricule,FullName,left(The_Date,10)[The_Date],left(Temps_Sortie,5)[Temps_Sortie]  from Paie_total where Id_Table = '999'

select distinct Matricule,left(The_Date,10)[The_Date],left(Temps_Sortie,5)[Temps_Sortie]  from Paie_total where Id_Table='mpf0508'



/*Trigger replace empty columns 01*/
create trigger replace_empty_time_column01 on Paie_initial After insert as
update Paie_initial set Entree_01='00:00', Sortie_01='00:00' where Entree_01= '' and Sortie_01= ''

/*Trigger replace empty columns 02*/
create trigger replace_empty_time_column02 on Paie_initial After insert as
update Paie_initial set Entree_02='00:00', Sortie_02='00:00' where Entree_02= '' and Sortie_02= ''

/*Trigger replace empty columns 03*/
create trigger replace_empty_time_column03 on Paie_initial After insert as
update Paie_initial set Entree_03='00:00', Sortie_03='00:00' where Entree_03= '' and Sortie_03= ''

*************************************************

/*Trigger replace null columns01*/
create trigger replace_empty_null_column01 on Paie_initial After insert as
update Paie_initial set Entree_01='00:00', Sortie_01='00:00' where Entree_01 is null or Sortie_01 is null

/*Trigger replace null columns02*/
create trigger replace_empty_null_column02 on Paie_initial After insert as
update Paie_initial set Entree_02='00:00', Sortie_02='00:00' where Entree_02 is null or Sortie_02 is null

/*Trigger replace null columns03*/
create trigger replace_empty_null_column03 on Paie_initial After insert as
update Paie_initial set Entree_03='00:00', Sortie_03='00:00' where Entree_03 is null or Sortie_03 is null

******************************************************


/*Trigger change the value of Time in Archive from 8 characters to 5*/
create trigger replace_time_in_archiv on archiv_liste After insert as
UPDATE HoursCreation SET The_Date = SUBSTRING(The_Date, 0, 11)

************************************************************************************************************

/*Trigger replace Temps_Sortie column*/
create trigger replace_Temps_Sortie_column on Paie_total After insert as
update Paie_total set Temps_Sortie= null where Temps_Sortie='103.04:40:39'

************************************************************************************************************
/*Delet both tables at the same time*/

BEGIN DELETE FROM    Paie_initial  DELETE FROM    Paie_total END

******************************************************

select distinct Id_Table, CONVERT(char(20), The_Time) from Paie_initial order by  CONVERT(char(20), The_Time) desc

select distinct Id_Table, CONVERT(char(20), The_Time) from Paie_total order by  CONVERT(char(20), The_Time) desc

************************************************************************************************************
/*select the same matricule in both tables*/
select cibel_liste.matricule, cibel_liste.name, cibel_liste.persnl_time, archiv_liste.matricule, archiv_liste.name, right(archiv_liste.persnl_time, 8) [persnl_time] from archiv_liste, cibel_liste where archiv_liste.matricule = cibel_liste.matricule and cibel_liste.value='F206' and archiv_liste.value='F206'
/*Updated*/
select cibel_liste.matricule, cibel_liste.name, right(cibel_liste.persnl_time, 8) [time], archiv_liste.matricule, archiv_liste.name, right(archiv_liste.persnl_time, 5) [time] from archiv_liste, cibel_liste where archiv_liste.matricule = cibel_liste.matricule and cibel_liste.value='5' and archiv_liste.value= '5'

************************************************************************************************************
/*select the matricules that exist only on the first table*/
select * from cibel_liste where cibel_liste.matricule not in (select archiv_liste.matricule from archiv_liste where archiv_liste.value='F206') and cibel_liste.value='F206' 

/*select first 11 char of a column*/
SELECT convert(char(11), persnl_time, 10) [time] FROM archiv_liste

/*select last 8 char of a column*/
SELECT right(archiv_liste.persnl_time, 8) [time] FROM archiv_liste
************************************************************************************************************
/*Trigger change the value of Time in Cibel from 8 characters to 5*/
create trigger replace_time_in_cibel on cibel_liste After insert as
UPDATE cibel_liste SET persnl_time = SUBSTRING(persnl_time, 1, 16)

************************************************************************************************************
/*Trigger change the value of Time in Archive from 8 characters to 5*/
create trigger replace_time_in_archiv on archiv_liste After insert as
UPDATE archiv_liste SET persnl_time = SUBSTRING(persnl_time, 1, 16)

************************************************************************************************************
/*Delet both tables at the same time*/

BEGIN DELETE FROM    cibel_liste  DELETE FROM    archiv_liste END
************************************************************************************************************
/*Combobx calling*/
select distinct value from cibel_liste order by value desc
************************************************************************************************************

/*Select empty persnl_time in Archive*/
select distinct matricule, name, persnl_time from archiv_liste where persnl_time ='' and value = 'mr'
************************************************************************************************************

/*Delet both tables at the same time*/

BEGIN DELETE FROM    Final_Total  DELETE FROM    Final_Total_Calculated END

******************************************************

/*Trigger replace empty Prime whre Prime = 0*/
create trigger replace_empty_Prime on Final_Total_Calculated After insert as
update Final_Total_Calculated set Prime = '' where Prime = 0

/*Trigger replace empty empty H_All whre H_All = 0*/
create trigger replace_empty_H_All on Final_Total_Calculated After insert as
update Final_Total_Calculated set H_All = '' where H_All = 0
************************************************************************************************************

/*Trigger change the value of Time in Archive from 8 characters to 5*/
create trigger replace_date_in_hourscreation on HoursCreation After insert as
UPDATE HoursCreation SET The_Date = SUBSTRING(The_Date, 0, 11)

************************************************************************************************************
/*Trigger replace TimeOfEntry column HoursCreation*/
create trigger replace_TimeOfEntry_column on HoursCreation After insert as
update HoursCreation set TimeOfEntry= null where TimeOfEntry='103.04:40:39'

************************************************************************************************************
/*Trigger replace TimeOfExit column HoursCreation*/
create trigger replace_TimeOfExit_column on HoursCreation After insert as
update HoursCreation set TimeOfExit= null where TimeOfExit='103.04:40:39'

************************************************************************************************************



INSERT INTO Paie_total VALUES('','007070FSOS','ENNAKNAFI RKIA','05/08/2020 00:00:00','','','','','','','','22:35:00')


select * from Paie_total where Matricule='000368FSOS'

select distinct Id_Table from Paie_initial where Temps_Sortie='103.04:40:39'

select * from Paie_initial where Id_Table='999'


delete from Paie_initial
delete from Paie_total

select * from archiv_liste WHERE value='F206' order by matricule

select archiv_liste.matricule, archiv_liste.name, right(persnl_time, 8) as Time from archiv_liste WHERE value='TEST'

select distinct archiv_liste.value from archiv_liste

select cibel_liste.matricule, cibel_liste.name, right(cibel_liste.persnl_time, 8) [time], archiv_liste.matricule, archiv_liste.name, right(archiv_liste.persnl_time, 8) [time] from archiv_liste, cibel_liste where archiv_liste.matricule = cibel_liste.matricule and cibel_liste.value='mr1' and archiv_liste.value='mr1'

select cibel_liste.matricule, cibel_liste.name, right(cibel_liste.persnl_time, 8) [time] from cibel_liste where cibel_liste.matricule not in (select archiv_liste.matricule from archiv_liste where archiv_liste.value='mr1') and cibel_liste.value='mr1'

select * from cibel_liste

************************************************************************************************************

delete Final_Total

select distinct * from Final_Total where Id_Table ='123654'

select distinct Matricule,FullName,H_Cibel,convert(char(5), H_Blue, 10) as H_Blue from Final_Total where Id_Table ='123654'

SELECT convert(char(1), H_Blue, 10) [time] FROM Final_Total

UPDATE Final_Total SET H_Blue= LEN(H_Blue)-1

UPDATE Final_Total SET H_Blue = SUBSTRING(H_Blue, 0, 6)


select distinct Matricule, FullName, NH_Cibel, Prime, H_All, H_Blue_100, H_Blue_125 from Final_Total_Calculated

select distinct Id_Table, CONVERT(char(20), The_Time) from Final_Total_Calculated order by CONVERT(char(20), The_Time) desc


******************************************************


