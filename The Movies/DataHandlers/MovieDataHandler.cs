using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;
using The_Movies.Repositories;

namespace The_Movies.DataHandlers
{
    internal class MovieDataHandler
    {
        private static string _filePath = @"C:\\TheMovies\\Movies.txt";
        private MovieRepository _repository = new MovieRepository();

        //læser fra tekstfiler
        public void Read()
        {
            CheckIfFileExists(_filePath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            //lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');

                //match kolonner med udleveret csv fil!!
                string title = values[3];

                string[] strings = values[4].Split(",");
                List<int> genreids = new List<int>();
                //konverter strings til int og put dem i genreidlisten 
                foreach (string s in strings)
                {
                    genreids.Add(int.Parse(s));
                }

                int playingTime = int.Parse(values[5]);
                int id = int.Parse(values[10]);

                Movie movie = new Movie(title, id, playingTime, genreids);
                _repository.Add(movie);
            }
        }

        //skriver til tekstfiler
        public void Write()
        {
            CheckIfFileExists(_filePath);

            List<Movie> lines = _repository.GetAll().ToList();
            foreach (Movie movie in lines)
            {
                //Console.OutputEncoding = Encoding.UTF8;
                string createText = $"ukendt biograf;ukendt by;Forestillingstidspunkt;{movie.Title};{movie.GenreIds};{movie.PlayingTime};Filminstruktør;Premieredato;Bookingmail;Bookingtelefonnummer;{movie.Id}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
            }

        }

        //tjek om fil eksisterer 
        public void CheckIfFileExists(string fullPath)
        {

            string directory = Path.GetDirectoryName(fullPath);

            // Tjek og opret mappen hvis den ikke findes
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(fullPath))
            {
                FileStream fs = File.Create(fullPath);
                fs.Close();
            }
        }
    }
}
