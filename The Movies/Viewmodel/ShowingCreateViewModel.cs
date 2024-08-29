using ApplicationLayer.Controllers;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Controllers;
using The_Movies.DomainModel;
using The_Movies.Model;
using The_Movies.Converter;
using System.IO;
using System.Windows.Input;
using System.Windows;
using The_Movies.Commands;

namespace The_Movies.Viewmodel
{
    internal class ShowingCreateViewModel: INotifyPropertyChanged
    {
        //movies relateret
        public MovieController moviecontroller { get; set; }
        public ObservableCollection<Movie> movies { get; set; }
        public Movie selectedMovie {  get; set; }

        //cinema relateret
        public CinemaController CinemaController { get; set; }
        public ObservableCollection<Cinema> cinemas { get; set; }
        private Cinema selectedCinema;
        public Cinema SelectedCinema
        {
            get { return selectedCinema; }
            set
            {
                selectedCinema = value;
                OnPropertyChanged(nameof(SelectedCinema));
                IsTheaterComboBoxEnabled = true;
                LoadTheaters(SelectedCinema.Id);
            }
        }

        //Theater realteret
        public TheaterController theaterController { get; set; }
        public ObservableCollection<Theater> theatersInCinema { get; set; }
        public Theater selectedTheater { get; set; }
        private bool isTheaterComboBoxEnabled = false;
        public bool IsTheaterComboBoxEnabled
        {
            get { return isTheaterComboBoxEnabled; }
            set { isTheaterComboBoxEnabled = value; OnPropertyChanged(nameof(isTheaterComboBoxEnabled)); }
        }

        public DateOnly SelectedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public TimeOnly SelectedTime { get; set; } = TimeOnly.FromDateTime(DateTime.Now);

        public ShowingCreateViewModel() 
        {
            moviecontroller = new MovieController();
            CinemaController = new CinemaController();
            theaterController = new TheaterController();

            movies = new ObservableCollection<Movie>();
            cinemas = new ObservableCollection<Cinema>();
            theatersInCinema = new ObservableCollection<Theater>();

            LoadMovies();
            LoadCinemas();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void LoadMovies()
        {
            List<Movie> tempMovies = moviecontroller.GetAll();
            foreach (Movie movie in tempMovies) 
            {
                movies.Add(movie);
            }
        }
        private void LoadCinemas()
        {
            List<Cinema> tempCinemas = CinemaController.GetAll();
            foreach (Cinema cinema in tempCinemas)
            {
                cinemas.Add(cinema);
            }
        }

        public void LoadTheaters(int cinemaId)
        {
            theatersInCinema.Clear();
            List<Theater> tempTheaters = theaterController.GetByCinemaId(cinemaId);
            foreach (Theater theater in tempTheaters)
            {
                theatersInCinema.Add(theater);
            }
        }

        public ICommand CreateShowingCMD { get; set; } = new CreateShowingCommand();
        public void AddShowing()
        {
            ShowingController showingController = new ShowingController();
            Showing showing = new Showing(selectedMovie, selectedTheater, SelectedDate, SelectedTime);
            showingController.Add(showing);
        }

       
    }
}
