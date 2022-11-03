using static Builder03.IMotor;

namespace Builder03
{
    internal class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();
        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public void ConstrulleLLantas()
        {
            auto.ColocarLlantas(new llantasSuper());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        internal Producto ObtenProducto()
        {
            return auto;
        }
    }
}