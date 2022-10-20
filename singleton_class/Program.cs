// Singleton es un patrón de diseño creacional
// que nos permite asegurarnos de que una clase tenga una única instancia
// a la vez que proporciona un punto de acceso global a dicha instancia.

// Utilice el patrón Singleton cuando una clase de su programa deba tener una única instancia disponible para todos los clientes; 
// por ejemplo, un solo objeto de base de datos compartido por diferentes partes del programa.

// Utilice el patrón Singleton cuando necesite un control más estricto sobre las variables globales.

namespace Patrones
{
    class MainApp
    {
        static void Main()
        {
            Singleton? s1 = Singleton.Instance();
            Singleton? s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Son iguales");
            }
        }
    }

    internal class Singleton
    {
        internal static Singleton? _instance;
        internal static Singleton? Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                Console.WriteLine("Guardando la sesión por primera vez");
            }
            return _instance;
        }
    }
}

