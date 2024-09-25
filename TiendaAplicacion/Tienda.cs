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

        //punto 3
        public void AplicarDescuento(string nombre, decimal porcentaje)
        {
            if (porcentaje < 0 || porcentaje > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(porcentaje), "El porcentaje debe estar entre 0 y 100.");
            }

            var producto = BuscarProducto(nombre);
            producto.ActualizarPrecio(producto.Precio * (1 - porcentaje / 100));
        }

        //Punto 5
        public decimal CalcularTotalCarrito(List<string> nombresProductos)
        {
            decimal total = 0;
            foreach (var nombre in nombresProductos)
            {
                var producto = BuscarProducto(nombre);
                if (producto != null)
                {
                    total += producto.Precio;
                }
            }
            return total;
        }
    }
}
