﻿using ApplicationLayer.DataHandlers;
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

        private List<Movie> _movies = new List<Movie>();

        private MovieRepository _repository = new MovieRepository();
        private GenreRepository _genreRepository = new GenreRepository();


        internal override MovieRepository Read()
        {
            CheckIfFileExists(_filePath);
            CheckIfFileExists(_genreRelationPath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            //lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                var id = int.Parse(values[0]);
                var title = values[1];
                var playingTime = int.Parse(values[2]);

                var genres = GetGenresForMovie(id);
                Movie movie = new Movie(id, title, playingTime, genres);
                _repository.Add(movie);
            }
            return _repository;
        }

        private List<Genre> GetGenresForMovie(int movieId)
        {
            List<string> lines = File.ReadLines(_genreRelationPath).ToList();
            List<Genre> genres = [];
            foreach (var line in lines)
            {
                string[] values = line.Split(';');
                if (int.Parse(values[0]) == movieId)
                {
                    var genre = _genreRepository.GetAll().FirstOrDefault(g => g.Id == int.Parse(values[1]));
                    if (genre != null)
                    {
                        genres.Add(genre);
                    }
                }
            }

            return genres;
        }

        internal override void Write(MovieRepository repository)
        {
            CheckIfFileExists(_filePath);
            CheckIfFileExists(_genreRelationPath);

            List<Movie> lines = _repository.GetAll().ToList();
            foreach (Movie movie in lines)
            {
                var createText = $"{movie.Id};{movie.Title};{movie.PlayingTime}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
                foreach (var genre in movie.Genres)
                {
                    File.AppendAllText(_genreRelationPath, $"{movie.Id};{genre.Id}" + Environment.NewLine);
                }
            }
        }
    }
}
