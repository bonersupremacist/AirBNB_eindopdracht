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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AirBNB.Classes;
using AirBNB.Viewmodels;

namespace AirBNB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new HomeViewModel();
        }

        private void Home_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new HomeViewModel();
        }
        private void LandlordOverview_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new LandlordsViewModel();
        }

        private void LocationOverview_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new LocationViewModel();
        }

    }
}
