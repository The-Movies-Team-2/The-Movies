using ApplicationLayer.DataHandlers;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.DataHandlers;
using ApplicationLayer.DataHandlers.DomainDataHandlers;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace ApplicationLayer.Controllers
{
    public class ShowingController
    {
        private readonly ShowingRepository repository;
        private readonly MasterDataHandler dataHandler;
        public ShowingController()
        {
            dataHandler = new MasterDataHandler();
            repository = dataHandler.ShowingRepository;
        }

        public void Add(Showing showing)
        {
            repository.Add(showing);
            dataHandler.Write();
        }

        public List<Showing> GetAll()
        {
            return repository.GetAll();
        }
    }
}
