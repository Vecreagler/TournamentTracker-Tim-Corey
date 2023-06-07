-- Run ; by ; 

CREATE DATABASE Tournaments;
-- dont forget to use it, it will create tables at master if you dont
USE Tournaments;

-- Creating tables
-- People Table
-- I named all the id's as ID, i prefer writing ID
-- also i used varchar for names, not nvarchar
-- dont know about performance but i dont think its needed


CREATE TABLE People(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
EmailAddress NVARCHAR(100) NOT NULL,
CellphoneNumber VARCHAR(20) NULL,
);
-- People Table Alter

-- TeamMembers Table
CREATE TABLE TeamMembers(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
TeamId INT NOT NULL,
PersonId INT  NOT NULL,
);

-- TeamMembers Table Alter

ALTER TABLE TeamMembers
ADD FOREIGN KEY (TeamId)
REFERENCES Teams(ID);

--Teams Table
CREATE TABLE Teams(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
TeamName VARCHAR(50) NOT NULL,
);

-- Teams Table Alter

--Tournaments Table 
CREATE TABLE Tournaments(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
TournamentName VARCHAR(100) NOT NULL,
EntryFee MONEY NOT NULL, 
Active BIT NOT NULL,
);

--Tournaments Table Alter

--Matchups Table
CREATE TABLE Matchups(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
TournamentId INT NOT NULL ,
WinnerId INT NULL,
MatchupRound INT NOT NULL,
);

--MatchupEntries Table
CREATE TABLE MatchupEntries(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
MatchupId INT NOT NULL FOREIGN KEY  REFERENCES dbo.Matchups(ID),
ParentMatchupId INT  NULL,
TeamCompetingId INT  NULL,
Score FLOAT NULL,
);
--MatchupEntries Table Alter

--TournamentEntries Table 
CREATE TABLE TournamentEntries(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
TournamentId INT NOT NULL FOREIGN KEY  REFERENCES Tournaments(ID),
TeamId INT NOT NULL FOREIGN KEY  REFERENCES Teams(ID),
);

--TournamentEntries Table Alter

--TournamentPrizes Table
CREATE TABLE TournamentPrizes(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
TournamentId INT NOT NULL FOREIGN KEY REFERENCES Tournaments(ID),
PrizeId INT NOT NULL FOREIGN KEY REFERENCES Prizes(ID),
);	

--TournamentPrizes Alter


-- Prizes Table
CREATE TABLE Prizes(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1) ,
PlaceNumber INT NOT NULL,
PlaceName VARCHAR(50) NOT NULL,
PrizeAmount MONEY NOT NULL,
PrizePercentage FLOAT NOT NULL,
);

--Prizes Table Alter

-- Stored Procedures
-- spPrizes_GetByTournament

CREATE PROCEDURE spPrizes_GetByTournament 
@TournamentId INT 
AS
BEGIN

		SET NOCOUNT ON;

	SELECT * FROM Prizes
	INNER JOIN TournamentPrizes ON Prizes.ID = TournamentPrizes.PrizeId
	WHERE TournamentPrizes.TournamentId = @TournamentId;

END

-- I hate renaming table names, it always confuses me


--stored procedure
--spPrizes

CREATE PROCEDURE spPrizes_Insert
	@PlaceNumber INT,
	@PlaceName VARCHAR(50),
	@PrizeAmount MONEY,
	@PrizePercentage FLOAT,
	@ID INT = 0 OUTPUT
AS
BEGIN

		SET NOCOUNT ON;

	INSERT INTO dbo.Prizes( PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @ID = SCOPE_IDENTITY();
END


--stored procedure
--spPeople_Insert
CREATE PROCEDURE spPeople_Insert
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@EmailAddress NVARCHAR(100),
	@CellphoneNumber VARCHAR(20),
	@ID INT = 0 OUTPUT
AS
BEGIN

		SET NOCOUNT ON;

	INSERT INTO dbo.People(FirstName, LastName, EmailAddress, CellphoneNumber)
	VALUES (@FirstName, @LastName, @EmailAddress, @CellphoneNumber);

	SELECT @ID = SCOPE_IDENTITY();
END



--stored procedure
--dbo.spPeople_GetAll
-- might be wrong but, thats what i've seen in video
CREATE PROCEDURE spPeople_GetAll
AS
BEGIN
select * from dbo.People;
END



--stored procedure
--spTeams_Insert
CREATE PROCEDURE spTeams_Insert
	@TeamName VARCHAR(50),
	@ID INT = 0 OUTPUT
AS
BEGIN

		SET NOCOUNT ON;

	INSERT INTO dbo.Teams(TeamName)
	VALUES (@TeamName);

	SELECT @ID = SCOPE_IDENTITY();
END

 
--stored procedure
--spTeamMembers_Insert

CREATE PROCEDURE spTeamMembers_Insert
	@TeamId INT,
	@PersonId INT,
	@ID INT = 0 OUTPUT
AS
BEGIN

		SET NOCOUNT ON;

	INSERT INTO dbo.TeamMembers(TeamId,PersonId)
	VALUES (@TeamId, @PersonId);

	SELECT @ID = SCOPE_IDENTITY();
END

--stored procedure
--spTeam_GetAll

CREATE PROCEDURE spTeam_GetAll
AS
BEGIN
SELECT * FROM  Teams
END

CREATE PROCEDURE spTeamMembers_GetByTeam
@TeamId INT
AS
BEGIN
SET NOCOUNT ON;

SELECT People.* FROM TeamMembers 
INNER JOIN People ON TeamMembers.PersonId = People.ID 
WHERE TeamMembers.TeamId = @TeamId;
END



--stored procedure
--spTournaments_Insert

CREATE PROCEDURE spTournaments_Insert
@TournamentName VARCHAR(100),
@ENTRYFEE MONEY,
@ID INT = 0 OUTPUT
AS
BEGIN
SET NOCOUNT ON
INSERT INTO dbo.Tournaments (TournamentName, EntryFee, Active)
VALUES (@TournamentName,@ENTRYFEE,1);
	SELECT @ID = SCOPE_IDENTITY();
END


--stored procedure
--spTournamentPrizes_Insert

CREATE PROCEDURE spTournamentPrizes_Insert
@TournamentId INT,
@PrizeId INT,
@ID INT = 0 OUTPUT
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO dbo.TournamentPrizes(TournamentId,PrizeId)
VALUES (@TournamentId,@PrizeId);
SELECT @ID = SCOPE_IDENTITY();
END

--stored procedure
--spTournamentEntries_Insert

CREATE PROCEDURE spTournamentEntries_Insert
@TournamentId INT,
@TeamId INT,
@ID INT = 0 OUTPUT
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO dbo.TournamentEntries(TournamentId,TeamId)
VALUES (@TournamentId,@TeamId);
SELECT @ID = SCOPE_IDENTITY();
END

--stored procedure
--spMatchups_Insert

CREATE PROCEDURE spMatchups_Insert
@TournamentId INT,
--@WinnerId INT,
@MatchupRound INT,
@ID INT = 0 OUTPUT
AS
BEGIN
SET NOCOUNT ON;

INSERT INTO dbo.Matchups(TournamentId, MatchupRound)
VALUES (@TournamentId, @MatchupRound);

SELECT @ID = SCOPE_IDENTITY();
END

--stored procedure
--spMatchupEntries_Insert

CREATE PROCEDURE spMatchupEntries_Insert
@MatchupId INT,
@ParentMatchupId INT,
@TeamCompetingId INT,
@ID INT = 0 OUTPUT
AS
BEGIN
SET NOCOUNT ON;

INSERT INTO dbo.MatchupEntries(MatchupId,ParentMatchupId,TeamCompetingId)
VALUES (@MatchupId,@ParentMatchupId,@TeamCompetingId);

SELECT @ID = SCOPE_IDENTITY();
END


--stored procedure
--spTournaments_GetAll
CREATE PROCEDURE spTournaments_GetAll
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM dbo.Tournaments
WHERE Active = 1;
END

--stored procedure
--spPrizes_GetByTournament
CREATE PROCEDURE spPrizes_GetByTournament
@TournamentId INT
AS
BEGIN
SET NOCOUNT ON;
SELECT	dbo.Prizes.* FROM dbo.Prizes
INNER JOIN dbo.TournamentPrizes ON dbo.Prizes.ID = dbo.TournamentPrizes.PrizeId
WHERE dbo.TournamentPrizes.TournamentId = @TournamentId;
END


--stored procedure
--spTeam_GetByTournament
CREATE PROCEDURE spTeam_GetByTournament
@TournamentId INT
AS
BEGIN
SET NOCOUNT ON;
SELECT	dbo.Teams.* FROM dbo.Teams
INNER JOIN dbo.TournamentEntries ON dbo.Teams.ID = dbo.TournamentEntries.TeamId
WHERE dbo.TournamentEntries.TournamentId = @TournamentId;
END


--stored procedure
--spMatchups_GetByTournament
CREATE PROCEDURE spMatchups_GetByTournament
@TournamentId INT
AS
BEGIN
SET NOCOUNT ON;
SELECT	dbo.Matchups.* FROM dbo.Matchups
WHERE dbo.Matchups.TournamentId = @TournamentId;
END


--stored procedure
--spMatchupEntries_GetByMatchup
CREATE PROCEDURE spMatchupEntries_GetByMatchup
@MatchupId INT
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM dbo.MatchupEntries
WHERE dbo.MatchupEntries.MatchupId = @MatchupId;
END


--stored procedure
--spMatchups_Update
CREATE PROCEDURE spMatchups_Update
@WinnerId INT,
@ID INT
AS
BEGIN
SET NOCOUNT ON;
UPDATE dbo.Matchups
SET WinnerId = @WinnerId
WHERE dbo.Matchups.ID = @ID;
END


--stored procedure
--spMatchupEntries_Update
CREATE PROCEDURE spMatchupEntries_Update
@ID INT,
@TeamCompetingId INT = NULL,
@Score FLOAT = NULL
AS
BEGIN
SET NOCOUNT ON;
UPDATE dbo.MatchupEntries
SET TeamCompetingId = @TeamCompetingId, Score = @Score
WHERE ID = @ID;
END



--stored procedure
--spTournaments_Complete
CREATE PROCEDURE dbo.spTournaments_Complete
@ID INT
AS
BEGIN
SET NOCOUNT ON;
UPDATE dbo.Tournaments
SET Active = 0
WHERE ID = @ID;
END



select * from Matchups
--reset area
drop table TournamentPrizes
drop table TournamentEntries
drop table Matchups
drop table MatchupEntries
Drop table Tournaments
