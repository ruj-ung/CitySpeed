using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CitySpeedLimit.Model
{
    public class Utils : INotifyPropertyChanged
    {
        private string logo = System.IO.Path.GetFullPath("./Photos/AllLogos.png");

        public string Logo
        {
            get { return logo; }
            set { logo = value; OnPropertyChanged("Logo"); }
        }

        private string photo1 = System.IO.Path.GetFullPath("./Photos/Snap1.png");
        //private string photo1 = ".\\Photos\\Snap1.png";
        //private string photo1;
        public string Photo1
        {
            get { return photo1; }
            set { photo1 = value; OnPropertyChanged("Photo1"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
