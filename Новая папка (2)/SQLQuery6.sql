Select Last_Name, len(Last_Name) as Lenth  From customers
group by  (Last_Name) having len(Last_Name)=(Select min(len(Last_Name)) From customers)
order by Last_Name

Select Avg(monthly_payment) as medium_monthly_payment  From packages

Select Last_Name, len(Last_Name) as Lenth  From customers
group by  (Last_Name) having len(Last_Name)=(Select max(len(Last_Name)) From customers)
order by Last_Name

Select pack_id From packages

Select Customer_Id From customers

Select distinct [State] From customers

Select distinct Speed From packages

Select fax From customers
where fax is not null

Select fax From customers
where fax is null

Select max(monthly_discount) as max_monthly_discount,min(monthly_discount) as min_monthly_discount,avg(monthly_discount) as medium_monthly_discount From customers

Select [state], customers.Birth_Date, count(Customer_Id) as Number_Clients
From customers
group by [state], customers.Birth_Date

Select Speed,avg(monthly_payment) as Medium_monthly_discount From packages
group by speed

Select [state],count(distinct City) as Number_Distinct_Cities From customers
group by [state]

Select p.sector_id,max(p.monthly_payment) From packages p
group by p.sector_id

Select pack_id,avg(monthly_discount) as Medium_Monthly_Discount From customers
group by pack_id having pack_id is not null

Select pack_id,avg(monthly_discount) as Medium_Monthly_Discount From customers
where pack_id =22 or pack_id=13
group by pack_id 

Select max(monthly_payment) as max_monthly_payment,min(monthly_payment) as min_monthly_payment,avg(monthly_payment) as medium_monthly_payment From packages
group by speed

Select pack_id,count(pack_id) as Number_Clients From customers
where pack_id is not null
group by pack_id 

Select pack_id,count(pack_id) as Number_Clients From customers
where monthly_discount>20
group by pack_id having pack_id is not null

Select pack_id,count(pack_id) as Number_Clients From customers
group by pack_id having pack_id is not null and count(pack_id)>100

Select [state],city,count(Customer_Id) as Number_Clients From customers
group by [state],city

Select city,avg(monthly_discount) as Medium_mounthly_discount From Customers
where monthly_discount>20
group by city

Select [state],avg(monthly_discount) as Medium_mounthly_discount From Customers
where monthly_discount>10
group by [state]

Select speed,count(pack_id) From packages
group by speed having count(pack_id)>8

Update  c set c.monthly_discount=c.monthly_discount*1.10 from Customers c
join packages p on c.pack_id=p.pack_id 
where p.speed like '1.5%'

 MERGE INTO Customers as c USING packages as p ON (p.pack_id=c.pack_id)
 WHEN MATCHED and p.speed like '1.5%' THEN
 UPDATE  SET c.monthly_discount=c.monthly_discount*1.10 
 WHEN NOT MATCHED by Source THEN
 UPDATE 
 SET c.monthly_discount =0;

   