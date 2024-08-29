using DomainModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Repositories
{
    public class ShowingRepository
    {
        private readonly List<Showing> Showings = new List<Showing>();
        private readonly List<Booking> Bookings = new List<Booking>();
        private readonly List<Movie> Movies = new List<Movie>();

        public List<Showing> GetShowing() {
            return Showings;
        }

        public void AddShowing(Showing Showing)
        {
            int maxId = 0;
            if (Showings.Count > 0) maxId = Showings.Max(h => h.Id);
            Showing.Id = maxId + 1;
            Showings.Add(Showing);
        }
        public Showing GetById(int id)
        {
            return Showings.FirstOrDefault(g => g.Id == id);
        }
        public List<Showing> GetAll()
        {
            return Showings;
        }


        public Booking CreateBooking(int BookingId, DateOnly BookingDate, string Email, int PhoneNumber, int NumberOfTickets, Showing showing) {
            Booking booking = new Booking(BookingId, BookingDate, Email,PhoneNumber ,NumberOfTickets, showing);
            Bookings.Add(booking);

            return booking;
        }

        public void RemoveBooking(Booking booking) {
            if (Bookings.Contains(booking)) {
                Bookings.Remove(booking);
            }
        }

        public List<Booking> GetBooking() {
            return Bookings;
        }

        public List<Movie> GetMovies()
        {
            return Movies;
        }

       
    }
}
