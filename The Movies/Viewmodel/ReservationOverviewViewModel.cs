using ApplicationLayer.Controllers;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Controllers;
using The_Movies.Controllers;
using The_Movies.DomainModel;

namespace The_Movies.Viewmodel
{
    public class ReservationOverviewViewModel
    {
        public ObservableCollection<Reservation> Reservations { get; set; }
        public ObservableCollection<Showing> Showings { get; set; }

        public ReservationController reservationController { get; set; }
        public ShowingController showingController { get; set; }
       

        public ReservationOverviewViewModel() 
        {
            reservationController = new ReservationController();
            showingController = new ShowingController();
            Reservations = new ObservableCollection<Reservation>();
            Showings = new ObservableCollection<Showing>();
            LoadReservations();
            LoadShowings();
        }

        private void LoadReservations()
        {
            List<Reservation> TempReservations = reservationController.GetAll();
            foreach (Reservation reservation in TempReservations)
            {
                Reservations.Add(reservation);

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
    }
}
