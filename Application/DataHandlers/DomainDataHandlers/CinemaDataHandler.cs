using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;
using The_Movies.Model;

namespace ApplicationLayer.DataHandlers.DomainDataHandlers
{
    internal class CinemaDataHandler //**: AbstractDataHandler<MovieRepository> ??
    {
        private static string _filePath = @"C:\\TheMovies\\Cinemas.txt";
        private static string _cinemaHallRelationPath = @"C:\\TheMovies\\CinemaHall.txt"; //**skal denne være her?

        private List<Cinema> _cinemas = new List<Cinema>();

        private CinemaRepository _repository = new CinemaRepository();
        private CinemaHallsReps _cinemaHallsReps = new CinemaHallsReps();


    }
}
