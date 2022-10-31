
--Date : 31/October/2022
--Problem Name : 595. Big Countries
--Topic : SQL
--URL : https://leetcode.com/problems/big-countries/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : World
select name, population, area from World where area >= 3000000 or population >= 25000000