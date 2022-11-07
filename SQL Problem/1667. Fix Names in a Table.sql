
--Date : 07/November/2022
--Problem Name : 1667. Fix Names in a Table
--Topic : SQL String Process
--URL : https://leetcode.com/problems/fix-names-in-a-table/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : Users

select 
	user_id, 
	CONCAT(UPPER(LEFT(name,1)), LOWER(RIGHT(name,LEN(name)-1))) as name 
from Users 
order by user_id