namespace MetodoFabrica02
{
    internal class Creador
    {
        internal static ITarjeta MetodoFabrica(string tarjeta)
        {
            ITarjeta _tarjeta = null;

            if (tarjeta == "MoneyBack"){
                _tarjeta = new MoneyBack();
            }
            else if (tarjeta == "Platinum"){
                _tarjeta = new Platinum();
            }
            else if (tarjeta == "Titanium"){
                _tarjeta = new Titanium();
            }
            return _tarjeta;
        }
    }
}