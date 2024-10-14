using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    internal interface IVehiculoAereo : IVehiculo
    {
        void IncrementarAltitud();
        void DisminuirAltitud();
        void ObtenerAltitud();
        void Aterrizar();
        void Despegar();

    }
}
