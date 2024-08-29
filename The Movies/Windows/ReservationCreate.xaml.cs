using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using The_Movies.Commands;
using The_Movies.Viewmodel;

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for ShowingsOverview.xaml
    /// </summary>
    public partial class CreateReservationWindow: Window
    {
        ReservationCreateViewModel viewModel = new ReservationCreateViewModel();
        public CreateReservationWindow()
        {
            InitializeComponent(); 
            DataContext = viewModel;

            // Set up the command parameter in code-behind
            CreateReservationCommandParameter commandParameters = new CreateReservationCommandParameter
            {
                ReservationCreateViewModel = viewModel,
                Window = this
            };
            SaveButton.CommandParameter = commandParameters;
        }

        private void AllowOnlyNumbersInTextBox(object sender, TextCompositionEventArgs e)
        {
            //regular expression(regex) genkender mønstrer og sørger for der kun kan indtastes tal i textboksen
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
