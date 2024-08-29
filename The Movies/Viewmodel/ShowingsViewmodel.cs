using ApplicationLayer.Controllers;
using DomainModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using The_Movies.ApplicationLayer.Controllers;
using The_Movies.Commands;

namespace The_Movies.Viewmodel
{
    public class ShowingsViewmodel
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
                ConvertToView(showing);
            }
        }
        private ShowingForView ConvertToView(Showing showing) 
        {
            ShowingForView NewShowing = new ShowingForView();
            NewShowing.MovieTitle = movieController.GetById(showing.Movie.Id).Title;
            NewShowing.CinemaName = cinemaController.GetById(showing.Theater.CinemaId).Name;
            NewShowing.TheaterName = theaterController.GetById(showing.Theater.Id).Name;
            NewShowing.Date = showing.Date;
            NewShowing.TimeRange = showing.TimeRange;
            return NewShowing;
        }


        public class ShowingForView
        {
            public string MovieTitle { get; set; }
            public string CinemaName { get; set; }
            public string TheaterName { get; set; }
            public DateOnly Date {  get; set; }
            public string TimeRange { get; set; }
        }

        public ICommand SortByBioCMD { get; set; } = new SortList();
        public void SortByBio(string sortCriterion)
        {
             List<Showing> TempShowings = showingsController.GetAll();
             Showings.Clear();

                switch (sortCriterion)
                {
                    case "Hjerm":
                        foreach (Showing showing in TempShowings)
                        {
                            if (cinemaController.GetById(showing.Theater.CinemaId).Name == "Hjerm Biograf")
                            {
                                Showings.Add(ConvertToView(showing));
                            }
                        }
                        break;

                    case "Videbæk":
                        foreach (var showing in TempShowings)
                        {
                            if (cinemaController.GetById(showing.Theater.CinemaId).Name == "Videbæk Biograf")
                            {
                                Showings.Add(ConvertToView(showing));
                            }
                        }
                        break;

                    case "Thorsminde":
                        foreach (var showing in TempShowings)
                        {
                            if (cinemaController.GetById(showing.Theater.CinemaId).Name == "Thorsminde Biograf")
                            {
                                Showings.Add(ConvertToView(showing));
                            }
                        }
                        break;

                    case "Ræhr":
                        foreach (var showing in TempShowings)
                        {
                            if (cinemaController.GetById(showing.Theater.CinemaId).Name == "Ræhr Biograf")
                            {
                                Showings.Add(ConvertToView(showing));
                            }
                        }
                        break;

                    case "Alle":
                    default:
                        // Viser alle forestillinger
                        foreach (Showing showing in TempShowings)
                        {
                            Showings.Add(ConvertToView(showing));
                        }
                        break;
                }
            

        }
    }
}
