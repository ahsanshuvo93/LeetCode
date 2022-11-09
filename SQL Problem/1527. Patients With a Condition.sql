
--Date : 09/November/2022
--Problem Name : 1527. Patients With a Condition
--Topic : SQL (String Processing)
--URL : https://leetcode.com/problems/patients-with-a-condition/
--Status : My Solution
--Level : Easy

--Table Name : Patients

with CTE_tempTable (patient_id, patient_name, conditions)
as
(
	select patient_id, patient_name,
		case
			when conditions like 'DIAB1%' then conditions
			when conditions like '% DIAB1%' then conditions
		end as conditions
	from Patients
)
select * from CTE_tempTable where conditions is not null