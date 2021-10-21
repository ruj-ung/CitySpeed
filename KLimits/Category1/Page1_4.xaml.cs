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

namespace KLimits
{
    /// <summary>
    /// Interaction logic for Page1_4.xaml
    /// </summary>
    public partial class Page1_4 : Page
    {
        public Page1_4()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.MainFrame.Content = mainwnd.page1_3;
        }
        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.MainFrame.Content = mainwnd.page1_5;
        }

        private void Radio1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 1;
        }
        private void Radio2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 2;
        }
        private void Radio3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 3;
        }
        private void Radio4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 4;
        }
        private void Radio5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 5;
        }
        private void Radio6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 6;
        }
        private void Radio7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.parameters.RoadFunction = 7;
        }
    }
}
