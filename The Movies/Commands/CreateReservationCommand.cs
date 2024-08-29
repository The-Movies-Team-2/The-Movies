using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using The_Movies.Viewmodel;
using The_Movies.Windows;

namespace The_Movies.Commands
{
    internal class CreateReservationCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is CreateReservationCommandParameter commandParams)
            {
                ReservationCreateViewModel MCVM = commandParams.ReservationCreateViewModel;
                MCVM.Add();
                Window createReservationWindow = commandParams.Window;
                ReservationOverviewWindow ownerWindow = createReservationWindow?.Owner as ReservationOverviewWindow;
                if (ownerWindow != null)
                {
                    ownerWindow.RefreshOwner();
                    createReservationWindow?.Close();
                }

            }
            if (parameter is ReservationCreateViewModel viewModel) 
            {
                viewModel.Add();
            }
        }
    }
}
