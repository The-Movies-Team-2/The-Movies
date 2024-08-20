using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for MovieOverviewWindow.xaml
    /// </summary>
    public partial class MovieOverviewWindow : Window
    {
        MovieViewModel movieViewModel = new MovieViewModel();
        public MovieOverviewWindow()
        {
            InitializeComponent();
            DataContext = movieViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
