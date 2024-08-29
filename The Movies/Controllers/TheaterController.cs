using ApplicationLayer.DataHandlers.DomainDataHandlers;
using ApplicationLayer.Repositories;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace ApplicationLayer.Controllers
{
    public class TheaterController
    {
        private readonly TheaterRepository _repository;

        public TheaterController()
        {
            _repository = new TheaterRepository();            
        }

        public virtual List<Theater> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Theater GetById(int id)
        {
            return _repository.GetById(id);
        }
        public List<Theater> GetByCinemaId(int cinemaid)
        {
           return _repository.GetByCinemaId(cinemaid);
        }


    }
}
