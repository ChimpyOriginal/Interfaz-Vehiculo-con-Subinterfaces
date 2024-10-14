namespace Interfaz_Vehiculo_con_Subinterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            try
            {
                Menu menu = new Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
//terrestre: 