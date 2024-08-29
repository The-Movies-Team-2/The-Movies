using System.Windows;
using System.Windows.Input;
using The_Movies.Viewmodel;

namespace The_Movies.Commands
{
    internal class CreateMovieCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is CreateMovieCommandParameters commandParams)
            {
                MovieCreateViewModel MCVM = commandParams.MovieCreateViewModel;
                MCVM.AddMovie();
                Window createMovieWindow = commandParams.Window;
                MovieOverviewWindow ownerWindow = createMovieWindow?.Owner as MovieOverviewWindow;
                if (ownerWindow != null)
                {
                   ownerWindow.RefreshOwner();
                   createMovieWindow?.Close();
                }

            }
        }
    }
}
