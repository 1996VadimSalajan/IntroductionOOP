USE Db;


GO
CREATE TABLE [dbo].[Customers]
(
    Id     BIGINT        NOT NULL CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED,
    [Name] NVARCHAR (50) NOT NULL
) ON [PRIMARY];


GO
CREATE TABLE [dbo].[Orders]
(
    Id           BIGINT          NOT NULL CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED,
    [Total]      DECIMAL (18, 0) NOT NULL,
    [PostalCode] BIGINT          NOT NULL,
    [CustomerId] BIGINT          NOT NULL
) ON [PRIMARY];

ALTER TABLE [Orders]
    ADD CONSTRAINT Orders_CustomerId FOREIGN KEY (CustomerId) REFERENCES Customers (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
INSERT  INTO Customers
VALUES (1, 'John'),
(2, 'Joe'),
(3, 'Oscar');

INSERT  INTO Orders (Id, Total, PostalCode, CustomerId)
VALUES             (1, 1000.5, 2056, 1),
(2, 100.5, 2052, 1),
(3, 300.5, 2052, 1),
(4, 400.5, 2055, 2);


GO
--Request: based on data, count default postal code
ALTER TABLE Customers
    ADD DefaultPostalCode BIGINT;


GO
--- non-deterministic choice
---   select distinct c.id, o.PostalCode
---   FROM dbo.Customers AS C 
---     INNER JOIN dbo.Orders AS O 
---      ON C.Id = O.CustomerId;
---

--- but merge raises an exception
--MERGE INTO dbo.Customers 
-- AS C
-- USING dbo.Orders as O ON O.CustomerId = c.Id
-- WHEN MATCHED THEN UPDATE 
--    SET c.DefaultPostalCode = o.PostalCode

--WHEN NOT MATCHED BY SOURCE THEN UPDATE 
--    SET c.DefaultPostalCode = 1111;

UPDATE  C
    SET C.DefaultPostalCode = O.PostalCode
FROM    dbo.Customers AS C
        INNER JOIN
        dbo.Orders AS O
        ON C.Id = O.CustomerId;

GO
---a better option
UPDATE  C
    SET C.DefaultPostalCode = A.PostalCode
FROM    dbo.Customers AS C CROSS APPLY (SELECT   TOP (1) O.PostalCode
                                        FROM     dbo.Orders AS O
                                        WHERE    O.CustomerId = c.Id
                                        GROUP BY o.PostalCode
                                        ORDER BY COUNT(O.PostalCode) DESC) AS A;

-- an even better option
MERGE INTO dbo.Customers
 AS C
USING (SELECT   O.CustomerId,
                o.PostalCode,
                RANK() OVER (PARTITION BY O.CustomerId ORDER BY COUNT(O.PostalCode) DESC) AS rank
       FROM     dbo.Orders AS O
       GROUP BY O.CustomerId, o.PostalCode) AS O ON O.CustomerId = c.Id

WHEN MATCHED AND O.rank = 1 THEN UPDATE 
    SET c.DefaultPostalCode = o.PostalCode

WHEN NOT MATCHED BY SOURCE THEN UPDATE 
    SET c.DefaultPostalCode = 1111;


GO
DROP TABLE Orders;

DROP TABLE Customers;