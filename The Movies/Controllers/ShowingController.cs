using ApplicationLayer.DataHandlers;
using DomainModel;
using The_Movies.ApplicationLayer.Repositories;
using ApplicationLayer.Interfaces;

namespace ApplicationLayer.Controllers
{
    public class ShowingController
    {
        private readonly ShowingRepository repository;
        private readonly IMasterDataHandler dataHandler;
        public ShowingController()
        {
            dataHandler = DataHandlerManager.GetMasterDataHandler();
            repository = dataHandler.ShowingRepository;
        }

        public void Add(Showing showing)
        {
            repository.Add(showing);
            dataHandler.Write();
        }
        public Showing GetById(int id) 
        { 
           return repository.GetById(id);
        }
        public List<Showing> GetAll()
        {
            return repository.GetAll();
        }
    }
}
