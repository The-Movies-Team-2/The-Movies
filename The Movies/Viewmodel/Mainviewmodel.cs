using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using The_Movies.Controllers;
using The_Movies.Model;
using The_Movies.Commands;

namespace The_Movies.Viewmodel
{
    internal class MainViewModel
    {
        public ObservableCollection<Genre> Genres { get; set; }
        public MovieController MovieController { get; set; }
        public GenreController GenreController { get; set; }

        public string Title {  get; set; }
        public int Duration { get; set; }
        //TODO
        public Genre SelectedGenre { get; set; }


        public MainViewModel()
        {
            MovieController = new MovieController();
            GenreController = new GenreController();
            Genres = new ObservableCollection<Genre>();

            LoadGenres();

            Title = "Filmens titel her";
            Duration = 0;
        }

        private void LoadGenres()
        {
            //Genres.Clear();
            List<Genre> TempGenres = GenreController.GetAll();
            foreach (Genre genre in TempGenres)
            {
                Genres.Add(genre);
            }
        }

        public ICommand CreateMovieCMD { get; set; } = new CreateMovieCommand();
        public void AddMovie(Movie movie)
        {
            movie.Title = Title;
            movie.PlayingTime = Duration;
            movie.GenreIds.Add(SelectedGenre.Id);
            MovieController.Add(movie);
        }

    }

}
