SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[usp_InsertMovie]
@Title nchar(30), @Director nchar(30), @Year int, @Length int,
@Genre nchar(10),@MovieID int, @Status smallint, @Price int
AS
BEGIN
SET NOCOUNT ON
INSERT INTO Movies([Title], [Director], [Year], [Length(Min)], [Genre])
VALUES(@Title, @Director, @Year, @Length, @Genre)
INSERT INTO MovieStatus(MovieID, [Status], Price)
VALUES (SCOPE_IDENTITY(), @Status, @Price)
END;
GO
drop proc usp_InsertMovie

EXEC usp_InsertMovie 'Frost', 'joestar', 1998, 134, 'Adventure', NULL,2, 39
SELECT*FROM Movies
SELECT * FROM MovieStatus
DELETE FROM Movies
WHERE Title LIKE 'Fros%'

