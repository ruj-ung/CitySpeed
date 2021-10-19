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
using CitySpeedLimit.ViewModel;
using CitySpeedLimit.Model;

namespace CitySpeedLimit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Category Conflict;
        Category Activity;
        public Model.Utils modelview;

        public MainWindow()
        {
            modelview = new Model.Utils();
            DataContext = modelview;
            InitializeComponent();

            Conflict = new Category
            {
                type = 1
            };
            Activity = new Category
            {
                type = 2
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainViewModel myVM = listBoxConflict.DataContext as MainViewModel;
            
            myVM.ItemList.Clear();
            myVM.ItemList2.Clear();
            myVM.FillListFromDB();
            Conflict.ItemList = myVM.ItemList;
            Activity.ItemList = myVM.ItemList2;
           listBoxConflict.Items.Refresh();
            listBoxActivity.Items.Refresh();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UpdateCategory();
            Conflict.Evaluate();
            Activity.Evaluate();
            if(Conflict.Level < 0 || Activity.Level < 0)
            {
                MessageBox.Show("You must choose any item on both sizes");
                return;
            }
            ResultInfoWindow resWnd = new ResultInfoWindow
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this,
            };

            int speed = resWnd.rMatrix[Activity.Level, Conflict.Level];
            resWnd.textBlockSpeed.Text = string.Format("Speed Limit = {0} MPH", speed);

            if (Conflict.Level == 0 && Activity.Level == 0)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/HH.png");
            if (Conflict.Level == 0 && Activity.Level == 1)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/HM.png");
            if (Conflict.Level == 0 && Activity.Level == 2)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/HL.png");
            if (Conflict.Level == 1 && Activity.Level == 0)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/MH.png");
            if (Conflict.Level == 1 && Activity.Level == 1)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/MM.png");
            if (Conflict.Level == 1 && Activity.Level == 2)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/ML.png");
            if (Conflict.Level == 2 && Activity.Level == 0)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/LH.png");
            if (Conflict.Level == 2 && Activity.Level == 1)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/LM.png");
            if (Conflict.Level == 2 && Activity.Level == 2)
                resWnd.modelview.Photo1 = System.IO.Path.GetFullPath("./Photos/LL.png");

            resWnd.Parent1.Header += Conflict.ToString();
            resWnd.Parent2.Header += Activity.ToString();
            foreach(Item it in Conflict.ItemList)
            {
                if(it.Checked)
                {
                    TreeViewItem newChild = new TreeViewItem();
                    newChild.Header = "- "+it.Description;
                    resWnd.Parent1.Items.Add(newChild);
                }
            }
            foreach (Item it in Activity.ItemList)
            {
                if (it.Checked)
                {
                    TreeViewItem newChild = new TreeViewItem();
                    newChild.Header = "- "+it.Description;
                    resWnd.Parent2.Items.Add(newChild);
                }
            }
            resWnd.ShowDialog();
        }

        private void UpdateCategory()
        {
            MainViewModel myVM = listBoxConflict.DataContext as MainViewModel;
            for(int i=0; i < Conflict.ItemList.Count; i++)
            {
                Conflict.ItemList[i].Checked = myVM.ItemList[i].Checked;
            }
            for (int i = 0; i < Activity.ItemList.Count; i++)
            {
                Activity.ItemList[i].Checked = myVM.ItemList2[i].Checked;
            }
        }
    }
}
