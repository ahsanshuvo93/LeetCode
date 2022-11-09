
--Date : 09/November/2022
--Problem Name : 196. Delete Duplicate Emails
--Topic : SQL
--URL : https://leetcode.com/problems/delete-duplicate-emails/
--Status : My Solution
--Level : Easy

--Table Name : Person

with CTE_tempTable (id, email, num)
as
(
	select id, email, ROW_NUMBER() over(Partition BY email order by id) as num from Person
)
delete from CTE_tempTable where num > 1