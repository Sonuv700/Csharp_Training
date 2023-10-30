-- Create a new database for the Student Management System
CREATE DATABASE StudentManagementDB;
USE StudentManagementDB;

-- Create a table for students
CREATE TABLE Students (
    StudentId INT PRIMARY KEY ,
    StudentName VARCHAR(30),
    DateOfBirth varchar(20),
	courseid int foreign key references courses(courseId) 
);
select * from students;
drop table students;

-- Create a table for courses
CREATE TABLE Courses (
    CourseId INT PRIMARY KEY ,
    CourseName VARCHAR(30)
);

-- Create a table for enrollments

drop table Enrollments;
INSERT INTO Courses VALUES 
(100, 'Computer science and engg'),
(101, 'Information science and engg'),
(102, 'electronics and comm engg'),
(103, 'electrical engg'),
(104, 'Mechanical and engg'),
(105, 'Civil engg');



