using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.Model
{
    internal class Movie
    {
        public int Id;
        public string Title { get; set; }
        public int PlayingTime { get; set; }
        public List<int> genreids = new List<int>();

        public Movie(string title, int id, int time, List<int> genres)
        {
            Title = title;
            PlayingTime = time;
            Id = id;
            genreids = genres;
        }

        public Movie(string title, int time, List<int> genres)
        
        {
            Title = title; 
            PlayingTime = time;
            genreids = genres; 
        }

    }
}
