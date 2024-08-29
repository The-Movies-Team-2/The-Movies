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
        public DateOnly Date { get; set; }
        private TimeOnly startTime { get; set; }
        private TimeOnly EndTime { get; set; }

        private int CleaningTime = 15;
        private int AdvertisingTime = 15;
  
      
        public List<Reservation> Reservations {get; set; } = new List<Reservation>();


        public override string ToString()
        {
            return $"{Movie.Title}, {Theater.Name}, {Date} , {StartTime}";
        }
        public TimeOnly StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                EndTime = startTime.AddMinutes(Movie.Duration + CleaningTime + AdvertisingTime); // Beregn EndTime
            }
        }

        public Showing(int id, Movie movie,Theater theater,DateOnly date,TimeOnly start) 
        {
            Id = id;
            Movie = movie;
            Theater = theater;
            Date = date;
            StartTime = start;
        }

        public Showing( Movie movie, Theater theater, DateOnly date, TimeOnly start)
        {
            Movie = movie;
            Theater = theater;
            Date = date;
            StartTime = start;
        }


        // Ny egenskab, der kombinerer start- og sluttidspunkt
        public string TimeRange => $"{StartTime:HH:mm} - {EndTime:HH:mm}";
    }
}
