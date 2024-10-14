using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    public abstract class VehiculoAcuatico : IVehiculoAcuatico
    {
        public string Nombre { get; set; }
        protected int velocidad;
        protected bool enNavegacion;

        public abstract void AumentarVelocidad();
        public abstract void DisminuirVelocidad();

        public void GirarIzquierda()
        {
            if (EstaEnNavegacion())
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha girado a la izquierda! Cuidado con las olas.");
        }

        public void GirarDerecha()
        {
            if (EstaEnNavegacion())
                GestorMensajes.Imprimir($"¡Tu {Nombre} ha girado a la derecha! Cuidado con las olas.");
        }

        public void ObtenerVelocidad()
        {
            GestorMensajes.Imprimir($"¡Tu {Nombre} va a la velocidad de {velocidad} km/h!");
        }

        protected bool EstaEnNavegacion()
        {
            if (enNavegacion)
                return true;

            GestorMensajes.Imprimir($"¡Tu {Nombre} no está en el agua aún o está inmovilizado :c!");
            return false;
        }

        public void Anclarse()
        {
            enNavegacion = false;
            velocidad = 0;
            GestorMensajes.Imprimir($"¡Tu {Nombre} ahora está anclado, tranquilo que no irá a ningún lado.");
        }

        public void Desanclarse()
        {
            enNavegacion = true;
            GestorMensajes.Imprimir($"Tu {Nombre} ya no está anclado, puedes seguir navegando libremente.");
        }

        public void Atracar()
        {
            enNavegacion = false;
            velocidad = 0;
            GestorMensajes.Imprimir($"Tu {Nombre} ha sido atracado, ¡espero hayas tenido un buen viaje!");
        }

        public void BotarAlAgua()
        {
            enNavegacion = true;
            velocidad = 0;
            GestorMensajes.Imprimir($"Tu {Nombre} ahora está en el agua, ¿listo para tu viaje? :D.");
        }
    }
}
