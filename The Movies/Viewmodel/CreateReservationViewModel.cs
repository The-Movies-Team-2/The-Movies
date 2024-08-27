using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace The_Movies.Viewmodel
{
    class CreateReservationViewModel
    {
        public ObservableCollection<Showing> Showings { get; set; }
        public Showing SelectedShowing { get; set; }
        public string WantedTickets {  get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
      

        public ShowingController showingController { get; set; }
        public ReservationController reservationController { get; set; }

        public CreateReservationViewModel()
        {
            showingController = new ShowingController();
            reservationController = new ReservationController();
            Showings = new ObservableCollection<Showing>();
            LoadShowings();
        }

        public void LoadShowings()
        {
            List<Showing> TempShowings = showingController.GetAll();
            foreach (Showing showing in TempShowings)
            {
                Showings.Add(showing);
            }
        }

        public ICommand CreateReservationCMD { get; set; } = new CreateReservationCommand();

        public void Add()
        {
            int tickets = int.Parse(WantedTickets);
            reservationController.Add(new Reservation(tickets,SelectedShowing,Phone,Email));
        }

        public bool CheckIfThereIsEnoughSeats()
        {
            int seatsInTheatre = SelectedShowing.Theater.NumberOfSeats;
            List<Reservation> reservationOnShow = reservationController.GetByShowingId(SelectedShowing.Id);
            int SumOfReservations = reservationOnShow.Sum(t => t.NumberOfTickets);

            return seatsInTheatre < (SumOfReservations + int.Parse(WantedTickets)) ? false : true;
        }
    }
}
