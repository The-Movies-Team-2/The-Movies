using ApplicationLayer.DataHandlers;
using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;

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
    }
}
