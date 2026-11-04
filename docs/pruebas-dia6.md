# Día 6 — Integración del sistema y prueba de escritorio

**Proyecto:** Biblioteca Escolar con Ejemplares Irregulares  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9

---

## 1. Objetivo

Comprobar que las funciones desarrolladas durante los días anteriores trabajan correctamente sobre un mismo catálogo de libros.

Para esto realizamos una prueba integrada que combina el registro de títulos, los préstamos, el cálculo de disponibilidad, el ordenamiento por inserción y las búsquedas por nombre e ISBN.

También elaboramos una prueba de escritorio para comparar la información antes y después de tres préstamos simulados.

## 2. Descripción de la prueba

Utilizamos los ocho títulos registrados inicialmente en nuestro programa.

Cada libro contiene su nombre, código ISBN, cantidad de ejemplares y contador de préstamos históricos.

Primero se registraron tres préstamos:

1. Un ejemplar de El principito.
2. Un ejemplar de Pedro Páramo.
3. Otro ejemplar de El principito.

Posteriormente se comprobó que las cantidades disponibles y los préstamos históricos se actualizaran correctamente.

Finalmente, ordenamos el catálogo y utilizamos los dos algoritmos de búsqueda para comprobar que consultaran la misma información.

## 3. Prueba de escritorio

### 3.1. Estado inicial del catálogo

| Libro | Ejemplares totales | Disponibles | Préstamos históricos |
|---|---:|---:|---:|
| El principito | 5 | 5 | 12 |
| Don Quijote | 2 | 2 | 8 |
| Cien años de soledad | 3 | 3 | 15 |
| Pedro Páramo | 1 | 1 | 6 |
| La Odisea | 4 | 4 | 15 |
| 1984 | 6 | 6 | 10 |
| Rayuela | 2 | 2 | 4 |
| La metamorfosis | 1 | 1 | 7 |

En este momento teníamos 24 ejemplares disponibles y un total acumulado de 77 préstamos históricos.

### 3.2. Registro de los tres préstamos

| Operación | Libro | Disponibles antes | Disponibles después | Historial antes | Historial después |
|---|---|---:|---:|---:|---:|
| 1 | El principito | 5 | 4 | 12 | 13 |
| 2 | Pedro Páramo | 1 | 0 | 6 | 7 |
| 3 | El principito | 4 | 3 | 13 | 14 |

Las tres operaciones fueron exitosas.

Cada préstamo disminuyó la disponibilidad de su título en una unidad y aumentó su historial en una unidad.

### 3.3. Estado final del catálogo ordenado

Después de ejecutar las operaciones y aplicar el algoritmo de inserción, obtuvimos:

| Posición | Libro | Total | Disponibles | Historial |
|---|---|---:|---:|---:|
| 1 | Cien años de soledad | 3 | 3 | 15 |
| 2 | La Odisea | 4 | 4 | 15 |
| 3 | El principito | 5 | 3 | 14 |
| 4 | 1984 | 6 | 6 | 10 |
| 5 | Don Quijote | 2 | 2 | 8 |
| 6 | La metamorfosis | 1 | 1 | 7 |
| 7 | Pedro Páramo | 1 | 0 | 7 |
| 8 | Rayuela | 2 | 2 | 4 |

Los datos muestran que el catálogo quedó ordenado correctamente por préstamos históricos y que los títulos empatados respetaron el criterio alfabético.

## 4. Verificación de disponibilidad

Al terminar la prueba obtuvimos:

- Títulos registrados: 8.
- Ejemplares totales: 24.
- Préstamos simulados exitosos: 3.
- Ejemplares disponibles: 21.
- Préstamos históricos acumulados: 80.

La cantidad total de ejemplares permaneció igual porque los préstamos modifican el estado de disponibilidad, pero no eliminan las copias físicas del catálogo.

## 5. Integración de las búsquedas

Para verificar que las búsquedas trabajaran con la información actualizada, utilizamos el libro Pedro Páramo.

Primero realizamos la búsqueda secuencial utilizando su nombre.

Después realizamos la búsqueda binaria mediante el ISBN `9780000000033`.

Comprobamos que ambas operaciones devolvieran la misma referencia del objeto mediante `ReferenceEquals()`.

El programa mostró:

**Busquedas consistentes: SI**

Este resultado confirma que las dos búsquedas localizaron el mismo registro almacenado en el catálogo.

## 6. Resultados obtenidos

La prueba integrada se ejecutó correctamente.

Comprobamos que:

- El catálogo conserva los ocho títulos registrados.
- Los préstamos actualizan la información correspondiente.
- La disponibilidad se calcula según el estado de los ejemplares.
- El ordenamiento utiliza los préstamos históricos actualizados.
- Las búsquedas por título e ISBN consultan el mismo objeto.
- Las operaciones no modifican incorrectamente la cantidad total de ejemplares.

Los resultados de la ejecución coincidieron con los valores esperados para los casos probados.

## 7. Conclusión

Durante el Día 6 logramos integrar las principales funcionalidades de nuestro sistema Biblioteca Escolar.

La prueba de escritorio nos permitió observar cómo cambia la información del catálogo después de realizar préstamos y comprobar que las operaciones posteriores utilizan los datos actualizados.

Considero que esta etapa fue importante porque no solamente verificamos los métodos por separado, sino también su funcionamiento conjunto.

En el Día 7 continuaremos con la medición de comparaciones de la búsqueda binaria y su contraste con Array.BinarySearch, como lo solicita el proyecto.