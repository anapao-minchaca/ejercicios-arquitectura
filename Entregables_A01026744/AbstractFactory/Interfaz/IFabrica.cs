namespace Patrones.AbstractFactory
{
    interface IFabrica
    {
        void crearProducto();
        IProductosAceites ObtenerAceite { get; }
        IProductoIngrediente ObtenerIngrediente { get; }

    }
}