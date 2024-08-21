using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.DomainModel
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PlayingTime { get; set; }

        public List<Genre> Genres = new List<Genre>();

        public string GenreString
        {
            get
            {
                return string.Join(", ", Genres.Select(p => p.Name));
            }
        }

        public Movie(int id, string title, int time, List<Genre> genres)
        {
            Title = title;
            PlayingTime = time;
            Id = id;
            Genres = genres;
        }

        public Movie(string title, int time, List<Genre> genres)

        {
            Title = title;
            PlayingTime = time;
            Genres = genres;
        }

    }
}
