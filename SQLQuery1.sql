Create Database RainbowSchool
Use RainbowSchool
Drop Table Teacher
Create table Student (
StudentID int Primary Key not null,
 StudentName nvarchar(50),
StudentClass int)
Create table Teacher (
TeacherId int Primary Key not null,
 TeacherName nvarchar(50),
TeacherSubject int)
select * from Teacher
select * from Student
