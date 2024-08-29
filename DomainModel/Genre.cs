using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.DomainModel
{
    public class Genre
    {
        public int Id { get; }
        public string Name { get; set; }
        public Genre(int id, string name)
        {
            Name = name;
            Id = id;
        }

    }
}
