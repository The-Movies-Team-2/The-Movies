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

        private void Show_MoviesOverview(object sender, RoutedEventArgs e)
        {
            MovieOverviewWindow SMW = new MovieOverviewWindow();
            SMW.ShowDialog();
        }

        private void Show_ShowingsOverview(object sender, RoutedEventArgs e)
        {
            ShowingsOverview SSW = new ShowingsOverview();
            SSW.ShowDialog();
        }
        private void Show_ReservationsOverview(object sender, RoutedEventArgs e)
        {
            ReservationOverviewWindow SRW = new ReservationOverviewWindow();
            SRW.ShowDialog();
        }

        private void Open_Create_Reservation(object sender, RoutedEventArgs e)
        {
            CreateReservationWindow CRW = new CreateReservationWindow();
            CRW.ShowDialog();
        }

        private void Open_Create_Showing(object sender, RoutedEventArgs e)
        {
            CreateShowingWindow CSW = new CreateShowingWindow();
            CSW.ShowDialog();
        }
    }
}