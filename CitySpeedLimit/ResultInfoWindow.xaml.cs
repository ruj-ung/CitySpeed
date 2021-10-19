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

namespace CitySpeedLimit
{
    /// <summary>
    /// Interaction logic for ResultInfoWindow.xaml
    /// </summary>
    public partial class ResultInfoWindow : Window
    {
        public Model.Utils modelview;
        public int[,] rMatrix;
        public ResultInfoWindow()
        {
            modelview = new Model.Utils();
            rMatrix = new int[3,3] {
                {20, 20, 25},
                {20, 25, 30},
                {25, 30, 35}
                                    };
            DataContext = modelview;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
