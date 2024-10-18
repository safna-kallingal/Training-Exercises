--create table candidates (Id int,Name varchar(20),Email varchar(25),Age float(5),Place varchar(15),Language varchar(10))

USE claysys;


select * from candidates;

--insert into candidates values(1,'Safna','safna@gmail.com',24,'Malappuram','Malayalam'),(2,'Muhzina','muhzi@gmail.com',28,'Ernakulam','Malayalam'),
--(3,'Yadhu','yadhu@gmail.com',25,'Kottayam','Malayalam'),(4,'Sugunadevi','suguna@gmail.com',24,'Chennai','Tamil'),(5,'Shyamini','shyamini@gmail.com',25,'Coimbatore','Tamil')

--select Name,Age,Place from candidates


--create a view for names,place where age is 24--------------------------------

--create view malayali as
--select Name,Place from candidates
--where Language='Malayalam';

select * from malayali;

--CREATE VIEW [Age below Average Age] AS
--SELECT Name, Age
--FROM candidates
--WHERE Age < (SELECT AVG(Age) FROM candidates);
--select * from [Age below Average Age];



--Second highest salary------------------------------

CREATE TABLE employees (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50),
    salary DECIMAL(10, 2)
);

select * from employees;

INSERT INTO employees (name, salary)
VALUES 
('John', 3000.00),
('Alice', 4500.00),
('Bob', 3500.00),
('David', 5000.00),
('Eve', 5500.00);

SELECT MAX(salary) AS second_highest_salary
FROM employees
WHERE salary < (SELECT MAX(salary) FROM employees);



------------ user management --------------------------------



--create database user_management;
use user_management;

------------ 1) signup---------------------------------------

--   create signup table ---------

--CREATE TABLE signup (
--    id INT IDENTITY(1,1) PRIMARY KEY,
--    full_name VARCHAR(100) NOT NULL,
--    email VARCHAR(100) NOT NULL UNIQUE,
--    phone_number VARCHAR(15) NOT NULL UNIQUE,
--    username VARCHAR(50) NOT NULL UNIQUE,
--    password_hash VARCHAR(255) NOT NULL,
--    created_at DATETIME DEFAULT GETDATE(),
--    updated_at DATETIME DEFAULT GETDATE()
--);
-- retrieve all data from the table --------------

select * from signup;

-- inserting -------------------

--INSERT INTO signup (full_name, email, phone_number, username, password_hash)
--VALUES ('John Doe', 'john@example.com', '1234567890', 'john_doe', HASHBYTES('SHA2_256', 'password123'));

--INSERT INTO signup (full_name, email, phone_number, username, password_hash)
--VALUES ('Paul', 'paul@example.com', '9876543210', 'Pa_ul', HASHBYTES('SHA2_256', 'password456'));



-- updating -------------------------------

--UPDATE signup
--SET email = 'new_email@example.com', phone_number = '1472583690', updated_at = GETDATE()
--WHERE id = 1;



-- select ---------------------------------

--SELECT full_name, email, phone_number, username, created_at, updated_at
--FROM signup
--WHERE username = 'john_doe';




-- delete -------------------

--DELETE FROM signup
--WHERE id = 2;




--------------- 2)Login -----------------------------------------------


--CREATE TABLE login (
--    login_id INT IDENTITY(1,1) PRIMARY KEY,
--    user_id INT FOREIGN KEY REFERENCES signup(id),
--    login_time DATETIME DEFAULT GETDATE(),
--    login_ip VARCHAR(45)
--);

select * from login;

--insert -------------------------

--INSERT INTO login (user_id, login_ip)
--VALUES (1, '192.168.0.1');

--retrive login history of a user------------

--SELECT l.login_time, l.login_ip, s.username
--FROM login l
--JOIN signup s ON l.user_id = s.id
--WHERE s.username = 'john_doe';



--------------- sql query to list the number of employess in each dptmnt---------------------


--CREATE DATABASE company;
use company;


--CREATE TABLE employees (
--    employee_id INT IDENTITY(1,1) PRIMARY KEY,
--    first_name VARCHAR(50) NOT NULL,
--    last_name VARCHAR(50) NOT NULL,
--    department VARCHAR(100),
--    salary DECIMAL(10, 2),
--    hire_date DATE
--);

select * from employees;

--INSERT INTO employees (first_name, last_name, department, salary, hire_date)
--VALUES
--('John', 'Doe', 'Sales', 55000, '2022-01-15'),
--('Jane', 'Smith', 'HR', 45000, '2021-06-22'),
--('Mark', 'Brown', 'IT', 70000, '2020-03-10'),
--('Emily', 'Davis', 'Sales', 60000, '2019-08-12'),
--('Paul', 'Wilson', 'IT', 75000, '2021-09-28'),
--('Sarah', 'Miller', 'HR', 47000, '2018-04-30'),
--('Tom', 'Clark', 'Marketing', 52000, '2019-07-18');


------ to select employee count in each dptmnt-----------------------------------


SELECT department, COUNT(*) AS employee_count
FROM employees
GROUP BY department;


-------- tables to perform all the join concepts --------------------------------


-- table 1------------ 

--CREATE TABLE departments (
--    department_id INT IDENTITY(1,1) PRIMARY KEY ,
--    department_name VARCHAR(100) NOT NULL
--);

select * from departments;


-- table 2--------------

--CREATE TABLE employee (
--    employee_id INT IDENTITY(1,1) PRIMARY KEY,
--    first_name VARCHAR(50) NOT NULL,
--    last_name VARCHAR(50) NOT NULL,
--    department_id INT,           -- This is a foreign key (Reference) from the departments table
--    salary DECIMAL(10, 2),
--    hire_date DATE,
--    FOREIGN KEY (department_id) REFERENCES departments(department_id) -- Foreign key relationship
--);

select * from employee;

-- inserting values to table 1-------------------

--INSERT INTO departments (department_name)
--VALUES
--('HR'),
--('IT'),
--('Sales'),
--('Marketing');


-- inserting values to table 2--------------------

--INSERT INTO employee (first_name, last_name, department_id, salary, hire_date)
--VALUES
--('John', 'Doe', 1, 55000, '2022-01-15'),
--('Jane', 'Smith', 2, 45000, '2021-06-22'),
--('Mark', 'Brown', 3, 70000, '2020-03-10'),
--('Emily', 'Davis', 3, 60000, '2019-08-12'),
--('Paul', 'Wilson', 2, 75000, '2021-09-28'),
--('Sarah', 'Miller', 1, 47000, '2018-04-30'),
--('Tom', 'Clark', NULL, 52000, '2019-07-18'); -- dpmt is null



---- indexes-----------------------------clustered and non clustered

sp_helpindex employee;

create index IN_Employee_Salary on employee(salary asc);





-- applying joins

--inner join---------------------- displays matching values from both tables if condition is true


SELECT employee.first_name, employee.last_name, departments.department_name
FROM employee
INNER JOIN departments ON employee.department_id = departments.department_id;


-- left join ---------------  displays all rows from left table and matched row from right table


SELECT employee.first_name, employee.last_name, departments.department_name
FROM employee
LEFT JOIN departments ON employee.department_id = departments.department_id;


-- right join-----------similar to left join but opposite


SELECT employee.first_name, employee.last_name, departments.department_name
FROM employee
RIGHT JOIN departments ON employee.department_id = departments.department_id;


--full outer join----displays every results from both tables--


SELECT employee.first_name, employee.last_name, departments.department_name
FROM employee
FULL OUTER JOIN departments ON employee.department_id = departments.department_id;



--STORED PROCEDURE----------------------------------


--create database signupdb;
use signupdb;

--CREATE TABLE users (
--    user_id INT IDENTITY(1,1) PRIMARY KEY,
--    first_name VARCHAR(50) NOT NULL,
--    last_name VARCHAR(50) NOT NULL,
--    email VARCHAR(100) NOT NULL UNIQUE,
--    password VARCHAR(255) NOT NULL,
--    phone VARCHAR(15),
--	created_at DATETIME2 DEFAULT GETDATE() 
--);

--INSERT INTO users (first_name,last_name, email,password, phone)
--VALUES ('John',' Doe', 'john@example.com', HASHBYTES('SHA2_256', 'password123'), '1234567890'),
--		('Alex',' Paul', 'alex@example.com', HASHBYTES('SHA2_256', 'password147'), '9638527410'),
--		('Adam',' John', 'adam@example.com', HASHBYTES('SHA2_256', 'password258'), '1234535410');

--INSERT INTO users (first_name,last_name, email,password, phone,Age)
--VALUES ('Maria',' Philip', 'mari@example.com', HASHBYTES('SHA2_256', 'password128'), '1234531540',24),
--		('Teena',' Eric', 'teena@example.com', HASHBYTES('SHA2_256', 'password147'), '9638348215',27),
--		('Joel','Alen', 'alen@example.com', HASHBYTES('SHA2_256', 'password258'), '1232514670',25);

INSERT INTO users (first_name,last_name, email,password, phone,Age)
VALUES ('Adam',' Philip', 'ad@example.com', HASHBYTES('SHA2_256', 'password128'), '1236421540',25);

select * from users;

--ALTER TABLE users
--ADD Age INT NULL;

--UPDATE users SET Age = 25 WHERE user_id = 1;
--UPDATE users SET Age = 30 WHERE user_id = 2;
--UPDATE users SET Age = 25 WHERE user_id = 3;

--UPDATE users SET Age = 25 WHERE user_id = 3;


-- stored procedure for crud operation------

--create procedure age
--AS                         --- seperates heading and body of the stored procedure
--BEGIN
--	select first_name,COUNT(Age) AS [Age Count]
--	from users
--	group by first_name
--	order by COUNT(Age) desc
--END;

--execute age;



-- with 1 parameter student admission form page

--CREATE DATABASE StudentDB;
--GO

--USE StudentDB;

--CREATE TABLE Students (
--    StudentID INT IDENTITY(1,1) PRIMARY KEY,
--    FirstName NVARCHAR(50),
--    LastName NVARCHAR(50),
--    Age INT,
--    Course NVARCHAR(100),
--    AdmissionDate DATETIME DEFAULT GETDATE()
--);

CREATE PROCEDURE ManageStudents
    @Operation NVARCHAR(10),   -- 'CREATE', 'READ', 'UPDATE', 'DELETE'
    @StudentID INT = NULL,      -- For identifying the student (required for UPDATE and DELETE)
    @FirstName NVARCHAR(50) = NULL,
    @LastName NVARCHAR(50) = NULL,
    @Age INT = NULL,
    @Course NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;  -- Prevents extra result sets from interfering with SELECT statements.

    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Students (FirstName, LastName, Age, Course)
        VALUES (@FirstName, @LastName, @Age, @Course);
        SELECT SCOPE_IDENTITY() AS NewStudentID; -- Returns the ID of the newly created student
    END
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Students WHERE (@StudentID IS NULL OR StudentID = @StudentID);
    END
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Students
        SET FirstName = @FirstName,
            LastName = @LastName,
            Age = @Age,
            Course = @Course
        WHERE StudentID = @StudentID;
    END
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Students WHERE StudentID = @StudentID;
    END
    ELSE
    BEGIN
        RAISERROR('Invalid operation. Use CREATE, READ, UPDATE, or DELETE.', 16, 1);
    END
END;

-- Create 

--EXEC ManageStudents 'CREATE', NULL, 'Anu', 'Deepak', 20, 'Computer Science';
--EXEC ManageStudents 'CREATE', NULL, 'Manu', 'Prakash', 22, 'Maths';
--EXEC ManageStudents 'CREATE', NULL, 'Ramya', 'Arun', 20, 'Statistics';
--EXEC ManageStudents 'CREATE', NULL, 'Venki', 'Kumar', 21, 'Data Science';

-- Read/Retrieve

EXEC ManageStudents 'READ', NULL; -- Read all students
--EXEC ManageStudents 'READ', 1;     -- Read student with StudentID 1

-- Update

--EXEC ManageStudents 'UPDATE', 1, 'Anu', 'Deepak', 21, 'Physics'; -- Update student with ID 1

-- Delete

EXEC ManageStudents 'DELETE', 1; -- Delete student with StudentID 1




-- Normalization
----------------------------------------------------->--





