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

namespace KLimits.Category3
{
    /// <summary>
    /// Interaction logic for Page3_2.xaml
    /// </summary>
    public partial class Page3_2 : Page
    {
        public Page3_2()
        {
            InitializeComponent();
            buttonNext.Visibility = Visibility.Hidden;
        }
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.MainFrame.Content = mainwnd.page3_1;
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwnd.MainFrame.Content = mainwnd.page3_1;
        }
    }
}
