
--Date : 31/October/2022
--Problem Name : 183. Customers Who Never Order
--Topic : SQL
--URL : https://leetcode.com/problems/customers-who-never-order/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : Customers
--Table Name : Orders

select name as Customers from Customers where id not in (select customerId from Orders)