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
        public int NumberOfSeats { get; set; }

        public Theater(int id, string name, int cinemaId,int numberOfSeats)
        {
            Name = name;
            Id = id;
            CinemaId = cinemaId;
            NumberOfSeats = numberOfSeats;
        }
    }
}
