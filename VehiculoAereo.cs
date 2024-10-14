using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public abstract class VehiculoAereo : IVehiculoAereo
    {
        public string Nombre { get; set; }
        protected int velocidad;
        protected int altitud;
        protected bool enVuelo;

        public abstract void AumentarVelocidad();
        public abstract void DisminuirVelocidad();
        public abstract void IncrementarAltitud();
        public abstract void DisminuirAltitud();


        public void GirarIzquierda()
        {
            if (EstaEnVuelo())
            {
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha girado a la izquierda! Acabas de atravesar una gran nube.");
            }
        }

        public void GirarDerecha()
        {
            if (EstaEnVuelo())
            {
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha girado a la derecha! Acabas de atravesar una gran nube.");
            }
        }
        protected bool EstaEnVuelo()
        {
            if (enVuelo)
                return true;

            GestorMensajes.Imprimir($"¡Tu {Nombre} no está en el aire aún!");
            return false;
        }
        public void ObtenerVelocidad()
        {
            GestorMensajes.Imprimir($"Tu {Nombre} va a la velocidad de {velocidad} km/h");
        }

        public void ObtenerAltitud()
        {
            GestorMensajes.Imprimir($"Tu {Nombre} va a {altitud} ft de altitud");
        }

        public void Aterrizar()
        {
            velocidad = 0;
            enVuelo = false;
            GestorMensajes.Imprimir($"Tu {Nombre} ha aterrizado, ¡espero hayas tenido un buen viaje!");
        }

        public void Despegar()
        {
            enVuelo = true;
            velocidad = 250; 
            GestorMensajes.Imprimir($"¡Tu {Nombre} ha despegado! Ojalá no tengas miedo a las alturas.");
        }
    }
}
