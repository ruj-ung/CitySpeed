using KLimits.Category2;
using KLimits.Category3;
using KLimits.Category4;
using KLimits.Category5;
using KLimits.Category6;
using KLimits.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
        public string[] inputs = new string[] { "2", "3", "2", "6", "0", "1", "1", "1", "1" };
        //string[] inputs = new string[] { "5", "2", "2", "2", "0", "0", "0", "0", "0" };

        public InputParameters parameters;
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

            Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("th_TH");

            parameters = new InputParameters
            {
                DevelopmentType = 2,
                RoadsideAccesssFrequency = 2,
                IsUndivided = 1,
                RoadFunction = 2,
                FreewayConditions = 0,
                AccessRestictions = 1,
                Pedestrians = 1,
                MedainWidth = 1,
                ProtectionForRigthTurn = 1
            };
            //MainFrame.Source = new Uri("https://map.google.com", UriKind.Absolute);
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
        public static string CalculateSpeed(InputParameters para)
        {
            int DevType = para.DevelopmentType;
            int RoadsideFreq = para.RoadsideAccesssFrequency;
            int Divided = para.IsUndivided;
            int RoadFunc = para.RoadFunction;
            int FreewayCond = para.FreewayConditions;
            int AccessRest = para.AccessRestictions;
            int Pedestrians = para.Pedestrians;
            int MedianWidth = para.MedainWidth;
            int Protection4R = para.ProtectionForRigthTurn;
            return (DevType, RoadsideFreq, Divided, RoadFunc, FreewayCond, AccessRest, Pedestrians, MedianWidth, Protection4R) switch
            {
                (4, 1, 0, 2, _, _, _, _, _) => "80",
                (4, 1, 0, 4, _, _, _, _, _) => "80",
                (4, 2, 1, 2, _, _, _, _, _) => "80",
                (4, 2, 1, 4, _, _, _, _, _) => "80",
                (4, 2, 2, 2, _, _, _, _, _) => "80",
                (4, 2, 2, 4, _, _, _, _, _) => "80",
                (4, 3, _, _, _, _, _, _, _) => "XX",
                (5, 1, 1, 2, _, _, _, _, _) => "100",
                (5, 1, 1, 4, _, _, _, _, _) => "100",
                (5, 1, 2, 1, 1, _, _, _, _) => "100",
                (5, 1, 2, 1, 2, _, _, _, _) => "100",
                (5, 1, 2, 2, 1, _, _, _, _) => "100",
                (5, 1, 2, 2, 2, _, _, _, _) => "100",
                (5, 1, 2, 4, _, _, _, _, _) => "100",
                (5, 2, 1, 2, _, _, _, _, _) => "100",
                (5, 2, 1, 4, _, _, _, _, _) => "100",
                (5, 2, 2, 2, _, _, _, _, _) => "100",
                (5, 2, 2, 4, _, _, _, _, _) => "100",
                (5, 3, 0, 0, _, _, _, _, _) => "XX",
                (3, 1, 1, 2, _, _, _, _, _) => "80",
                (3, 1, 1, 3, _, _, _, _, _) => "80",
                (3, 1, 1, 4, _, _, _, _, _) => "80",
                (3, 1, 2, 1, _, _, _, _, _) => "100",
                (3, 1, 2, 2, _, _, _, _, _) => "100",
                (3, 1, 2, 3, _, _, _, _, _) => "80",
                (3, 1, 2, 4, _, _, _, _, _) => "80",
                (3, 2, 1, 2, _, _, _, _, _) => "80",
                (3, 2, 1, 3, _, _, _, _, _) => "80",
                (3, 2, 1, 4, _, _, _, _, _) => "80",
                (3, 2, 2, 2, _, _, _, _, _) => "100",
                (3, 2, 2, 3, _, _, _, _, _) => "80",
                (3, 2, 2, 4, _, _, _, _, _) => "80",
                (3, 3, 0, 0, _, _, _, _, _) => "XX",
                _ => "NA"//throw new ArgumentException("")
            };
        }
        public static string CalculateSpeed1(InputParameters para)
        {
            int DevType = para.DevelopmentType;
            int RoadsideFreq = para.RoadsideAccesssFrequency;
            int Divided = para.IsUndivided;
            int RoadFunc = para.RoadFunction;
            int FreewayCond = para.FreewayConditions;
            int AccessRest = para.AccessRestictions;
            int Pedestrians = para.Pedestrians;
            int MedianWidth = para.MedainWidth;
            int Protection4R = para.ProtectionForRigthTurn;
            return (DevType, RoadsideFreq, Divided, RoadFunc, FreewayCond, AccessRest, Pedestrians, MedianWidth, Protection4R) switch
            {
                (1, 1, 1, 2, _, _, _, _, _) => "60",
                (1, 1, 1, 3, _, _, _, _, _) => "50",
                (1, 1, 1, 4, _, _, _, _, _) => "50",
                (1, 1, 1, 6, _, _, _, _, _) => "20",
                (1, 1, 1, 7, _, _, _, _, _) => "10",
                (1, 1, 2, 1, _, _, _, _, _) => "100",
                (1, 1, 2, 2, _, _, 1, 1, 1) => "80",
                (1, 1, 2, 2, _, _, 1, 1, 2) => "60",
                (1, 1, 2, 2, _, _, 1, 2, _) => "80",
                (1, 1, 2, 2, _, _, 2, _, _) => "60",
                (1, 1, 2, 3, _, _, _, _, _) => "50",
                (1, 1, 2, 4, _, _, _, _, _) => "50",
                (1, 1, 2, 6, _, _, _, _, _) => "20",
                (1, 1, 2, 7, _, _, _, _, _) => "10",
                (1, 2, 1, 2, _, 1, _, _, _) => "60",
                (1, 2, 1, 2, _, 2, _, _, _) => "60",
                (1, 2, 1, 2, _, 3, _, _, _) => "60",
                (1, 2, 1, 3, _, _, _, _, _) => "50",
                (1, 2, 1, 4, _, _, _, _, _) => "50",
                (1, 2, 1, 6, _, _, _, _, _) => "20",
                (1, 2, 1, 7, _, _, _, _, _) => "10",
                (1, 2, 2, 2, _, 1, 1, 1, 1) => "80",
                (1, 2, 2, 2, _, 1, 1, 1, 2) => "60",
                (1, 2, 2, 2, _, 1, 1, 2, _) => "80",
                (1, 2, 2, 2, _, 1, 2, _, _) => "60",
                (1, 2, 2, 2, _, 2, 1, 1, 1) => "80",
                (1, 2, 2, 2, _, 2, 1, 1, 2) => "60",
                (1, 2, 2, 2, _, 2, 1, 2, _) => "80",
                (1, 2, 2, 2, _, 2, 2, _, _) => "60",
                (1, 2, 2, 2, _, 3, 1, 1, 1) => "80",
                (1, 2, 2, 2, _, 3, 1, 1, 2) => "60",
                (1, 2, 2, 2, _, 3, 1, 2, _) => "80",
                (1, 2, 2, 2, _, 3, 2, _, _) => "60",
                (1, 2, 2, 3, _, _, _, _, _) => "50",
                (1, 2, 2, 4, _, _, _, _, _) => "50",
                (1, 2, 2, 6, _, _, _, _, _) => "20",
                (1, 2, 2, 7, _, _, _, _, _) => "10",
                (1, 3, 1, 2, _, _, _, _, _) => "60",
                (1, 3, 1, 3, _, _, _, _, _) => "50",
                (1, 3, 1, 4, _, _, _, _, _) => "50",
                (1, 3, 1, 6, _, _, _, _, _) => "20",
                (1, 3, 1, 7, _, _, _, _, _) => "10",
                (1, 3, 2, 2, _, 1, 1, 1, 1) => "80",
                (1, 3, 2, 2, _, 1, 1, 1, 2) => "60",
                (1, 3, 2, 2, _, 1, 1, 2, _) => "80",
                (1, 3, 2, 2, _, 1, 2, _, _) => "60",
                (1, 3, 2, 2, _, 2, 1, 1, 1) => "60",
                (1, 3, 2, 2, _, 2, 1, 1, 2) => "60",
                (1, 3, 2, 2, _, 2, 1, 2, _) => "80",
                (1, 3, 2, 2, _, 2, 2, _, _) => "60",
                (1, 3, 2, 2, _, 3, 1, 1, 1) => "60",
                (1, 3, 2, 2, _, 3, 1, 1, 2) => "60",
                (1, 3, 2, 2, _, 3, 1, 2, _) => "60",
                (1, 3, 2, 2, _, 3, 2, _, _) => "60",
                (1, 3, 2, 3, _, _, _, _, _) => "50",
                (1, 3, 2, 4, _, _, _, _, _) => "50",
                (1, 3, 2, 6, _, _, _, _, _) => "20",
                (1, 3, 2, 7, _, _, _, _, _) => "10",
                _ => "NA"//throw new ArgumentException("")
            };
        }
        public static string CalculateSpeed2(InputParameters para)
        {
            int DevType = para.DevelopmentType;
            int RoadsideFreq = para.RoadsideAccesssFrequency;
            int Divided = para.IsUndivided;
            int RoadFunc = para.RoadFunction;
            int FreewayCond = para.FreewayConditions;
            int AccessRest = para.AccessRestictions;
            int Pedestrians = para.Pedestrians;
            int MedianWidth = para.MedainWidth;
            int Protection4R = para.ProtectionForRigthTurn;
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
                (2, 1, 2, 2, _, _, 1, 2, _) => "80",        //(2,1,2,2,0,0,1,2,0) => "80",
                (2, 1, 2, 2, _, _, 2, _, _) => "60",        //(2,1,2,2,0,0,2,0,0) => "60",
                (2, 1, 2, 3, _, _, _, _, _) => "50",        //(2,1,2,3,0,0,0,0,0) => "50",
                (2, 1, 2, 4, _, _, _, _, _) => "50",        //(2,1,2,4,0,0,0,0,0) => "50",
                (2, 1, 2, 6, _, _, _, _, _) => "20",        //(2,1,2,6,0,0,0,0,0) => "20",
                (2, 1, 2, 7, _, _, _, _, _) => "10",        //(2,1,2,7,0,0,0,0,0) => "10",
                (2, 2, 1, 2, _, 1, 2, _, _) => "60",        //(2,2,1,2,0,1,2,0,0) => "60",
                (2, 2, 1, 2, _, 1, 1, _, _) => "80",        //(2,2,1,2,0,1,1,0,0) => "80",
                (2, 2, 1, 2, _, 2, 2, _, _) => "60",        //(2,2,1,2,0,2,2,0,0) => "60",
                (2, 2, 1, 2, _, 2, 1, _, _) => "80",        //(2,2,1,2,0,2,1,0,0) => "80",
                (2, 2, 1, 2, _, 3, _, _, _) => "60",        //(2,2,1,2,0,3,0,0,0) => "60",
                (2, 2, 1, 3, _, _, _, _, _) => "50",        //(2,2,1,3,0,0,0,0,0) => "50",
                (2, 2, 1, 4, _, _, _, _, _) => "50",        //(2,2,1,4,0,0,0,0,0) => "50",
                (2, 2, 1, 6, _, _, _, _, _) => "20",        //(2,2,1,6,0,0,0,0,0) => "20",
                (2, 2, 1, 7, _, _, _, _, _) => "10",        //(2,2,1,7,0,0,0,0,0) => "10",
                (2, 2, 2, 2, _, 1, 1, 1, 1) => "80",        //(2,2,2,2,0,1,1,1,1) => "80",
                (2, 2, 2, 2, _, 1, 1, 1, 2) => "80",        //(2,2,2,2,0,1,1,1,2) => "80",
                (2, 2, 2, 2, _, 1, 1, 2, _) => "80",        //(2,2,2,2,0,1,1,2,0) => "80",
                (2, 2, 2, 2, _, 1, 2, _, _) => "60",        //(2,2,2,2,0,1,2,0,0) => "60",
                (2, 2, 2, 2, _, 2, 1, 1, 1) => "80",        //(2,2,2,2,0,2,1,1,1) => "80",
                (2, 2, 2, 2, _, 2, 1, 1, 2) => "80",        //(2,2,2,2,0,2,1,1,2) => "80",
                (2, 2, 2, 2, _, 2, 1, 2, _) => "80",        //(2,2,2,2,0,2,1,2,0) => "80",
                (2, 2, 2, 2, _, 2, 2, _, _) => "60",        //(2,2,2,2,0,2,2,0,0) => "60",
                (2, 2, 2, 2, _, 3, 1, 1, 1) => "80",        //(2,2,2,2,0,3,1,1,1) => "80",
                (2, 2, 2, 2, _, 3, 1, 1, 2) => "60",        //(2,2,2,2,0,3,1,1,2) => "60",
                (2, 2, 2, 2, _, 3, 1, 2, _) => "80",        //(2,2,2,2,0,3,1,2,0) => "80",
                (2, 2, 2, 2, _, 3, 2, _, _) => "60",        //(2,2,2,2,0,3,2,0,0) => "60",
                (2, 2, 2, 3, _, _, _, _, _) => "60",        //(2,2,2,3,0,0,0,0,0) => "60",
                (2, 2, 2, 4, _, _, _, _, _) => "50",        //(2,2,2,4,0,0,0,0,0) => "50",
                (2, 2, 2, 6, _, _, _, _, _) => "20",        //(2,2,2,6,0,0,0,0,0) => "20",
                (2, 2, 2, 7, _, _, _, _, _) => "10",        //(2,2,2,7,0,0,0,0,0) => "10",
                (2, 3, 1, 2, _, 1, 2, _, _) => "60",        //(2,3,1,2,0,1,2,0,0) => "60",
                (2, 3, 1, 2, _, 1, 1, _, _) => "80",        //(2,3,1,2,0,1,1,0,0) => "80",
                (2, 3, 1, 2, _, 2, _, _, _) => "60",        //(2,3,1,2,0,2,0,0,0) => "60",
                (2, 3, 1, 2, _, 3, _, _, _) => "60",        //(2,3,1,2,0,3,0,0,0) => "60",
                (2, 3, 1, 3, _, _, _, _, _) => "50",        //(2,3,1,3,0,0,0,0,0) => "50",
                (2, 3, 1, 4, _, _, _, _, _) => "50",        //(2,3,1,4,0,0,0,0,0) => "50",
                (2, 3, 1, 6, _, _, _, _, _) => "20",        //(2,3,1,6,0,0,0,0,0) => "20",
                (2, 3, 1, 7, _, _, _, _, _) => "10",        //(2,3,1,7,0,0,0,0,0) => "10",
                (2, 3, 2, 2, _, 1, 1, 1, 1) => "80",        //(2,3,2,2,0,1,1,1,1) => "80",
                (2, 3, 2, 2, _, 1, 1, 1, 2) => "80",        //(2,3,2,2,0,1,1,1,2) => "80",
                (2, 3, 2, 2, _, 1, 1, 2, _) => "80",        //(2,3,2,2,0,1,1,2,0) => "80",
                (2, 3, 2, 2, _, 1, 2, _, _) => "60",        //(2,3,2,2,0,1,2,0,0) => "60",
                (2, 3, 2, 2, _, 2, 1, 1, 1) => "80",        //(2,3,2,2,0,2,1,1,1) => "80",
                (2, 3, 2, 2, _, 2, 1, 1, 2) => "80",        //(2,3,2,2,0,2,1,1,2) => "80",
                (2, 3, 2, 2, _, 2, 1, 2, _) => "80",        //(2,3,2,2,0,2,1,2,0) => "80",
                (2, 3, 2, 2, _, 2, 2, _, _) => "60",        //(2,3,2,2,0,2,2,0,0) => "60",
                (2, 3, 2, 2, _, 3, 1, 1, 1) => "80",        //(2,3,2,2,0,3,1,1,1) => "80",
                (2, 3, 2, 2, _, 3, 1, 1, 2) => "60",        //(2,3,2,2,0,3,1,1,2) => "60",
                (2, 3, 2, 2, _, 3, 1, 2, _) => "80",        //(2,3,2,2,0,3,1,2,0) => "80",
                (2, 3, 2, 2, _, 3, 2, _, _) => "60",        //(2,3,2,2,0,3,2,0,0) => "60",
                (2, 3, 2, 3, _, _, _, _, _) => "50",        //(2,3,2,3,0,0,0,0,0) => "50",
                (2, 3, 2, 4, _, _, _, _, _) => "50",        //(2,3,2,4,0,0,0,0,0) => "50",
                (2, 3, 2, 6, _, _, _, _, _) => "20",        //(2,3,2,6,0,0,0,0,0) => "20",
                (2, 3, 2, 7, _, _, _, _, _) => "10",        //(2,3,2,7,0,0,0,0,0) => "10",
                _ => "NA"//throw new ArgumentException("")
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //inputs[3] = "1";
            //parameters.RoadFunction = 1;
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
            //inputs[3] = "2";
            //parameters.RoadFunction = 2;
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
            //inputs[3] = "3";
            //parameters.RoadFunction = 3;
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
            //inputs[3] = "4";
            //parameters.RoadFunction = 4;
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
            //inputs[3] = "6";
            //parameters.RoadFunction = 6;
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
            //inputs[3] = "7";
            //parameters.RoadFunction = 7;
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
            var data = (RoadsideAccessFreqquency)page2_2.DataContext;
            switch(parameters.DevelopmentType)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    if(data.Frequency < 2.0) parameters.RoadsideAccesssFrequency = 1;
                    else if (data.Frequency < 4.0) parameters.RoadsideAccesssFrequency = 2;
                    else parameters.RoadsideAccesssFrequency = 3;                    
                    break;
                case 5:
                    if (data.Frequency < 1.0) parameters.RoadsideAccesssFrequency = 1;
                    else if (data.Frequency < 1.25) parameters.RoadsideAccesssFrequency = 2;
                    else parameters.RoadsideAccesssFrequency = 3;
                    break;
            }

            switch (parameters.DevelopmentType)
            {
                case 1:
                    result.ResultSpeed.Text = CalculateSpeed1(parameters);
                    break;
                case 2:
                    result.ResultSpeed.Text = CalculateSpeed2(parameters);
                    break;
                default:
                    result.ResultSpeed.Text = CalculateSpeed(parameters);
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

            inputs[0] = parameters.DevelopmentType.ToString();
            inputs[1] = parameters.RoadsideAccesssFrequency.ToString();
            inputs[2] = parameters.IsUndivided.ToString();
            inputs[3] = parameters.RoadFunction.ToString();
            inputs[4] = parameters.FreewayConditions.ToString();
            inputs[5] = parameters.AccessRestictions.ToString();
            inputs[6] = parameters.Pedestrians.ToString();
            inputs[7] = parameters.MedainWidth.ToString();
            inputs[8] = parameters.ProtectionForRigthTurn.ToString();
            result.trace.Content  = inputs[0] + inputs[1] + inputs[2] + inputs[3] + inputs[4] + inputs[5] + inputs[6] + inputs[7] + inputs[8];
           var roadinfo = (RoadInformation)page1_1.DataContext;
            
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            //var navService = MainFrame.NavigationService;
            //dynamic browser = navService.GetType().GetField("_webBrowser", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(navService);
            //dynamic iWebBrowser2 = browser.GetType().GetField("_axIWebBrowser2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(browser);
            //iWebBrowser2.Silent = true;
        }
    }
}
