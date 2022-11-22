namespace Patron.Prototype
{
    class CCelular : IPrototipo
    {
        private string modelo;
        private int year;
        private int costo;


        public string Modelo { get => modelo; set => modelo = value; }

        public CCelular(string pModelo, int pYear, int pCosto)
        {
            modelo = pModelo;
            year = pYear;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", modelo, year, costo);
        }
        public object Clonar()
        {
            CCelular clon = new CCelular(modelo, year, costo);

            return clon;
        }
    }
}