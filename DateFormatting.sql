use Sandbox
GO 



CREATE TABLE mtable
(
	mfirstname varchar(40) not null,
	mlastname  varchar(40) not null,
	birthdate  date    not null,
	city       varchar(40) not null,
	state      varchar(40) not null,
	joindate   date       not null
)




CREATE TABLE conversiondate
(
	firstname varchar(40)  not null,
	lastname  varchar(40)  not null, 
	birthdate varchar(40)  not null,
	city      varchar(40)  not null,
	state     varchar(40)  not null,
	joindate  varchar(40)  not null

)

GO 



-------- this inserts all the data from the member csv file in the conversion table 

--BULK INSERT conversiondate
--FROM       'C:\Users\Cyberadmin\Downloads\MemberSort.csv'

--WITH 
--(
--	rowterminator = '\n',
--	fieldterminator = ','

--)


--select * from conversiondate


------------------------------Practice function(dont work)
--create function conv
--(
--	@d char(10),
--	@dstyle TINYINT
--)
--RETURNS Char(10)
--AS
--BEGIN 

--	RETURN (SELECT CASE WHEN ISDATE (@d) = 1 THEN CONVERT (char (10), CONVERT (DATE, @d), @dstyle) END)
--END 
--GO 

-----------function altered to convert the dates properly

CREATE FUNCTION standard_date_convert(@inputDate VARCHAR(255)) RETURNS date
BEGIN
 
 DECLARE @output date = null;
 DECLARE @result date = null;
 DECLARE @r_input varchar(255) = '';
 DECLARE @y_length int = 0;
 DECLARE @y_value INT = 0;
 
 IF len(@inputDate) > 0 BEGIN

 -- Trim leading spaces
 SET @inputDate = RTRIM(LTRIM(@inputDate));

 -- Trim starting 0 if there is one.
 IF LEFT(@inputDate, 1) = '0' BEGIN 
 SET @inputDate = RIGHT(@inputDate, LEN(@inputDate) - 1); 
 END 

 -- Replace dashes and periods 

 SET @inputDate = REPLACE(@inputDate, '-', '/');
 SET @inputDate = REPLACE(@inputDate, '.', '/');

 -- Isolate and process year value
 -- First, get year string by reversing string and finding first (last) separator.
 SET @r_input = REVERSE(@inputDate);
 SET @y_length = CHARINDEX('/', @r_input) - 1;

 -- Get the year value from the last two digits ...
 SET @y_value = CAST(REVERSE(LEFT(@r_input, 2)) AS  NUMERIC(10));

 -- If the year value is greater than or equal to the current year, assume last century, else this century.
 IF @y_length > 0 AND @y_length < 4 BEGIN
   IF @y_value < 10 BEGIN
     SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '200', @y_value);
   END
   ELSE IF @y_value >= YEAR(GETDATE()) % 100  

     SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '19', @y_value); 
   END
   ELSE BEGIN
     SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '20', @y_value);
   END 
 END 

 
 -- Remove extra zeroes
 
 SET @inputDate = REPLACE(@inputDate, '/0', '/');
 
 SET @result = convert(varchar, getdate(), 101)
 
 IF @result IS NOT NULL BEGIN
   SET @output = @result;
 END
 ELSE BEGIN
   SET @OUTPUT = '00/00/0000';
 END 
 
 RETURN @output;

END;
GO 



INSERT INTO mtable (mfirstname, mlastname, birthdate, city, state, joindate)
SELECT      firstname, lastname, dbo.standard_date_convert(birthdate), city, state, dbo.standard_date_convert(joindate)
FROM        conversiondate





