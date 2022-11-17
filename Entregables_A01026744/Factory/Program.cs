namespace MetodoFabrica02
{
    // Este es un ejemplo de Factory Method con tipos de tarjetas según seleccione el usuario
    class Program
    {
        static void Main(string[] args){
            string dato;
            ITarjeta tarjeta;

            Console.WriteLine("¿Qué tarjeta quieres?");
            Console.WriteLine("MoneyBack, Titanium o Platinum");
            dato = Console.ReadLine();
            tarjeta = Creador.MetodoFabrica(dato);

            tarjeta.CardType();
            tarjeta.CreditLimit();
            tarjeta.AnnualCharge();
        }
    }
}