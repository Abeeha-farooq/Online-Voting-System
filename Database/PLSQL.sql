/* ONLINE VOTING SYSTEM – PROCEDURES, FUNCTIONS, TRIGGERS, CURSORS */

/* ================================
   STORED PROCEDURES
   ================================ */

-- Procedure 1 : IN + OUT Parameter
CREATE PROCEDURE sp_GetCandidateVotes
    @CandidateID INT,
    @TotalVotes INT OUTPUT
AS
BEGIN
    SELECT @TotalVotes = COUNT(*)
    FROM VOTE
    WHERE candidate_id = @CandidateID;
END;
GO

-- Execute example
DECLARE @votes INT;
EXEC sp_GetCandidateVotes 1, @votes OUTPUT;
PRINT @votes;
GO


-- Procedure 2 : Exception Handling (Vote Casting)
CREATE PROCEDURE sp_CastVote
    @VoterID INT,
    @CandidateID INT,
    @ElectionID INT
AS
BEGIN
    BEGIN TRY
        INSERT INTO VOTE(vote_time,status,voter_id,candidate_id,election_id)
        VALUES(GETDATE(),'Cast',@VoterID,@CandidateID,@ElectionID);

        PRINT 'Vote Cast Successfully';
    END TRY
    BEGIN CATCH
        PRINT 'Error while casting vote';
    END CATCH
END;
GO


-- Procedure 3 : Nested Procedure
CREATE PROCEDURE sp_CountVotes
    @CandidateID INT,
    @Votes INT OUTPUT
AS
BEGIN
    SELECT @Votes = COUNT(*) 
    FROM VOTE
    WHERE candidate_id=@CandidateID;
END;
GO

CREATE PROCEDURE sp_ShowWinner
AS
BEGIN
    DECLARE @votes INT;
    EXEC sp_CountVotes 1, @votes OUTPUT;
    PRINT 'Votes of Candidate 1 = ' + CAST(@votes AS VARCHAR);
END;
GO



/* ================================
   FUNCTIONS
   ================================ */

-- Function 1 : Vote Percentage
CREATE FUNCTION fn_VotePercentage(@CandidateID INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @totalVotes INT;
    DECLARE @candidateVotes INT;

    SELECT @totalVotes = COUNT(*) FROM VOTE;
    SELECT @candidateVotes = COUNT(*) FROM VOTE WHERE candidate_id=@CandidateID;

    RETURN (@candidateVotes * 100.0 / @totalVotes);
END;
GO


-- Function 2 : Used inside SELECT
CREATE FUNCTION fn_TotalCandidates(@PartyID INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;
    SELECT @count = COUNT(*) FROM CANDIDATE WHERE party_id=@PartyID;
    RETURN @count;
END;
GO

-- Example usage
SELECT name, dbo.fn_TotalCandidates(party_id) AS TotalCandidates
FROM PARTY;
GO



/* ================================
   TRIGGERS
   ================================ */

-- BEFORE INSERT Trigger (Auto Vote Time)
CREATE TRIGGER trg_BeforeVoteInsert
ON VOTE
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO VOTE(vote_time,status,voter_id,candidate_id,election_id)
    SELECT GETDATE(),'Cast',voter_id,candidate_id,election_id
    FROM inserted;
END;
GO


-- Audit Table
CREATE TABLE Election_Audit(
    audit_id INT IDENTITY PRIMARY KEY,
    election_id INT,
    update_time DATETIME
);
GO

-- AFTER UPDATE Trigger
CREATE TRIGGER trg_ElectionUpdate
ON ELECTION
AFTER UPDATE
AS
BEGIN
    INSERT INTO Election_Audit(election_id,update_time)
    SELECT election_id,GETDATE() FROM inserted;
END;
GO


-- Archive Table
CREATE TABLE Vote_Archive(
    vote_time DATETIME,
    voter_id INT,
    candidate_id INT
);
GO

-- AFTER DELETE Trigger
CREATE TRIGGER trg_DeleteVote
ON VOTE
AFTER DELETE
AS
BEGIN
    INSERT INTO Vote_Archive
    SELECT vote_time,voter_id,candidate_id FROM deleted;
END;
GO



/* ================================
   CURSORS
   ================================ */

-- Cursor 1 : Explicit Cursor
DECLARE vote_cursor CURSOR FOR
SELECT name FROM CANDIDATE;

DECLARE @name VARCHAR(100);

OPEN vote_cursor;
FETCH NEXT FROM vote_cursor INTO @name;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @name;
    FETCH NEXT FROM vote_cursor INTO @name;
END;

CLOSE vote_cursor;
DEALLOCATE vote_cursor;
GO


-- Cursor 2 : Cursor with parameter
DECLARE @PartyID INT = 1;

DECLARE candidate_cursor CURSOR FOR
SELECT name FROM CANDIDATE WHERE party_id=@PartyID;

OPEN candidate_cursor;
FETCH NEXT FROM candidate_cursor INTO @name;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @name;
    FETCH NEXT FROM candidate_cursor INTO @name;
END;

CLOSE candidate_cursor;
DEALLOCATE candidate_cursor;
GO



/* ================================
   PACKAGE (Schema in SQL Server)
   ================================ */

CREATE SCHEMA ElectionPkg;
GO

CREATE PROCEDURE ElectionPkg.sp_TotalVotes
AS 
SELECT COUNT(*) AS TotalVotes FROM VOTE;
GO

CREATE PROCEDURE ElectionPkg.sp_TotalVoters
AS 
SELECT COUNT(*) AS TotalVoters FROM VOTER;
GO

CREATE FUNCTION ElectionPkg.fn_TotalParties()
RETURNS INT
AS
BEGIN
    RETURN (SELECT COUNT(*) FROM PARTY);
END;
GO

-- Package usage examples
EXEC ElectionPkg.sp_TotalVotes;
SELECT ElectionPkg.fn_TotalParties();
GO