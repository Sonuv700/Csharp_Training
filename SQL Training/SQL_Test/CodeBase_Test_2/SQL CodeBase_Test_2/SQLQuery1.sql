create Database CodeBase_Test_2

CREATE TABLE Code_Employee (
    empno INT PRIMARY KEY,
    empname VARCHAR(35) NOT NULL,
    empsal NUMERIC(10, 2) CHECK (empsal >= 25000),
    emptype CHAR(1) CHECK (emptype IN ('F', 'P'))
);

CREATE PROCEDURE AddEmployee
    @empname VARCHAR(35),
    @empsal NUMERIC(10, 2),
    @emptype CHAR(1)
AS
BEGIN
    DECLARE @newEmpNo INT;

    -- Generate the new employee no by finding the maximum empno and adding 1
    SELECT @newEmpNo = ISNULL(MAX(empno), 0) + 1 FROM Code_Employee;

    -- Insert the new record
    INSERT INTO Code_Employee (empno, empname, empsal, emptype)
    VALUES (@newEmpNo, @empname, @empsal, @emptype);
END;
EXEC AddEmployee @empname = 'John Doe', @empsal = 30000.00, @emptype = 'F';
EXEC AddEmployee @empname = 'Jane Smith', @empsal = 35000.00, @emptype = 'F';
EXEC AddEmployee @empname = 'Bob Johnson', @empsal = 28000.00, @emptype = 'P';
EXEC AddEmployee @empname = 'Sarah Brown', @empsal = 32000.00, @emptype = 'F';
EXEC AddEmployee @empname = 'Michael Lee', @empsal = 40000.00, @emptype = 'F';
EXEC AddEmployee @empname = 'Alice Williams', @empsal = 27000.00, @emptype = 'P';
EXEC AddEmployee @empname = 'David Jones', @empsal = 33000.00, @emptype = 'F';
EXEC AddEmployee @empname = 'Emily Davis', @empsal = 31000.00, @emptype = 'P';
EXEC AddEmployee @empname = 'Daniel Wilson', @empsal = 29000.00, @emptype = 'F';
EXEC AddEmployee @empname = 'Olivia Martin', @empsal = 36000.00, @emptype = 'F';

SELECT * FROM Code_Employee;
------------------------------------------------------------------------------------------------------------------
DECLARE
  CURSOR c_emp IS
    SELECT empno, salary
    FROM employee
    WHERE Deptno = 7566;
BEGIN
  FOR emp IN c_emp LOOP
    UPDATE employee
    SET salary = salary * 1.15
    WHERE empno = emp.empno;
  END LOOP;
  COMMIT;
END;