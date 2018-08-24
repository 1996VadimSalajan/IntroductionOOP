Update  p set p.strt_date=c.Join_Date from packages p
join customers c on c.pack_id=p.pack_id 
where p.pack_id=23
MERGE INTO packages as p USING (SELECT c.pack_id,c.Join_Date,
                RANK() OVER (PARTITION BY c.pack_id ORDER BY COUNT(c.Join_Date) DESC) AS rank
                FROM customers as c  GROUP BY c.pack_id,c.Join_Date) as c ON (p.pack_id=c.pack_id)
WHEN MATCHED and p.pack_id=23 and c.rank=3  THEN
UPDATE  SET p.strt_date=c.Join_Date
WHEN NOT MATCHED by Source THEN
 UPDATE 
 SET p.strt_date=null;
Select c.Join_Date,c.pack_id from customers c where c.pack_id=23
Select p.strt_date,p.pack_id from packages p where p.pack_id=23