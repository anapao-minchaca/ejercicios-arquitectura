namespace Builder03
{
    internal class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        internal void ColocarMotor(IMotor _motor)
        {
            motor = _motor;
            Console.WriteLine("Se ha colocado el motor {0} ", motor);
        }

        internal void ColocarCarroceria(ICarroceria _carrorecia)
        {
            carroceria = _carrorecia;
            Console.WriteLine("Se ha colocado la carroceria {0} ", carroceria);
        }

        internal void ColocarLlantas(ILlantas _llantas)
        {
            llantas = _llantas;
            Console.WriteLine("Se han colocado las llantas {0} ", _llantas);
        }

        internal void MostrarAuto()
        {
            Console.WriteLine("motor: {0}", motor);
            Console.WriteLine("carroceria: {0}", carroceria);
            Console.WriteLine("llantas: {0}", llantas);
        }
    }
}