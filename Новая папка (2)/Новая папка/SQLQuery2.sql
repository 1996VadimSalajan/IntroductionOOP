--delete from Users where IdUser=10
--Truncate Table Users
set identity_insert Users on
insert into Users (IdUser,FirstName,LastName,Email,PasswordUser,IDNP,Photo,DateCreated,BirthDate,Age,Gender) 
values (10,'Cebotari', 'Ion','cebotari2000@mail.ru','fdshhghfdghdgfj',1134242434234,'efwasdfsafagfdgfdg','2018/06/03','2000/06/03',18,'m');
Set identity_insert users off;
insert into NewUser (FirstName,LastName,Email,IDNP,BirthDate,Age)
Select FirstName,LastName,Email,IDNP,BirthDate,Age From Users where iduser=1
Select u.IdUser,u.FirstName,u.LastName,u.Email,u.IDNP,u.BirthDate,u.Age into NewUser From Users u
