namespace PatronSingleton
{
    internal class Singleton 
    {
        private static Singleton instancia;
        private string nombre;
        private int edad;

        private Singleton()
        {
            nombre = "--";
            edad = 0;
        }

        internal static Singleton ObtenerInstancia()
        {
            if (instancia == null){
                instancia = new Singleton();
                Console.WriteLine("Conectando a la base de datos");
            }
            else {
                Console.WriteLine("Hay una conexión activa, no es necesario volver a conectarte");
            }

            return instancia;
        }

        internal void PonerDatos(string _nombre, int _edad)
        {
            nombre = _nombre;
            edad = _edad;
        }

        internal void AlgunProceso()
        {
            Console.WriteLine("Buscando en la BD a {0}", nombre);
            Console.WriteLine("{0} se encuentra disponible para asesorias los martes", nombre);
        }
    }
}