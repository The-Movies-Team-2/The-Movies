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
                ReservationCreateViewModel viewModel = commandParams.ReservationCreateViewModel;
                // Kontroller om der er tilstrækkelige pladser før oprettelse af reservation
                if (viewModel.CheckIfThereIsEnoughSeats())
                {
                    // Opret reservationen
                    viewModel.Add();

                    // Opdater ejerne af vinduet, hvis det er relevant
                    Window createReservationWindow = commandParams.Window;
                    ReservationOverviewWindow ownerWindow = createReservationWindow?.Owner as ReservationOverviewWindow;
                    if (ownerWindow != null)
                    {
                        ownerWindow.RefreshOwner();
                        createReservationWindow?.Close();
                    }
                }
                else
                {
                    // Informer brugeren om, at der ikke er nok pladser
                    MessageBox.Show("Der er ikke nok pladser til rådighed.");
                }
            }
        }
    }



}

