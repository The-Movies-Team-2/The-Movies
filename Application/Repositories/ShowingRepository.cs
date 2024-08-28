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

        //midlertidig
        public ShowingRepository() 
        {
            Add(new Showing(1,new Movie(70,"NOT A MOVIE",0,new List<Genre>(),"instruktør"),new Theater(30,"ukendt"), DateOnly.FromDateTime(DateTime.Now),TimeOnly.FromDateTime(DateTime.Now)));
            Add(new Showing(2,new Movie(80,"NOT A MOVIE", 0, new List<Genre>(), "instruktør"), new Theater(40,"ukendt",1), DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
        }

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
