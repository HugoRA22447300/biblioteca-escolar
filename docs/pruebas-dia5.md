# Día 5 — Implementación de algoritmos de búsqueda

**Proyecto:** Biblioteca Escolar con Ejemplares Irregulares  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9

---

## 1. Objetivo

Implementar dos algoritmos que permitan localizar libros dentro del catálogo de la biblioteca escolar.

El primero consiste en una búsqueda secuencial por título, mientras que el segundo utiliza una búsqueda binaria por ISBN.

También se realizarán pruebas con libros existentes e inexistentes para comprobar que ambos métodos funcionen correctamente.

## 2. Búsqueda secuencial por título

### 2.1. Descripción

La búsqueda secuencial consiste en recorrer los elementos de una colección uno por uno hasta encontrar el dato solicitado.

Para nuestro proyecto implementamos el método `BuscarPorTitulo()` dentro de la clase `Biblioteca`.

Este método recibe el nombre de un libro y compara ese nombre con los títulos registrados.

La comparación se realiza sin distinguir entre letras mayúsculas y minúsculas.

Si encuentra el libro, devuelve el objeto correspondiente. Si no existe, devuelve `null`.

### 2.2. Pruebas realizadas

**Prueba 1: Libro existente**

Se buscó el título `pedro páramo`.

Resultados:

- Título encontrado: Pedro Páramo.
- ISBN: 9780000000033.
- Ejemplares disponibles: 0.
- Resultado: búsqueda exitosa.

**Prueba 2: Libro inexistente**

Se buscó el título `El libro perdido`.

Resultado: el programa informó que el libro no existe en el catálogo.

### 2.3. Resultado de la búsqueda secuencial

Ambas pruebas fueron satisfactorias.

El sistema encontró el título solicitado incluso cuando se escribió en minúsculas y también manejó correctamente el caso de un libro inexistente.

## 3. Ordenamiento del catálogo por ISBN

Antes de implementar la búsqueda binaria fue necesario crear una copia del catálogo ordenada por ISBN.

Para esto desarrollamos el método `ObtenerCatalogoOrdenadoPorISBN()`.

El método utiliza el algoritmo de inserción para ordenar los códigos ISBN de manera ascendente.

La comparación se realiza mediante `string.CompareOrdinal()`, ya que los ISBN se almacenan como cadenas de texto.

Decidimos trabajar con una copia para conservar el catálogo original y evitar modificar el orden utilizado en otras operaciones.

## 4. Búsqueda binaria por ISBN

### 4.1. Descripción

La búsqueda binaria es un algoritmo que permite localizar elementos dentro de una colección previamente ordenada.

En nuestro proyecto desarrollamos el método `BuscarPorISBN()`.

El algoritmo trabaja con tres variables principales:

- **inicio:** indica la primera posición del intervalo de búsqueda.
- **fin:** indica la última posición.
- **medio:** representa la posición central del intervalo.

Durante cada repetición se compara el ISBN buscado con el ISBN ubicado en la posición central.

Si ambos coinciden, el libro se devuelve como resultado.

Si el ISBN buscado es mayor, la búsqueda continúa en la mitad derecha. Si es menor, continúa en la mitad izquierda.

Cuando el intervalo queda vacío, el método devuelve `null`, indicando que no se encontró el libro.

### 4.2. Pruebas realizadas

**Prueba 1: ISBN existente**

Se buscó el ISBN `9780000000033`.

Resultados:

- Libro encontrado: Pedro Páramo.
- ISBN: 9780000000033.
- Ejemplares disponibles: 0.
- Resultado: búsqueda exitosa.

**Prueba 2: ISBN inexistente**

Se buscó el ISBN `9780000000999`.

Resultado: el programa informó que el ISBN no existe en el catálogo.

## 5. Comparación de los algoritmos

| Característica | Búsqueda secuencial | Búsqueda binaria |
|---|---|---|
| Dato utilizado | Nombre del libro | ISBN |
| Requiere ordenar previamente | No | Sí |
| Forma de búsqueda | Recorre elementos consecutivamente | Divide el intervalo de búsqueda |
| Caso no encontrado | Devuelve null | Devuelve null |
| Complejidad de la búsqueda | O(n) | O(log n) |

La complejidad O(log n) corresponde a la búsqueda binaria cuando la colección ya está ordenada.

En nuestra implementación actual, el método también prepara una copia ordenada mediante inserción. Por lo tanto, ese trabajo adicional debe considerarse si analizamos el costo de la operación completa.

## 6. Resultados obtenidos

Se realizaron cuatro pruebas principales: dos con búsqueda secuencial y dos con búsqueda binaria.

Los resultados coincidieron con los esperados.

Ambos métodos localizaron correctamente el libro Pedro Páramo y detectaron los datos que no estaban registrados.

También comprobamos que encontrar un libro no significa necesariamente que tenga ejemplares disponibles.

## 7. Conclusión

Durante el Día 5 implementamos y probamos los algoritmos de búsqueda secuencial y binaria utilizando C#.

Esta actividad nos permitió comprender las diferencias entre recorrer una colección elemento por elemento y dividir un intervalo de búsqueda para reducir las comparaciones.

También aprendimos que la búsqueda binaria requiere que los elementos estén organizados previamente según el dato utilizado para buscar.

Considero que ambos algoritmos son importantes porque permiten consultar la información de la biblioteca de diferentes maneras.

En las siguientes etapas integraremos las funciones del sistema y realizaremos mediciones de comparaciones para analizar el funcionamiento de la búsqueda binaria.