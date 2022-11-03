// dotnet run -- ruben

// Builder es un patrón de diseño creacional que nos permite construir objetos complejos paso a paso. 
// El patrón nos permite producir distintos tipos y representaciones de un objeto empleando el mismo 
// código de construcción.

namespace Builder03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join('-', args));
            Director miDirector = new Director();
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);
            Producto auto1 = normal.ObtenProducto();
            auto1.MostrarAuto();            
        }
    }
}