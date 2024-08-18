using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.DataHandlers;
using ApplicationLayer.DataHandlers.DomainDataHandlers;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Controllers
{
    public class MovieController
    {
        private readonly MovieRepository repository;
        private readonly MasterDataHandler dataHandler;
        public MovieController() 
        { 
            dataHandler = new MasterDataHandler();
            repository = dataHandler.MovieRepository;
        }


        public void Add(Movie movie)
        {
            repository.Add(movie);
            dataHandler.Write();
        }

        public List<Movie> GetAll()
        {
            return repository.GetAll();
        }
    }
}
