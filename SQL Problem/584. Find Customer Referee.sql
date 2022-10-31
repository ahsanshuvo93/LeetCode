
--Date : 31/October/2022
--Problem Name : 584. Find Customer Referee
--Topic : SQL
--URL : https://leetcode.com/problems/find-customer-referee/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : Customer
select name from Customer where referee_id != 2 or referee_id is null
