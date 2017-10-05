--USE Movies
CREATE PROCEDURE usp_UpdatePrice
	(
		@Title AS nvarchar(50),
		@Price AS smallint
	)
AS
BEGIN
	SET NOCOUNT ON

	UPDATE MovieStatus
	SET
		[Price] = @Price
	FROM MovieStatus as MS
	INNER JOIN Movies as M
	ON MS.MovieID = M.MovieID
	WHERE 
		M.[Title] LIKE '%' + @Title + '%';
END
GO

EXEC usp_UpdatePrice '2001', 18

SELECT M.MovieID, M.Title, M.Director, M.[Year], M.[Length(Min)], M.Genre, [Status], Price   
	FROM MovieStatus as MS
	INNER JOIN Movies as M
	ON MS.MovieID = M.MovieID