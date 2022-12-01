
--Date : 02/December/2022
--Problem Name : 197. Rising Temperature
--Topic : SQL
--URL : https://leetcode.com/problems/rising-temperature/
--Status : My Solution
--Level : Easy

--Table Name : Weather

with CTE_TemperatureWithPreviousData(id, temperature, recordDate, prev_temperature, prev_recordDate)
as
(
    select id, temperature, recordDate, lag(temperature,1) over (order by recordDate) as prev_temperature, lag(recordDate,1) over(order by recordDate) as prev_recordDate from Weather 
),
CTE_TempTable(id,temperature,recordDate)
as
(
    select id, temperature,
        case
            when (temperature > prev_temperature)  and (recordDate = DATEADD(day, 1, prev_recordDate)) then recordDate
        end as recordDate
    from CTE_TemperatureWithPreviousData
)
select id from CTE_TempTable where recordDate is not null