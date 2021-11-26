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
using AirBNB.Viewmodels;
using AirBNB.Classes;

namespace AirBNB.views
{
    /// <summary>
    /// Interaction logic for LandlordsView.xaml
    /// </summary>
    public partial class LandlordsView : UserControl
    {
        public LandlordsView()
        {
            InitializeComponent();
            DataContext = new LandlordsViewModel();
        }

        private void View_Landlord_Click(object sender, RoutedEventArgs e)
        {
            TheHiddenViewer.Visibility = Visibility.Visible;
        }
    }
}
