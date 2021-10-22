using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    public class NombreCompletoViewModel:BaseViewModel
    {
        string nombre;
        string apellido1;
        string apellido2;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.Equals(nombre, value)) return;
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(NombreCompleto));

            }
        }
        public string Apellido1
        {
            get => apellido1; set
            {
                if (string.Equals(apellido1, value)) return;
                apellido1 = value;
                OnPropertyChanged(nameof(Apellido1));
                OnPropertyChanged(nameof(NombreCompleto));

            }
        }
        public string Apellido2
        {
            get => apellido2;
            set 
            {
                if (string.Equals(apellido2, value)) return;
                apellido2 = value;
                OnPropertyChanged(nameof(Apellido2));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => string.Format("Tu nombre completo es {0} {1} {2}", nombre, apellido1, apellido2);
        }
    }
}
