CREATE DATABASE HowtoCRUDDemo
CREATE TABLE Audiences
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    FirstName VARCHAR(50) NOT NULL,
    Lastname VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(5) NULL,
    Age INT NOT NULL    
)
CREATE TABLE AudienceAddress
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Audience_Id INT FOREIGN KEY REFERENCES Audiences(Id),
    Street VARCHAR(200),
    City VARCHAR(100),
    Province VARCHAR(100)    
)
INSERT INTO Audiences([FirstName], [Lastname], [Age])
VALUES 
    ('Frace', 'Marteja', 32)

INSERT INTO AudienceAddress([Audience_Id], [Street], [City], [Province])
VALUES
    (IDENT_CURRENT('Audiences'), 'Floodway', 'Cainta', 'Rizal')