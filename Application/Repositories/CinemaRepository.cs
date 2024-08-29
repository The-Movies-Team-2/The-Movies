using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;
using The_Movies.Model;

namespace ApplicationLayer.Repositories
{
    internal class CinemaRepository
    {

        private readonly List<Cinema> cinemas = new List<Cinema>();
        private readonly List<Theater> theaters = new List<Theater>();  

        public void AddCinema(Cinema cinema)
        {
            int maxId = 0;
            if (cinemas.Count > 0) maxId = cinemas.Max(h => h.Id);
            cinema.Id = maxId + 1;
            cinemas.Add(cinema);            
        }

        public List<Cinema> GetCinema() { return cinemas; }


        //create theater & remove? 

        public List<Theater> GetTheater()
        {
            return theaters;
        }

    }
}
