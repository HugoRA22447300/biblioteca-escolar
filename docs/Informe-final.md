# Informe final — Biblioteca Escolar con Ejemplares Irregulares

**Alumno:** Hugo Reyes Alvarez  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Lenguaje de programación:** C#  
**Entorno de desarrollo:** Visual Studio Code  
**Plataforma:** .NET 9  
**Control de versiones:** Git y GitHub

---

## 1. Introducción

El presente informe describe el desarrollo de un sistema de biblioteca escolar utilizando el lenguaje de programación C#.

El proyecto surge de la necesidad de administrar libros que tienen diferentes cantidades de ejemplares. Algunos títulos pueden contar con varias copias, mientras que otros solamente disponen de una.

Para resolver este problema se utilizaron estructuras de datos, clases, métodos, algoritmos de ordenamiento y algoritmos de búsqueda.

El desarrollo se organizó en ocho días de trabajo, permitiendo implementar, probar y documentar cada funcionalidad de manera progresiva.

## 2. Objetivo general

Desarrollar un sistema de biblioteca escolar en C# que permita administrar títulos con cantidades variables de ejemplares, controlar su disponibilidad, registrar préstamos y realizar operaciones de ordenamiento y búsqueda mediante algoritmos implementados manualmente.

## 3. Análisis y selección de la estructura de datos

Durante el primer día se analizaron tres alternativas para almacenar los ejemplares de la biblioteca.

Las estructuras estudiadas fueron:

- Arreglo escalonado `int[][]`.
- Lista de arreglos `List<int[]>`.
- Lista de objetos `List<Titulo>`.

Después de comparar sus características, se seleccionó `List<Titulo>`.

Esta estructura permite organizar la información mediante objetos, de modo que cada libro contiene su nombre, ISBN, historial de préstamos y colección de ejemplares.

La decisión facilitó el desarrollo de las operaciones posteriores y permitió representar títulos con diferentes cantidades de copias.

## 4. Diseño e implementación de clases

El sistema utiliza clases para distribuir sus responsabilidades.

**Ejemplar:** representa una copia física de un libro. Contiene un identificador y un estado que indica si está disponible.

**Titulo:** almacena la información general del libro y administra sus ejemplares y préstamos históricos.

**Biblioteca:** mantiene la colección de títulos y proporciona métodos para registrar, ordenar y buscar libros.

**ComparadorISBN:** permite contar las comparaciones realizadas por `Array.BinarySearch`.

También se desarrolló un menú de consola para facilitar la consulta de los libros durante la demostración del proyecto.

Inicialmente se registraron ocho títulos con diferentes cantidades de ejemplares, obteniendo un total de 24 copias.

## 5. Disponibilidad y registro de préstamos

Para controlar la disponibilidad se implementó el método `ContarDisponibles()`, que recorre los ejemplares de cada título y cuenta aquellos que todavía pueden prestarse.

También se desarrolló `RegistrarPrestamo()`, que busca una copia disponible, modifica su estado y actualiza el historial del libro.

Se realizaron tres préstamos simulados:

| Operación | Libro | Disponibles antes | Disponibles después |
|---|---|---:|---:|
| 1 | El principito | 5 | 4 |
| 2 | Pedro Páramo | 1 | 0 |
| 3 | El principito | 4 | 3 |

Después de estas operaciones quedaron 21 ejemplares disponibles.

También se comprobó que el sistema rechaza solicitudes cuando un título ya no dispone de copias.

## 6. Algoritmo de ordenamiento por inserción

Se implementó manualmente el algoritmo de ordenamiento por inserción para organizar los títulos según su cantidad de préstamos históricos.

El criterio principal consiste en colocar primero los libros con mayor número de préstamos.

Cuando dos títulos tienen la misma cantidad, se utiliza el orden alfabético.

El algoritmo trabaja sobre una copia de la colección original, conservando el orden de registro de los libros.

También se realizó una prueba de estabilidad con registros equivalentes, comprobando que conservaran su orden relativo.

No se utilizaron los métodos `Array.Sort()` ni `List<T>.Sort()` para realizar este ordenamiento.

## 7. Algoritmos de búsqueda

Se implementaron dos métodos de búsqueda.

### 7.1. Búsqueda secuencial por título

El método `BuscarPorTitulo()` recorre el catálogo y compara los nombres hasta encontrar el solicitado.

La comparación no distingue entre mayúsculas y minúsculas.

Si el libro existe, devuelve el objeto correspondiente. En caso contrario, devuelve `null`.

### 7.2. Búsqueda binaria por ISBN

El método `BuscarPorISBN()` utiliza una copia del catálogo previamente ordenada por ISBN.

La búsqueda emplea las variables `inicio`, `medio` y `fin` para reducir progresivamente el intervalo de búsqueda.

En cada repetición se compara el ISBN central con el código solicitado.

Si existe una coincidencia, se devuelve el libro. Si la búsqueda termina sin encontrarlo, se devuelve `null`.

## 8. Integración y prueba de escritorio

Durante la integración se comprobó que los préstamos, el ordenamiento y las búsquedas trabajaran con los mismos datos del catálogo.

Los principales resultados fueron:

| Concepto | Resultado |
|---|---:|
| Títulos registrados | 8 |
| Ejemplares totales | 24 |
| Préstamos simulados exitosos | 3 |
| Ejemplares disponibles al finalizar | 21 |
| Préstamos históricos acumulados | 80 |

También se comprobó que la búsqueda por nombre y la búsqueda por ISBN devolvieran el mismo objeto de Pedro Páramo mediante `ReferenceEquals()`.

El programa mostró el resultado `Busquedas consistentes: SI`.

## 9. Comparación de algoritmos de búsqueda binaria

Durante el séptimo día se implementó un contador para medir las comparaciones realizadas por nuestra búsqueda binaria.

Posteriormente se utilizó `Array.BinarySearch` con un comparador personalizado para verificar los resultados.

Se realizaron cinco consultas.

| Libro o consulta | Búsqueda propia | Array.BinarySearch |
|---|---:|---:|
| El principito | 3 | 3 |
| Pedro Páramo | 1 | 1 |
| 1984 | 2 | 2 |
| La metamorfosis | 4 | 4 |
| ISBN inexistente | 4 | 4 |
| **Total** | **14** | **14** |

Ambas implementaciones obtuvieron resultados coincidentes en las cinco consultas y realizaron un promedio de 2.8 comparaciones por búsqueda.

Estas mediciones corresponden únicamente al proceso de búsqueda, sin incluir el costo del ordenamiento previo.

## 10. Complejidad de los algoritmos

La búsqueda secuencial presenta una complejidad temporal de O(n) en el peor caso, debido a que puede necesitar recorrer todos los elementos.

La búsqueda binaria presenta una complejidad de O(log n) cuando la colección ya se encuentra ordenada.

Por su parte, el algoritmo de ordenamiento por inserción tiene una complejidad de O(n²) en el peor caso.

Por esta razón, es importante distinguir entre preparar los datos y realizar las consultas.

## 11. Pruebas y evidencias

Durante el proyecto se elaboraron documentos de diseño y pruebas para registrar los avances.

Los archivos se encuentran organizados en la carpeta `docs`.

Entre las evidencias se incluyen:

- Comparación inicial de estructuras de datos.
- Verificación de los ocho títulos y 24 ejemplares.
- Registro de tres préstamos simulados.
- Prueba de estabilidad del ordenamiento.
- Búsquedas exitosas e inexistentes.
- Prueba integrada del catálogo.
- Tabla comparativa de cinco búsquedas binarias.
- Anexo con la salida completa del catálogo ordenado.

Las pruebas permitieron comprobar el comportamiento de las funcionalidades implementadas en los casos evaluados.

## 12. Control de versiones

Para organizar el desarrollo se utilizó Git y un repositorio público en GitHub.

Cada etapa fue registrada mediante commits descriptivos que permiten consultar los cambios realizados.

El repositorio incluye el código fuente, los documentos de prueba y el archivo README.

**Repositorio:** https://github.com/HugoRA22447300/biblioteca-escolar

## 13. Conclusión general

Durante el desarrollo de Biblioteca Escolar con Ejemplares Irregulares pude aplicar diferentes conocimientos de la materia Estructura de Datos.

El proyecto me permitió comprender la importancia de seleccionar correctamente una estructura para representar información y distribuir las responsabilidades mediante clases.

También aprendí a implementar algoritmos de ordenamiento y búsqueda, controlar el estado de los ejemplares y realizar pruebas para verificar los resultados.

La comparación entre mi búsqueda binaria y `Array.BinarySearch` fue especialmente útil para comprender cómo funcionan las comparaciones internas y cómo se reduce el intervalo de búsqueda.

Finalmente, considero que el proyecto cumplió con los objetivos funcionales evaluados durante las siete etapas de implementación y me permitió adquirir experiencia en programación, organización de código, documentación y control de versiones.

## 14. Anexos

La documentación complementaria se encuentra en los siguientes archivos:

- `diseño-preliminar.md`
- `pruebas-dia2.md`
- `pruebas-dia3.md`
- `pruebas-dia4.md`
- `pruebas-dia5.md`
- `pruebas-dia6.md`
- `pruebas-dia7.md`
- `anexo-catalogo-ordenado.md`

Estos documentos contienen los análisis, las pruebas y los resultados obtenidos durante el desarrollo.