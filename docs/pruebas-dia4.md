# Día 4 — Ordenamiento por inserción

**Proyecto:** Biblioteca Escolar con Ejemplares Irregulares  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9

---

## 1. Objetivo

Implementar manualmente el algoritmo de ordenamiento por inserción para organizar los títulos de la biblioteca según su cantidad de préstamos históricos, de mayor a menor.

También se busca comprobar que los títulos empatados se organicen alfabéticamente y que el algoritmo conserve el orden relativo de los registros que tengan los mismos criterios de comparación.

## 2. Análisis del algoritmo

Para esta actividad utilizamos el ordenamiento por inserción, que consiste en recorrer los elementos de una colección y colocar cada uno en la posición que le corresponde dentro de la parte que ya se encuentra ordenada.

El algoritmo compara los préstamos históricos de cada título para determinar cuál debe aparecer primero.

Cuando dos títulos tienen la misma cantidad de préstamos, se utiliza su nombre para establecer el orden alfabético.

Este algoritmo fue implementado manualmente, sin utilizar los métodos Array.Sort() ni List<T>.Sort() de C#.

## 3. Métodos implementados

### 3.1. ObtenerCatalogoOrdenadoPorPrestamos()

Se implementó dentro de la clase Biblioteca.

Su función es generar una copia del catálogo original y ordenarla utilizando el algoritmo por inserción.

Para ello, recorre la colección mediante un ciclo for y desplaza los elementos utilizando un ciclo while hasta encontrar la posición correspondiente.

De esta manera podemos consultar los libros ordenados sin modificar el orden de registro del catálogo original.

### 3.2. DebeIrAntes()

Este método permite comparar dos títulos.

Primero verifica cuál tiene más préstamos históricos. Si ambos tienen la misma cantidad, compara sus nombres alfabéticamente sin distinguir entre mayúsculas y minúsculas.

El resultado determina si un título debe colocarse antes que otro.

## 4. Pruebas realizadas

### 4.1. Catálogo antes del ordenamiento

Después de realizar los préstamos simulados del Día 3, el catálogo conservaba el siguiente orden:

| Título | Préstamos históricos |
|---|---:|
| El principito | 14 |
| Don Quijote | 8 |
| Cien años de soledad | 15 |
| Pedro Páramo | 7 |
| La Odisea | 15 |
| 1984 | 10 |
| Rayuela | 4 |
| La metamorfosis | 7 |

### 4.2. Catálogo después del ordenamiento

Al ejecutar nuestro algoritmo de inserción, obtuvimos:

| Posición | Título | Préstamos históricos |
|---|---|---:|
| 1 | Cien años de soledad | 15 |
| 2 | La Odisea | 15 |
| 3 | El principito | 14 |
| 4 | 1984 | 10 |
| 5 | Don Quijote | 8 |
| 6 | La metamorfosis | 7 |
| 7 | Pedro Páramo | 7 |
| 8 | Rayuela | 4 |

Los resultados muestran que los títulos quedaron ordenados correctamente de mayor a menor cantidad de préstamos.

También comprobamos que los libros empatados respetan el orden alfabético.

## 5. Prueba de estabilidad

Para verificar la estabilidad del algoritmo, creamos una biblioteca independiente con tres registros de prueba.

Dos registros tenían el mismo nombre y la misma cantidad de préstamos, pero diferentes códigos ISBN.

Los datos utilizados fueron:

| Libro | ISBN | Préstamos |
|---|---|---:|
| Libro de prueba | 9780000000088 | 5 |
| Libro de prueba | 9780000000095 | 5 |
| Otro libro | 9780000000101 | 8 |

Después de aplicar el algoritmo, obtuvimos el siguiente resultado:

1. Otro libro — 8 préstamos.
2. Libro de prueba — ISBN 9780000000088 — 5 préstamos.
3. Libro de prueba — ISBN 9780000000095 — 5 préstamos.

Observamos que el título con ocho préstamos quedó primero.

Los otros dos registros conservaron su orden original porque tenían el mismo nombre y la misma cantidad de préstamos.

Esto permite comprobar que el algoritmo mantiene el orden relativo de elementos equivalentes según los criterios de comparación utilizados.

## 6. Resultados obtenidos

Las pruebas realizadas fueron satisfactorias.

El sistema permitió ordenar los ocho títulos de mayor a menor cantidad de préstamos históricos.

También se verificó el orden alfabético de los títulos empatados y la estabilidad del algoritmo mediante registros de prueba independientes.

El ordenamiento se realizó sobre una copia de la colección original.

## 7. Conclusión

Durante el Día 4 logramos implementar el algoritmo de ordenamiento por inserción utilizando C#.

Esta actividad nos permitió comprender cómo se realizan las comparaciones y los desplazamientos necesarios para ordenar una colección.

Además, comprobamos que podemos utilizar más de un criterio de comparación sin perder la estabilidad del algoritmo.

Considero que esta práctica fue importante para entender cómo funcionan internamente los métodos de ordenamiento.

En el Día 5 continuaremos con la implementación de la búsqueda secuencial por título y la búsqueda binaria por ISBN.