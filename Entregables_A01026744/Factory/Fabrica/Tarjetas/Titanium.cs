namespace MetodoFabrica02
{
    internal class Titanium : ITarjeta
    {
        public void CardType()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("La tarjeta es de tipo Titanium Edge");
        }

        public void CreditLimit()
        {
            Console.WriteLine("Tiene un limite de 25000 dolares");
        }

        public void AnnualCharge()
        {
            Console.WriteLine("El cargo anual es de 1500 dolares");
        }
    }
}