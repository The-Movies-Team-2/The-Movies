using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;

namespace The_Movies.Applikation
{
    internal class GenreDataHandler
    {
        private string _filePath = @"C:\\TheMovies\\Genres.txt";
        private GenreRepository _repository = new GenreRepository();

        //læser fra tekstfiler
        public void Read()
        {
            CheckIfFileExists(_filePath);
            List<string> lines = File.ReadLines(_filePath).ToList();
            
            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                string name = values[0];
                int id = int.Parse(values[1]);
                
                Genre genre = new Genre(name);
                
                _repository.Add(genre);
            }
        }

        //skriver til tekstfiler
        public void Write()
        {
            CheckIfFileExists(_filePath);

            List<Genre> lines = _repository.GetAll().ToList();
            foreach (Genre genre in lines)
            {
                
                string createText = $"{genre.Name},{genre.Id}";
                File.AppendAllText(_filePath, createText + Environment.NewLine);
            }

        }

        //tjek om fil eksisterer 
        public void CheckIfFileExists(string fullPath)
        {
            if (!File.Exists(fullPath))
            {
                FileStream fs = File.Create(fullPath);
                fs.Close();
            }
        }

    }
}
