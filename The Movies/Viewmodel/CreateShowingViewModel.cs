using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Controllers;
using ApplicationLayer.Controllers;
using The_Movies.DomainModel;
using System.Windows.Input;
using The_Movies.Commands;
using The_Movies.Controllers;
using The_Movies.ApplicationLayer.Repositories;
using System.Collections.ObjectModel;

namespace The_Movies.Viewmodel
{
    class CreateShowingViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }
        public MovieController MovieController = new MovieController();
        public CinemaController cinemaController = new CinemaController();
        public TheaterController theaterController = new TheaterController();

        public CreateShowingViewModel()
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
        }
    }
}
