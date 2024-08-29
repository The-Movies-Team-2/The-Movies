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

namespace The_Movies.Windows
{
    /// <summary>
    /// Interaction logic for CreateShowing.xaml
    /// </summary>
    public partial class CreateShowingWindow : Window
    {
        public CreateShowingWindow()
        {
            InitializeComponent();
            ShowingCreateViewModel _viewModel = new ShowingCreateViewModel();
            DataContext = _viewModel;

        }

        
    }
}
