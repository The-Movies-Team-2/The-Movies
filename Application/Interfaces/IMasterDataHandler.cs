using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;

namespace ApplicationLayer.Interfaces
{
    public interface IMasterDataHandler
    {

        public MovieRepository MovieRepository { get; set; }

        public ShowingRepository ShowingRepository { get; set; }

        public CinemaRepository CinemaRepository { get; set; }
        public void Write();

    }
}
