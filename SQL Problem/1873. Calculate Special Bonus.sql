
--Date : 01/November/2022
--Problem Name : 1873. Calculate Special Bonus
--Topic : SQL (Select, Order)
--URL : https://leetcode.com/problems/calculate-special-bonus/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : Employees

select employee_id, 
	case
		when (employee_id % 2 = 0 or LEFT(name, 1) = 'M') then 0
		else salary
	end as Bonus
from Employees
order by employee_id

--LEFT(name, 1) ==>> Take the first character from string