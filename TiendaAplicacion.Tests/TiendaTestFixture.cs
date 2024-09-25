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
        var nuevoProducto = new Producto("Silla", 80m, "Muebles");

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
}
