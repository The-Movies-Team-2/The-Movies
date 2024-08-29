using ApplicationLayer.DataHandlers;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Repositories;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace The_Movies.Controllers
{
    public class ReservationController
    {
        private readonly ReservationRepository _repository;
        private readonly IMasterDataHandler _dataHandler;

        public ReservationController()
        {
            _dataHandler = DataHandlerManager.GetMasterDataHandler();
            _repository = _dataHandler.ReservationRepository;
        }

        public void Add(Reservation reservation)
        {
            _repository.Add(reservation);
            _dataHandler.Write();
        }

        public Reservation GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Reservation> GetAll()
        {
            return _repository.GetAll();
        }
        public List<Reservation> GetByShowingId(int id)
        {
            return _repository.GetByShowingId(id);
        }
    }
}
