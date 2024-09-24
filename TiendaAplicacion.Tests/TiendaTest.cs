/*public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}*/
using NUnit.Framework;
using TiendaAplicacion;

namespace TiendaAplicacion.Tests
{
    public class TiendaTests
    {
        private Tienda _tienda;
        private Producto _producto;

        [SetUp] /*Se ejecuta antes de cada prueba para configurar un estado inicial.*/

        public void Setup()
        {
            _tienda = new Tienda();
            _producto = new Producto("Laptop", 1000, "Electrónica");
        }

        [Test]
        public void TestAgregarProducto()
        {
            _tienda.AgregarProducto(_producto);
            // Verificar que el producto se haya agregado correctamente
            var encontrado = _tienda.BuscarProducto("Laptop");
            Assert.IsNotNull(encontrado);
            Assert.AreEqual(_producto, encontrado);
        }

        [Test]
        public void TestBuscarProductoExistente()
        {
            // Arrange
            _tienda.AgregarProducto(_producto);

            // Act
            var productoEncontrado = _tienda.BuscarProducto("Laptop");

            // Assert
            Assert.NotNull(productoEncontrado);
            Assert.AreEqual(_producto, productoEncontrado);
        }

        [Test]
        public void TestBuscarProductoNoExistente()
        {
            // Act
            var productoNoEncontrado = _tienda.BuscarProducto("Tablet");

            // Assert
            Assert.IsNull(productoNoEncontrado);
        }

        [Test]
        public void TestEliminarProductoExistente()
        {
            // Arrange
            _tienda.AgregarProducto(_producto);

            // Act
            var eliminado = _tienda.EliminarProducto("Laptop");
            var productoEncontrado = _tienda.BuscarProducto("Laptop");

            // Assert
            Assert.IsNull(productoEncontrado);
        }
        [Test]
        public void TestEliminarProductoNoExistente()
        {
            var eliminado = _tienda.EliminarProducto("Cámara");
            Assert.IsFalse(eliminado);
        }
    }
}
/*Assert.NotNull, Assert.AreEqual, y Assert.IsNull: 
Aserciones para verificar los resultados esperados.*/
