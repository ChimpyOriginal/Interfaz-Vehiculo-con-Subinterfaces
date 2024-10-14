using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    internal interface IVehiculoTerrestre : IVehiculo
    {
        void TocarClaxon();
        void Frenar();
        void EncenderLuces();
    }
}
