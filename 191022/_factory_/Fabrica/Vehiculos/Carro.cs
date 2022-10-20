namespace MetodoFabrica02
{
    internal class Carro : IVehiculo
    {
        public void Acelera()
        {
            Console.WriteLine("El carro puede acelerar");
        }

        public void Encender()
        {
            Console.WriteLine("El carro puede encender");
        }


        public void Frena()
        {
            Console.WriteLine("El carro puede frenar");
        }

        public void Gira()
        {
            Console.WriteLine("El carro puede girar");
        }
    }
}