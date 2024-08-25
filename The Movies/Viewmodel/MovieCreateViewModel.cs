using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using The_Movies.DomainModel;
using The_Movies.Commands;
using The_Movies.ApplicationLayer.Controllers;
using System.Collections.Specialized;
using ApplicationLayer.Interfaces;

namespace The_Movies.Viewmodel
{
    public class MovieCreateViewModel
    {
        public ObservableCollection<Genre> AvailableGenres { get; set; }
        public ObservableCollection<Genre> SelectedGenres { get; set; }

        public MovieController MovieController { get; set; }
        public GenreController GenreController { get; set; }

        public string Title { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }


        public MovieCreateViewModel()
        {
            MovieController = new MovieController();
            GenreController = new GenreController();
            AvailableGenres = new ObservableCollection<Genre>();
            SelectedGenres = new ObservableCollection<Genre> { null };

            LoadGenres();

            Title = "Filmens titel";
            Director = "instruktør";
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
        public void AddMovie()
        {
            var genres = SelectedGenres.Distinct().ToList();
            Movie movie = new Movie(Title, Duration, genres,Director);
            MovieController.Add(movie);
           

        }

    }

}
