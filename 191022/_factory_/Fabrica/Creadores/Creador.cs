namespace MetodoFabrica02
{
    internal class Creador
    {
        internal static IVehiculo MetodoFabrica(int dinero)
        {
            IVehiculo _vehiculo = null;
            if (dinero > 1000){
                _vehiculo = new Carro();
            }
            if (dinero < 500){
                _vehiculo = new Bici();
            }
            return _vehiculo;
        }
    }
}