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

namespace KLimits.Category5
{
    /// <summary>
    /// Interaction logic for Page5_1.xaml
    /// </summary>
    public partial class Page5_1 : Page
    {
        public Page5_1()
        {
            InitializeComponent();
            buttonNext.Visibility = Visibility.Hidden;
            buttonBack.Visibility = Visibility.Hidden;
        }
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            //mainwnd.MainFrame.Content = mainwnd.page1_2;
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            //mainwnd.MainFrame.Content = mainwnd.page1_2;
        }
    }
}
