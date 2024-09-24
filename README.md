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
