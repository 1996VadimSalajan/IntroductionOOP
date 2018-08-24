--Transaction 1
--Deadlock
begin tran
Update customer set First_Name='John' where id=1
Waitfor delay '00:00:08'
Update sectors set sector_name='Private' where sector_id=1
commit tran

--Dirty Read
begin tran
Update sectors set sector_name='Privates' where sector_id=1
Waitfor delay '00:00:08'
Rollback tran

--Nonrepetable Read
Set transaction isolation level read uncommitted;
begin tran
Select * from sectors where sector_id=1
Waitfor delay '00:00:07'
Select * from sectors where sector_id=1
commit tran


--Phantom reads
--Set transaction isolation level  serializable;
begin tran
Select * from sectors where sector_id between 1 and 12
Waitfor delay '00:00:10'
Select * from sectors where sector_id between 1 and 12
commit tran

--lock
Set transaction isolation level read uncommitted;
begin tran
Select * from sectors where sector_id=1
Waitfor delay '00:00:17'
Select * from sectors where sector_id=1
commit tran