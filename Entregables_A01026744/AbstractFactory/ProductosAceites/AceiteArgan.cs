namespace Patrones.AbstractFactory
{
    class AceiteMineral : IProductosAceites
    {
        public string obtenerDatos()
        {
            return "Aceite mineral, 20ml";
        }

        public void producir()
        {
            Console.WriteLine("Destilando el petróleo crudo");
        }
    }
}