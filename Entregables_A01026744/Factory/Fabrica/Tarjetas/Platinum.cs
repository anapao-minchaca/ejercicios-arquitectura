namespace MetodoFabrica02
{
    internal class Platinum : ITarjeta
    {
        public void CardType()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("La tarjeta es de tipo Platinum Plus");
        }

        public void CreditLimit()
        {
            Console.WriteLine("Tiene un limite de 35000 dolares");
        }

        public void AnnualCharge()
        {
            Console.WriteLine("El cargo anual es de 2000 dolares");
        }
    }
}