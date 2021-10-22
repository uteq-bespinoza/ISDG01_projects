using System;
using System.ComponentModel;

namespace App2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _nombre;

        public MainPageViewModel()
        {
            _nombre = "Holi";
        }


        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(SinUpdate));
            }
        }

        public string SinUpdate
        {
            get => _nombre;
        }

    }
}
