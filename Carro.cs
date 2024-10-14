using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    internal class Carro : VehiculoTerrestre
    {
        public Carro()
        {
            Nombre = "Carro";
        }

        public override void AumentarVelocidad()
        {
            enTransito = true;
            velocidad += 15;
            GestorMensajes.Imprimir($"¡Tu {Nombre} ha aumentado su velocidad!");
        }

        public override void DisminuirVelocidad()
        {
            if (EstaEnTransito())
            {
                velocidad -= 7;
                if (velocidad < 0) velocidad = 0;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha disminuido su velocidad!");
            }
        }
    }
}
