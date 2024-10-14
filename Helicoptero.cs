using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public class Helicoptero : VehiculoAereo
    {
        public Helicoptero()
        {
            Nombre = "Helicóptero";
        }

        public override void AumentarVelocidad()
        {
            if (EstaEnVuelo())
            {
                velocidad += 200;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha aumentado su velocidad!");
            }
        }

        public override void DisminuirVelocidad()
        {
            if (EstaEnVuelo())
            {
                velocidad -= 100;
                if (velocidad < 0) velocidad = 0;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha disminuido su velocidad!");
            }
        }

        public override void IncrementarAltitud()
        {
            if (EstaEnVuelo())
            {
                altitud += 1000;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha incrementado su altitud! ¡Agárrate fuerte!");
            }
        }

        public override void DisminuirAltitud()
        {
            if (EstaEnVuelo())
            {
                altitud -= 1000;
                if (altitud < 0) altitud = 0;
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha disminuido su altitud!");
            }
        }
    }
}
