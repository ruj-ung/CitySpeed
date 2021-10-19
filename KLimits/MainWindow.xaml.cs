using KLimits.Category2;
using KLimits.Category3;
using KLimits.Category4;
using KLimits.Category5;
using KLimits.Category6;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1_1 page1_1;
        public Page1_2 page1_2;
        public Page1_3 page1_3;
        public Page1_4 page1_4;
        public Page1_5 page1_5;
        public Page1_6 page1_6;
        public Page1_7 page1_7;
        public Page1_8 page1_8;
        public Page1_9 page1_9;

        public Page2_1 page2_1;
        public Page2_2 page2_2;
        public Page2_3 page2_3;
        public Page2_4 page2_4;

        public Page3_1 page3_1;
        public Page3_2 page3_2;
        public Page4_1 page4_1;
        public Page5_1 page5_1;
        public Page6_1 page6_1;
        public Page6_2 page6_2;
        public ResultPage result;
        string[] inputs = new string[] { "2", "3", "2", "6", "0", "1", "1", "1", "1" };
        //string[] inputs = new string[] { "5", "2", "2", "2", "0", "0", "0", "0", "0" };
        public MainWindow()
        {
            InitializeComponent();
            page1_1 = new Page1_1();
            page1_2 = new Page1_2();
            page1_3 = new Page1_3();
            page1_4 = new Page1_4();
            page1_5 = new Page1_5();
            page1_6 = new Page1_6();
            page1_7 = new Page1_7();
            page1_8 = new Page1_8();
            page1_9 = new Page1_9();

            page2_1 = new Page2_1();
            page2_2 = new Page2_2();
            page2_3 = new Page2_3();
            page2_4 = new Page2_4();

            page3_1 = new Page3_1();
            page3_2 = new Page3_2();
            page4_1 = new Page4_1();
            page5_1 = new Page5_1();
            page6_1 = new Page6_1();
            page6_2 = new Page6_2();
            result = new ResultPage();


        }

        public static string CalculateSpeed(string[] input)
        {
            int DevType = int.Parse(input[0]);
            int RoadsideFreq = int.Parse(input[1]);
            int Divided = int.Parse(input[2]);
            int RoadFunc = int.Parse(input[3]);
            int FreewayCond = int.Parse(input[4]);
            int AccessRest = int.Parse(input[5]);
            int Pedestrians = int.Parse(input[6]);
            int MedianWidth = int.Parse(input[7]);
            int Protection4R = int.Parse(input[8]);
            return (DevType, RoadsideFreq, Divided, RoadFunc, FreewayCond, AccessRest, Pedestrians, MedianWidth, Protection4R) switch
            {
                (4, 1, 0, 2, 0, 0, 0, 0, 0) => "80",
                (4, 1, 0, 4, 0, 0, 0, 0, 0) => "80",
                (4, 2, 1, 2, 0, 0, 0, 0, 0) => "80",
                (4, 2, 1, 4, 0, 0, 0, 0, 0) => "80",
                (4, 2, 2, 2, 0, 0, 0, 0, 0) => "80",
                (4, 2, 2, 4, 0, 0, 0, 0, 0) => "80",
                (4, 3, 0, 0, 0, 0, 0, 0, 0) => "XX",
                (5, 1, 1, 2, 0, 0, 0, 0, 0) => "100",
                (5, 1, 1, 4, 0, 0, 0, 0, 0) => "100",
                (5, 1, 2, 1, 1, 0, 0, 0, 0) => "100",
                (5, 1, 2, 1, 2, 0, 0, 0, 0) => "100",
                (5, 1, 2, 2, 1, 0, 0, 0, 0) => "100",
                (5, 1, 2, 2, 2, 0, 0, 0, 0) => "100",
                (5, 1, 2, 4, 0, 0, 0, 0, 0) => "100",
                (5, 2, 1, 2, 0, 0, 0, 0, 0) => "100",
                (5, 2, 1, 4, 0, 0, 0, 0, 0) => "100",
                (5, 2, 2, 2, 0, 0, 0, 0, 0) => "100",
                (5, 2, 2, 4, 0, 0, 0, 0, 0) => "100",
                (5, 3, 0, 0, 0, 0, 0, 0, 0) => "XX",
                (3, 1, 1, 2, 0, 0, 0, 0, 0) => "80",
                (3, 1, 1, 3, 0, 0, 0, 0, 0) => "80",
                (3, 1, 1, 4, 0, 0, 0, 0, 0) => "80",
                (3, 1, 2, 1, 0, 0, 0, 0, 0) => "100",
                (3, 1, 2, 2, 0, 0, 0, 0, 0) => "100",
                (3, 1, 2, 3, 0, 0, 0, 0, 0) => "80",
                (3, 1, 2, 4, 0, 0, 0, 0, 0) => "80",
                (3, 2, 1, 2, 0, 0, 0, 0, 0) => "80",
                (3, 2, 1, 3, 0, 0, 0, 0, 0) => "80",
                (3, 2, 1, 4, 0, 0, 0, 0, 0) => "80",
                (3, 2, 2, 2, 0, 0, 0, 0, 0) => "100",
                (3, 2, 2, 3, 0, 0, 0, 0, 0) => "80",
                (3, 2, 2, 4, 0, 0, 0, 0, 0) => "80",
                (3, 3, 0, 0, 0, 0, 0, 0, 0) => "XX",
                _ => "XX"//throw new ArgumentException("")
            };
        }
        public static string CalculateSpeed1(string[] input)
        {
            int DevType = int.Parse(input[0]);
            int RoadsideFreq = int.Parse(input[1]);
            int Divided = int.Parse(input[2]);
            int RoadFunc = int.Parse(input[3]);
            int FreewayCond = int.Parse(input[4]);
            int AccessRest = int.Parse(input[5]);
            int Pedestrians = int.Parse(input[6]);
            int MedianWidth = int.Parse(input[7]);
            int Protection4R = int.Parse(input[8]);
            return (DevType, RoadsideFreq, Divided, RoadFunc, FreewayCond, AccessRest, Pedestrians, MedianWidth, Protection4R) switch
            {
                (1, 1, 1, 2, 0, 0, 0, 0, 0) => "60",
                (1, 1, 1, 3, 0, 0, 0, 0, 0) => "50",
                (1, 1, 1, 4, 0, 0, 0, 0, 0) => "50",
                (1, 1, 1, 6, 0, 0, 0, 0, 0) => "20",
                (1, 1, 1, 7, 0, 0, 0, 0, 0) => "10",
                (1, 1, 2, 1, 0, 0, 0, 0, 0) => "100",
                (1, 1, 2, 2, 0, 0, 1, 1, 1) => "80",
                (1, 1, 2, 2, 0, 0, 1, 1, 2) => "60",
                (1, 1, 2, 2, 0, 0, 1, 2, _) => "80",
                (1, 1, 2, 2, 0, 0, 2, _, _) => "60",
                (1, 1, 2, 3, 0, 0, 0, 0, 0) => "50",
                (1, 1, 2, 4, 0, 0, 0, 0, 0) => "50",
                (1, 1, 2, 6, 0, 0, 0, 0, 0) => "20",
                (1, 1, 2, 7, 0, 0, 0, 0, 0) => "10",
                (1, 2, 1, 2, 0, 1, 0, 0, 0) => "60",
                (1, 2, 1, 2, 0, 2, 0, 0, 0) => "60",
                (1, 2, 1, 2, 0, 3, 0, 0, 0) => "60",
                (1, 2, 1, 3, 0, 0, 0, 0, 0) => "50",
                (1, 2, 1, 4, 0, 0, 0, 0, 0) => "50",
                (1, 2, 1, 6, 0, 0, 0, 0, 0) => "20",
                (1, 2, 1, 7, 0, 0, 0, 0, 0) => "10",
                (1, 2, 2, 2, 0, 1, 1, 1, 1) => "80",
                (1, 2, 2, 2, 0, 1, 1, 1, 2) => "60",
                (1, 2, 2, 2, 0, 1, 1, 2, 0) => "80",
                (1, 2, 2, 2, 0, 1, 2, 0, 0) => "60",
                (1, 2, 2, 2, 0, 2, 1, 1, 1) => "80",
                (1, 2, 2, 2, 0, 2, 1, 1, 2) => "60",
                (1, 2, 2, 2, 0, 2, 1, 2, 0) => "80",
                (1, 2, 2, 2, 0, 2, 2, 0, 0) => "60",
                (1, 2, 2, 2, 0, 3, 1, 1, 1) => "80",
                (1, 2, 2, 2, 0, 3, 1, 1, 2) => "60",
                (1, 2, 2, 2, 0, 3, 1, 2, 0) => "80",
                (1, 2, 2, 2, 0, 3, 2, 0, 0) => "60",
                (1, 2, 2, 3, 0, 0, 0, 0, 0) => "50",
                (1, 2, 2, 4, 0, 0, 0, 0, 0) => "50",
                (1, 2, 2, 6, 0, 0, 0, 0, 0) => "20",
                (1, 2, 2, 7, 0, 0, 0, 0, 0) => "10",
                (1, 3, 1, 2, 0, 0, 0, 0, 0) => "60",
                (1, 3, 1, 3, 0, 0, 0, 0, 0) => "50",
                (1, 3, 1, 4, 0, 0, 0, 0, 0) => "50",
                (1, 3, 1, 6, 0, 0, 0, 0, 0) => "20",
                (1, 3, 1, 7, 0, 0, 0, 0, 0) => "10",
                (1, 3, 2, 2, 0, 1, 1, 1, 1) => "80",
                (1, 3, 2, 2, 0, 1, 1, 1, 2) => "60",
                (1, 3, 2, 2, 0, 1, 1, 2, _) => "80",
                (1, 3, 2, 2, 0, 1, 2, 0, 0) => "60",
                (1, 3, 2, 2, 0, 2, 1, 1, 1) => "60",
                (1, 3, 2, 2, 0, 2, 1, 1, 2) => "60",
                (1, 3, 2, 2, 0, 2, 1, 2, 0) => "80",
                (1, 3, 2, 2, 0, 2, 2, 0, 0) => "60",
                (1, 3, 2, 2, 0, 3, 1, 1, 1) => "60",
                (1, 3, 2, 2, 0, 3, 1, 1, 2) => "60",
                (1, 3, 2, 2, 0, 3, 1, 2, 0) => "60",
                (1, 3, 2, 2, 0, 3, 2, 0, 0) => "60",
                (1, 3, 2, 3, 0, 0, 0, 0, 0) => "50",
                (1, 3, 2, 4, 0, 0, 0, 0, 0) => "50",
                (1, 3, 2, 6, 0, 0, 0, 0, 0) => "20",
                (1, 3, 2, 7, 0, 0, 0, 0, 0) => "10",
                _ => "XX"//throw new ArgumentException("")
            };
        }
        public static string CalculateSpeed2(string[] input)
        {
            int DevType = int.Parse(input[0]);
            int RoadsideFreq = int.Parse(input[1]);
            int Divided = int.Parse(input[2]);
            int RoadFunc = int.Parse(input[3]);
            int FreewayCond = int.Parse(input[4]);
            int AccessRest = int.Parse(input[5]);
            int Pedestrians = int.Parse(input[6]);
            int MedianWidth = int.Parse(input[7]);
            int Protection4R = int.Parse(input[8]);
            return (DevType, RoadsideFreq, Divided, RoadFunc, FreewayCond, AccessRest, Pedestrians, MedianWidth, Protection4R) switch
            {
                (2, 1, 1, 2, _, _, 1, _, _) => "80",        //(2,1,1,2,0,0,1,0,0) => "80",
                (2, 1, 1, 2, _, _, 2, _, _) => "60",        //(2,1,1,2,0,0,2,0,0) => "60",
                (2, 1, 1, 3, _, _, _, _, _) => "50",        //(2,1,1,3,0,0,0,0,0) => "50",
                (2, 1, 1, 4, _, _, _, _, _) => "50",        //(2,1,1,4,0,0,0,0,0) => "50",
                (2, 1, 1, 6, _, _, _, _, _) => "20",        //(2,1,1,6,0,0,0,0,0) => "20",
                (2, 1, 1, 7, _, _, _, _, _) => "10",        //(2,1,1,7,0,0,0,0,0) => "10",
                (2, 1, 2, 1, _, _, _, _, _) => "100"        /*(2,1,2,1,0,0,0,0,0) => "100"*/,
                (2, 1, 2, 2, _, _, 1, 1, 1) => "80",        //(2,1,2,2,0,0,1,1,1) => "80",
                (2, 1, 2, 2, _, _, 1, 1, 2) => "80",        //(2,1,2,2,0,0,1,1,2) => "80",
                (2, 1, 2, 2, _, _, 1, 2, 0) => "80",        //(2,1,2,2,0,0,1,2,0) => "80",
                (2, 1, 2, 2, _, _, 2, 0, 0) => "60",        //(2,1,2,2,0,0,2,0,0) => "60",
                (2, 1, 2, 3, _, _, _, _, _) => "50",        //(2,1,2,3,0,0,0,0,0) => "50",
                (2, 1, 2, 4, _, _, _, _, _) => "50",        //(2,1,2,4,0,0,0,0,0) => "50",
                (2, 1, 2, 6, _, _, _, _, _) => "20",        //(2,1,2,6,0,0,0,0,0) => "20",
                (2, 1, 2, 7, _, _, _, _, _) => "10",        //(2,1,2,7,0,0,0,0,0) => "10",
                (2, 2, 1, 2, 0, 1, 2, 0, 0) => "60",        //(2,2,1,2,0,1,2,0,0) => "60",
                (2, 2, 1, 2, 0, 1, 1, 0, 0) => "80",        //(2,2,1,2,0,1,1,0,0) => "80",
                (2, 2, 1, 2, 0, 2, 2, 0, 0) => "60",        //(2,2,1,2,0,2,2,0,0) => "60",
                (2, 2, 1, 2, 0, 2, 1, 0, 0) => "80",        //(2,2,1,2,0,2,1,0,0) => "80",
                (2, 2, 1, 2, 0, 3, 0, 0, 0) => "60",        //(2,2,1,2,0,3,0,0,0) => "60",
                (2, 2, 1, 3, 0, 0, 0, 0, 0) => "50",        //(2,2,1,3,0,0,0,0,0) => "50",
                (2, 2, 1, 4, 0, 0, 0, 0, 0) => "50",        //(2,2,1,4,0,0,0,0,0) => "50",
                (2, 2, 1, 6, 0, 0, 0, 0, 0) => "20",        //(2,2,1,6,0,0,0,0,0) => "20",
                (2, 2, 1, 7, 0, 0, 0, 0, 0) => "10",        //(2,2,1,7,0,0,0,0,0) => "10",
                (2, 2, 2, 2, 0, 1, 1, 1, 1) => "80",        //(2,2,2,2,0,1,1,1,1) => "80",
                (2, 2, 2, 2, 0, 1, 1, 1, 2) => "80",        //(2,2,2,2,0,1,1,1,2) => "80",
                (2, 2, 2, 2, 0, 1, 1, 2, 0) => "80",        //(2,2,2,2,0,1,1,2,0) => "80",
                (2, 2, 2, 2, 0, 1, 2, 0, 0) => "60",        //(2,2,2,2,0,1,2,0,0) => "60",
                (2, 2, 2, 2, 0, 2, 1, 1, 1) => "80",        //(2,2,2,2,0,2,1,1,1) => "80",
                (2, 2, 2, 2, 0, 2, 1, 1, 2) => "80",        //(2,2,2,2,0,2,1,1,2) => "80",
                (2, 2, 2, 2, 0, 2, 1, 2, 0) => "80",        //(2,2,2,2,0,2,1,2,0) => "80",
                (2, 2, 2, 2, 0, 2, 2, 0, 0) => "60",        //(2,2,2,2,0,2,2,0,0) => "60",
                (2, 2, 2, 2, 0, 3, 1, 1, 1) => "80",        //(2,2,2,2,0,3,1,1,1) => "80",
                (2, 2, 2, 2, 0, 3, 1, 1, 2) => "60",        //(2,2,2,2,0,3,1,1,2) => "60",
                (2, 2, 2, 2, 0, 3, 1, 2, 0) => "80",        //(2,2,2,2,0,3,1,2,0) => "80",
                (2, 2, 2, 2, 0, 3, 2, 0, 0) => "60",        //(2,2,2,2,0,3,2,0,0) => "60",
                (2, 2, 2, 3, 0, 0, 0, 0, 0) => "60",        //(2,2,2,3,0,0,0,0,0) => "60",
                (2, 2, 2, 4, 0, 0, 0, 0, 0) => "50",        //(2,2,2,4,0,0,0,0,0) => "50",
                (2, 2, 2, 6, 0, 0, 0, 0, 0) => "20",        //(2,2,2,6,0,0,0,0,0) => "20",
                (2, 2, 2, 7, 0, 0, 0, 0, 0) => "10",        //(2,2,2,7,0,0,0,0,0) => "10",
                (2, 3, 1, 2, 0, 1, 2, 0, 0) => "60",        //(2,3,1,2,0,1,2,0,0) => "60",
                (2, 3, 1, 2, 0, 1, 1, 0, 0) => "80",        //(2,3,1,2,0,1,1,0,0) => "80",
                (2, 3, 1, 2, 0, 2, 0, 0, 0) => "60",        //(2,3,1,2,0,2,0,0,0) => "60",
                (2, 3, 1, 2, 0, 3, 0, 0, 0) => "60",        //(2,3,1,2,0,3,0,0,0) => "60",
                (2, 3, 1, 3, 0, 0, 0, 0, 0) => "50",        //(2,3,1,3,0,0,0,0,0) => "50",
                (2, 3, 1, 4, 0, 0, 0, 0, 0) => "50",        //(2,3,1,4,0,0,0,0,0) => "50",
                (2, 3, 1, 6, 0, 0, 0, 0, 0) => "20",        //(2,3,1,6,0,0,0,0,0) => "20",
                (2, 3, 1, 7, 0, 0, 0, 0, 0) => "10",        //(2,3,1,7,0,0,0,0,0) => "10",
                (2, 3, 2, 2, 0, 1, 1, 1, 1) => "80",        //(2,3,2,2,0,1,1,1,1) => "80",
                (2, 3, 2, 2, 0, 1, 1, 1, 2) => "80",        //(2,3,2,2,0,1,1,1,2) => "80",
                (2, 3, 2, 2, 0, 1, 1, 2, 0) => "80",        //(2,3,2,2,0,1,1,2,0) => "80",
                (2, 3, 2, 2, 0, 1, 2, 0, 0) => "60",        //(2,3,2,2,0,1,2,0,0) => "60",
                (2, 3, 2, 2, 0, 2, 1, 1, 1) => "80",        //(2,3,2,2,0,2,1,1,1) => "80",
                (2, 3, 2, 2, 0, 2, 1, 1, 2) => "80",        //(2,3,2,2,0,2,1,1,2) => "80",
                (2, 3, 2, 2, 0, 2, 1, 2, 0) => "80",        //(2,3,2,2,0,2,1,2,0) => "80",
                (2, 3, 2, 2, 0, 2, 2, 0, 0) => "60",        //(2,3,2,2,0,2,2,0,0) => "60",
                (2, 3, 2, 2, 0, 3, 1, 1, 1) => "80",        //(2,3,2,2,0,3,1,1,1) => "80",
                (2, 3, 2, 2, 0, 3, 1, 1, 2) => "60",        //(2,3,2,2,0,3,1,1,2) => "60",
                (2, 3, 2, 2, 0, 3, 1, 2, 0) => "80",        //(2,3,2,2,0,3,1,2,0) => "80",
                (2, 3, 2, 2, 0, 3, 2, 0, 0) => "60",        //(2,3,2,2,0,3,2,0,0) => "60",
                (2, 3, 2, 3, _, _, _, _, _) => "50",        //(2,3,2,3,0,0,0,0,0) => "50",
                (2, 3, 2, 4, _, _, _, _, _) => "50",        //(2,3,2,4,0,0,0,0,0) => "50",
                (2, 3, 2, 6, _, _, _, _, _) => "20",        //(2,3,2,6,0,0,0,0,0) => "20",
                (2, 3, 2, 7, _, _, _, _, _) => "10",        //(2,3,2,7,0,0,0,0,0) => "10",
                _ => "XX"//throw new ArgumentException("")
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inputs[3] = "1";
            MainFrame.Content = page1_1;
            Cat1.Background = Brushes.DeepSkyBlue;
            Cat2.Background = Brushes.DarkOrange;
            Cat3.Background = Brushes.DarkOrange;
            Cat4.Background = Brushes.DarkOrange;
            Cat5.Background = Brushes.DarkOrange;
            Cat6.Background = Brushes.DarkOrange;
            Result.Background = Brushes.DarkOrange;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            inputs[3] = "2";
            MainFrame.Content = page2_1;
            Cat2.Background = Brushes.DeepSkyBlue;
            Cat1.Background = Brushes.DarkOrange;
            Cat3.Background = Brushes.DarkOrange;
            Cat4.Background = Brushes.DarkOrange;
            Cat5.Background = Brushes.DarkOrange;
            Cat6.Background = Brushes.DarkOrange;
            Result.Background = Brushes.DarkOrange;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            inputs[3] = "3";
            MainFrame.Content = page3_1;
            Cat3.Background = Brushes.DeepSkyBlue;
            Cat2.Background = Brushes.DarkOrange;
            Cat1.Background = Brushes.DarkOrange;
            Cat4.Background = Brushes.DarkOrange;
            Cat5.Background = Brushes.DarkOrange;
            Cat6.Background = Brushes.DarkOrange;
            Result.Background = Brushes.DarkOrange;
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            inputs[3] = "4";
            MainFrame.Content = page4_1;
            Cat4.Background = Brushes.DeepSkyBlue;
            Cat2.Background = Brushes.DarkOrange;
            Cat3.Background = Brushes.DarkOrange;
            Cat1.Background = Brushes.DarkOrange;
            Cat5.Background = Brushes.DarkOrange;
            Cat6.Background = Brushes.DarkOrange;
            Result.Background = Brushes.DarkOrange;
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            inputs[3] = "5";
            MainFrame.Content = page5_1;
            Cat5.Background = Brushes.DeepSkyBlue;
            Cat2.Background = Brushes.DarkOrange;
            Cat3.Background = Brushes.DarkOrange;
            Cat4.Background = Brushes.DarkOrange;
            Cat1.Background = Brushes.DarkOrange;
            Cat6.Background = Brushes.DarkOrange;
            Result.Background = Brushes.DarkOrange;
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            inputs[3] = "6";
            MainFrame.Content = page6_1;
            Cat6.Background = Brushes.DeepSkyBlue;
            Cat2.Background = Brushes.DarkOrange;
            Cat3.Background = Brushes.DarkOrange;
            Cat4.Background = Brushes.DarkOrange;
            Cat5.Background = Brushes.DarkOrange;
            Cat1.Background = Brushes.DarkOrange;
            Result.Background = Brushes.DarkOrange;
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            switch (inputs[0])
            {
                case "1":
                    result.ResultSpeed.Text = CalculateSpeed1(inputs);
                    break;
                case "2":
                    result.ResultSpeed.Text = CalculateSpeed2(inputs);
                    break;
                default:
                    result.ResultSpeed.Text = CalculateSpeed(inputs);
                    break;
            }
            MainFrame.Content = result;
            Result.Background = Brushes.DeepSkyBlue;
            Cat2.Background = Brushes.DarkOrange;
            Cat3.Background = Brushes.DarkOrange;
            Cat4.Background = Brushes.DarkOrange;
            Cat5.Background = Brushes.DarkOrange;
            Cat1.Background = Brushes.DarkOrange;
            Cat6.Background = Brushes.DarkOrange;
        }
    }
}
