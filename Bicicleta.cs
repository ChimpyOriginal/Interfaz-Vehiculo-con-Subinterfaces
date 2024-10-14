using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    internal class Bicicleta : VehiculoTerrestre
    {
        public Bicicleta()
        {
            Nombre = "Bicicleta";
        }

        public override void AumentarVelocidad()
        {
            enTransito = true;
            velocidad += 5;
            GestorMensajes.Imprimir($"¡Tu {Nombre} ha aumentado su velocidad! ¡Cuida que no venga ningún carro!");
        }

        public override void DisminuirVelocidad()
        {
            if (EstaEnTransito())
            {
                velocidad -= 3;
                if (velocidad < 0) velocidad = 0;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha disminuido su velocidad!");
            }
        }
    }
}
