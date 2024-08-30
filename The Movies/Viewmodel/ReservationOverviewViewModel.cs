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
using The_Movies.Controllers;
using The_Movies.DomainModel;
using The_Movies.Model;

namespace The_Movies.Viewmodel
{
    public class ReservationOverviewViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<ReservationForView> Reservations { get; set; }
        public ObservableCollection<Showing> Showings { get; set; }
        private Showing selectedShowing { get; set; }
        public Showing SelectedShowing
        {
            get { return selectedShowing; }
            set
            {
                selectedShowing = value;
                OnPropertyChanged(nameof(SelectedShowing));
                LoadReservations(selectedShowing.Id);
            }
        }

        public ReservationController reservationController { get; set; }
        public ShowingController showingController { get; set; }
        public CinemaController cinemaController { get; set; }
       

        public ReservationOverviewViewModel() 
        {
            reservationController = new ReservationController();
            showingController = new ShowingController();
            cinemaController = new CinemaController();

            Reservations = new ObservableCollection<ReservationForView>();
            Showings = new ObservableCollection<Showing>();
            LoadReservations();
            LoadShowings();
        }

        private void LoadReservations(int showId = 0)
        {
            Reservations.Clear();
             List<Reservation> TempReservations = reservationController.GetAll();
            if (showId != 0)
            {
                TempReservations = TempReservations.Where(item => item.Id == showId).ToList();
            }
            
            foreach (Reservation reservation in TempReservations)
            {
                ReservationForView reservationForView = new ReservationForView();
                reservationForView.Id = reservation.Id;
                reservationForView.MovieTitle = showingController.GetById(reservation.ShowingId).Movie.Title;

                int cinemaId = showingController.GetById(reservation.ShowingId).Theater.CinemaId;
                string CinemaName = cinemaController.GetById(cinemaId).Name;
                string TheaterName = showingController.GetById(reservation.ShowingId).Theater.Name;
                reservationForView.Place = $"{CinemaName},{TheaterName}";

                reservationForView.Date = showingController.GetById(reservation.ShowingId).Date;
                reservationForView.TimeRange = showingController.GetById(reservation.ShowingId).TimeRange;

                reservationForView.NumberOfTickets = reservation.NumberOfTickets;
                reservationForView.CustomerPhone = reservation.CustomerPhone;
                reservationForView.CustomerMail = reservation.CustomerMail;
                Reservations.Add(reservationForView);
            }
        }
        private void LoadShowings()
        {
            List<Showing> TempShowings = showingController.GetAll();

            foreach (Showing showing in TempShowings)
            {
                Showings.Add(showing);
            } 
        }

        public class ReservationForView
        {
            public int Id { get; set; }
            public string MovieTitle { get; set; }
            public string Place { get; set; }
            public DateOnly Date { get; set; }
            public string TimeRange {  get; set; }
            public int NumberOfTickets { get; set; }
            public string CustomerPhone { get; set; }
            public string CustomerMail { get; set; }

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
