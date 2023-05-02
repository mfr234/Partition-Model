using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Media;

namespace Partition_Model
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private double _lungShunt;
        private double _lungMass;
        private double _liverVolume;
        private double _tnRatio;
        private double _tumorVolume;
        private double _doseActivity;
        private double _tumorDose;

        public double LungShunt
        {
            get { return _lungShunt; }
            set
            {
                _lungShunt = value;
                OnPropertyChanged();
            }
        }

        public double LungMass
        {
            get { return _lungMass; }
            set
            {
                _lungMass = value;
                OnPropertyChanged();
            }
        }

        public double LiverVolume
        {
            get { return _liverVolume; }
            set
            {
                _liverVolume = value;
                OnPropertyChanged();
            }
        }

        public double TnRatio
        {
            get { return _tnRatio; }
            set
            {
                _tnRatio = value;
                OnPropertyChanged();
            }
        }

        public double TumorVolume
        {
            get { return _tumorVolume; }
            set
            {
                _tumorVolume = value;
                OnPropertyChanged();
            }
        }

        public double TumorDose
        {
            get { return _tumorVolume; }
            set
            {
                _tumorVolume = value;
                OnPropertyChanged();
            }
        }

        public double DoseActivity
        {
            get { return _doseActivity; }
            set
            {
                _doseActivity = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
