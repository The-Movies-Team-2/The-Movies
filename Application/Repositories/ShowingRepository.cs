using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Repositories
{
    public class ShowingRepository
    {
        private List<Showing> showings = new List<Showing>();

        public void Add(Showing Showing)
        {
            int maxId = 0;
            if (showings.Count > 0) maxId = showings.Max(h => h.Id);
            Showing.Id = maxId + 1;
            showings.Add(Showing);
        }
        public Showing GetById(int id)
        {
            return showings.FirstOrDefault(g => g.Id == id);
        }
        public List<Showing> GetAll()
        {
            return showings;
        }
    }
}
