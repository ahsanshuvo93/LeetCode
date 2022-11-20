
--Date : 20/November/2022
--Problem Name : 608. Tree Node
--Topic : SQL (String Processing)
--URL : https://leetcode.com/problems/tree-node/
--Status : My Solution
--Level : Easy

--Table Name : Tree

select id, 
case
	when p_id is null then 'Root'
	when id in (select distinct id from Tree m1 where not exists (select 1 from Tree m2 where m2.p_Id = m1.id)) then 'Leaf'
	else 'Inner'
end as type
from Tree