using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.DataHandlers;
using ApplicationLayer.DataHandlers.DomainDataHandlers;
using ApplicationLayer.Interfaces;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Controllers
{
    public class MovieController
    {
        private readonly MovieRepository _repository;
        private readonly IMasterDataHandler _dataHandler;

        public MovieController()
        {
            _dataHandler = DataHandlerManager.GetMasterDataHandler();
            _repository = _dataHandler.MovieRepository;
        }

        public void Add(Movie movie)
        {
            _repository.Add(movie);
            _dataHandler.Write();
        }

        public Movie GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Movie> GetAll()
        {
            return _repository.GetAll();
        }

      
    }
}
