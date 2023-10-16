create database Assignment_4
use Assignment_4

-- Declare variables
DECLARE @InputNumber INT = 5; -- Replace with the desired number
DECLARE @Factorial INT = 1;
DECLARE @Counter INT = 1;

-- Calculate factorial
WHILE @Counter <= @InputNumber
BEGIN
SET @Factorial = @Factorial * @Counter;
SET @Counter = @Counter + 1;
END

-- Print the result
SELECT 'The factorial of ' + CAST(@InputNumber AS NVARCHAR(10)) + ' is ' + CAST(@Factorial AS NVARCHAR(10));

---------------------------------------------------------------------
-- Create a stored procedure
CREATE PROCEDURE GenerateMultiplicationTable
    @N INT -- Input number for the table
AS
BEGIN
DECLARE @Counter INT = 1;

WHILE @Counter <= @N
BEGIN
DECLARE @Multiplier INT = 1;
WHILE @Multiplier <= 10
BEGIN
PRINT CAST(@Counter AS NVARCHAR(10)) + ' x ' + CAST(@Multiplier AS NVARCHAR(10)) + ' = ' + CAST(@Counter * @Multiplier AS NVARCHAR(10));
SET @Multiplier = @Multiplier + 1;
END

SET @Counter = @Counter + 1;
END
END
exec GenerateMultiplicationTable @N = 10

-- Create a holiday table
CREATE TABLE Holiday (
    HolidayDate DATE PRIMARY KEY,
    HolidayName NVARCHAR(100)
);

-- Insert holiday data
INSERT INTO Holiday (HolidayDate, HolidayName)
VALUES ('2023-07-04', 'Independence Day'),
       ('2023-10-28', 'Diwali');

-- Create a trigger
/*CREATE TRIGGER RestrictDataManipulationOnHolidays
ON EMP
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @Today DATE = GETDATE();

IF EXISTS (SELECT 1 FROM Holiday WHERE HolidayDate = @Today)
BEGIN
RAISEERROR('Due to ' + (SELECT HolidayName FROM Holiday WHERE HolidayDate = @Today) + ' you cannot manipulate data', 16, 1);
ROLLBACK;
END
END*/
create trigger RestrictChanges
on EMP
for insert, update, delete
as
begin
    declare @HolidayName varchar(max)
    declare @IsHoliday int

    -- Check if it's a holiday
    select @IsHoliday = count(*), @HolidayName = Holiday_name
    from Holidays
    where holiday_date = cast(getdate() as date)

    -- If it's a holiday, prevent data manipulation and display an error message
    if @IsHoliday > 0
    begin
        raiserror('Due to %s, you cannot manipulate data', 16, 1, @HolidayName)
        rollback transaction
    end
end

insert into EMP values(7777,'Aman', 'Verma', 1914,'2004-12-01',9821,null,09)