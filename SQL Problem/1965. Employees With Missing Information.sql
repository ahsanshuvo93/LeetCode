
--Date : 11/November/2022
--Problem Name : 1965. Employees With Missing Information
--Topic : SQL (Union, Select)
--URL : https://leetcode.com/problems/patients-with-a-condition/
--Status : My Solution
--Level : Easy

--Table Name : Employees
--Table Name : Salaries

--this temp table create a list which contains all employee_id [union operator does this]
with CTE_AllEmployeeTable (employee_id)
as
(
	select employee_id from Employees
	union
	select employee_id from Salaries
),
--this temp table create a list which contains the common employee_id [inner join do this]
CTE_CommonEmployeeTable (employee_id)
as
(
	select emp.employee_id from Employees as emp
	inner join Salaries as sal
	on emp.employee_id = sal.employee_id
)
--this select query takes all missing employee_id in common table list
select * from CTE_AllEmployeeTable where employee_id not in (select * from CTE_CommonEmployeeTable)