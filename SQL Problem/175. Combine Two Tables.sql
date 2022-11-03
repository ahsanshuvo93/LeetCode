
--Date : 03/November/2022
--Problem Name : 175. Combine Two Tables
--Topic : SQL (Join)
--URL : https://leetcode.com/problems/combine-two-tables/
--Status : My Solution
--Level : Easy

--Table Name : Person
--Table Name : Address

select per.firstName, per.lastName, adr.city, adr.State from Person as per
left join Address as adr on
per.PersonId = adr.PersonId