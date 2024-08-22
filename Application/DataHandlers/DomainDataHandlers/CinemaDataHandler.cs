using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;
using The_Movies.Model;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;
using DomainModel;


namespace ApplicationLayer.DataHandlers.DomainDataHandlers
{
    internal class CinemaDataHandler : AbstractDataHandler<CinemaRepository> //**
    {
        private static string _filePath = @"C:\\TheMovies\\Cinemas.txt";
        private static string _cinemaHallRelationPath = @"C:\\TheMovies\\CinemaHalls.txt"; //**skal denne være her?

        private List<Cinema> _cinemas = new List<Cinema>();

        private CinemaRepository _repository = new CinemaRepository();
        private TheaterRepository _cinemaHallsReps = new TheaterRepository();

        internal override CinemaRepository Read()
        {
            CheckIfFileExists(_filePath);
            CheckIfFileExists(_cinemaHallRelationPath);

            List<string>lines = File.ReadLines(_filePath).ToList();

            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                int id = int.Parse(values[0]);
                int numberOfHalls = int.Parse(values[1]);
                string name = values[2];

                List<Theater> theaters = GetTheatersForCinema(id);
                Cinema cinema = new Cinema(id, name, numberOfHalls, theaters);
                _repository.Add(cinema); 
            }
            return _repository;
        }

        private List<Theater> GetTheatersForCinema(int cinemaId)
        {
            List<string> lines = File.ReadLines(_cinemaHallRelationPath).ToList();
            List<Theater> theaters = [];
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                if (int.Parse(values[0]) == cinemaId)
                {
                    Theater theater = _cinemaHallsReps.GetAll().FirstOrDefault(g => g.Id == int.Parse(values[1]));
                    if (theater != null)
                    {
                        theaters.Add(theater);
                    }
                }
            }
            return theaters;
        }

        internal override void Write(CinemaRepository repository)
        {
            CheckIfFileExists(_filePath);
            CheckIfFileExists(_cinemaHallRelationPath);

            List<Cinema> lines = _repository.GetALL().ToList();
            foreach (Cinema cinema in lines)
            {
                string createText = $"{cinema.Name};{cinema.Id};{cinema.NumberOfHalls}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
                foreach (Theater theater in cinema.Theaters)
                {
                    File.AppendAllText(_cinemaHallRelationPath, $"{cinema.Id} {theater.Id}" + Environment.NewLine);
                }
            }
        }
        

    }
}
