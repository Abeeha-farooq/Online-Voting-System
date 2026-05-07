/* ONLINE VOTING SYSTEM – QUERIES FILE */

-- BASIC SELECT QUERIES

-- All voters from Lahore constituencies
SELECT * FROM VOTER 
WHERE constituency_id IN (1,2,3);

-- All completed elections
SELECT * FROM ELECTION
WHERE status = 'Completed';

-- Candidates older than 40
SELECT name, age FROM CANDIDATE
WHERE age > 40;

-- Votes cast in Election 1
SELECT * FROM VOTE
WHERE election_id = 1;

-- Parties from Lahore headquarters
SELECT * FROM PARTY
WHERE headquarters = 'Lahore';



-- AGGREGATE QUERIES (GROUP BY)

-- Total votes per candidate
SELECT candidate_id, COUNT(*) AS TotalVotes
FROM VOTE
GROUP BY candidate_id;

-- Average candidate age per party
SELECT party_id, AVG(age) AS AvgAge
FROM CANDIDATE
GROUP BY party_id;

-- Max, Min and Sum votes from results
SELECT 
MAX(total_votes) AS HighestVotes,
MIN(total_votes) AS LowestVotes,
SUM(total_votes) AS TotalVotes
FROM RESULT;



-- SUBQUERIES

-- Candidates who received votes
SELECT name FROM CANDIDATE
WHERE candidate_id IN
(SELECT candidate_id FROM VOTE);

-- Candidate with highest votes
SELECT name FROM CANDIDATE
WHERE candidate_id =
(
    SELECT candidate_id 
    FROM RESULT
    WHERE total_votes = (SELECT MAX(total_votes) FROM RESULT)
);

-- Candidates who got more votes than average
SELECT candidate_id
FROM RESULT r
WHERE total_votes >
(
   SELECT AVG(total_votes)
   FROM RESULT
);



-- JOIN QUERIES

-- INNER JOIN: Candidates with party names
SELECT c.name, p.name AS Party
FROM CANDIDATE c
INNER JOIN PARTY p 
ON c.party_id = p.party_id;

-- LEFT JOIN: All voters with votes (if any)
SELECT u.name, v.vote_time
FROM USERS u
LEFT JOIN VOTE v 
ON u.user_id = v.voter_id;

-- RIGHT JOIN: All elections with votes
SELECT e.title, v.vote_time
FROM VOTE v
RIGHT JOIN ELECTION e
ON v.election_id = e.election_id;

-- MULTI TABLE JOIN: Election result report
SELECT 
c.name AS Candidate,
p.name AS Party,
e.title AS Election,
r.total_votes
FROM RESULT r
JOIN CANDIDATE c ON r.candidate_id = c.candidate_id
JOIN PARTY p ON c.party_id = p.party_id
JOIN ELECTION e ON r.election_id = e.election_id;



-- UPDATE QUERIES

-- Update election status
UPDATE ELECTION
SET status = 'Completed'
WHERE election_id = 2;

-- Update candidate manifesto
UPDATE CANDIDATE
SET manifesto = 'Economic Reform'
WHERE candidate_id = 1;



-- DELETE QUERIES

-- Delete cancelled votes
DELETE FROM VOTE
WHERE status = 'Cancelled';

-- Delete old election
DELETE FROM ELECTION
WHERE election_id = 10;



-- DCL QUERIES

-- Grant read-only access
GRANT SELECT ON VOTE TO PUBLIC;

-- Revoke permission
REVOKE SELECT ON VOTE FROM PUBLIC;