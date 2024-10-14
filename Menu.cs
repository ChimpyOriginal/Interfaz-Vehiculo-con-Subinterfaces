using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Vehiculo_con_Subinterfaces
{
    internal class Menu
    {
        private List<Opcion> menuPrincipal;
        private List<Opcion> VehiculoAereo;
        private List<Opcion> VehiculoTerrestre;
        private List<Opcion> VehiculoAcuatico;
        private IVehiculo vehiculo = null;

        public Menu()
        {

            menuPrincipal = new List<Opcion>()
            {
                new Opcion("Carro", () => { vehiculo = new Carro(); MostrarSubMenu(VehiculoTerrestre); }),
                new Opcion("Bicicleta", () => { vehiculo = new Bicicleta(); MostrarSubMenu(VehiculoTerrestre); }),
                new Opcion("Avion", () => { vehiculo = new Avion(); MostrarSubMenu(VehiculoAereo); }),
                new Opcion("Helicóptero", () => { vehiculo = new Helicoptero(); MostrarSubMenu(VehiculoAereo); }),
                new Opcion("Lancha pesquera", () => { vehiculo = new Lancha(); MostrarSubMenu(VehiculoAcuatico); }),
                new Opcion("Barco", () => { vehiculo = new Barco(); MostrarSubMenu(VehiculoAcuatico); }),
                new Opcion("Salir", () => Environment.Exit(0))
            };

            VehiculoTerrestre = new List<Opcion>()
            {
            new Opcion("Aumentar la velocidad", () => {vehiculo.AumentarVelocidad(); }),
            new Opcion("Disminuir la velocidad", () => {vehiculo.DisminuirVelocidad(); }),
            new Opcion("Girar a la izquierda", () => {vehiculo.GirarIzquierda(); }),
            new Opcion("Girar a la derecha", () => {vehiculo.GirarDerecha(); }),
            new Opcion("Obtener velocidad", () => {vehiculo.ObtenerVelocidad(); }),
            new Opcion("Tocar claxon", () => { ((VehiculoTerrestre)vehiculo).TocarClaxon();}),
            new Opcion("Frenar", () => { ((VehiculoTerrestre)vehiculo).Frenar();}),
            new Opcion("Encender luces", () => { ((VehiculoTerrestre)vehiculo).EncenderLuces();}),
            new Opcion("Regresar al menú principal", () => MostrarMenuPrincipal())
            };

            VehiculoAereo = new List<Opcion>()
            {
            new Opcion("Aumentar la velocidad", () => {vehiculo.AumentarVelocidad(); }),
            new Opcion("Disminuir la velocidad", () => {vehiculo.DisminuirVelocidad(); }),
            new Opcion("Girar a la izquierda", () => {vehiculo.GirarIzquierda(); }),
            new Opcion("Girar a la derecha", () => {vehiculo.GirarDerecha(); }),
            new Opcion("Obtener velocidad", () => {vehiculo.ObtenerVelocidad(); }),
            new Opcion("Incrementar Altitud", () => { ((VehiculoAereo)vehiculo).IncrementarAltitud();}),
            new Opcion("Disminuir Altitud", () => { ((VehiculoAereo)vehiculo).DisminuirAltitud();}),
            new Opcion("Obtener Altitud", () => { ((VehiculoAereo)vehiculo).ObtenerAltitud();}),
            new Opcion("Despegar", () => { ((VehiculoAereo)vehiculo).Despegar();}),
            new Opcion("Aterrizar", () => { ((VehiculoAereo)vehiculo).Aterrizar();}),
            new Opcion("Regresar al menú principal", () => MostrarMenuPrincipal())
            };

            VehiculoAcuatico = new List<Opcion>()
            {
            new Opcion("Aumentar la velocidad", () => {vehiculo.AumentarVelocidad(); }),
            new Opcion("Disminuir la velocidad", () => {vehiculo.DisminuirVelocidad(); }),
            new Opcion("Girar a la izquierda", () => {vehiculo.GirarIzquierda(); }),
            new Opcion("Girar a la derecha", () => {vehiculo.GirarDerecha(); }),
            new Opcion("Obtener velocidad", () => {vehiculo.ObtenerVelocidad(); }),
            new Opcion("Anclar", () => { ((VehiculoAcuatico)vehiculo).Anclarse();}),
            new Opcion("Desanclar", () => { ((VehiculoAcuatico)vehiculo).Desanclarse();}),
            new Opcion("Atracar", () => { ((VehiculoAcuatico)vehiculo).Atracar();}),
            new Opcion("Botar al agua", () => { ((VehiculoAcuatico)vehiculo).BotarAlAgua();}),
            new Opcion("Regresar al menú principal", () => MostrarMenuPrincipal())
            };

            MostrarMenuPrincipal();
        }

        public void MostrarMenu(List<Opcion> opciones)
        {
            for (int i = 0; i < opciones.Count; i++)
            {
                GestorMensajes.Imprimir((i + 1) + ". " + opciones[i].Message);
            }
        }

        public void ElegirOpcion(List<Opcion> opciones)
        {
            Console.Write("\nElige una opción: ");
            int numOpcion = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numOpcion >= 0 && numOpcion < opciones.Count)
            {
                Console.Clear();
                opciones[numOpcion].Action.Invoke();
            }
            else
            {
                GestorMensajes.Imprimir("\nOpción no válida. Por favor, elige una opción válida.");
            }

            Continuar();
        }

        private void MostrarSubMenu(List<Opcion>menuVehiculo)
        {
            while (true)
            {
                Console.Clear();
                GestorMensajes. Imprimir("¿Qué deseas hacer con tu vehículo?");
                MostrarMenu(menuVehiculo);
                ElegirOpcion(menuVehiculo);
            }
        }

        private void MostrarMenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                GestorMensajes.Imprimir("LISTA DE VEHÍCULOS:");
                MostrarMenu(menuPrincipal);
                ElegirOpcion(menuPrincipal);
            }
        }

        private static void Continuar()
        {
            GestorMensajes.Imprimir("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
