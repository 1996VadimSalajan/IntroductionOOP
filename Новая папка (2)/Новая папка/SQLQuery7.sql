---Transaction 2
--Deadlock
begin tran
Update sectors set sector_name='Privater' where sector_id=1
Update customer set First_Name='Johnd' where id=1
commit tran

--Dirty Read
Set transaction isolation level read uncommitted;
Select * from sectors where sector_id=1

--Nonrepetable Read
BEGIN TRAN
--Waitfor delay '00:00:02'
Update sectors set sector_name='Privatytyt' where sector_id=1
commit tran

--Phantom reads
Insert into sectors values (12,'fSHdsssssfsdfsdG')
Set transaction isolation level read uncommitted;
Select * from sectors where sector_id=1
--lock
