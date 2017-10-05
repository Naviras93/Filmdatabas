using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMovies;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Windows.Forms;


namespace ClassLibraryMovies
{
    public class MovieClass
    {
        public int MovieID { get; set; } //Properties for every column in the database.
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public int Status { get; set; }
        public int Price { get; set; }
        public List<MovieClass> Search(string title) // The search method. 
        {
            List<MovieClass> movieList = new List<MovieClass>();

            var connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString; //Connecting to database.
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("usp_ReadMovie", connection); 
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Title = new SqlParameter(); //Creating a strongly typed properties
                Title.ParameterName = "@Title";
                Title.Value = title;
                Title.SqlDbType = SqlDbType.NVarChar;
                Title.Size = 50;
                cmd.Parameters.Add(Title);

                using (var reader = cmd.ExecuteReader()) //Looping through the films.
                {
                    while (reader.Read())
                    {
                        MovieClass movieSearch = new MovieClass();
                        movieSearch.MovieID = (int)reader["MovieID"];
                        movieSearch.Title = (string)reader["Title"];
                        movieSearch.Director = (string)reader["Director"];
                        movieSearch.Year = (int)reader["Year"];
                        movieSearch.Length = (int)reader["Length(Min)"];
                        movieSearch.Genre = (string)reader["Genre"];
                        movieSearch.Status = (int)reader["Status"];
                        movieSearch.Price = (int)reader["Price"];
                        movieList.Add(movieSearch);
                    }

                }

            }

            return movieList; //Returning a list of films matching the search.

        }
        public void AddMovie(string title, string director, int year, int length, string genre, int status, int price) //The method for adding a film to the database.
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("usp_InsertMovie", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Title = new SqlParameter();
                Title.ParameterName = "@Title";
                Title.Value = title;
                Title.SqlDbType = SqlDbType.NVarChar;
                Title.Size = 50;
                cmd.Parameters.Add(Title);

                SqlParameter Director = new SqlParameter();
                Director.ParameterName = "@Director";
                Director.Value = director;
                Director.SqlDbType = SqlDbType.NVarChar;
                Director.Size = 50;
                cmd.Parameters.Add(Director);

                SqlParameter Year = new SqlParameter();
                Year.ParameterName = "@Year";
                Year.Value = year;
                Year.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(Year);

                SqlParameter Length = new SqlParameter();
                Length.ParameterName = "@Length";
                Length.Value = length;
                Length.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(Length);

                SqlParameter Genre = new SqlParameter();
                Genre.ParameterName = "@Genre";
                Genre.Value = genre;
                Genre.SqlDbType = SqlDbType.NVarChar;
                Genre.Size = 50;
                cmd.Parameters.Add(Genre);

                SqlParameter Status = new SqlParameter();
                Status.ParameterName = "@Status";
                Status.Value = status;
                Status.SqlDbType = SqlDbType.Int; ;
                cmd.Parameters.Add(Status);

                SqlParameter Price = new SqlParameter();
                Price.ParameterName = "@Price";
                Price.Value = price;
                Price.SqlDbType = SqlDbType.Int; ;
                cmd.Parameters.Add(Price);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePrice(int movieIdInt, int priceInt) // Update price method.
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("usp_UpdatePrice", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter MovieId = new SqlParameter();
                MovieId.ParameterName = "@MovieID";
                MovieId.Value = movieIdInt;
                MovieId.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(MovieId);

                SqlParameter Price = new SqlParameter();
                Price.ParameterName = "@Price";
                Price.Value = priceInt;
                Price.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(Price);

                object obj = cmd.ExecuteScalar(); //The stored procedure returns the value 1 or 0.  
                int returnValue = (int)obj; //Cast the value from the SP to int.
                if (returnValue > 0)  //Checking if the movieID exists.
                {
                    MessageBox.Show("Price updated");
                }
                else
                {
                    MessageBox.Show("MovieID does not exist");
                }
            }

        }

        public void UpdateStatus(int movieIdInt, int statusInt) //Uppdate status method.
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("usp_UpdateStatus", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter MovieId = new SqlParameter();
                MovieId.ParameterName = "@MovieID";
                MovieId.Value = movieIdInt;
                MovieId.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(MovieId);

                SqlParameter Status = new SqlParameter();
                Status.ParameterName = "@Status";
                Status.Value = statusInt;
                Status.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(Status);

                
                object obj = cmd.ExecuteScalar(); //The stored procedure returns the value 1 or 0.
                int returnValue = (int)obj; //Cast the value from the SP to int.
                if (returnValue > 0) //Checking if movieID exists.
                {
                    MessageBox.Show("Status updated");
                }
                else
                {
                    MessageBox.Show("MovieID does not exist");
                }
            }
        }

        public void RemoveMovie(int movieIdInt) //Remove a movie. Updating status and price to 0.
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("usp_DeleteMovie", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter MovieId = new SqlParameter();
                MovieId.ParameterName = "@MovieID";
                MovieId.Value = movieIdInt;
                MovieId.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(MovieId);

                object obj = cmd.ExecuteScalar(); //The stored procedure returns the value 1 or 0.
                int returnValue = (int)obj; //Cast the value from the SP to int.
                if (returnValue > 0) //Checking if the movieID exists.
                {
                    MessageBox.Show("Movie Removed");
                }
                else
                {
                    MessageBox.Show("MovieID does not exist");
                }
                
            }
            
        }

        public void ExitApplication() //Exit application method.
        {
            Application.Exit();
        }

        

    }
}
