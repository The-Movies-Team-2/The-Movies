using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Theater
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CinemaId {  get; set; }

        public Theater(string name)

        {
            Name = name;
        }
        public Theater(int id, string name)

        {
            Name = name;
            Id = id;
        }

        public Theater(int id, string name, int cinemaId)

        {
            Name = name;
            Id = id;
            CinemaId = cinemaId;
        }
    }
}
