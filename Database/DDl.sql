/* =====================================================
   ONLINE VOTING SYSTEM – DATABASE DDL
   =====================================================
   */


--  USERS TABLE

CREATE TABLE USERS (
    user_id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    user_type VARCHAR(10) NOT NULL
        CHECK (user_type IN ('ADMIN','VOTER')),
    created_at DATETIME DEFAULT GETDATE()
);

CREATE INDEX idx_users_email ON USERS(email);


-- ADMIN TABLE

CREATE TABLE ADMIN (
    admin_id INT PRIMARY KEY,
    role VARCHAR(30) NOT NULL
        CHECK (role IN ('SuperAdmin','ElectionOfficer')),
    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT fk_admin_user FOREIGN KEY (admin_id)
    REFERENCES USERS(user_id) ON DELETE CASCADE
);


-- VOTER TABLE


CREATE TABLE VOTER (
    voter_id INT PRIMARY KEY,
    cnic VARCHAR(15) UNIQUE NOT NULL,

    CONSTRAINT fk_voter_user FOREIGN KEY (voter_id)
    REFERENCES USERS(user_id) ON DELETE CASCADE
);


-- PARTY TABLE


CREATE TABLE PARTY (
    party_id INT PRIMARY KEY,
    name VARCHAR(100) UNIQUE NOT NULL,
    symbol VARCHAR(50) UNIQUE NOT NULL,
    leader_name VARCHAR(100) NOT NULL,
    founded_year INT CHECK (founded_year > 1900),
    headquarters VARCHAR(200)
);


--  CONSTITUENCY TABLE


CREATE TABLE CONSTITUENCY (
    constituency_id INT PRIMARY KEY
);


--  ELECTION TABLE

CREATE TABLE ELECTION (
    election_id INT PRIMARY KEY,
    title VARCHAR(200) NOT NULL,
    election_date DATE NOT NULL,
    start_time DATETIME NOT NULL,
    end_time DATETIME NOT NULL,
    status VARCHAR(20) DEFAULT 'Upcoming'
        CHECK (status IN ('Upcoming','Ongoing','Completed')),

    CONSTRAINT chk_election_dates CHECK (end_time > start_time)
);

CREATE INDEX idx_election_status ON ELECTION(status);


--  CANDIDATE TABLE


CREATE TABLE CANDIDATE (
    candidate_id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    age INT CHECK (age >= 18),
    manifesto VARCHAR(MAX),

    party_id INT NULL,
    election_id INT NOT NULL,
    constituency_id INT NOT NULL,

    CONSTRAINT fk_candidate_party FOREIGN KEY (party_id)
        REFERENCES PARTY(party_id) ON DELETE SET NULL,

    CONSTRAINT fk_candidate_election FOREIGN KEY (election_id)
        REFERENCES ELECTION(election_id) ON DELETE CASCADE
);

CREATE INDEX idx_candidate_election 
ON CANDIDATE(election_id, party_id);


-- VOTE TABLE

CREATE TABLE VOTE (
    vote_id INT IDENTITY(1,1) PRIMARY KEY,
    vote_time DATETIME DEFAULT GETDATE(),
    status VARCHAR(15) DEFAULT 'Cast'
        CHECK (status IN ('Cast','Invalid')),

    voter_id INT NOT NULL,
    candidate_id INT NOT NULL,
    election_id INT NOT NULL,

    CONSTRAINT fk_vote_voter FOREIGN KEY (voter_id)
        REFERENCES VOTER(voter_id) ON DELETE CASCADE,

    CONSTRAINT fk_vote_candidate FOREIGN KEY (candidate_id)
        REFERENCES CANDIDATE(candidate_id) ON DELETE CASCADE,

    CONSTRAINT fk_vote_election FOREIGN KEY (election_id)
        REFERENCES ELECTION(election_id) ON DELETE NO ACTION,

    -- Prevent duplicate voting in same election
    CONSTRAINT uk_voter_election UNIQUE (voter_id, election_id)
);

CREATE INDEX idx_vote_candidate ON VOTE(candidate_id, election_id);
CREATE INDEX idx_vote_voter ON VOTE(voter_id);


--  RESULT TABLE


CREATE TABLE RESULT (
    result_id INT PRIMARY KEY,
    total_votes INT DEFAULT 0 CHECK (total_votes >= 0),
    position INT CHECK (position >= 1),
    result_status VARCHAR(20) NOT NULL
        CHECK (result_status IN ('Won','Lost','Tie')),

    candidate_id INT NOT NULL,
    election_id INT NOT NULL,

    CONSTRAINT fk_result_candidate FOREIGN KEY (candidate_id)
        REFERENCES CANDIDATE(candidate_id) ON DELETE CASCADE,

    CONSTRAINT fk_result_election FOREIGN KEY (election_id)
        REFERENCES ELECTION(election_id) ON DELETE NO ACTION,

    CONSTRAINT uk_election_candidate UNIQUE (election_id, candidate_id)
);

--  VIEWS


-- Election Results View
CREATE VIEW vw_ElectionResults AS
SELECT 
    c.name AS Candidate,
    p.name AS Party,
    r.total_votes,
    r.result_status,
    e.title AS Election
FROM RESULT r
JOIN CANDIDATE c ON r.candidate_id = c.candidate_id
JOIN PARTY p ON c.party_id = p.party_id
JOIN ELECTION e ON r.election_id = e.election_id;

-- Voter History View

CREATE VIEW vw_VoterHistory AS
SELECT 
    u.name AS VoterName,
    c.name AS Candidate,
    e.title AS Election,
    v.vote_time
FROM VOTE v
JOIN VOTER vt ON v.voter_id = vt.voter_id
JOIN USERS u ON vt.voter_id = u.user_id
JOIN CANDIDATE c ON v.candidate_id = c.candidate_id
JOIN ELECTION e ON v.election_id = e.election_id;


-- TEST QUERIES


SELECT * FROM vw_ElectionResults;
SELECT * FROM vw_VoterHistory;