using ApplicationLayer.DataHandlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;

namespace ApplicationLayer.DataHandlers.DomainDataHandlers
{
    internal class MovieDataHandler : AbstractDataHandler<MovieRepository>
    {
        private static string _filePath = @"C:\\TheMovies\\Movies.txt";
        private static string _genreRelationPath = @"C:\\TheMovies\\MovieGenre.txt";

        private readonly List<Movie> _movies = new List<Movie>();

        private readonly MovieRepository _repository = new MovieRepository();
        private readonly GenreRepository _genreRepository = new GenreRepository();


        internal MovieRepository Read()
        {
            CheckIfFileExists(_filePath);
            CheckIfFileExists(_genreRelationPath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            //lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                int id = int.Parse(values[0]);
                string title = DecryptString(values[1]);
                int playingTime = int.Parse(values[2]);
                string director = values[3];

                List<Genre> genres = GetGenresForMovie(id);
                Movie movie = new Movie(id, title, playingTime, genres, director);
                _repository.Add(movie);
            }
            return _repository;
        }

        private List<Genre> GetGenresForMovie(int movieId)
        {
            List<string> lines = File.ReadLines(_genreRelationPath).ToList();
            List<Genre> genres = [];
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                if (int.Parse(values[0]) == movieId)
                {
                    Genre genre = _genreRepository.GetAll().FirstOrDefault(g => g.Id == int.Parse(values[1]));
                    if (genre != null)
                    {
                        genres.Add(genre);
                    }
                }
            }

            return genres;
        }

        internal void Write(MovieRepository repository)
        {
            CheckIfFileExists(_filePath);
            CheckIfFileExists(_genreRelationPath);

            List<Movie> lines = _repository.GetAll().ToList();
            foreach (Movie movie in lines)
            {
                string encryptedTitle = EncryptString(movie.Title);

                string createText = $"{movie.Id};{encryptedTitle};{movie.Duration};{movie.Director}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
                foreach (Genre genre in movie.Genres)
                {
                    File.AppendAllText(_genreRelationPath, $"{movie.Id};{genre.Id}" + Environment.NewLine);
                }
            }
        }
    }
}
