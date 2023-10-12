create database ASSIGNMENT_2
USE ASSIGNMENT_2
create table dept(
deptno int,
dname varchar(30),
dloc varchar(30),
primary key(deptno)
);
insert into dept values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

create table emp(
empno int primary key,
ename varchar(40),
ejob varchar(30),
emgr_id int ,
ehire_date date not null ,
salary int not null,
comm int,
deptno int foreign key references dept(deptno)
);

insert into emp values
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);
---SELECT*FROM EMP;

---**List all employees whose name begins with 'A'.
SELECT*FROM EMP WHERE ENAME LIKE 'A%'

---**Select all those employees who don't have a manager. 
SELECT*FROM EMP WHERE EMGR_ID IS NULL

---**List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
SELECT ename, empno, salary
from emp
where salary between 1200 and 1400;



---Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 



---**Find the number of CLERKS employed. Give it a descriptive heading. 
SELECT COUNT(*) AS "Number of CLERKS"
FROM emp  
WHERE ejob = 'CLERK';
---**Find the average salary for each job type and the number of people employed in each job.
SELECT ejob, 
AVG(salary) AS "Average Salary",
COUNT(*) AS "Number of Employees"
FROM emp  
GROUP BY ejob
ORDER BY ejob;
---**List the employees with the lowest and highest salary. 
select top 1 with ties ename,ejob, salary
FROM emp 
ORDER BY salary ASC;
select top 1 with ties ename,ejob, salary
FROM emp 
ORDER BY salary DESC;