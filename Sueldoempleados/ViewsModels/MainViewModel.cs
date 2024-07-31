using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldoempleados.ViewsModels
{
    public partial class MainViewModel  : ObservableObject
    {
        [ObservableProperty]
        private double _SueldoActual;
        [ObservableProperty]
        private string? _Resultado;
        [ObservableProperty]
        private string? _NuevoSueldo;

        [RelayCommand]
        public void Porcentaje()
        {
            double aumento;
            if (SueldoActual < 1000)
            {
                aumento = SueldoActual * 0.15;
            }
            else
            {
                aumento = SueldoActual * 0.12;
            }
            double nuevoSueldo = SueldoActual + aumento;
            NuevoSueldo = $"El nuevo sueldo es: ${nuevoSueldo:F2}";
            Resultado = NuevoSueldo.ToString();
        }
    }
}
