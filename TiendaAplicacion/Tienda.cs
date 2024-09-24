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

        /*
        public Producto BuscarProducto(string nombre)
        {
            _inventario.TryGetValue(nombre, out var producto);
            return producto;
        }*/
        //Punto 2: modificacion para lanzar excepciones
        public Producto BuscarProducto(string nombre)
        {
            if (!_inventario.TryGetValue(nombre, out var producto))
            {
                throw new KeyNotFoundException($"El producto '{nombre}' no se encontró.");
            }
            return producto;
        }
        /*
        public bool EliminarProducto(string nombre)
        {
            var producto = BuscarProducto(nombre);
            if (producto != null)
            {
                _inventario.Remove(producto.Nombre);
                return true;
            }   
            return false;
        }*/
        //Punto 2: modificacion para lanzar excepciones
        public bool EliminarProducto(string nombre)
        {
            if (!BuscarProducto(nombre).Equals(null))
            {
                _inventario.Remove(nombre);
                return true;
            }
            throw new KeyNotFoundException($"No se puede eliminar el producto '{nombre}' porque no existe.");
        }
    }
}
