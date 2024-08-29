using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using The_Movies.DomainModel;
using The_Movies.Model;


namespace ApplicationLayer.Repositories
{
    class BookingRepository
    {
        private readonly List<Booking> bookings = new List<Booking>();
        private readonly List<Showing> showing = new List<Showing>();
        private readonly List<Movie> movie = new List<Movie>();

        
    }
}
