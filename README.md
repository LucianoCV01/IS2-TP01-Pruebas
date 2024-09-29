# IS2-TP01-Pruebas
## Integrantes:
- Atim, Guadalupe
- Cosentino Veglia, Luciano
- Rollan, Natalia
- Serra, Maria José
- Zelaya, Andrea Vanina

### Punto 1:

**¿Podés identificar pruebas de unidad y de integración en la práctica que realizaste?**  

**Pruebas de unidad:**  

Todas las pruebas descriptas son pruebas de unidad, ya que se enfocan en verificar el comportamiento de métodos individuales dentro de las clases Tienda y Producto.

**Pruebas de integración:**  

Aunque las pruebas son mayormente de unidad, se puede considerar que el uso de múltiples métodos dentro de la clase Tienda (por ejemplo, AgregarProducto, BuscarProducto y EliminarProducto) en una secuencia de acciones clasifica algunas como pruebas de integración básicas, ya que verifican cómo interactúan estos métodos entre sí.

Con esta estructura, podés seguir expandiendo la aplicación y las pruebas a medida que lo necesites.

### Punto 2: 

**¿Podría haber escrito las pruebas primero antes de modificar el código de la aplicación? ¿Cómo sería el proceso de escribir primero los tests?**

Sí, se podrían haber escrito las pruebas antes de modificar el código de la aplicación. Se utiliza un enfoque de una práctica llamada **Desarrollo Basado en Pruebas (TDD)**, que implica escribir las pruebas antes de implementar o modificar el código, lo que te obliga a pensar en los requisitos y el comportamiento del sistema desde el punto de vista del usuario final o del desarrollador.

Proceso para escribir primero los tests (TDD):
- **Escribir una prueba que falle (failing test):** Se escribe una prueba para una función o comportamiento específico que aún no ha sido implementado. En este caso, podrías escribir una prueba que verifique que BuscarProducto lanza una excepción si el producto no existe.
- **Ejecutar la prueba:** Como aún no se ha implementado el código, la prueba fallará. Esta falla confirma que la funcionalidad no está presente o no funciona correctamente, validando que la prueba es efectiva.
- **Escribir el código mínimo necesario para pasar la prueba:** Una vez que la prueba ha fallado, se implementa el código necesario para que la prueba pase. No se debe agregar más funcionalidad de la necesaria, solo lo suficiente para que la prueba pase.
- **Refactorizar:** Después de que la prueba pase, se puede limpiar o mejorar el código sin cambiar su funcionalidad, asegurándose de que todas las pruebas sigan pasando.


### Punto 3:

**¿Puedes identificar 'Controladores' y 'Resguardos' en lo que va del trabajo práctico?**

- **Controladores (drivers):** en este proyecto son métodos que conducen la ejecución de las pruebas. En este caso: Cada método de prueba individual dentro de ProductoTest, TiendaTest y TiendaTestFixture actúa como un controlador. Estos métodos son los que ejecutan el código bajo prueba y verifican su comportamiento.
- **Resguardos (Stubs):** son representaciones simplificadas de objetos reales que solo proporcionan datos de prueba o imitan comportamientos simples. En este caso, los mocks actúan como resguardos porque permiten simular el comportamiento de los productos sin interactuar con objetos reales.

**¿Qué es un mock? ¿Hay otros nombres para los objetos/funciones simulados?**
Un mock es un objeto simulado que se utiliza en las pruebas para imitar el comportamiento de objetos reales. Los mocks permiten verificar interacciones, como si se llamó a un método y con qué argumentos, sin necesidad de usar una instancia real de ese objeto. 
Otros nombres para objetos/funciones simulados:
- **Stub:** objeto que simplemente devuelve datos predefinidos, pero no registra información sobre cómo se ha utilizado.
- **Fake:** objeto que tiene una implementación simple pero funcional, que se usa en lugar de un objeto real en las pruebas.
- **Spy:** similar a un mock, pero además de simular el comportamiento, también puede verificar si se han realizado llamadas a métodos, como cuántas veces se llamaron y con qué argumentos.
- **Dummy:** objeto que no tiene comportamiento, se utiliza solo para cumplir con los parámetros requeridos en las pruebas.

### Punto 4:

Ventajas del Uso de Fixtures:
- **Reutilización de Código:** el fixture permite reutilizar la inicialización de datos y lógica en múltiples pruebas, evitando la duplicación.
- **Facilidad de Mantenimiento:** si necesitas cambiar los datos de prueba, solo necesitas hacerlo en un lugar.
- **Claridad:** las pruebas se vuelven más limpias y más fáciles de leer, ya que se eliminan los detalles de la configuración.

Setup y Teardown en Testing:
- **Setup:** se refiere al proceso de preparar el entorno antes de ejecutar cada prueba. Esto puede incluir la creación de objetos necesarios, inicialización de datos y configuración de dependencias. en NUnit, esto se puede hacer con el atributo *SetUp*.
- **Teardown:** se refiere a la limpieza del entorno después de que una prueba se ha ejecutado. Esto puede incluir liberar recursos, eliminar datos temporales o cerrar conexiones. En NUnit, esto se puede hacer con el atributo *TearDown*.

### Punto 5:

**¿Puede describir una situación de desarrollo para este caso en donde se plantee pruebas de integración ascendente? Describa la situación.**

**Descripción de la Situación**:  
En el contexto del proyecto de gestión de productos en una tienda, las pruebas de integración ascendente se enfocan en verificar que varios componentes del sistema funcionen correctamente juntos, simulando el flujo completo que un usuario podría experimentar. A continuación, se detallan algunas pruebas que se pueden considerar como pruebas de integración ascendente, junto con sus métodos asociados:

**Agregar Productos y Calcular Total**
- **Método**: *CalcularTotalCarrito*
  
Agregar productos a la tienda y luego calcular el total de un carrito de compras para asegurarse de que la suma de los precios sea correcta.

**Aplicar Descuento y Calcular Total**
- **Método**: *AplicarDescuento* y *CalcularTotalCarrito*
  
Agregar productos a la tienda, aplicar un descuento a uno de ellos y calcular el total del carrito para verificar que el descuento se aplique correctamente.

**Buscar Producto y Verificar Precio**
- **Método**: *AgregarProducto* y *BuscarProducto*
  
Agregar un producto a la tienda y luego buscarlo para asegurarse de que se recupere correctamente y que su precio sea el esperado.

**Eliminar Producto y Calcular Total**
- **Método**: *EliminarProducto* y *CalcularTotalCarrito*
  
Agregar varios productos, eliminar uno y luego calcular el total del carrito para asegurarse de que el total se actualice correctamente.

**Flujo Completo de Compras**
- **Método**: *AgregarProducto*, *AplicarDescuento*, *CalcularTotalCarrito*
  
Simular el flujo completo de un usuario que agrega productos al carrito, aplica descuentos y finalmente calcula el total.

Este enfoque garantiza que todos los componentes del sistema interactúen correctamente, desde los módulos más básicos hasta las funcionalidades más complejas. Las pruebas de integración ascendente no solo mejoran la calidad del software, sino que también permiten a los desarrolladores identificar problemas en etapas tempranas del desarrollo.
