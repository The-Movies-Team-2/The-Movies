using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;

namespace The_Movies.Viewmodel
{
    internal class MainViewModel
    {
        public ObservableCollection<Genre> Genres { get; set; }
        public Genre SelectedGenre; 

       public MainViewModel()
        {
            Genres = new ObservableCollection<Genre>() { new Genre("drama"), new Genre("romantik"),new Genre("Gys"),new Genre("thriller") };
        }


    }
}
