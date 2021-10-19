
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_RadioButton.Command;

namespace MVVM_RadioButton.ViewModel
{

    public class ViewModel :INotifyPropertyChanged
    {

        public ICommand MyCommand { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChange("Name");
            }
        }

        private int _NL;

        public int NL
        {
            get { return _NL; }
            set { _NL = value; OnPropertyChange("NL"); }
        }
        private int _WLC;
        public int WLC
        {
            get { return _WLC; }
            set { _WLC = value; OnPropertyChange("WLC"); }
        }

        private int _SL;
        public int SL
        {
            get { return _SL; }
            set { _SL = value; OnPropertyChange("SL"); }
        }

        private int _ST;
        public int ST
        {
            get { return _ST; }
            set { _ST = value; OnPropertyChange("ST"); }
        }

        private int _NIEP ;
        public int NIEP
        {
            get { return _NIEP; }
            set { _NIEP = value; OnPropertyChange("NIEP"); }
        }

        private int _OP;
        public int OP
        {
            get { return _OP; }
            set { _OP = value; OnPropertyChange("OP"); }
        }

        private int _PW;
        public int PW
        {
            get { return _PW; }
            set { _PW = value; OnPropertyChange("PW"); }
        }

        private int _NCB;
        public int NCB
        {
            get { return _NCB; }
            set { _NCB = value; OnPropertyChange("NCB"); }
        }


        private int _CS;

        public int CS
        {
            get { return _CS; }
            set { _CS = value; OnPropertyChange("CS"); }
        }
        private string _CSL = "";

        public string CSL
        {
            get { return _CSL; }
            set { _CSL = value; OnPropertyChange("CSL"); }
        }

       public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string propertyname)
        {
            if (PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public ViewModel()
        {
            NL = 50;
            WLC = SL = 40;
            ST = 30;
            NIEP = OP = NCB = 0;
            PW = 10;
            CS = NL + WLC + SL + ST + NIEP + OP + PW + NCB;
            if (CS > 170) CSL = "40 Km/Hr";
            else if (CS >= 120) CSL = "50 Km/Hr";
            else if (CS >= 80) CSL = "60 Km/Hr";
            else CSL = "70 Km/Hr";
            MyCommand = new RelayCommand(executemethod, canexecutemethod);
        }

 

        private bool canexecutemethod(object parameter)
        {
            if (parameter != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void executemethod(object parameter)
        {
            int n = int.Parse(parameter.ToString());
            if (n == 1) NL = 50;
            if (n == 2) NL = 25;
            if (n == 3) NL = 0;
            if (n == 4) WLC = 40;
            if (n == 5) WLC = 20;
            if (n == 6) WLC = 0;
            if (n == 7) SL = 40;
            if (n == 8) SL = 20;
            if (n == 9) SL = 0;
            if (n == 10) ST = 30;
            if (n == 11) ST = 15;
            if (n == 12) ST = 0;
            if (n == 13) NIEP = 0;
            if (n == 14) NIEP = 15;
            if (n == 15) NIEP = 25;
            if (n == 16) OP = 0;
            if (n == 17) OP = 15;
            if (n == 18) OP = 25;
            if (n == 19) PW = 10;
            if (n == 20) PW = 5;
            if (n == 21) PW = 0;
            if (n == 22) NCB = 0;
            if (n == 23) NCB = 20;
            if (n == 24) NCB = 40;

            CS = NL + WLC + SL + ST + NIEP + OP + PW +  NCB;
            if (CS > 170) CSL = "40 Km/Hr";
            else if (CS >= 120) CSL = "50 Km/Hr";
            else if (CS >= 80) CSL = "60 Km/Hr";
            else CSL = "70 Km/Hr";
            Name = (string)parameter;
        }
    }
}
