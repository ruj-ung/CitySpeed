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
    /// Interaction logic for Page1_9.xaml
    /// </summary>
    public partial class Page1_9 : Page
    {
        public Page1_9()
        {
            InitializeComponent();
            buttonNext.Visibility = Visibility.Hidden;
        }
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.MainFrame.Content = mainwnd.page1_5;
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.MainFrame.Content = mainwnd.page1_7;
        }
    }
}
