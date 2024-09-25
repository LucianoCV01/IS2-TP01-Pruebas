//Punto 4
using TiendaAplicacion;
namespace TiendaAplicacion.Tests.Fixtures;
public class TiendaFixture
{
    public Tienda Tienda { get; private set; }

    public TiendaFixture()
    {
        Tienda = new Tienda();
        Tienda.AgregarProducto(new Producto("Laptop", 1000, "Electrónica"));
        Tienda.AgregarProducto(new Producto("Teléfono", 500, "Electrónica"));
        Tienda.AgregarProducto(new Producto("Mesa", 150, "Muebles"));
    }
}
