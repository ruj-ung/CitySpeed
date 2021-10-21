using KLimits.Model;
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
    /// Interaction logic for PrintPreView.xaml
    /// </summary>
    public partial class PrintPreView : Page
    {

        public PrintPreView()
        {
            InitializeComponent();
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            this.ResultSpeed.Text = mainwnd.result.ResultSpeed.Text;
            placeImage.Source = mainwnd.page1_1.placeImage.Source;
            mapImage.Source = mainwnd.page1_1.mapImage.Source;

            RoadInformation roadInformation = (RoadInformation)mainwnd.page1_1.DataContext;
            roadname.Text = roadInformation.RoadName;
            location.Text = roadInformation.Location;
            place.Text = roadInformation.Suburb;
            localGov.Text = roadInformation.LocalGovernment;
            userRef.Text = roadInformation.Userreference;

            RoadCharacteristics roadCharacteristics = (RoadCharacteristics)mainwnd.page1_2.DataContext;
            sectionLenth.Text = roadCharacteristics.SectionLength.ToString()+" km";
            aadt.Text = roadCharacteristics.AADT.ToString() + " vpd";
            existSpeed.Text = roadCharacteristics.ExistingSpeed.ToString() + " km/h";
            _85Speed.Text = roadCharacteristics.Speed85.ToString() + " km/h";


            roadfunction.Text = roadfuncDictionary[mainwnd.inputs[3]];
            divided.Text = undividedDictionary[mainwnd.inputs[2]];
            if (mainwnd.inputs[0] != "5")
                roadfrequency.Text = freqquencyDictionary1[mainwnd.inputs[1]];
            else
                roadfrequency.Text = freqquencyDictionary2[mainwnd.inputs[1]];
            devType.Text = developtypeDictionary[mainwnd.inputs[0]];
            accessrestric.Text = accessDictionary[mainwnd.inputs[5]];
            pedestrians.Text = pedestrianDictionary[mainwnd.inputs[6]];
            medianwidth.Text = medianwidthDictionary[mainwnd.inputs[7]];
            protectionRightTurn.Text = protectrightDictionary[mainwnd.inputs[8]];
        }

        Dictionary<string, string> protectrightDictionary = new Dictionary<string, string>
        {
            { "1", "Full" },
            { "2", "Partially or not at all" },

        }; Dictionary<string, string> medianwidthDictionary = new Dictionary<string, string>
        {
            { "1", "< 4.5" },
            { "2", ">= 4.5" },
        };

        Dictionary<string, string> pedestrianDictionary = new Dictionary<string, string>
        {
            { "1", "Neither" },
            { "2", "High pedestrian and/or cyclist activity/crashes" },
        };
        
        Dictionary<string, string> accessDictionary = new Dictionary<string, string>
        {
            { "1", "Restrictions to both sides" },
            { "2", "Restrictions to one side only" },
            { "3", "None" },
        };
        
        Dictionary<string, string> developtypeDictionary = new Dictionary<string, string>
        {
            { "1", "Fully built-up" },
            { "2", "Partially built-up" },
            { "3", "Sparsely built-up" },
            { "4", "Hamlet" },
            { "5", "Rural" },
        };
        Dictionary<string, string> freqquencyDictionary1 = new Dictionary<string, string>
        {
            { "1", "< 2" },
            { "2", "2 < 4" },
            { "3", "> 4" },
        };
        Dictionary<string, string> freqquencyDictionary2 = new Dictionary<string, string>
        {
            { "1", "< 1" },
            { "2", "1 < 2.5" },
            { "3", "> 2.5" },
        };

        Dictionary<string, string> undividedDictionary = new Dictionary<string, string>
        {
            { "1", "Undivided" },
            { "2", "Divided" },
        }; 
        Dictionary<string, string> roadfuncDictionary = new Dictionary<string, string>
        {
            { "1", "Freeway" },
            { "2", "Arterial/ Major Road" },
            { "3", "Collector" },
            { "4", "Local Access" },
            { "5", "Rural Local" },
            { "6", "Car park" },
            { "7", "Shared zone" },
        };

        private void buttonPrint_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = (MainWindow)System.Windows.Application.Current.MainWindow;
            //this.ResultSpeed =  mainwnd.result.ResultSpeed;
            scroller.ScrollToHome();
            Print(printArea);
            return;
            var printDlg = new PrintDialog();

           try
            {
                this.IsEnabled = false;
                if (printDlg.ShowDialog() == true)
                {
                    //get selected printer capabilities

                    System.Printing.PrintCapabilities capabilities = printDlg.PrintQueue.GetPrintCapabilities(printDlg.PrintTicket);



                    //get scale of the print wrt to screen of WPF visual

                    double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / printArea.ActualWidth, capabilities.PageImageableArea.ExtentHeight /

                                   printArea.ActualHeight);



                    //Transform the Visual to scale

                    printArea.LayoutTransform = new ScaleTransform(scale, scale);



                    //get the size of the printer page

                    Size sz = new Size(850, 1100);//Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);



                    //update the layout of the visual to the printer page size.

                    printArea.Measure(sz);

                    printArea.Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz)); 
                    printDlg.PrintVisual(printArea, "sadlksa");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
        private void Print(Visual v)
        {

            System.Windows.FrameworkElement e = v as System.Windows.FrameworkElement;
            if (e == null)
                return;

            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                //store original scale
                Transform originalScale = e.LayoutTransform;
                //get selected printer capabilities
                System.Printing.PrintCapabilities capabilities = pd.PrintQueue.GetPrintCapabilities(pd.PrintTicket);

                //get scale of the print wrt to screen of WPF visual
                double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / e.ActualWidth, capabilities.PageImageableArea.ExtentHeight /
                               e.ActualHeight);

                //Transform the Visual to scale
                e.LayoutTransform = new ScaleTransform(scale, scale);

                //get the size of the printer page
                System.Windows.Size sz = new System.Windows.Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);

                //update the layout of the visual to the printer page size.
                e.Measure(sz);
                e.Arrange(new System.Windows.Rect(new System.Windows.Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz));

                //now print the visual to printer to fit on the one page.
                pd.PrintVisual(v, "My Print");

                //apply the original transform.
                e.LayoutTransform = originalScale;
            }
        }
    }
}
