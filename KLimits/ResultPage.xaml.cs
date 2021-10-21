using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
            buttonBack.Visibility = Visibility.Hidden;
            //buttonNext.Visibility = Visibility.Hidden;
        }
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            //mainwnd.MainFrame.Content = mainwnd.page6_2;
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            //mainwnd.MainFrame.Content = mainwnd.page6_2;
        }

        private void buttonReport_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            PrintPreView p = new PrintPreView();
            mainwnd.MainFrame.Content = p; //new PrintPreView();
            /*
            var pd = new PrintDialog();

            // calculate page size  
            var sz = new Size(pd.PrintableAreaWidth, pd.PrintableAreaHeight);

            FlowDocument doc = new FlowDocument(new Paragraph(new Run("Suggested Speed = "+ResultSpeed.Text + " km/h")));

            doc.Name = "FlowDoc";
            // Create IDocumentPaginatorSource from FlowDocument  

            IDocumentPaginatorSource idpSource = doc;

            try
            {
                this.IsEnabled = false;
                if (pd.ShowDialog() == true)
                {
                    //pd.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing."); 
                    pd.PrintVisual(print, "sadlksa");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
            */
        }
    }
}
