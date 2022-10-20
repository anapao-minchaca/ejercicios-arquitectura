// Factory Method es un patrón de diseño creacional que proporciona una interfaz para crear objetos
// en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crearán.

namespace MetodoFabrica02
{
    class Program
    {
        static void Main(string[] args){
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("¿Cuánto dinero tienes?");
            dato = Console.ReadLine();
            // dato = "100000";
            dinero = Convert.ToInt32(dato);
            vehiculo = Creador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelera();
            vehiculo.Frena();
            vehiculo.Gira();
        }
    }
}