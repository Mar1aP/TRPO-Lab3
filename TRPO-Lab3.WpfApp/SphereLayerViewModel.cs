using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.WpfApp
{
    public class SphereLayerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private double radius1, radius2, height, volume;

        public double Radius1
        {
            get { return radius1; }
            set
            {
                radius1 = value;
                OnPropertyChanged(nameof(Radius1));
                CalculateVolume();
            }
        }
        public double Radius2
        {
            get { return radius2; }
            set
            {
                radius2 = value;
                OnPropertyChanged(nameof(Radius2));
                CalculateVolume();
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged(nameof(height));
                CalculateVolume();
            }
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                OnPropertyChanged(nameof(volume));
            }
        }

        void CalculateVolume()
        {
            Volume = SphereLayer.FindVolume(Radius1, Radius2, Height);
        }
    }
}
