namespace Patrones.AbstractFactory
{
    class FabricaNatural : IFabrica
    {
        private IProductosAceites aceite;
        private IProductoIngrediente ingrediente;
        public IProductosAceites ObtenerAceite
        {
            get { return aceite; }
        }

        public IProductoIngrediente ObtenerIngrediente
        {
            get { return ingrediente; }
        }

        public void crearProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string selection = "";
            Console.WriteLine("Estamos creando tu maquillaje");
            Console.WriteLine("1) Almendra\n2) Coco\n");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                aceite = new AceiteAlmendra();
            }
            else
            {
                aceite = new AceiteCoco();
            }
            aceite.producir();
            Console.WriteLine("Ahora extraemos el ingrediente");
            ingrediente = new Betabel();
            ingrediente.obtener();
        }
    }
}