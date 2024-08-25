﻿using ApplicationLayer.DataHandlers.DomainDataHandlers;
using ApplicationLayer.Interfaces;
using ApplicationLayer.Repositories;
using The_Movies.ApplicationLayer.Repositories;

namespace ApplicationLayer.DataHandlers
{
    internal class MasterDataHandler: IMasterDataHandler
    {
        private MovieDataHandler _movieDataHandler = new MovieDataHandler();
        private ShowingDataHandler showingDataHandler = new ShowingDataHandler();

        public MovieRepository MovieRepository { get; set; }
        public ShowingRepository ShowingRepository { get; set; }

        public CinemaRepository CinemaRepository { get; set; }
        public TheaterRepository TheaterRepository { get; set; }


        internal MasterDataHandler()
        {
            Read();
            TheaterRepository = new TheaterRepository();
            CinemaRepository = new CinemaRepository(this);
            
        }

        internal void Read()
        {
            MovieRepository = _movieDataHandler.Read();
            ShowingRepository = showingDataHandler.Read();
            //ShowingRepository = showingDataHandler.Read(); //TODO 
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
