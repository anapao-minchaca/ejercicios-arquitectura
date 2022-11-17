namespace Patrones.AbstractFactory
{
    class Cacao : IProductoIngrediente
    {
        public string informacion()
        {
            return "Cacao orgánico";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce CacacoSD23");
        }
    }
}