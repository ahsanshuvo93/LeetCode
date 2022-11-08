
--Date : 08/November/2022
--Problem Name : 1484. Group Sold Products By The Date
--Topic : SQL String Process
--URL : https://leetcode.com/problems/group-sold-products-by-the-date/
--Status : My Solution
--Level : Easy

--Table Name : Activities

with tempUniqueOrders (sell_date, product)
as
(
    select Distinct sell_date, product from Activities
)
select 
    sell_date, 
    Count(product) as num_sold,
    STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product) as "products"
from tempUniqueOrders 
group by sell_date

--STRING_AGG() ==> this function contact the field of all column

--with CTE we create and temp table. The table being unique, then we execute the query 