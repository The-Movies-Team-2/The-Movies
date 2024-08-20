using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.Model
{
    internal class Movie
    {
        private int _id;
        public int Id { get; set; }

        private string _title;
        public string Title { get; set; }

        private int _PlayingTime;
        public int PlayingTime { get; set; }

        private List<int> _genreids = new List<int>();
        public List<int> genreids { get; set; }

        private string _Director;
        public string Director { get; set; }

        private float _PremierDate;
        public float PremierDate { get; set; }
        
        public Movie(string title, int id, int time, string director, List<int> genres, float date)
        {
            Title = title;
            PlayingTime = time;
            Id = id;
            genreids = genres;
            Director = director;
            PremierDate = date;
            
        }

        public Movie(string title, int time, List<int> genres)
        
        {
            Title = title; 
            PlayingTime = time;
            genreids = genres; 
        }

    }
}
