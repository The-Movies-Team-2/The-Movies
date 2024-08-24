using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using The_Movies.Commands;
using The_Movies.Viewmodel;

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for CreateMovieWindow.xaml
    /// </summary>
    public partial class CreateMovieWindow : Window
    {
        MovieCreateViewModel _viewModel = new MovieCreateViewModel();
        public CreateMovieWindow()
        {
            InitializeComponent();
            _viewModel = new MovieCreateViewModel();
            DataContext = _viewModel;

            // Set up the command parameter in code-behind
            var commandParameters = new CreateMovieCommandParameters
            {
                MovieCreateViewModel = _viewModel,
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

        private void AddGenreComboBoX(object sender, RoutedEventArgs e)
        {
            ComboBox genreComboBox = new ComboBox();
            genreComboBox.Width = 100;

            // Opret ItemsSource binding til Genres
            Binding itemsSourceBinding = new Binding("AvailableGenres");
            genreComboBox.SetBinding(ComboBox.ItemsSourceProperty, itemsSourceBinding);

            // Sæt DisplayMemberPath
            genreComboBox.DisplayMemberPath = "Name";

            // Find indekset for den nye ComboBox
            int index = _viewModel.SelectedGenres.Count;

            // Sørg for, at listen er lang nok
            if (index >= _viewModel.SelectedGenres.Count)
            {
                _viewModel.SelectedGenres.Add(null);  // Tilføj en ny post til listen
            }

            // Opret SelectedItem binding til den korrekte indeks i SelectedGenres
            Binding selectedItemBinding = new Binding($"SelectedGenres[{index}]")
            {
                Mode = BindingMode.TwoWay
            };
            genreComboBox.SetBinding(ComboBox.SelectedItemProperty, selectedItemBinding);

            // Tilføj ComboBox til StackPanel
            GenreComboboxes.Children.Add(genreComboBox);
        }
    }
}
