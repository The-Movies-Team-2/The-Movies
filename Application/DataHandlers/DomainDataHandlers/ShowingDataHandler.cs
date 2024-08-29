using ApplicationLayer.Repositories;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace ApplicationLayer.DataHandlers.DomainDataHandlers
{
    internal class ShowingDataHandler: AbstractDataHandler<ShowingRepository>
    {
        private static string _filePath = @"C:\\TheMovies\\Showings.txt";

        private readonly List<Showing> _movies = new List<Showing>();

        private readonly ShowingRepository _repository = new ShowingRepository();
        private readonly TheaterRepository _theaterRepository = new TheaterRepository();
        private readonly MovieRepository _movieRepository = new MovieRepository();
     
        internal override ShowingRepository Read()
        {
            CheckIfFileExists(_filePath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            //lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                int id = int.Parse(values[0]);
                Movie movie = GetMovieForShowing(int.Parse(values[1]));
                Theater theater = GetTheaterForShowing(int.Parse(values[2]));
                DateOnly theaterDate = DateOnly.Parse(values[3]);
                TimeOnly theaterTime = TimeOnly.Parse(values[4]);
               
                Showing showing = new Showing(id,movie,theater,theaterDate,theaterTime);
                _repository.Add(showing);
            }
            return _repository;
        }

        private Movie GetMovieForShowing(int id)
        {
            Movie movie = _movieRepository.GetById(id);
            return movie != null ? movie : new Movie("ukendt", 100, new List<Genre>(), "ukendt");
        }
        private Theater GetTheaterForShowing(int id)
        {
            return _theaterRepository.GetById(id);
        }

        internal override void Write(ShowingRepository repository)
        {
            CheckIfFileExists(_filePath);

            List<Showing> lines = repository.GetAll().ToList();
            foreach (Showing showing in lines)
            {
                var createText = $"{showing.Id};{showing.Movie.Id};{showing.Theater.Id};{showing.Date};{showing.StartTime}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
            }
        }
    }
}
