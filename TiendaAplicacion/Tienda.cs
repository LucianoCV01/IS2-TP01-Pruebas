using System.Collections.Generic;

namespace TiendaAplicacion
{
    public class Tienda
    {
        private readonly Dictionary<string, Producto> _inventario = new();

        public void AgregarProducto(Producto producto)
        {
            _inventario[producto.Nombre] = producto;
        }

        public Producto BuscarProducto(string nombre)
        {
            _inventario.TryGetValue(nombre, out var producto);
            return producto;
        }

        public bool EliminarProducto(string nombre)
        {
            var producto = BuscarProducto(nombre);
            if (producto != null)
            {
                _inventario.Remove(producto.Nombre);
                return true;
            }   
            return false;
        }
    }
}
