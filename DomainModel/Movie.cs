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
        public int Duration { get; set; }
        public string Director { get; set; }

        public List<Genre> Genres = new List<Genre>();

        public string GenreString
        {
            get
            {
                return string.Join(", ", Genres.Select(p => p.Name));
            }
        }

        public Movie(int id, string title, int time, List<Genre> genres,string director)
        {
            Title = title;
            Duration = time;
            Id = id;
            Genres = genres;
            Director = director;
        }

        public Movie(string title, int time, List<Genre> genres, string director)
        {
            Title = title;
            Duration = time;
            Genres = genres;
            Director = director;
        }

    }
}
