using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public class Lancha : VehiculoAcuatico
    {
        public Lancha()
        {
            Nombre = "Lancha pesquera";
        }
        public override void AumentarVelocidad()
        {
            if (EstaEnNavegacion())
            {
                velocidad += 15;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha aumentado su velocidad! ¡Vamos por esos peces!");
            }
        }
        public override void DisminuirVelocidad()
        {
            if (EstaEnNavegacion())
            {
                velocidad -= 7;
                if (velocidad < 0) velocidad = 0;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha disminuido su velocidad!");
            }
        }

    }
}
