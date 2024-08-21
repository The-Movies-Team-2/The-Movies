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

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel dvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = dvm;
        }

        private void CreateMovie_Button_Click(object sender, RoutedEventArgs e)
        {
            CreateMovieWindow c = new CreateMovieWindow();
            c.Show();
        }

        private void ShowOverview_Button_Click(object sender, RoutedEventArgs e)
        {
            MovieOverviewWindow m = new MovieOverviewWindow();
            m.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScreeningsOverview s = new ScreeningsOverview();
            s.Show();
        }
    }
}