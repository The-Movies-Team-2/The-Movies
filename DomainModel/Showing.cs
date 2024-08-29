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
        public Cinema Cinema { get; set; }
        public Theater Theater { get; set; }

        private DateTime startTime; 
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                EndTime = startTime.AddMinutes(Movie.PlayTime + 30); // Beregn EndTime
            }
        }
        private DateTime EndTime { get; set; }

        public Showing(int id, Movie movie, Cinema cinema, Theater theater, DateTime startTime, DateTime endTime)
        {
            this.Id = id;
            this.Movie = movie;
            this.Cinema = cinema;
            this.Theater = theater;
            this.StartTime = startTimeV;
            this.EndTime = endTime;
        }



        // Ny egenskab, der kombinerer start- og sluttidspunkt
        public string TimeRange => $"{StartTime:HH:mm} - {EndTime:HH:mm}";
    }
}
