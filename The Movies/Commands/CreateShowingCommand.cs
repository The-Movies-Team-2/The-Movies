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
    internal class CreateShowingCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
              if (parameter is CreateShowingCommandParameter commandParams)
                {
                    ShowingCreateViewModel MCVM = commandParams.ShowingCreateViewModel;
                    MCVM.AddShowing();
                    Window createShowingWindow = commandParams.Window;

                    ShowingsOverview ownerWindow = createShowingWindow?.Owner as ShowingsOverview;
                    if (ownerWindow != null)
                    {
                        ownerWindow.RefreshOwner();
                        createShowingWindow?.Close();
                    }

                }
            }
        }
}
