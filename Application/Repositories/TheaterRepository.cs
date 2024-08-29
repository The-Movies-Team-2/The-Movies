using DomainModel;
using The_Movies.DomainModel;
using The_Movies.Model;
namespace ApplicationLayer.Repositories
{
    internal class TheaterRepository
    {
        public readonly List<Showing> Showings = new List<Showing>();

        public List<Showing> GetShowing()
        {
            return Showings;
        }

        public Showing CreateShowing(int id, Movie movie, Cinema cinema, Theater theater, DateTime startTime, DateTime endTime)
        {
            Showing showing = new Showing(id, movie, cinema, theater, startTime, endTime);
            Showings.Add(showing);
            return showing; 

        }

        public void RemoveShowing(Showing showing)
        {
            if (Showings.Contains(showing)) {
                Showings.Remove(showing);
            }
        }

    }
}
