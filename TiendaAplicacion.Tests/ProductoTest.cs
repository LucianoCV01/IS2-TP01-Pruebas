using NUnit.Framework;
using TiendaAplicacion;

namespace TiendaAplicacion.Tests
{
    [TestFixture]
    public class ProductoTest
    {
        private Producto producto;

        [SetUp]
        public void SetUp()
        {
            producto = new Producto("Laptop", 1000m, "Electrónica");
        }

        [Test]
        public void TestProductoInicializaCorrectamente()
        {
            Assert.AreEqual("Laptop", producto.Nombre);
            Assert.AreEqual(1000m, producto.Precio);
            Assert.AreEqual("Electrónica", producto.Categoria);
        }

        [Test]
        public void TestActualizarPrecioValido()
        {
            // Act
            producto.ActualizarPrecio(800m);

            // Assert
            Assert.AreEqual(800m, producto.Precio);
        }

        [Test]
        public void TestActualizarPrecioNegativoLanzaExcepcion()
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => producto.ActualizarPrecio(-500m));
            Assert.That(ex.Message, Contains.Substring("El precio no puede ser negativo."));
        }

        [Test]
        public void TestActualizarPrecioCero()
        {
            // Act
            producto.ActualizarPrecio(0m);

            // Assert
            Assert.AreEqual(0m, producto.Precio);
        }
    }
}