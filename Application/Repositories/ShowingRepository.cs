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
            Add(new Showing(1,new Movie(70,"NOT A MOVIE",0,new List<Genre>(),"instruktør"),new Theater(30,"ukendt"), DateOnly.FromDateTime(DateTime.Now),TimeOnly.FromDateTime(DateTime.Now)));
            Add(new Showing(2,new Movie(80,"NOT A MOVIE", 0, new List<Genre>(), "instruktør"), new Theater(40,"ukendt",1), DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
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
