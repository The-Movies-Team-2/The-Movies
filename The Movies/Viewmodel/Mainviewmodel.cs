using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;

namespace The_Movies.Viewmodel
{
    internal class MainViewModel
    {
        List<Genre> genres { get; set; } = new List<Genre> { new Genre("drama"), new Genre("romantik") };
    }
}
