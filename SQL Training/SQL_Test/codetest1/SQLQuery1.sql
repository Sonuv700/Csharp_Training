Create database SQL_Test_1
use SQL_Test_1
CREATE TABLE books (
    id INT PRIMARY KEY,
    title NVARCHAR(255) NOT NULL,
    author NVARCHAR(255) NOT NULL,
    isbn NVARCHAR(13) NOT NULL,
    published_date DATETIME NOT NULL
);
-- Inserting data into the "books" table
INSERT INTO books (id, title, author, isbn, published_date)
VALUES
    (1, 'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
    (2, 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
    (3, 'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');

	CREATE TABLE reviews (
    id INT PRIMARY KEY,
    book_id INT,
    reviewer_name NVARCHAR(255),
    content NVARCHAR(MAX),
    rating INT,
    published_date DATETIME
);
-- Inserting data into the "reviews" table
INSERT INTO reviews (id, book_id, reviewer_name, content, rating, published_date)
VALUES
    (11, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
    (22, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
    (32, 3, 'Alice Walker', 'Another review', NULL, '2017-10-22 23:47:10');
	



-- Create a table called "employee"
CREATE TABLE employee (
ID INT PRIMARY KEY,
NAME VARCHAR(255),
AGE INT,
ADDRESS VARCHAR(255),
SALARY DECIMAL(10, 2)
);

-- Insert data into the "employee" table
INSERT INTO employee (ID, NAME, AGE, ADDRESS, SALARY)
VALUES
    (1, 'Ramesh', 32, 'Ahmedabad', 1500.00),
    (2, 'Khilan', 25, 'Delhi', 2000.00),
    (3, 'Kaushik', 23, 'Kota', 6500.00),
    (4, 'Chaitali', 25, 'Mumbai', 4500.00),
    (5, 'Hardik', 27, 'Bhopal', 8500.00),
    (6, 'Komal', 22, 'MP', NULL),
    (7, 'Muffy', 24, 'Indore', 10000.00);

-- Create the ORDERS table
CREATE TABLE ORDERS (
    OID INT PRIMARY KEY,
    DATE DATETIME,
    CUSTOMER_ID INT,
    AMOUNT DECIMAL(10, 2)
);
-- Insert data into the ORDERS table
INSERT INTO ORDERS (OID, DATE, CUSTOMER_ID, AMOUNT)
VALUES
    (102, '2009-10-08 00:00:00', 3, 3000.00),
    (100, '2009-10-08 00:00:00', NULL, 1500.00),
    (101, '2009-11-20 00:00:00', 24, 1560.00),
    (103, '2008-05-20 00:00:00', NULL, 2060.00);


-- Create the Studentdetails table
CREATE TABLE Studentdetails (
    RegisterNo INT,
    Name VARCHAR(50),
    Age INT,
    Qualification VARCHAR(50),
    MobileNo VARCHAR(10),
    Mail_id VARCHAR(50),
	Location VARCHAR(50),
    Gender CHAR(1)
);

-- Insert data into the table
INSERT INTO Studentdetails (Name, Age, Qualification,  MobileNo, Mail_id,Location, Gender)
VALUES
    ('Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com','Chennai', 'F'),
    ('Kumar', 20, 'BSC','7890125648', 'Kumar@gmail.com','Madurai', 'M'),
    ('Selvi', 22, 'B.Tech','8904567342', 'selvi@gmail.com', 'Selam','F'),
    ('Nisha', 25, 'M.E',  '7834672310', 'Nisha@gmail.com', 'Theni','F'),
    ('SaiSaran', 21, 'B.A','4560', 'SaiSaran@gmail.com','Madurai', 'M'),
    ('Tom', 23, 'BCA', '7890345678', 'Tom@gmail.com', 'Pune','M');

---Q1)Write a query to fetch the details of the books written by author whose name ends with er.
	select*from books where author like '%er'


---Q2) Display the Title ,Author and ReviewerName for all the books from the above table 
SELECT b.title, b.author, r.reviewer_name
FROM books AS b
INNER JOIN reviews AS r ON b.id = r.book_id;


---Q3) Display the  reviewer name who reviewed more than one book
SELECT reviewer_name
FROM reviews
GROUP BY reviewer_name
HAVING COUNT(DISTINCT book_id) > 1;


---Q4)  Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address

SELECT id,NAME,address
FROM employee
WHERE ADDRESS LIKE '%o%'


---Q5 Write a query to display the   Date,Total no of customer  placed order on same Date 
SELECT DATE, COUNT(DISTINCT CUSTOMER_ID) AS TotalCustomers
FROM ORDERS
GROUP BY DATE
ORDER BY DATE;

---Q6) Display the Names of the Employee in lower case, whose salary is null 
SELECT LOWER(Name) AS LowercaseName
FROM Employee
WHERE Salary IS NULL;


---Q7)  Write a sql server query to display the Gender,Total no of male and female from the above relation    .
SELECT Gender,
COUNT(*) AS TotalNo
FROM Studentdetails
GROUP BY Gender;
