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
        private readonly CinemaRepository repository;
        private readonly MasterDataHandler dataHandler;//**KORREKT?

        public CinemaController()
        {
            dataHandler = new MasterDataHandler();//**
            repository = dataHandler.CinemaRepository;
        }
    }
}
