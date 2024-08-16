using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DataHandlers;
using The_Movies.Model;
using The_Movies.Repositories;

namespace The_Movies.Controllers
{
    internal class MovieController
    {
        private readonly MovieRepository repository;
        private readonly MovieDataHandler dataHandler;
        public MovieController() 
        { 
            repository = new MovieRepository();
            dataHandler = new MovieDataHandler();
        }
        public virtual void Add(Movie movie)
        {
            repository.Add(movie);
            dataHandler.Write();
        }
    }
}
