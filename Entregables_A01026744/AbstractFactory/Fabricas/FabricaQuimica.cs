namespace Patrones.AbstractFactory
{
    class FabricaQuimica : IFabrica
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
            Console.WriteLine("Estamos produciendo tu rubor");
            aceite = new AceiteMineral();
            ingrediente = new Cacao();
        }
    }
}