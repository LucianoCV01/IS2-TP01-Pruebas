using NUnit.Framework;
using TiendaAplicacion;
using Moq;

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
            //_producto = new Producto("Laptop", 1000, "Electrónica");
        }

        /*[Test]
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
        }*/

        /*Punto 1:
        [Test]
        public void TestBuscarProductoNoExistente()
        {
            // Act
            var productoNoEncontrado = _tienda.BuscarProducto("Tablet");

            // Assert
            Assert.IsNull(productoNoEncontrado);
        }*/
        //Punto 2: lanzar exepcion si el producto no existe
        /*[Test]
        public void TestBuscarProductoNoExistente()
        {
            var ex = Assert.Throws<KeyNotFoundException>(() => _tienda.BuscarProducto("Cámara"));
            Assert.That(ex.Message, Is.EqualTo("El producto 'Cámara' no se encontró."));
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
        }*/
        /* Punto 1:
        [Test]
        public void TestEliminarProductoNoExistente()
        {
            var eliminado = _tienda.EliminarProducto("Cámara");
            Assert.IsFalse(eliminado);
        }*/
        //Punto 2: lanzar exepcion si intenta eliminar un producto que no existe
        /*[Test]
        public void TestEliminarProductoNoExistente()
        {
            var ex = Assert.Throws<KeyNotFoundException>(() => _tienda.EliminarProducto("Cámara"));
            Assert.That(ex.Message, Is.EqualTo("No se puede eliminar el producto 'Cámara' porque no existe."));
        }
        //Punto 2: nuevo test para lanzar excepcion
        [Test]
        public void TestActualizarPrecioNegativoLanzaExcepcion()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _producto.ActualizarPrecio(-500));
            Assert.That(ex.Message, Contains.Substring("El precio no puede ser negativo."));
        }*/

        //punto 3

        [Test]
        public void TestAplicarDescuentoCalculaNuevoPrecio()
        {
            // Arrange
            var productoMock = new Mock<Producto>("Laptop", 1000m, "Electrónica");
            _tienda.AgregarProducto(productoMock.Object);

            // Act
            _tienda.AplicarDescuento("Laptop", 10); // Aplicamos un 10% de descuento

            // Assert
            // Verificamos que se haya llamado a ActualizarPrecio con el nuevo precio
            productoMock.Verify(p => p.ActualizarPrecio(900), Times.Once);
        }

        [Test]
        public void TestAplicarDescuentoFueraDeRangoLanzaExcepcion()
        {
            // Arrange
            _tienda.AgregarProducto(new Producto("Laptop", 1000m, "Electrónica"));

            // Act & Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _tienda.AplicarDescuento("Laptop", 110));
            Assert.That(ex.Message, Is.EqualTo("El porcentaje debe estar entre 0 y 100. (Parameter 'porcentaje')"));
        }

        [Test]
        public void TestAplicarDescuentoProductoNoExistenteLanzaExcepcion()
        {
            // Act & Assert
            var ex = Assert.Throws<KeyNotFoundException>(() => _tienda.AplicarDescuento("Cámara", 10));
            Assert.That(ex.Message, Is.EqualTo("El producto 'Cámara' no se encontró."));
        }

    }
}
/*Assert.NotNull, Assert.AreEqual, y Assert.IsNull: 
Aserciones para verificar los resultados esperados.*/
