using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public class Barco : VehiculoAcuatico
    {
        public Barco()
        {
            Nombre = "Barco";
        }

        public override void AumentarVelocidad()
        {
            if (EstaEnNavegacion())
            {
                velocidad += 30;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha aumentado su velocidad!");
            }
        }

        public override void DisminuirVelocidad()
        {
            if (EstaEnNavegacion())
            {
                velocidad -= 10;
                if (velocidad < 0) velocidad = 0;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha disminuido su velocidad!");
            }
        }
    }
}
