
--Date : 02/December/2022
--Problem Name : 1581. Customer Who Visited but Did Not Make Any Transactions
--Topic : SQL
--URL : https://leetcode.com/problems/customer-who-visited-but-did-not-make-any-transactions/
--Status : My Solution
--Level : Easy

--Table Name : Visits
--Table Name : Transactions

with CTE_CustomerVisitWithoutTransaction(customer_id)
as
(
	select v.customer_id as customerId from Visits as v
	left join Transactions as t 
	on t.visit_id = v.visit_id where amount is null
)
select customer_id, count(customer_id) as count_no_trans from CTE_CustomerVisitWithoutTransaction group by customer_id