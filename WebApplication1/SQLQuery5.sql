create table Student1(
StudentID int not null,
StudentName varchar(max) not null,
StandardId varchar(250) not null,
Primary Key (StudentID),
)

create table StudentAddress1(
StudentID int not null,
Adress1 varchar(max) not null,
Adress2 varchar(max) ,
City varchar(250) not null,
"State" varchar(250) not null,
Foreign Key (StudentID)references Student1(StudentID),
)

create table Course1(
CourseId int not null,
CourseName varchar(250) not null,
"Location" varchar(250) not null,
TeacherId int not null,
Primary key (CourseId),
)

create table StudenCourse1(
StudentId int not null,
CourseId int not null,
Foreign key (StudentId) references Student1(StudentId),
Foreign key (CourseId) references Course1(CourseId),
)

create table Teacher1(
TeacherId int not null,
TeacherName varchar(max) not null,
StandadId varchar(250) not null,
TeacherType varchar(250) not null,

Primary key (TeacherId),
)

create table Standard1(
StandardId varchar(250) not null,
StandardName varchar(250) not null,
"Description" varchar(250) not null,
Primary Key (StandardId),
)
