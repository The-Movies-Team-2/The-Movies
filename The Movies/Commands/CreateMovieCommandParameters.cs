using System.Windows;
using The_Movies.Viewmodel;

namespace The_Movies.Commands
{
    public class CreateMovieCommandParameters
    {
        public MovieCreateViewModel MovieCreateViewModel { get; set; }
        public Window? Window { get; set; }
    }
}
