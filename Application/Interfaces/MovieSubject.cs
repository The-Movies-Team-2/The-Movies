using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace ApplicationLayer.Interfaces
{
    public class MovieMasterList : ISubject
    {
        List<IObserver> subscribers = new List<IObserver>();
        private List<Movie> movies = new List<Movie>();

        public List<Movie> Movies
        {
            get { return movies.ToList(); }
            set
            {
                movies = value;
                Notify();
            }
        }

        public void Attach(IObserver o)
        {
            subscribers.Add(o);
        }

        public void Detach(IObserver o)
        {
            subscribers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver Datacontext in subscribers)
            {
                Datacontext.Update();
            }

        }

    }
}