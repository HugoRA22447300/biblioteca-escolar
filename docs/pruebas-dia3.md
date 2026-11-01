# Día 3 — Registro de préstamos y cálculo de disponibilidad

**Proyecto:** Biblioteca Escolar con Ejemplares Irregulares  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9

---

## 1. Objetivo

Implementar las funciones necesarias para consultar la disponibilidad de los ejemplares y registrar préstamos dentro de la biblioteca escolar.

También se realizarán pruebas para comprobar que el sistema actualiza correctamente los préstamos históricos y evita registrar préstamos cuando no existen ejemplares disponibles.

## 2. Funcionalidades implementadas

### 2.1. Método Prestar()

Se agregó este método a la clase `Ejemplar`.

Su función es comprobar si un ejemplar se encuentra disponible. Cuando lo está, cambia su estado a prestado y devuelve `true`.

Si el ejemplar ya está prestado, devuelve `false` y mantiene su estado.

### 2.2. Método ContarDisponibles()

Se implementó en la clase `Titulo`.

Este método recorre la colección de ejemplares y cuenta solamente aquellos que tienen su propiedad `EstaDisponible` establecida en `true`.

De esta manera podemos conocer cuántas copias de un libro pueden prestarse.

### 2.3. Método RegistrarPrestamo()

Se agregó a la clase `Titulo`.

El método recorre los ejemplares e intenta prestar una copia disponible.

Cuando el préstamo se realiza correctamente, aumenta en uno el contador de préstamos históricos.

Si todos los ejemplares están prestados, devuelve `false` y no modifica el historial.

## 3. Pruebas realizadas

Para comprobar el funcionamiento se utilizaron los títulos registrados durante el Día 2.

Se realizaron tres préstamos exitosos y una prueba adicional intentando prestar un libro sin ejemplares disponibles.

| Prueba | Libro | Disponibles antes | Disponibles después | Historial antes | Historial después |
|---|---|---:|---:|---:|---:|
| 1 | El principito | 5 | 4 | 12 | 13 |
| 2 | Pedro Páramo | 1 | 0 | 6 | 7 |
| 3 | El principito | 4 | 3 | 13 | 14 |
| 4 | Pedro Páramo | 0 | 0 | 7 | 7 |

## 4. Resultados obtenidos

Las primeras tres pruebas se realizaron correctamente.

En cada préstamo exitoso, la disponibilidad disminuyó en una unidad y el historial aumentó en una unidad.

En la cuarta prueba se intentó prestar nuevamente el libro Pedro Páramo, que solamente tenía un ejemplar y ya se encontraba prestado.

El programa mostró el mensaje `Sin disponibilidad`, conservando la cantidad de ejemplares disponibles en cero y el historial en siete préstamos.

Por lo tanto, los resultados coincidieron con el comportamiento esperado.

## 5. Conclusión

Durante el Día 3 se implementaron las primeras operaciones de préstamos de la biblioteca.

Las pruebas permitieron comprobar que los métodos desarrollados actualizan correctamente la disponibilidad y el historial de los libros.

También verificamos que el sistema rechaza nuevos préstamos cuando ya no existen ejemplares disponibles.

Con estos resultados se completó la implementación inicial de préstamos. En la siguiente etapa se trabajará en el algoritmo de ordenamiento por inserción, siguiendo los requisitos del proyecto.