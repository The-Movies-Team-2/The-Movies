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
        private readonly CinemaRepository repository;
        private readonly MasterDataHandler dataHandler;//**KORREKT?

        public CinemaController()
        {
            dataHandler = new MasterDataHandler();//**
            repository = dataHandler.CinemaRepository;
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
