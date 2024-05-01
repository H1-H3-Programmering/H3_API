-- Insert data into tables with foreign key constraints

INSERT INTO Users (Username, Email, Password) VALUES 
('string', 'Kyler42@gmail', 'itVC3Xq5BOqasC3'),
('string', 'Gage.Runolfsdottir28@gmail', 'ZL1GtMt4QZNsf57'),
('string', 'Marcel0@gmail', 'qIInPJNPxdRiuhe');

INSERT INTO Country (CountryName, Continent) VALUES 
('United States Minor Outlying Islands', 'string'),
('Malaysia', 'string'),
('Nauru', 'string');

INSERT INTO Region (RegionName, CountryId) VALUES 
('string', 1),
('string', 2),
('string', 3);

INSERT INTO Language (LanguageName, CountryId) VALUES 
('string', 1),
('string', 2),
('string', 3);

INSERT INTO Kitchen (Name, Continent, Region, CountryId) VALUES 
('string', 'string', 'string', 1),
('string', 'string', 'string', 2),
('string', 'string', 'string', 3);

INSERT INTO Category (Name) VALUES 
('Random'),
('Random'),
('Random');

INSERT INTO Ingredient (Name, CategoryId) VALUES 
('string', 1),
('string', 2),
('string', 3);

INSERT INTO Preference (PreferenceType, PreferenceDescription) VALUES 
('string', 'string'),
('string', 'string'),
('string', 'string');

INSERT INTO DietaryPreference (PreferenceId) VALUES 
(1),
(2),
(3);

INSERT INTO Recipe (Name, Description, Origin, Instructions, Difficulty, PreparationTime) VALUES 
('string', 'string', 'string', 'string', 1, 1),
('string', 'string', 'string', 'string', 2, 2),
('string', 'string', 'string', 'string', 3, 3);

INSERT INTO RecipeTag (RecipeId, Tag) VALUES 
(1, 'string'),
(2, 'string'),
(3, 'string');

INSERT INTO Comments (UserId, RecipeId, Text) VALUES 
(1, 1, 'string'),
(2, 2, 'string'),
(3, 3, 'string');

INSERT INTO Review (Rating, Comment, UserId, RecipeId) VALUES 
(1, 'string', 1, 1),
(2, 'string', 2, 2),
(3, 'string', 3, 3);

INSERT INTO UserFavorite (UserId) VALUES 
(1),
(2),
(3);

INSERT INTO UserHistory (UserId, RecipeId) VALUES 
(1, 1),
(2, 2),
(3, 3);
