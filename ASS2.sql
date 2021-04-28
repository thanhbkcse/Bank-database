--Database
CREATE TABLE Branch 
(	braname		VARCHAR(15)	,
	bgmail		VARCHAR(30)	,						
	bno		INT	,
	bstreet		VARCHAR(30)	not null,
	bdistrict	VARCHAR(15),
	bcity		VARCHAR(15)	not null,
	bregion		VARCHAR(15),
	empcode		CHAR(9) not null,
	PRIMARY KEY (braname)


);



CREATE TABLE Employee
(	empcode		CHAR(9)	 	,	
	eno		INT	not null	,
	estreet		VARCHAR(30)	not null,
	edistrict	VARCHAR(15) ,
	ecity		VARCHAR(15)	not null,
	edob		DATE	not null	,
	eemail		VARCHAR(30)	,
	elname		VARCHAR(15)	not null,
	efname		VARCHAR(15)	not null,
	braname		VARCHAR(15)	not null,
	PRIMARY KEY (empcode),
	FOREIGN KEY (braname) REFERENCES Branch(braname)				
);



CREATE TABLE Customer
(	cuscode		CHAR(9)	 	,
	clname		VARCHAR(15)	not null,
	cfname		VARCHAR(15)	not null,
	chomeaddr	VARCHAR(30)	not null,
	cemail		VARCHAR(30)	,
	coffaddr		VARCHAR(30)	,
	empcode		CHAR(9)	not null	,
	PRIMARY KEY (cuscode),
	FOREIGN KEY (empcode) REFERENCES Employee(empcode)	
							
);



CREATE TABLE AccType
(	acccode		CHAR(9)	,	
	PRIMARY KEY (acccode)			
);



CREATE TABLE TK
(	anumber		CHAR(9) 	,
	cuscode		CHAR(9)	not null	,
	acccode		CHAR(9)	not null	,
	PRIMARY KEY (anumber),
	FOREIGN KEY (cuscode) REFERENCES Customer(cuscode),
	FOREIGN KEY (acccode) REFERENCES AccType(acccode)					
);


CREATE TABLE SavingAcc
(	acccode		CHAR(9)	,
	sdate		DATE	not null	,
	sbalance	INT 	not null	,
	sinsrate	DECIMAL(4,2) not null	,
	PRIMARY KEY (acccode),
	FOREIGN KEY (acccode) REFERENCES AccType(acccode)				
);




CREATE TABLE CheckingAcc
(	acccode		CHAR(9) 	,
	cbalance		INT	not null	,
	cdate		DATE	not null	,
	PRIMARY KEY (acccode),
	FOREIGN KEY (acccode) REFERENCES AccType(acccode)					
);





CREATE TABLE Loan
(	acccode		CHAR(9)	,
	linsrate		DECIMAL(4,2)  not null	,
	lbalance		INT	  not null	,
	ldate		DATE	not null	,
	PRIMARY KEY (acccode),
	FOREIGN KEY (acccode) REFERENCES AccType(acccode)						
);





CREATE TABLE Bra_Phone 
(	braname		VARCHAR(15)	,
	braphone	CHAR(10)  	,
	PRIMARY KEY (braname,braphone),
	FOREIGN KEY (braname) REFERENCES Branch(braname)						
);




CREATE TABLE Bra_Fax 
(	braname		VARCHAR(15)	,
	brafax		CHAR(10),
	PRIMARY KEY (braname,brafax),
	FOREIGN KEY (braname) REFERENCES Branch(braname)						
);




CREATE TABLE Emp_Phone 
(	empcode		CHAR(9)	,	
	empphone	CHAR(10)   ,	
	PRIMARY KEY (empcode,empphone),
	FOREIGN KEY (empcode) REFERENCES Employee(empcode)				
);



CREATE TABLE Cus_Phone 
(	cuscode		CHAR(9)	,
	cusphone	CHAR(10) 	,
	PRIMARY KEY (cuscode,cusphone),
	FOREIGN KEY (cuscode) REFERENCES Customer(cuscode)							
);



ALTER SESSION SET NLS_DATE_FORMAT = 'DD-MM-YYYY';

INSERT INTO Branch VALUES ('OCB', 'ocb@gmail.com' , '11', 'Hai Ba Trung', 'Quan 1' , 'Ho Chi Minh' , 'Mien nam' , '000000001');
INSERT INTO Branch VALUES ('BIDV', 'bidv@gmail.com' , '22', 'Luong Thanh', 'Quan 2' , 'Ho Chi Minh' , 'Mien nam' , '000000002');
INSERT INTO Branch VALUES ('AGRIBANK', 'agribank@gmail.com' , '33', 'Mac Dinh Chi', 'Quan 3' , 'Ho Chi Minh' , 'Mien nam' , '000000003');
INSERT INTO Branch VALUES ('ACB', 'acb@gmail.com' , '44', 'Pham Ngu Lao', 'Quan 4' , 'Ho Chi Minh' , 'Mien nam' , '000000004');



INSERT INTO Employee VALUES ('100000000', '10', 'Bui Vien', 'Quan 1', 'Ho Chi Minh' , '09-01-1965', 'vantan@gmail.com', 'Nguyen Van','Tan','OCB');
INSERT INTO Employee VALUES ('100000001', '20', 'Ly Thuong Kiet', 'Quan 2', 'Ho Chi Minh' , '10-02-1964', 'ngoctan@gmail.com', 'Nguyen Ngoc','Tan','BIDV');
INSERT INTO Employee VALUES ('100000002', '30', 'Hung Vuong', 'Quan 3', 'Ho Chi Minh' , '11-03-1963', 'quangtung@gmail.com', 'Nguyen Quang','Tung','AGRIBANK');
INSERT INTO Employee VALUES ('100000003', '40', 'Cao Ba Quat', 'Quan 4', 'Ho Chi Minh' , '12-04-1962', 'duythanh@gmail.com', 'Nguyen Duy','Thanh','ACB');


INSERT INTO Customer VALUES ('200000000', 'Nguyen Van' , 'Thang' , '20 Cao Bang' , 'vanthang@gmail.com' , '02 Vinh Xuan' , '100000000');
INSERT INTO Customer VALUES ('200000001', 'Tran Hoang' , 'Viet' , '20 Cao Bang' , 'hoangviet@gmail.com' , '03 Dong Du' , '100000001');
INSERT INTO Customer VALUES ('200000002', 'Hoang Quynh' , 'Anh' , '20 Cao Bang' , 'quynhanh@gmail.com' , '04 Dong Khoi' , '100000002');
INSERT INTO Customer VALUES ('200000003', 'Tran Yen' , 'Nhu' , '20 Cao Bang' , 'yennhu@gmail.com' , '05 Le Dung' , '100000003');


INSERT INTO AccType VALUES ('300000000');
INSERT INTO AccType VALUES ('300000001');
INSERT INTO AccType VALUES ('300000002');
INSERT INTO AccType VALUES ('300000003');
INSERT INTO AccType VALUES ('300000004');
INSERT INTO AccType VALUES ('300000005');
INSERT INTO AccType VALUES ('300000006');
INSERT INTO AccType VALUES ('300000007');
INSERT INTO AccType VALUES ('300000008');
INSERT INTO AccType VALUES ('300000009');
INSERT INTO AccType VALUES ('300000010');
INSERT INTO AccType VALUES ('300000011');


INSERT INTO TK VALUES ('400000000','200000000','300000000');
INSERT INTO TK VALUES ('400000001','200000001','300000001');
INSERT INTO TK VALUES ('400000002','200000002','300000002');
INSERT INTO TK VALUES ('400000003','200000003','300000003');

INSERT INTO TK VALUES ('400000004','200000000','300000004');
INSERT INTO TK VALUES ('400000005','200000001','300000005');
INSERT INTO TK VALUES ('400000006','200000002','300000006');
INSERT INTO TK VALUES ('400000007','200000003','300000007');

INSERT INTO TK VALUES ('400000008','200000000','300000008');
INSERT INTO TK VALUES ('400000009','200000001','300000009');
INSERT INTO TK VALUES ('400000010','200000002','300000010');
INSERT INTO TK VALUES ('400000011','200000003','300000011');
--INSERT INTO AccType VALUES ('300000012');
--INSERT INTO TK VALUES ('400000012','200000003','300000012');

INSERT INTO SavingAcc VALUES ('300000000', '05-12-2019' ,'25000000','06.50');
INSERT INTO SavingAcc VALUES ('300000001', '06-11-2019' ,'45000000','06.50');
INSERT INTO SavingAcc VALUES ('300000002', '07-10-2020' ,'125000000','06.50');
INSERT INTO SavingAcc VALUES ('300000003', '08-09-2020' ,'205000000','06.50');

INSERT INTO CheckingAcc VALUES ('300000004','100000000', '05-12-2019');
INSERT INTO CheckingAcc VALUES ('300000005','200000000', '06-11-2019');
INSERT INTO CheckingAcc VALUES ('300000006','300000000', '07-10-2020');
INSERT INTO CheckingAcc VALUES ('300000007','400000000', '08-09-2020');

INSERT INTO Loan VALUES ('300000008', '05.00' ,'12000000', '05-12-2019');
INSERT INTO Loan VALUES ('300000009', '05.00' ,'24000000', '06-11-2019');
INSERT INTO Loan VALUES ('300000010', '05.00' ,'36000000', '07-10-2020');
INSERT INTO Loan VALUES ('300000011', '05.00' ,'48000000', '08-09-2020');


INSERT INTO Bra_Phone VALUES ('OCB', '0848807872');
INSERT INTO Bra_Phone VALUES ('OCB', '0848807873');
INSERT INTO Bra_Phone VALUES ('BIDV', '0397755014');
INSERT INTO Bra_Phone VALUES ('BIDV', '0397755016');
INSERT INTO Bra_Phone VALUES ('AGRIBANK', '0395126195');
INSERT INTO Bra_Phone VALUES ('AGRIBANK', '0395126196');
INSERT INTO Bra_Phone VALUES ('ACB', '0384054105');
INSERT INTO Bra_Phone VALUES ('ACB', '0384054106');


INSERT INTO Bra_Fax VALUES ('OCB', '1111111111');
INSERT INTO Bra_Fax VALUES ('OCB', '2222222222');
INSERT INTO Bra_Fax VALUES ('BIDV', '3333333333');
INSERT INTO Bra_Fax VALUES ('BIDV', '4444444444');
INSERT INTO Bra_Fax VALUES ('AGRIBANK', '5555555555');
INSERT INTO Bra_Fax VALUES ('AGRIBANK', '6666666666');
INSERT INTO Bra_Fax VALUES ('ACB', '7777777777');
INSERT INTO Bra_Fax VALUES ('ACB', '8888888888');

INSERT INTO Emp_Phone VALUES ('100000000', '0123456789');
INSERT INTO Emp_Phone VALUES ('100000001', '0123456788');
INSERT INTO Emp_Phone VALUES ('100000002', '0123456787');
INSERT INTO Emp_Phone VALUES ('100000003', '0123456786');
INSERT INTO Emp_Phone VALUES ('100000000', '0123456785');
INSERT INTO Emp_Phone VALUES ('100000001', '0123456784');
INSERT INTO Emp_Phone VALUES ('100000002', '0123456783');
INSERT INTO Emp_Phone VALUES ('100000003', '0123456782');

INSERT INTO Cus_Phone VALUES ('200000000', '9876543210');
INSERT INTO Cus_Phone VALUES ('200000001', '9876543211');
INSERT INTO Cus_Phone VALUES ('200000002', '9876543212');
INSERT INTO Cus_Phone VALUES ('200000003', '9876543213');
INSERT INTO Cus_Phone VALUES ('200000000', '9876543220');
INSERT INTO Cus_Phone VALUES ('200000001', '9876543221');
INSERT INTO Cus_Phone VALUES ('200000002', '9876543222');
INSERT INTO Cus_Phone VALUES ('200000003', '9876543223');

--Part2 a
ALTER SESSION SET NLS_DATE_FORMAT = 'DD-MM-YYYY';
update savingacc
set sinsrate = sinsrate*0.9
where sdate > '31-08-2020';

--Part2 b

SELECT  cuscode, clname, cfname, chomeaddr, cemail, coffaddr
from customer
where clname = 'Nguyen Van' and cfname = 'Thang';

select Customer.cuscode, Customer.clname, Customer.cfname, Cus_Phone.cusphone
from (Customer
INNER JOIN Cus_Phone on Customer.cuscode = Cus_Phone.cuscode )
where Customer.clname = 'Nguyen Van' and Customer.cfname = 'Thang';

select Customer.cuscode, Customer.clname, Customer.cfname, TK.anumber, SavingAcc.sdate, SavingAcc.sbalance, SavingAcc.sinsrate
from ((Customer INNER JOIN TK on Customer.cuscode = TK.cuscode ) INNER JOIN SavingAcc on TK.acccode = SavingAcc.acccode)
where Customer.clname = 'Nguyen Van' and Customer.cfname = 'Thang';

select Customer.cuscode, Customer.clname, Customer.cfname, TK.anumber, CheckingAcc.cbalance, CheckingAcc.cdate
from ((Customer INNER JOIN TK on Customer.cuscode = TK.cuscode ) INNER JOIN CheckingAcc on TK.acccode = CheckingAcc.acccode)
where Customer.clname = 'Nguyen Van' and Customer.cfname = 'Thang';

select Customer.cuscode, Customer.clname, Customer.cfname, TK.anumber, Loan.linsrate, Loan.lbalance, Loan.ldate
from ((Customer INNER JOIN TK on Customer.cuscode = TK.cuscode ) INNER JOIN Loan on TK.acccode = Loan.acccode)
where Customer.clname = 'Nguyen Van' and Customer.cfname = 'Thang';

--Part2 c:

create or replace TYPE table_balance_type IS TABLE OF NUMBER(38,0);
create or replace FUNCTION Total_Balance (custom_id IN CHAR)
RETURN TABLE_BALANCE_TYPE
AS result_fun TABLE_BALANCE_TYPE := TABLE_BALANCE_TYPE();
BEGIN
    result_fun.extend(3);
    SELECT SUM(A.SBALANCE)  INTO result_fun(1)
    FROM SAVINGACC  A,  TK D 
    WHERE D.CUSCODE = custom_id AND D.ACCCODE = A.ACCCODE;
    
    SELECT SUM(B.CBALANCE)  INTO result_fun(2)
    FROM  CHECKINGACC B, TK D 
    WHERE D.CUSCODE = custom_id AND D.ACCCODE = B.ACCCODE;

    SELECT SUM(C.LBALANCE)  INTO result_fun(3)
    FROM   LOAN C, TK D 
    WHERE D.CUSCODE = custom_id AND D.ACCCODE = C.ACCCODE;
    RETURN result_fun;
END;
SELECT * FROM TABLE(TOTAL_BALANCE('200000000'));

--Part2 d:
CREATE OR REPLACE PROCEDURE sort_employee(bdate DATE,edate DATE)
IS
BEGIN
    DBMS_OUTPUT.put_line ('Start date = ' || bdate ||'      '||'End date = '|| edate);
    FOR rec IN(
    SELECT E.EMPCODE as G, COUNT(C.CUSCODE) AS H  
    FROM EMPLOYEE E,CUSTOMER C
    WHERE (E.EMPCODE = C.EMPCODE) AND C.CUSCODE IN 
    (
        SELECT DISTINCT D.CUSCODE
        FROM CUSTOMER D,TK T,SAVINGACC S,CHECKINGACC F,LOAN L
        WHERE (D.CUSCODE = T.CUSCODE AND (T.ACCCODE = S.ACCCODE) AND 
        ((S.SDATE > bdate) AND (S.SDATE < edate)))
        OR (D.CUSCODE = T.CUSCODE AND (T.ACCCODE = F.ACCCODE) AND 
        ((F.CDATE > bdate) AND (F.CDATE < edate)))
        OR (D.CUSCODE = T.CUSCODE AND (T.ACCCODE = L.ACCCODE) AND 
        ((L.LDATE > bdate) AND (L.LDATE < edate)))
    )
    GROUP BY E.EMPCODE
    ORDER BY COUNT(C.CUSCODE))
    LOOP
            DBMS_OUTPUT.put_line ('employee_id = ' || rec.G||'      '||'count customer served = '|| rec.H);

    END LOOP;    
END;

--TEST
SET SERVEROUTPUT ON;
EXECUTE SORT_EMPLOYEE(TO_DATE('01-01-2018','DD-MM-YYYY'),TO_DATE('12-12-2020','DD-MM-YYYY'));