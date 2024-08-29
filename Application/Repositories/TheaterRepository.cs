using DomainModel;
using The_Movies.DomainModel;
namespace ApplicationLayer.Repositories
{
    public class TheaterRepository
    {
        private readonly List<Theater> _theaters = new List<Theater>();


        public TheaterRepository()
        {
            Add(new Theater(0, "Testsal", 0,2));  // TestBiograf
            Add(new Theater(1, "Main Hall", 1,100));  // Hjerm Biograf
            Add(new Theater(2, "Cozy Corner", 1,50));  // Hjerm Biograf
            Add(new Theater(3, "Hjerm Lounge", 1,200));  // Hjerm Biograf
            Add(new Theater(4, "Central Screen", 2, 200));  // Videbæk Biograf
            Add(new Theater(5, "Videbæk Balcony", 2,45));  // Videbæk Biograf
            Add(new Theater(6, "Ocean View", 3,54));  // Thorsminde Biograf
            Add(new Theater(7, "Sunset Hall", 3,30));  // Thorsminde Biograf
            Add(new Theater(8, "Ræhr Prime", 4,100));  // Ræhr Biograf
            Add(new Theater(9, "Ræhr Studio", 4, 20));  // Ræhr Biograf
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
