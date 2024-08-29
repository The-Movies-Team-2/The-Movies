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

namespace The_Movies.Windows
{
    /// <summary>
    /// Interaction logic for ReservationOverviewWindow.xaml
    /// </summary>
    public partial class ReservationOverviewWindow : Window
    {
        public ReservationOverviewWindow()
        {
            InitializeComponent();
            ReservationOverviewViewModel viewModel = new ReservationOverviewViewModel();
            DataContext = viewModel;
        }
        private void Open_Create_Reservation(object sender, RoutedEventArgs e)
        {
            CreateReservationWindow CRW = new CreateReservationWindow();
            CRW.ShowDialog();
        }

        private void Close_Overview(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void RefreshOwner()
        {
            InitializeComponent();
            ReservationOverviewViewModel showingsViewmodel = new ReservationOverviewViewModel();
            DataContext = showingsViewmodel;
        }
    }
}
