using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KLimits.Model
{
    public class RoadInformation : INotifyPropertyChanged
    {
        private string _userreference = "รุจชัย อึ้งอารุณยะวี";

        public string Userreference
        {
            get { return _userreference; }
            set { _userreference = value; OnPropertyChanged("Userreference"); }
        }

        private string _roadname = "มิตรภาพ";

        public string RoadName
        {
            get { return _roadname; }
            set { _roadname = value; OnPropertyChanged("RoadName"); }
        }

        private string location = "ขอนแก่น";

        public string Location
        {
            get { return location; }
            set { location = value; OnPropertyChanged("Location"); }
        }

        private string suburbplace = "ช่วง 14 กิโลเมตร";

        public string Suburb
        {
            get { return suburbplace; }
            set { suburbplace = value; OnPropertyChanged("Suburb"); }
        }

        private string localgovernment = "เทศบาลนครขอนแก่น";

        public string LocalGovernment
        {
            get { return localgovernment; }
            set { localgovernment = value; OnPropertyChanged("LocalGovernment"); }
        }

        private DateTime dateTimedate = DateTime.Now;

        public DateTime date
        {
            get { return dateTimedate; }
            set { dateTimedate = value; OnPropertyChanged("date"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
