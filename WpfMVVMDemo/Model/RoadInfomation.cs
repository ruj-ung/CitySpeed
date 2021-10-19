using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMDemo.Model
{
    public class RoadInfomation : INotifyPropertyChanged
    {
        private string _userreference;

        public string Userreference
        {
            get { return _userreference; }
            set { _userreference = value; OnPropertyChanged("Userreference"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
