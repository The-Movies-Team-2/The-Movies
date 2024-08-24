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
using The_Movies.Viewmodel;

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for CreateMovieWindow.xaml
    /// </summary>
    public partial class CreateMovieWindow : Window
    {
        MainViewModel dvm = new MainViewModel();
        public CreateMovieWindow()
        {
            InitializeComponent();
            DataContext = dvm;
        }

        private void AllowOnlyNumbersInTextBox(object sender, TextCompositionEventArgs e)
        {
            //regular expression(regex) genkender mønstrer og sørger for der kun kan indtastes tal i textboksen
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
            int index = dvm.SelectedGenres.Count;

            // Sørg for, at listen er lang nok
            if (index >= dvm.SelectedGenres.Count)
            {
                dvm.SelectedGenres.Add(null);  // Tilføj en ny post til listen
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
