use QLHTChuyenHang
go

--Create login
exec sp_addlogin 'cooperator1', 'cooperator1'
exec sp_addlogin 'customer1', 'customer1'
exec sp_addlogin 'driver1', 'driver1'
exec sp_addlogin 'employee1', 'employee1'
exec sp_addlogin 'admin1', 'admin1'

--Create user
create user cooperator1 for login cooperator1
create user customer1 for login customer1
create user driver1 for login driver1
create user employee1 for login employee1
create user admin1 for login admin1

--Create Role
exec sp_addrole 'Cooperator'
exec sp_addrole 'Customer'
exec sp_addrole 'Driver'
exec sp_addrole 'Employee'
exec sp_addrole 'Admin'

--Grant authorization