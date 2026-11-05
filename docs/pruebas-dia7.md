# Día 7 — Comparación de algoritmos de búsqueda binaria

**Proyecto:** Biblioteca Escolar con Ejemplares Irregulares  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9

---

## 1. Objetivo

Comparar el número de operaciones de comparación realizadas por nuestra búsqueda binaria implementada manualmente y el método Array.BinarySearch proporcionado por .NET.

Para realizar esta actividad se utilizaron cinco consultas por ISBN sobre una colección de ocho títulos previamente ordenados.

## 2. Preparación de las pruebas

Primero utilizamos el método ObtenerCatalogoOrdenadoPorISBN() para generar una copia del catálogo ordenada de manera ascendente.

Esta colección se utilizó durante las cinco búsquedas para evitar repetir el proceso de ordenamiento en cada consulta.

También creamos un arreglo de cadenas que contiene los ISBN ordenados para utilizarlo con Array.BinarySearch.

De esta manera, ambos algoritmos trabajaron con los mismos datos y el mismo criterio de comparación.

## 3. Instrumentación de la búsqueda propia

Modificamos nuestro algoritmo para registrar la cantidad de comparaciones realizadas durante cada búsqueda.

Se implementó el método BuscarPorISBNConComparaciones(), que utiliza las variables inicio, medio y fin.

Cada vez que se examina el ISBN de la posición central, el contador aumenta una unidad.

El método devuelve el libro encontrado o null, además del número de comparaciones realizadas.

## 4. Instrumentación de Array.BinarySearch

Creamos la clase ComparadorISBN, que implementa IComparer<string>.

Su método Compare() utiliza string.CompareOrdinal() para comparar dos ISBN.

También contiene un contador que aumenta cada vez que Array.BinarySearch invoca el comparador.

Esto permite medir el número de comparaciones utilizadas por el método de .NET.

## 5. Pruebas realizadas

Se ejecutaron cinco consultas, cuatro correspondientes a libros registrados y una correspondiente a un ISBN inexistente.

| ISBN | Resultado | Búsqueda propia | Array.BinarySearch |
|---|---|---:|---:|
| 9780000000002 | El principito | 3 | 3 |
| 9780000000033 | Pedro Páramo | 1 | 1 |
| 9780000000057 | 1984 | 2 | 2 |
| 9780000000071 | La metamorfosis | 4 | 4 |
| 9780000000999 | No encontrado | 4 | 4 |
| **Total** | | **14** | **14** |

Todos los resultados de ambas implementaciones coincidieron.

## 6. Análisis de resultados

Durante las cinco pruebas observamos que ambos algoritmos realizaron