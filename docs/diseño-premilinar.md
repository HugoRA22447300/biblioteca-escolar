# Biblioteca Escolar con Ejemplares Irregulares

## Día 1 — Análisis y diseño preliminar

**Lenguaje de programación:** C#  
**Entorno de desarrollo:** Visual Studio Code  
**Plataforma:** .NET 9  
**Control de versiones:** Git y GitHub
**Alumno:** Hugo Reyes Alvarez
**Materia:** Estructura de Datos
**Grupo:** 501
---

## 1. Introducción

En este proyecto se desarrollará un sistema para administrar los libros de una biblioteca escolar utilizando el lenguaje de programación C#.

La finalidad de esta actividad es aplicar los conocimientos relacionados con estructuras de datos, programación orientada a objetos, algoritmos de ordenamiento y métodos de búsqueda.

Antes de comenzar a programar, analizaremos los requisitos y compararemos diferentes estructuras para elegir la que mejor se adapte al problema.

## 2. Análisis del problema

La biblioteca escolar cuenta con diferentes títulos, pero no todos tienen la misma cantidad de ejemplares. Algunos libros pueden tener varias copias, mientras que otros solamente tienen una.

Esto representa un problema al momento de organizar la información, ya que necesitamos una estructura que permita almacenar distintas cantidades de ejemplares sin reservar posiciones innecesarias.

Además, el bibliotecario necesita conocer cuáles libros se encuentran disponibles, registrar préstamos y localizar títulos utilizando su nombre o código ISBN.

También se requiere mantener un historial de préstamos para identificar qué libros han sido solicitados con mayor frecuencia.

Por lo tanto, el sistema debe administrar correctamente la información y permitir realizar las operaciones solicitadas.

## 3. Objetivo general

Desarrollar un programa en C# que permita administrar los títulos y ejemplares de una biblioteca escolar, utilizando estructuras de datos adecuadas e implementando manualmente algoritmos de búsqueda y ordenamiento.

## 4. Comparación de estructuras de datos

Para este proyecto se analizaron tres estructuras de datos propuestas en el enunciado.

### 4.1. Arreglo escalonado (int[][])

Un arreglo escalonado permite almacenar arreglos de diferentes tamaños dentro de un arreglo principal.

Su ventaja es que cada libro podría utilizar únicamente el espacio necesario para sus ejemplares, evitando posiciones sobrantes.

Sin embargo, presenta algunas limitaciones. Los arreglos internos tienen tamaños fijos y necesitaríamos organizar por separado otros datos importantes, como el nombre del libro y su ISBN.

### 4.2. List<int[]>

Esta estructura combina una lista dinámica con arreglos de números enteros.

Una de sus ventajas es que permite agregar y eliminar arreglos de la lista principal.

No obstante, los arreglos internos siguen teniendo un tamaño fijo y resulta más difícil identificar la información de cada libro utilizando únicamente números.

### 4.3. List<Titulo>

Esta estructura permite almacenar objetos que representan los títulos de la biblioteca.

Cada objeto puede contener información como el nombre, ISBN, cantidad de préstamos históricos y una colección de ejemplares.

Su principal ventaja es que facilita la organización del programa mediante clases y permite trabajar con diferentes cantidades de ejemplares.

Como desventaja, requiere diseñar las clases y sus responsabilidades antes de comenzar la implementación.

## 5. Estructura seleccionada

Después de comparar las tres opciones, se decidió utilizar List<Titulo> como estructura principal del catálogo.

Consideramos que esta opción es la más adecuada porque permite organizar la información de cada libro en un objeto y facilita el uso de programación orientada a objetos.

Cada título tendrá una colección de ejemplares, de manera que un libro con cinco copias almacenará cinco elementos, mientras que uno con una sola copia tendrá únicamente uno.

Esto permitirá administrar los préstamos y consultar la disponibilidad sin utilizar posiciones vacías innecesarias.

## 6. Diseño inicial del sistema

Se propone organizar el programa utilizando tres clases principales.

**Clase Titulo:** almacenará el nombre, ISBN, préstamos históricos y la colección de ejemplares de cada libro.

**Clase Ejemplar:** representará una copia física de un libro y permitirá conocer si está disponible o prestada.

**Clase Biblioteca:** administrará el catálogo y las operaciones principales, como registrar préstamos, consultar disponibilidad, ordenar títulos y realizar búsquedas.

## 7. Algoritmos que se implementarán

### Ordenamiento por inserción

Se utilizará para ordenar el catálogo de acuerdo con el número de préstamos históricos, de mayor a menor.

Cuando dos libros tengan la misma cantidad de préstamos, se utilizará el orden alfabético de sus títulos como criterio secundario.

El algoritmo será implementado manualmente, sin utilizar los métodos de ordenamiento incorporados en C#.

### Búsqueda secuencial

Se utilizará para localizar un libro mediante su título, recorriendo el catálogo hasta encontrarlo o comprobar que no existe.

### Búsqueda binaria

Se utilizará para encontrar libros mediante su código ISBN.

Para realizar esta búsqueda, primero necesitaremos una copia del catálogo ordenada por ISBN.

La búsqueda también será implementada manualmente.

## 8. Conclusión preliminar

El análisis realizado permite comprender que la elección de la estructura de datos influye directamente en la organización y funcionamiento del programa.

La estructura List<Titulo> parece ser la opción más adecuada para representar los libros de la biblioteca, ya que permite almacenar su información de manera clara y trabajar con cantidades variables de ejemplares.

Durante las siguientes etapas se desarrollarán las clases, las operaciones de préstamos y los algoritmos solicitados. Posteriormente se realizarán pruebas para verificar que el sistema funcione correctamente.