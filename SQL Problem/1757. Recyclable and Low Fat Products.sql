
--Date : 31/October/2022
--Problem Name : 1757. Recyclable and Low Fat Products
--Topic : SQL
--URL : https://leetcode.com/problems/recyclable-and-low-fat-products/?envType=study-plan&id=sql-i
--Status : My Solution
--Level : Easy

--Table Name : Products
select product_id from Products where low_fats >= 'Y' and recyclable >= 'Y'