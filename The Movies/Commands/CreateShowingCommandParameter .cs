using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using The_Movies.Viewmodel;

namespace The_Movies.Commands
{
    internal class CreateShowingCommandParameter
    {
        public ShowingCreateViewModel ShowingCreateViewModel { get; set; }
        public Window? Window { get; set; }
    }
}
