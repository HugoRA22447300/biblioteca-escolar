# Día 2 — Modelo de clases y pruebas iniciales

## 1. Objetivo

Implementar las clases principales del sistema Biblioteca Escolar y registrar ocho títulos con diferentes cantidades de ejemplares, verificando que la información se almacene correctamente.

## 2. Clases desarrolladas

**Ejemplar.cs:** representa una copia física de un libro. Contiene un identificador y una propiedad que indica si está disponible.

**Titulo.cs:** almacena el nombre, ISBN, préstamos históricos y una colección de ejemplares. Su constructor genera la cantidad de ejemplares indicada.

**Biblioteca.cs:** administra la colección de títulos y permite registrar nuevos libros, evitando ISBN duplicados.

**Program.cs:** contiene los datos de prueba y ejecuta la verificación del catálogo.

## 3. Datos de prueba

| Título | Ejemplares | Préstamos históricos |
|---|---:|---:|
| El principito | 5 | 12 |
| Don Quijote | 2 | 8 |
| Cien años de soledad | 3 | 15 |
| Pedro Páramo | 1 | 6 |
| La Odisea | 4 | 15 |
| 1984 | 6 | 10 |
| Rayuela | 2 | 4 |
| La metamorfosis | 1 | 7 |
| **Total** | **24** | |

Los ISBN utilizados en esta etapa son identificadores simulados para las pruebas del programa.

## 4. Pruebas realizadas

Se ejecutó el programa desde la terminal de Visual Studio Code utilizando .NET 9.

La primera prueba consistió en registrar los ocho títulos y mostrar sus datos en pantalla.

Posteriormente se agregó una verificación para comprobar que:

- El catálogo contenga ocho títulos.
- Cada título tenga al menos un ejemplar.
- No existan referencias nulas en las colecciones de ejemplares.
- Los identificadores de los ejemplares sean consecutivos.
- Todos los ejemplares estén inicialmente disponibles.

## 5. Resultados obtenidos

El programa registró correctamente los ocho títulos y sus 24 ejemplares.

La verificación mostró el resultado CORRECTO para cada uno de los libros.

Al finalizar se obtuvo el mensaje:

**Verificacion completada correctamente.**

Por lo tanto, las pruebas realizadas no detectaron inconsistencias en la estructura inicial del catálogo.

## 6. Conclusión

Durante el segundo día se implementó el modelo inicial de clases utilizando programación orientada a objetos en C#.

Se comprobó que la estructura seleccionada permite almacenar diferentes cantidades de ejemplares sin reservar posiciones vacías innecesarias.

También se verificó que el sistema puede registrar los ocho títulos requeridos.

En la siguiente etapa se implementarán las operaciones para consultar la disponibilidad y registrar préstamos, actualizando el historial correspondiente.