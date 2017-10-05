Create	Procedure	FindMovieId(
@MovieId	int)
As
Begin
Select	*	From	Movies
Where  MovieID = @MovieId
End