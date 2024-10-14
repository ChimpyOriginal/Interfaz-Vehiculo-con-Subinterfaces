using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public interface IVehiculo
    {
        string Nombre { get; set; }
        void AumentarVelocidad();
        void DisminuirVelocidad();
        void GirarIzquierda();
        void GirarDerecha();
        void ObtenerVelocidad();
    }
}
