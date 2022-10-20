namespace MetodoFabrica02
{
    internal class Bici : IVehiculo
    {
        public void Acelera()
        {
            Console.WriteLine("Tan rapido como pedalees");
        }

        public void Encender()
        {
            Console.WriteLine("Las bicis no encienden");
        }


        public void Frena()
        {
            Console.WriteLine("Tan rapido como pongas el zapato");
        }

        public void Gira()
        {
            Console.WriteLine("Completamente 360°");
        }
    }
}