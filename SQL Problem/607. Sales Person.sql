
--Date : 04/December/2022
--Problem Name : 607. Sales Person
--Topic : SQL
--URL : https://leetcode.com/problems/sales-person/description/
--Status : My Solution
--Level : Easy

--Table Name : SalesPerson
--Table Name : Company
--Table Name : Orders


with CTE_SalesJoin (order_id, sales_id, com_id, name)
as
(
	select o.order_id, o.sales_id, o.com_id, com.name as name from Orders as o
		left join SalesPerson as sp on o.sales_id = sp.sales_id 
		left join Company as com on o.com_id = com.com_id
	where com.name = 'RED'
)
select name from SalesPerson where sales_id not in (select sales_id from CTE_SalesJoin)