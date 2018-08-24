Select c.First_Name,c.Last_Name,c.pack_id,p.speed From customers c,packages p
where p.pack_id=c.pack_id

Select c.First_Name,c.Last_Name,c.pack_id,p.speed From customers c,packages p
where p.pack_id=c.pack_id and (p.pack_id=22 or p.pack_id=27) 
order by Last_Name 

Select p.pack_id,p.speed,p.monthly_payment,s.sector_name From packages p,sectors s
where s.sector_id=p.sector_id

Select c.First_Name,c.Last_Name,c.pack_id,p.speed,p.monthly_payment,s.sector_name From customers c,packages p,sectors s
where p.pack_id=c.pack_id and s.sector_id=p.sector_id

Select c.First_Name,c.Last_Name,c.pack_id,p.speed,p.monthly_payment,s.sector_name From customers c,packages p,sectors s
where p.pack_id=c.pack_id and s.sector_id=p.sector_id and s.sector_name like 'Business'

Select c.First_Name,c.Last_Name,c.pack_id,c.Join_Date,p.speed,p.monthly_payment,s.sector_name From customers c,packages p,sectors s
where p.pack_id=c.pack_id and s.sector_id=p.sector_id and s.sector_name like 'Private' and c.Join_Date like '2006%'

Select c.First_Name,c.Last_Name,c.pack_id,p.speed,p.monthly_payment From customers c
join packages p on c.pack_id=p.pack_id

Select c.First_Name,c.Last_Name,c.pack_id,p.speed,p.monthly_payment From customers c
left outer join packages p on c.pack_id=p.pack_id

Select c.First_Name,c.Last_Name,c.pack_id,p.speed,p.monthly_payment From customers c
right outer join packages p on c.pack_id=p.pack_id

Select c.First_Name,c.Last_Name,c.pack_id,p.speed,p.monthly_payment From customers c
full outer join packages p on c.pack_id=p.pack_id