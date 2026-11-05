# Anexo — Catálogo ordenado por préstamos históricos

**Proyecto:** Biblioteca Escolar con Ejemplares Irregulares  
**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9

---

## 1. Objetivo del anexo

Presentar la salida completa del catálogo de libros después de aplicar el algoritmo de ordenamiento por inserción desarrollado durante el Día 4.

El algoritmo organiza los títulos según su cantidad de préstamos históricos, de mayor a menor. Cuando dos libros tienen la misma cantidad, se utiliza el orden alfabético.

## 2. Salida del catálogo ordenado

Los resultados obtenidos después de los tres préstamos simulados fueron:

```text
===== CATALOGO ORDENADO POR PRESTAMOS =====

1. Cien años de soledad - Prestamos: 15
2. La Odisea - Prestamos: 15
3. El principito - Prestamos: 14
4. 1984 - Prestamos: 10
5. Don Quijote - Prestamos: 8
6. La metamorfosis - Prestamos: 7
7. Pedro Páramo - Prestamos: 7
8. Rayuela - Prestamos: 4
```

## 3. Estado final de los ejemplares

| Libro | Ejemplares totales | Disponibles | Préstamos históricos |
|---|---:|---:|---:|
| Cien años de soledad | 3 | 3 | 15 |
| La Odisea | 4 | 4 | 15 |
| El principito | 5 | 3 | 14 |
| 1984 | 6 | 6 | 10 |
| Don Quijote | 2 | 2 | 8 |
| La metamorfosis | 1 | 1 | 7 |
| Pedro Páramo | 1 | 0 | 7 |
| Rayuela | 2 | 2 | 4 |
| **Total** | **24** | **21** | **80** |

## 4. Análisis de resultados

El ordenamiento colocó primero los títulos con mayor cantidad de préstamos históricos.

Los libros Cien años de soledad y La Odisea tienen quince préstamos cada uno, por lo que se organizaron alfabéticamente.

Lo mismo ocurrió con La metamorfosis y Pedro Páramo, que tienen siete préstamos históricos.

También comprobamos que el ordenamiento se realizó sobre una copia del catálogo, conservando el orden original de registro.

## 5. Conclusión

El algoritmo de inserción permitió organizar correctamente los ocho títulos de la biblioteca según sus préstamos históricos.

La prueba demostró que es posible ordenar una colección utilizando comparaciones y desplazamientos manuales, sin recurrir a los métodos de ordenamiento incorporados en C#.

Además, los resultados respetaron el criterio alfabético establecido para los títulos empatados.