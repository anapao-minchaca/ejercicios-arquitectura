namespace Patrones.AbstractFactory
{
    class AceiteAlmendra : IProductosAceites
    {
        public string obtenerDatos()
        {
            return "Aceite de almendras dulces, 15ml";
        }

        public void producir()
        {
            Console.WriteLine("Procesar las almendras");
        }
    }
}