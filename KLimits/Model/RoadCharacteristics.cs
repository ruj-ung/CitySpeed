using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KLimits.Model
{
    public class RoadCharacteristics : INotifyPropertyChanged
    {
        private int sectionlength = 2;

        public int SectionLength
        {
            get { return sectionlength; }
            set { sectionlength = value; OnPropertyChanged("SectionLength"); }
        }

        private int aadt = 2000;

        public int AADT
        {
            get { return aadt; }
            set { aadt = value; OnPropertyChanged("AADT"); }
        }

        private int existingspeed = 50;

        public int ExistingSpeed
        {
            get { return existingspeed; }
            set { existingspeed = value; OnPropertyChanged("ExistingSpeed"); }
        }

        private int speed85 = 40;

        public int Speed85
        {
            get { return speed85; }
            set { speed85 = value; OnPropertyChanged("Speed85"); }
        }

        private int speed85type = 2;

        public int Speed85Type
        {
            get { return speed85type; }
            set { speed85type = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
