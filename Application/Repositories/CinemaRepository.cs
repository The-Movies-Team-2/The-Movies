using ApplicationLayer.DataHandlers;
using ApplicationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;
using The_Movies.Model;

namespace ApplicationLayer.Repositories
{
    public class CinemaRepository
    {
        private readonly List<Cinema> cinemas = new List<Cinema>();
        private IMasterDataHandler dataHandler;


       public CinemaRepository(IMasterDataHandler dataHandler)
        {
            Add(new Cinema(1, "Hjerm Biograf",dataHandler.TheaterRepository.GetByCinemaId(1)));
            Add(new Cinema(2, "Videbæk Biograf", dataHandler.TheaterRepository.GetByCinemaId(2)));
            Add(new Cinema(3, "Thorsminde Biograf", dataHandler.TheaterRepository.GetByCinemaId(3)));
            Add(new Cinema(4, "Ræhr Biograf", dataHandler.TheaterRepository.GetByCinemaId(4)));
        }

        public void Add(Cinema cinema)
        {
            cinemas.Add(cinema);
        }

        public List<Cinema> GetALL() { return cinemas; }        
    }
}
