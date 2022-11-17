namespace Patrones.AbstractFactory
{
    class Program
    {

        // Ejemplo de Abstract factory con distintas fábricas de maquillaje
        static void Main(string[] args)
        {
            // Fabrica 1
            IFabrica mifabrica = new FabricaQuimica();
            mifabrica.crearProducto();

            IProductosAceites _aceite_ = mifabrica.ObtenerAceite;
            IProductoIngrediente _ingrediente_ = mifabrica.ObtenerIngrediente;

            _aceite_.producir();
            _aceite_.obtenerDatos();

            Console.WriteLine("* Mi rubor es de {0} y {1}", _aceite_.obtenerDatos(), _ingrediente_.informacion());
            Console.WriteLine("---");
            
            // Fabrica 2
            mifabrica = new FabricaNatural();
            mifabrica.crearProducto();

            _aceite_ = mifabrica.ObtenerAceite;
            _ingrediente_ = mifabrica.ObtenerIngrediente;

            _aceite_.producir();
            _aceite_.obtenerDatos();

            Console.WriteLine("* Mi rubor es de {0} y {1}", _aceite_.obtenerDatos(), _ingrediente_.informacion());
        }
    }
}
