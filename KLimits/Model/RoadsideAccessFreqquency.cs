using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KLimits.Model
{
    public class RoadsideAccessFreqquency
    {
        private float frequency = 2.1f;

        public float Frequency
        {
            get { return frequency; }
            set { frequency = value; OnPropertyChanged("Frequency"); }
        }

        private float typeA;

        public float TypeA
        {
            get { return typeA; }
            set { typeA = value; OnPropertyChanged("TypeA"); }
        }

        private float typeB;

        public float TypeB
        {
            get { return typeB; }
            set { typeB = value; OnPropertyChanged("TypeB"); }
        }
        private float typeC;

        public float TypeC
        {
            get { return typeC; }
            set { typeC = value; OnPropertyChanged("TypeC"); }
        }

        private float typeD;

        public float TypeD
        {
            get { return typeD; }
            set { typeD = value; OnPropertyChanged("TypeD"); }
        }

        private float typeE;

        public float TypeE
        {
            get { return typeE; }
            set { typeE = value; OnPropertyChanged("TypeE"); }
        }
        private float typeF;

        public float TypeF
        {
            get { return typeF; }
            set { typeF = value; OnPropertyChanged("TypeF"); }
        }

        private float typeG;

        public float TypeG
        {
            get { return typeG; }
            set { typeG = value; OnPropertyChanged("TypeG"); }
        }

        private float typeH;

        public float TypeH
        {
            get { return typeH; }
            set { typeH = value; OnPropertyChanged("TypeH"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
