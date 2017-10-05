--USE Movies
CREATE PROCEDURE usp_UpdateStatus
	(
		@Title AS nvarchar(50),
		@Status AS smallint
	)
AS
BEGIN
	SET NOCOUNT ON

	UPDATE MovieStatus
	SET
		[Status] = @Status
	FROM MovieStatus as MS
	INNER JOIN Movies as M
	ON MS.MovieID = M.MovieID
	WHERE 
		M.[Title] LIKE '%' + @Title + '%';
END
GO

EXEC usp_UpdateStatus '2001', 1

SELECT M.MovieID, M.Title, M.Director, M.[Year], M.[Length(Min)], M.Genre, [Status], Price   
	FROM MovieStatus as MS
	INNER JOIN Movies as M
	ON MS.MovieID = M.MovieID