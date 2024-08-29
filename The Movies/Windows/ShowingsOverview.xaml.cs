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
using The_Movies.Commands;
using The_Movies.Viewmodel;
using The_Movies.Windows;

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for ShowingsOverview.xaml
    /// </summary>
    public partial class ShowingsOverview : Window
    {
        ShowingsViewmodel SVM = new ShowingsViewmodel();
        public ShowingsOverview()
        {
            InitializeComponent();
            DataContext = SVM;

            // Bind SaveButton Click event (for each button if necessary)
            HjermButton.Click += OnSortButtonClick;
            VidebaekButton.Click += OnSortButtonClick;
            ThorsmindeButton.Click += OnSortButtonClick;
            RaehrButton.Click += OnSortButtonClick;
            AlleButton.Click += OnSortButtonClick;
        }

        private void OnSortButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                SortListCommandParameters commandParameters = new SortListCommandParameters
                {
                    showingsViewmodel = SVM,
                    Content = button.Content.ToString()
                };

                button.CommandParameter = commandParameters;
            }
        }
    
        private void Close_overview(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Open_Create_Showing(object sender, RoutedEventArgs e)
        {
            CreateShowingWindow CSW = new CreateShowingWindow();
            CSW.ShowDialog();
        }
    }
}
