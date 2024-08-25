using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;
using The_Movies.Model;

namespace DomainModel
{
    public class Showing
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Theater Theater { get; set; }
        private int CleaningTime = 15;
        private int AdvertisingTime = 15;
        private DateTime startTime;
        private DateTime EndTime { get; set; }
        public List<Reservation> Reservations {get; set; } = new List<Reservation>();
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                EndTime = startTime.AddMinutes(Movie.Duration + CleaningTime + AdvertisingTime); // Beregn EndTime
            }
        }
       

        // Ny egenskab, der kombinerer start- og sluttidspunkt
        public string TimeRange => $"{StartTime:HH:mm} - {EndTime:HH:mm}";
    }
}
