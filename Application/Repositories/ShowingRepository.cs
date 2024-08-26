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
        private List<Showing> Showings = new List<Showing>();

        //midlertidig
        public ShowingRepository() 
        {
            Add(new Showing(1,"TestForestilling",new Movie("NOT A MOVIE",0,new List<Genre>(),"instruktør"),new Theater("ukendt"),DateTime.Now));
            Add(new Showing(2,"TestForestilling2",new Movie("NOT A MOVIE", 0, new List<Genre>(), "instruktør"), new Theater(40,"ukendt",1), DateTime.Now));
        }

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
