Select c.First_Name,c.Last_Name,c.city,c.[State] From Customers as c
where c.state=(Select c.[State] from Customers as c where c.Customer_Id=170)

Select p.pack_id,p.speed,p.sector_id From packages p
where p.sector_id=(Select p.sector_id From packages as p where p.pack_id=10)

Select c.First_Name,c.Last_Name,c.Join_Date From customers c
where c.Join_Date>(Select c.Join_Date From customers as c where c.Customer_Id=540)

Select c.First_Name,c.Last_Name,c.Join_Date From customers c
where (year(c.Join_Date))=(Select year(c.Join_Date) From customers as c where c.Customer_Id=372)
and (month(c.Join_Date))=(Select month(c.Join_Date) From customers as c where c.Customer_Id=372)

Select c.First_Name,c.Last_Name,c.city,c.[State],c.pack_id From Customers as c 
where c.pack_id in (Select p.pack_id from packages as p where p.speed like '5M%')

Select p.pack_id,p.speed,p.strt_date From packages as p
where year(p.strt_date)=any(Select year(p.strt_date) from packages as p where p.pack_id=7)

Select c.First_Name,c.monthly_discount,c.main_phone_num,c.secondary_phone_num From customers c,packages p
where c.pack_id=p.pack_id and p.sector_id=(Select s.sector_id From sectors as s where s.sector_name like 'B%')

Select c.First_Name,c.monthly_discount,c.pack_id From customers c,packages p
where c.pack_id=p.pack_id and p.monthly_payment>(Select avg(p.monthly_payment) from packages as p)

--Select c.First_Name,c.City,c.[State],Parse(c.Birth_Date as date),c.monthly_discount from customers c
--where day(Parse(c.Birth_Date as date))=(Select  day(Parse(c.Birth_Date as date)) from customers as c where c.pack_id=179)
 
Select c.First_Name,c.City,c.[State],c.Birth_Date,c.monthly_discount from customers c
where exists(Select *from customers as cus where c.Birth_Date=cus.Birth_Date and cus.Customer_Id=179)

Select p.pack_id,p.speed,p.strt_date,p.monthly_payment,p.sector_id From packages p
where (p.speed)=(Select p.speed From packages as p where p.pack_id=30) and (p.monthly_payment)>(Select p.monthly_payment From packages as p where p.pack_id=7)
 
Select p.pack_id,p.speed,p.strt_date,p.monthly_payment From packages p
where (p.monthly_payment)>(Select max(p.monthly_payment) From packages as p where p.speed like '5M%')

Select p.pack_id,p.speed,p.strt_date,p.monthly_payment From packages p
where (p.monthly_payment)>(Select min(p.monthly_payment) From packages as p where p.speed like '5M%')

Select p.pack_id,p.speed,p.strt_date,p.monthly_payment From packages p
where (p.monthly_payment)<(Select min(p.monthly_payment) From packages as p where p.speed like '5M%')

Select c.First_Name,c.monthly_discount,c.pack_id from customers c
where c.monthly_discount<(Select avg(c.monthly_discount) from customers as c)and c.pack_id=all(Select c.pack_id from customers as c where c.First_Name='Kevin')
