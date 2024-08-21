using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Repositories
{
    internal class ShowingRepository
    {
        private List<Showing> Showings = new List<Showing>();

        public void Add(Showing Showing)
        {
            int maxId = 0;
            if (Showings.Count > 0) maxId = Showings.Max(h => h.Id);
            Showing.Id = maxId + 1;
            Showings.Add(Showing);
        }
        public List<Showing> GetAll()
        {
            return Showings;
        }
    }
}
