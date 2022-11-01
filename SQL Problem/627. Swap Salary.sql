
--Date : 01/November/2022
--Problem Name : 627. Swap Salary
--Topic : SQL
--URL : https://leetcode.com/problems/swap-salary/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : Salary

update Salary set sex = 
    case
        when sex = 'm' then 'f'
        when sex = 'f' then 'm'
    end