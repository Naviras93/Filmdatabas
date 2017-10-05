using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMovies;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace WinFormMovies
{
    public partial class LableTitle : Form
    {
        public LableTitle()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)   //Searching for movie. Get list back.
        {
            string title = textBoxSearchTitle.Text;
            MovieClass mc = new MovieClass();
            List<MovieClass> no = mc.Search(title);
            
            if (no.Count<MovieClass>() == 0) // Checking if movie exist.
            {
                MessageBox.Show("Movie does not exist"); 
            }

            listViewMovieInfo.Items.Clear();
            
            foreach (var movie in mc.Search(title))      
            {
                ListViewItem item = new ListViewItem((movie.MovieID).ToString());
                item.SubItems.Add(movie.Title);
                item.SubItems.Add(movie.Director);
                item.SubItems.Add((movie.Year).ToString());
                item.SubItems.Add((movie.Length).ToString());
                item.SubItems.Add(movie.Genre);
                item.SubItems.Add((movie.Status).ToString());
                item.SubItems.Add((movie.Price).ToString());
                listViewMovieInfo.Items.Add(item);
            }
            
           textBoxSearchTitle.Clear();

        }
        private void buttonAdd_Click(object sender, EventArgs e) // Adding movie
        {
            int number1;
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text)) // Checking if the textbox is empty.
            {
                MessageBox.Show("You must add Title!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (string.IsNullOrWhiteSpace(textBoxDirector.Text)) // Checking if the textbox is empty.
            {
                MessageBox.Show("You must add Director!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (int.TryParse(textBoxDirector.Text, out number1)) //Checking if the value in the textbox is a string.
            {
                MessageBox.Show("A Director cannot have a integer, enter a string!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
                
            else if (string.IsNullOrWhiteSpace(textBoxYear.Text))
            {
                MessageBox.Show("You must add Year!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (!int.TryParse(textBoxYear.Text, out number1))
            {
                MessageBox.Show("A Year cannot have a string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (string.IsNullOrWhiteSpace(textBoxLength.Text))
            {
                MessageBox.Show("You must add Length!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

            else if (!int.TryParse(textBoxLength.Text, out number1))
            {
                MessageBox.Show("A Length cannot have a string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (string.IsNullOrWhiteSpace(textBoxGenre.Text))
            {
                MessageBox.Show("You must add Genre!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

            else if (int.TryParse(textBoxGenre.Text, out number1))
            {
                MessageBox.Show("A Genre cannot have a integer, enter a string!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("You must add Status!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }
            
            else if (!int.TryParse(textBoxStatus.Text, out number1))
            {
                MessageBox.Show("A Status cannot have string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("You must add Price!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

            else if (!int.TryParse(textBoxPrice.Text, out number1))
            {
                MessageBox.Show("A Price cannot have string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else
            {
                string title = textBoxTitle.Text;    //Creating variables from the value written in the textboxes.
                string director = textBoxDirector.Text;
                string year = textBoxYear.Text;
                int yearInt = Convert.ToInt32(year);
                string length = textBoxLength.Text;
                int lengthInt = Convert.ToInt32(length);
                string genre = textBoxGenre.Text;
                string status = textBoxStatus.Text;
                int statusInt = Convert.ToInt32(status);
                string price = textBoxPrice.Text;
                int priceInt = Convert.ToInt32(price);
                MovieClass Movie = new MovieClass();

                Movie.AddMovie(title, director, yearInt, lengthInt, genre, statusInt, priceInt); //Calling AddMovie method.
                MessageBox.Show("Movie added!");
                textBoxTitle.Clear(); //Clear the textboxes.
                textBoxDirector.Clear();
                textBoxYear.Clear();
                textBoxLength.Clear();
                textBoxGenre.Clear();
                textBoxStatus.Clear();
                textBoxPrice.Clear();
            }

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int number1;
            
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("You must add Price!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

            else if (!int.TryParse(textBoxPrice.Text, out number1))
            {
                MessageBox.Show("A Price cannot have string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else
            {
                string price = textBoxPrice.Text;
                int priceInt = Convert.ToInt32(price);
                string movieId = textBoxMovieId.Text;
                int movieIdInt = Convert.ToInt32(movieId);
                MovieClass UpPrice = new MovieClass();
                UpPrice.UpdatePrice(movieIdInt, priceInt);
                textBoxPrice.Clear();
                textBoxMovieId.Clear();
            }
        }
        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            int number1;
            
            if (string.IsNullOrWhiteSpace(textBoxMovieId.Text))
            {
                MessageBox.Show("You must add a MovieID", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (!int.TryParse(textBoxMovieId.Text, out number1))
            {
                MessageBox.Show("A MovieID cannot have a string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else if (string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("You must add Status!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

            else if (!int.TryParse(textBoxStatus.Text, out number1))
            {
                MessageBox.Show("A Status cannot have string, enter an integer!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else
            {
                string status = textBoxStatus.Text;
                int statusInt = Convert.ToInt32(status);
                string movieId = textBoxMovieId.Text;
                int movieIdInt = Convert.ToInt32(movieId);
                MovieClass UpStatus = new MovieClass();
                UpStatus.UpdateStatus(movieIdInt, statusInt);
                textBoxStatus.Clear();
                textBoxMovieId.Clear();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i;

            if (string.IsNullOrWhiteSpace(textBoxMovieId.Text))
            {
                MessageBox.Show("You must add a MoviedID to delete!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            }

            else if (!int.TryParse(textBoxMovieId.Text, out i))
            {
                MessageBox.Show("You must add an integer, not a string!", "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            else
            {
                
                string movieId = textBoxMovieId.Text;
                int movieIdInt = Convert.ToInt32(movieId);
                MovieClass ReMovie = new MovieClass();
                ReMovie.RemoveMovie(movieIdInt);                
                textBoxMovieId.Clear();
            }
        }











        private void textBoxMovieId_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewMovieInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewMovieInfo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieClass MoviesExit = new MovieClass();
            MoviesExit.ExitApplication();
        }

        private void LableTitle_Load(object sender, EventArgs e)
        {

        }

    }
}
