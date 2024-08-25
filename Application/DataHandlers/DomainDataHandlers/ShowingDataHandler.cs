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
     
        internal override ShowingRepository Read()
        {
            CheckIfFileExists(_filePath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            //lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                string title = values[0];
               
                Showing showing = new Showing(title);
                _repository.Add(showing);
            }
            return _repository;
        }

        internal override void Write(ShowingRepository repository)
        {
            CheckIfFileExists(_filePath);

            List<Showing> lines = _repository.GetAll().ToList();
            foreach (Showing showing in lines)
            {
                var createText = $"{showing.Name}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
            }
        }
    }
}
