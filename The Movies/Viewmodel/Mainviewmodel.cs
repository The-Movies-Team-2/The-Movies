using System.Collections.ObjectModel;
using System.Windows.Input;

using The_Movies.DomainModel;
using The_Movies.Commands;
using The_Movies.ApplicationLayer.Controllers;

namespace The_Movies.Viewmodel
{
    internal class MainViewModel
    {
        public ObservableCollection<Genre> AvailableGenres { get; set; }
        public ObservableCollection<Genre> SelectedGenres { get; set; }

        public MovieController MovieController { get; set; }
        public GenreController GenreController { get; set; }

        public string Title {  get; set; }
        public int Duration { get; set; }


        public MainViewModel()
        {
            MovieController = new MovieController();
            GenreController = new GenreController();
            AvailableGenres = new ObservableCollection<Genre>();
            SelectedGenres = new ObservableCollection<Genre>();

            LoadGenres();

            Title = "Filmens titel her";
            Duration = 0;
        }

        private void LoadGenres()
        {
            List<Genre> TempGenres = GenreController.GetAll();
            foreach (Genre genre in TempGenres)
            {
                AvailableGenres.Add(genre);
            }
        }

        public ICommand CreateMovieCMD { get; set; } = new CreateMovieCommand();
        public void AddMovie(Movie movie)
        {
            movie.Title = Title;
            movie.PlayingTime = Duration;
            movie.Genres =SelectedGenres.ToList();
            MovieController.Add(movie);
        }

    }

}
