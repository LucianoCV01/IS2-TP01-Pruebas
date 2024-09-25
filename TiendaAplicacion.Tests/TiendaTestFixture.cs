//Punto 4
using NUnit.Framework;
using TiendaAplicacion;
using TiendaAplicacion.Tests.Fixtures;

[TestFixture]
public class TiendaTestsFixture
{
    private TiendaFixture _fixture;

    [SetUp]
    public void Setup()
    {
        _fixture = new TiendaFixture(); // Inicializa el fixture antes de cada prueba
    }

    [Test]
    public void TestAgregarProducto()
    {
        // Arrange
        var nuevoProducto = new Producto("Silla", 80, "Muebles");

        // Act
        _fixture.Tienda.AgregarProducto(nuevoProducto);

        // Assert
        var productoBuscado = _fixture.Tienda.BuscarProducto("Silla");
        Assert.IsNotNull(productoBuscado);
        Assert.AreEqual("Silla", productoBuscado.Nombre);
    }

    [Test]
    public void TestBuscarProductoExistente()
    {
        // Act
        var productoBuscado = _fixture.Tienda.BuscarProducto("Laptop");

        // Assert
        Assert.IsNotNull(productoBuscado);
        Assert.AreEqual("Laptop", productoBuscado.Nombre);
    }

    [Test]
    public void TestBuscarProductoInexistente()
    {
        // Act
        var productoBuscado = _fixture.Tienda.BuscarProducto("Cama");

        // Assert
        Assert.IsNull(productoBuscado);
    }
    [Test]
    public void TestCalcularTotalCarrito()
    {
        // Arrange
        var carrito = new List<string> { "Laptop", "Teléfono" };

        // Act
        var total = _fixture.Tienda.CalcularTotalCarrito(carrito);

        // Assert
        Assert.AreEqual(1500, total); // 1000 + 500
    }
    [Test]
    public void TestCalcularTotalCarritoConProductoInexistente()
    {
        // Arrange
        var carrito = new List<string> { "Laptop", "Teléfono", "Cama" };

        // Act
        var total = _fixture.Tienda.CalcularTotalCarrito(carrito);

        // Assert
        Assert.AreEqual(1500, total); // 1000 + 500 + 0 (Cama no existe)
    }
    [Test]
    public void TestCalcularTotalCarritoConDescuento()
    {
        // Arrange
        var carrito = new List<string> { "Laptop", "Teléfono" };

        // Aplicar un descuento manualmente
        var producto = _fixture.Tienda.BuscarProducto("Laptop");
        producto.Precio = producto.Precio * (decimal)0.9; // Aplicar un 10% de descuento

        // Act
        var total = _fixture.Tienda.CalcularTotalCarrito(carrito);

        // Assert
        Assert.AreEqual(1400, total); // (1000 * 0.9) + 500
    }
}
