using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using The_Movies.Viewmodel;
using The_Movies.Windows;

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateMovie_Button_Click(object sender, RoutedEventArgs e)
        {
            CreateMovieWindow c = new CreateMovieWindow();
            c.ShowDialog();
        }

        private void Show_MoviesOverview(object sender, RoutedEventArgs e)
        {
            MovieOverviewWindow m = new MovieOverviewWindow();
            m.ShowDialog();
        }

        private void Show_Showings(object sender, RoutedEventArgs e)
        {
            ShowingsOverview s = new ShowingsOverview();
            s.ShowDialog();
        }

        private void Open_Create_Reservation(object sender, RoutedEventArgs e)
        {
            CreateReservationWindow CRVM = new CreateReservationWindow();
            CRVM.ShowDialog();

        }

        private void Open_Create_Showing(object sender, RoutedEventArgs e)
        {
            CreateShowingWindow c = new CreateShowingWindow();
            c.ShowDialog();
        }
    }
}