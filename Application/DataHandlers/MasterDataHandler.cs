using ApplicationLayer.DataHandlers.DomainDataHandlers;
using ApplicationLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.ApplicationLayer.Repositories;

namespace ApplicationLayer.DataHandlers
{
    public class MasterDataHandler
    {
        private MovieDataHandler _movieDataHandler = new MovieDataHandler();
        private GenreDataHandler _genreDataHandler = new GenreDataHandler();
        private ShowingDataHandler showingDataHandler = new ShowingDataHandler();

        internal MovieRepository MovieRepository { get; set; }
        internal ShowingRepository ShowingRepository { get; set; }

        public MasterDataHandler()
        {
            Read();
        }

        public void Read()
        {
            MovieRepository = _movieDataHandler.Read();
            
        }

        public void Write()
        {
            DirectoryInfo directory = new DirectoryInfo("C:\\TheMovies\\");
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
            _movieDataHandler.Write(MovieRepository);
        }

    }
}
