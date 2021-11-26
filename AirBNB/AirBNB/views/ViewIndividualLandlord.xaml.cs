﻿using System;
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

namespace AirBNB.views
{
    /// <summary>
    /// Interaction logic for ViewIndividualLandlord.xaml
    /// </summary>
    public partial class ViewIndividualLandlord : UserControl
    {
        public ViewIndividualLandlord()
        {
            InitializeComponent();
            DataContext = new LandlordsViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TheHiddenViewer.Visibility = Visibility.Hidden;
        }
    }
}
