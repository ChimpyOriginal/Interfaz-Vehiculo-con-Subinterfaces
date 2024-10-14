using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public abstract class VehiculoTerrestre : IVehiculoTerrestre
    {
        public string Nombre { get; set; }
        protected int velocidad;
        protected bool enTransito;

        public abstract void AumentarVelocidad();
        public abstract void DisminuirVelocidad();

        public void GirarIzquierda()
        {
            if (EstaEnTransito())
            {
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha girado a la izquierda!... ¿Esa vuelta está permitida?");
            }
        }

        public void GirarDerecha()
        {
            if (EstaEnTransito())
            {
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha girado a la derecha!... ¿Esa vuelta está permitida?");
            }
        }
        protected bool EstaEnTransito()
        {
            if (enTransito)
                return true;

            GestorMensajes.Imprimir($"¡Tu {Nombre} no está en tránsito aún o está detenido :c!");
            return false;
        }
        public void ObtenerVelocidad()
        {
            GestorMensajes.Imprimir($"Tu {Nombre} va a la velocidad de {velocidad} km/h");
        }

        public void Frenar()
        {
            enTransito = false;
            velocidad = 0;
            GestorMensajes.Imprimir($"Tu {Nombre} ha frenado por completo.");
        }

        public void TocarClaxon()
        {
            GestorMensajes.Imprimir("PI PIIIIIIII");
        }

        public void EncenderLuces()
        {
            GestorMensajes.Imprimir($"Tu {Nombre} ha prendido las luces.");
        }
    }
}
