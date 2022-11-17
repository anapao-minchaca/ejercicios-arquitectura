namespace Patrones.AbstractFactory
{
    class Betabel : IProductoIngrediente
    {
        public string informacion()
        {
            return "Betabel orgánico";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce Betabel12WER");
        }
    }
}