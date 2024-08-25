using DomainModel;
using The_Movies.DomainModel;
namespace ApplicationLayer.Repositories
{
    public class TheaterRepository
    {
        private readonly List<Theater> _theaters = new List<Theater>();


        public TheaterRepository()
        {
            Add(new Theater(1, "Sal 1",1));
            Add(new Theater(2, "Sal 2", 1));
            Add(new Theater(3, "Sal 3", 1));
            Add(new Theater(4, "Sal 1", 2));
            Add(new Theater(5, "Sal 2", 2));
        }

        public void Add(Theater theater)
        {            
         _theaters.Add(theater);
        }

        public Theater GetById(int id)
        {
            return _theaters.FirstOrDefault(g => g.Id == id);
        }
        public List<Theater> GetByCinemaId(int id)
        {
            return _theaters.FindAll(ci => ci.CinemaId == id);
        }
        public List<Theater> GetAll()
        {
            return _theaters.OrderBy(g => g.Name).ToList();
        }

    }
}
