
--Date : 02/December/2022
--Problem Name : 1148. Article Views I
--Topic : SQL
--URL : https://leetcode.com/problems/article-views-i/
--Status : My Solution
--Level : Easy

--Table Name : Views

with CTE_OwnView (author_id, viewer_id)
as
(
	select author_id,
		case
			when author_id = viewer_id then viewer_id
		end as viewer_id
	from Views
)
select Distinct (author_id) as id from CTE_OwnView where viewer_id is not null order by author_id