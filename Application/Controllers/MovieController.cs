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
        private readonly MovieRepository _repository;
        private readonly MasterDataHandler _dataHandler;
        public MovieController()
        {
            _dataHandler = new MasterDataHandler();
            _repository = _dataHandler.MovieRepository;
        }


        public void Add(Movie movie)
        {
            _repository.Add(movie);
            _dataHandler.Write();
        }

        public List<Movie> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
