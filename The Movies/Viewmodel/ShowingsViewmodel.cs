using ApplicationLayer.Controllers;
using DomainModel;
using System.Collections.ObjectModel;
using The_Movies.ApplicationLayer.Controllers;

namespace The_Movies.Viewmodel
{
    internal class ShowingsViewmodel
    {
        public ObservableCollection<ShowingForView> Showings {  get; set; }
        public ShowingController showingsController = new ShowingController();
        public MovieController movieController = new MovieController();
        public CinemaController cinemaController = new CinemaController();
        public TheaterController theaterController = new TheaterController();

        public ShowingsViewmodel() 
        {
            Showings = new ObservableCollection<ShowingForView>();
            LoadShowings();
        }

        private void LoadShowings()
        {
            List<Showing> TempShowings = showingsController.GetAll(); //TODO 

            foreach (Showing showing in TempShowings)
            {
                ShowingForView NewShowing = new ShowingForView();
                NewShowing.MovieTitle = movieController.GetById(showing.Movie.Id).Title; //showing.Movie.Id istedet for 1 på sigt
                NewShowing.CinemaName = cinemaController.GetById(showing.Theater.CinemaId).Name;
                NewShowing.TheaterName = theaterController.GetById(showing.Theater.Id).Name;
                NewShowing.Date = showing.Date;
                NewShowing.TimeRange = showing.TimeRange;
                Showings.Add(NewShowing);
            }
            
        }

        public class ShowingForView
        {
            public string MovieTitle { get; set; }
            public string CinemaName { get; set; }
            public string TheaterName { get; set; }
            public DateOnly Date {  get; set; }
            public string TimeRange { get; set; }

        }
    }
}
