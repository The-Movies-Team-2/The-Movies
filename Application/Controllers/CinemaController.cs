using ApplicationLayer.DataHandlers;
using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.Model;

namespace ApplicationLayer.Controllers
{
    internal class CinemaController
    {
        private readonly CinemaRepository _repository;
        private readonly MasterDataHandler _dataHandler;//**KORREKT?

        public CinemaController()
        {
            _dataHandler = new MasterDataHandler();//**
            _repository = _dataHandler.CinemaRepository;
        }

        public void Add(Cinema cinema)
        {
            repository.Add(cinema);
            dataHandler.Write(); //**
        }

        public List<Cinema> GetAll()
        {
            return repository.GetALL();
        }
    }
}
