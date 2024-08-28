using ApplicationLayer.DataHandlers;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;
using The_Movies.Model;

namespace ApplicationLayer.Controllers
{
    public class CinemaController
    {
        //private readonly CinemaRepository _repository;
        private readonly IMasterDataHandler _dataHandler;//**KORREKT?
        private CinemaRepository _repository;

        public CinemaController()
        {
            _dataHandler = DataHandlerManager.GetMasterDataHandler();
            _repository = _dataHandler.CinemaRepository;
        }

        public void Add(Cinema cinema)
        {
            _dataHandler.CinemaRepository.Add(cinema);
            _dataHandler.Write(); //**
        }
        public Cinema GetById(int id)
        {
            return _repository.GetById(id);
        }
        public List<Cinema> GetAll()
        {
            return _dataHandler.CinemaRepository.GetALL();
        }
    }
}
