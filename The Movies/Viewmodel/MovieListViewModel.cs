using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Controllers;
using The_Movies.DomainModel;

namespace The_Movies.Viewmodel
{
    class MovieListViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }
        public MovieController MovieController = new MovieController();
        // public Movie SelectedMovie;

        public MovieListViewModel()
        {
            Movies = new ObservableCollection<Movie>();
            LoadMovies();
        }
        private void LoadMovies()
        {
            List<Movie> TempMovies = MovieController.GetAll();
            foreach (Movie movie in TempMovies)
            {
                Movies.Add(movie);

            }
            //Movies.Add(new Movie(1, "test", 0, new List<Genre>()));
        }
        public void ReloadMovies()
        {
            Movies.Clear();
            LoadMovies();
        }



    }
}
