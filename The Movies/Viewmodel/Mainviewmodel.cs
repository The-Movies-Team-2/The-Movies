using System.Collections.ObjectModel;
using System.Windows.Input;

using The_Movies.DomainModel;
using The_Movies.Commands;
using The_Movies.ApplicationLayer.Controllers;

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
            movie.Genres.Add(SelectedGenre);
            MovieController.Add(movie);
        }

    }

}
