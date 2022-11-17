namespace Patron.Prototype
{
    class CPersona : IPrototipo
    {

        private string nombre;
        private string departamento;

        public string Nombre { get => nombre; set => nombre = value; }

        public CPersona(string pNombre, string pDepartamento)
        {
            nombre = pNombre;
            departamento = pDepartamento;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, departamento);
        }
        public object Clonar()
        {
            CPersona clon = new CPersona(nombre, departamento);

            return clon;
        }
    }
}