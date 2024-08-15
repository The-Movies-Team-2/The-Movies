using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;

namespace The_Movies.Application.Viewmodel
{
    internal class Mainviewmodel
    {
        List<Genre> genres { get; set; } = new List<Genre>  {new Genre("drama"), new Genre("romantik") };
    }
}
