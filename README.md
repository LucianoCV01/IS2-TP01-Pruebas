# IS2-TP01-Pruebas
**Punto 1: ¿Podés identificar pruebas de unidad y de integración en la práctica que realizaste?**  

**Pruebas de unidad:**  

Todas las pruebas descriptas son pruebas de unidad, ya que se enfocan en verificar el comportamiento de métodos individuales dentro de las clases Tienda y Producto.

**Pruebas de integración:**  

Aunque las pruebas son mayormente de unidad, se puede considerar que el uso de múltiples métodos dentro de la clase Tienda (por ejemplo, AgregarProducto, BuscarProducto y EliminarProducto) en una secuencia de acciones clasifica algunas como pruebas de integración básicas, ya que verifican cómo interactúan estos métodos entre sí.

Con esta estructura, podés seguir expandiendo la aplicación y las pruebas a medida que lo necesites.

**Punto 2: ¿Podría haber escrito las pruebas primero antes de modificar el código de la aplicación? ¿Cómo sería el proceso de escribir primero los tests?**

Sí, se podrían haber escrito las pruebas antes de modificar el código de la aplicación. Se utiliza un enfoque de una práctica llamada **Desarrollo Basado en Pruebas (TDD)**, que implica escribir las pruebas antes de implementar o modificar el código, lo que te obliga a pensar en los requisitos y el comportamiento del sistema desde el punto de vista del usuario final o del desarrollador.

Proceso para escribir primero los tests (TDD):
- **Escribir una prueba que falle (failing test):** Se escribe una prueba para una función o comportamiento específico que aún no ha sido implementado. En este caso, podrías escribir una prueba que verifique que BuscarProducto lanza una excepción si el producto no existe.
- **Ejecutar la prueba:** Como aún no se ha implementado el código, la prueba fallará. Esta falla confirma que la funcionalidad no está presente o no funciona correctamente, validando que la prueba es efectiva.
- **Escribir el código mínimo necesario para pasar la prueba:** Una vez que la prueba ha fallado, se implementa el código necesario para que la prueba pase. No se debe agregar más funcionalidad de la necesaria, solo lo suficiente para que la prueba pase.
- **Refactorizar:** Después de que la prueba pase, se puede limpiar o mejorar el código sin cambiar su funcionalidad, asegurándose de que todas las pruebas sigan pasando.


**Punto 3:**

**¿Puedes identificar 'Controladores' y 'Resguardos' en lo que va del trabajo práctico?**

**- Controladores:** en este contexto son los métodos que gestionan la lógica de negocio en la clase Tienda. Por ejemplo: agregar_producto, buscar_producto y eliminar_producto actúan como controladores, ya que gestionan el comportamiento de la tienda y su inventario.
**- Resguardos (Stubs):** son representaciones simplificadas de objetos reales que solo proporcionan datos de prueba o imitan comportamientos simples. En este caso, los mocks actúan como resguardos porque permiten simular el comportamiento de los productos sin interactuar con objetos reales.

**¿Qué es un mock? ¿Hay otros nombres para los objetos/funciones simulados?**
Un mock es un objeto simulado que se utiliza en las pruebas para imitar el comportamiento de objetos reales. Los mocks permiten verificar interacciones, como si se llamó a un método y con qué argumentos, sin necesidad de usar una instancia real de ese objeto. 
Otros nombres para objetos/funciones simulados:
**- Stub:** objeto que simplemente devuelve datos predefinidos, pero no registra información sobre cómo se ha utilizado.
**- Fake:** objeto que tiene una implementación simple pero funcional, que se usa en lugar de un objeto real en las pruebas.
**- Spy:** similar a un mock, pero además de simular el comportamiento, también puede verificar si se han realizado llamadas a métodos, como cuántas veces se llamaron y con qué argumentos.
**- Dummy:** objeto que no tiene comportamiento, se utiliza solo para cumplir con los parámetros requeridos en las pruebas.

**Punto 4:** 

Ventajas del Uso de Fixtures:
- **Reutilización de Código:** el fixture permite reutilizar la inicialización de datos y lógica en múltiples pruebas, evitando la duplicación.
- **Facilidad de Mantenimiento:** si necesitas cambiar los datos de prueba, solo necesitas hacerlo en un lugar.
- **Claridad:** las pruebas se vuelven más limpias y más fáciles de leer, ya que se eliminan los detalles de la configuración.

Setup y Teardown en Testing:
- **Setup:** se refiere al proceso de preparar el entorno antes de ejecutar cada prueba. Esto puede incluir la creación de objetos necesarios, inicialización de datos y configuración de dependencias. en NUnit, esto se puede hacer con el atributo *SetUp*.
- **Teardown:** se refiere a la limpieza del entorno después de que una prueba se ha ejecutado. Esto puede incluir liberar recursos, eliminar datos temporales o cerrar conexiones. En NUnit, esto se puede hacer con el atributo *TearDown*.
