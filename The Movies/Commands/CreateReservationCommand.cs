﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using The_Movies.Viewmodel;

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
            if (parameter is ReservationCreateViewModel viewModel) 
            {
                viewModel.Add();
            }
        }
    }
}
