SELECT event_id, COUNT(*) AS session_count_10to12
FROM Sessions
WHERE TIME(start_time) >= '10:00:00' AND TIME(end_time) <= '12:00:00'
GROUP BY event_id;
