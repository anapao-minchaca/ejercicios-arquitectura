namespace Patrones.AbstractFactory
{
    class AceiteCoco : IProductosAceites
    {
        public string obtenerDatos()
        {
            return "Aceite de coco, 10ml";
        }

        public void producir()
        {
            Console.WriteLine("Extraer pulpa de coco");
        }
    }
}