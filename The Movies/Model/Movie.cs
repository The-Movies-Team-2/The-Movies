using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.Model
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PlayingTime { get; set; }
        public List<int> GenreIds = new List<int>();

        public Movie(string title, int id, int time, List<int> genres)
        {
            Title = title;
            PlayingTime = time;
            Id = id;
            GenreIds = genres;
        }

        public Movie(string title, int time, List<int> genres)
        
        {
            Title = title; 
            PlayingTime = time;
            GenreIds = genres; 
        }

    }
}
