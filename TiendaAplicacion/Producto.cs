namespace TiendaAplicacion
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto(string nombre, decimal precio, string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"Producto(Nombre={Nombre}, Precio={Precio}, Categoria={Categoria})";
        }

        //Punto 2: nuevo metodo
        public virtual void ActualizarPrecio(decimal nuevoPrecio) //punto 3 agregar virtual para usar moq
        {
            if (nuevoPrecio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(nuevoPrecio), "El precio no puede ser negativo.");
            }
            Precio = nuevoPrecio;
        }
    }
}