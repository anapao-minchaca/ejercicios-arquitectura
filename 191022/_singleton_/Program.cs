// Singleton es un patrón de diseño creacional
// que nos permite asegurarnos de que una clase tenga una única instancia
// a la vez que proporciona un punto de acceso global a dicha instancia.

// Utilice el patrón Singleton cuando una clase de su programa deba tener una única instancia disponible para todos los clientes; 
// por ejemplo, un solo objeto de base de datos compartido por diferentes partes del programa.

// Utilice el patrón Singleton cuando necesite un control más estricto sobre las variables globales.

// dotnet new console => proyecto con el nombre de la carpeta
// dotnet new console -o singleton => proyecto con el nombre que le demos

// crear un espacio de trabajo
namespace PatronSingleton
{
    class Program {
    #region CreacionDelPrimerPatron
        static void Main(string[] args)
        {
            Singleton _singleton1 = Singleton.ObtenerInstancia();
            _singleton1.PonerDatos("Ana", 23);
            _singleton1.AlgunProceso();

            Singleton _singleton2 = Singleton.ObtenerInstancia();
            _singleton2.PonerDatos("Sandy", 26);
            _singleton2.AlgunProceso();
        }
    }
    #endregion CreacionDelPrimerPatron
}

