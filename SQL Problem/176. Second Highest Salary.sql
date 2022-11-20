
--Date : 20/November/2022
--Problem Name : 176. Second Highest Salary
--Topic : SQL
--URL : https://leetcode.com/problems/second-highest-salary/
--Status : My Solution
--Level : Easy

--Table Name : Employee

with CTE_RakingTable(salary, serial)
as
(
select salary, Rank() over(order by salary desc) as serial from Employee group by salary 
)
select Isnull((select salary from CTE_RakingTable where serial = 2),null) as SecondHighestSalary


