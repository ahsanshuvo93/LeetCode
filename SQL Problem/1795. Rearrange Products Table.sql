
--Date : 16/November/2022
--Problem Name : 1795. Rearrange Products Table
--Topic : SQL (Select & Union)
--URL : https://leetcode.com/problems/rearrange-products-table/
--Status : My Solution
--Level : Easy

--Table Name : Products

--UNPIVOT is used to Rotate multiple columns into multiple rows

select u.product_id, u.store, u.price  from Products s
UNPIVOT
(
    price for store in (store1, store2, store3)
)
as u