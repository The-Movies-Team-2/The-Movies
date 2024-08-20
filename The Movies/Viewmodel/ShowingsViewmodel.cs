using ApplicationLayer.Controllers;
using DomainModel;
using System.Collections.ObjectModel;
using The_Movies.ApplicationLayer.Controllers;

namespace The_Movies.Viewmodel
{
    internal class ShowingsViewmodel
    {
        ObservableCollection<Showing> Showings {  get; set; }
   
        public ShowingController showingsController = new ShowingController();

        public ShowingsViewmodel() 
        {
            Showings = new ObservableCollection<Showing>();
            LoadShowings();
        }

        private void LoadShowings()
        {

            List<Showing> TempShowings = showingsController.GetAll(); //TODO 

            foreach (Showing showing in TempShowings)
            {
                Showings.Add(showing);
            }
            
        }


    }
}
