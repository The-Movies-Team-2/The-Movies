using DomainModel;
using The_Movies.DomainModel;
namespace ApplicationLayer.Repositories
{
    internal class CinemaHallsReps
    {
        private readonly List<Movie> Movies = new List<Movie>();
        //Add time slots: list<slots>?
        private readonly List<Theater> _theaters = new List<Theater>();
        

        public List<Theater> GetAll()
        {
            return _theaters.OrderBy(g => g.Name).ToList();
        }
    }
}
