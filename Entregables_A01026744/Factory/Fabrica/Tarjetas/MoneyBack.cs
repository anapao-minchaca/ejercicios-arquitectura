namespace MetodoFabrica02
{
    internal class MoneyBack : ITarjeta
    {
        public void CardType()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("La tarjeta es de tipo MoneyBack");
        }

        public void CreditLimit()
        {
            Console.WriteLine("Tiene un limite de 15000 dolares");
        }

        public void AnnualCharge()
        {
            Console.WriteLine("El cargo anual es de 500 dolares");
        }
    }
}