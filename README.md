# Biblioteca Escolar con Ejemplares Irregulares

## Descripción del proyecto

Este proyecto consiste en desarrollar un sistema de administración de libros para una biblioteca escolar utilizando C# y los principios de programación orientada a objetos.

El sistema permitirá registrar libros con distintas cantidades de ejemplares, consultar su disponibilidad, realizar préstamos y buscar títulos mediante diferentes algoritmos.

## Integrantes

- **Alumno:** [Hugo Reyes Alvarez]
- **Materia:** Estructura de datos
- **Grupo:** 501

## Objetivo

Desarrollar un programa que permita administrar los ejemplares de una biblioteca escolar, aplicando estructuras de datos, ordenamiento por inserción y algoritmos de búsqueda secuencial y binaria.

## Herramientas utilizadas

- Lenguaje: C#
- Plataforma: .NET 9
- Editor: Visual Studio Code
- Control de versiones: Git
- Repositorio: GitHub

## Estructura del proyecto

- `docs/`: contiene los documentos de análisis, diseño, pruebas y evidencias.
  - `diseño-preliminar.md`: documento inicial de análisis y comparación de estructuras.
- `src/`: contendrá los archivos del programa desarrollado en C#.
- `README.md`: presenta la información general del proyecto.
- `.gitignore`: excluye archivos temporales y archivos de compilación.

## Funcionalidades previstas

1. Registrar al menos ocho títulos con diferentes cantidades de ejemplares.
2. Consultar la disponibilidad de los libros.
3. Registrar préstamos y actualizar el historial.
4. Ordenar los títulos por cantidad de préstamos históricos.
5. Buscar libros por título.
6. Buscar libros mediante su código ISBN.

## Estado del proyecto

**Día 1 — Análisis y diseño preliminar.**

Actualmente se está realizando la comparación de estructuras de datos y la planificación de las clases que se utilizarán durante la implementación.

El desarrollo del código comenzará en la siguiente etapa.
# Biblioteca Escolar con Ejemplares Irregulares

**Materia:** Estructura de Datos  
**Grupo:** 501  
**Alumno:** Hugo Reyes Alvarez  
**Lenguaje:** C#  
**Plataforma:** .NET 9  
**Entorno de desarrollo:** Visual Studio Code

## Descripción del proyecto

Biblioteca Escolar con Ejemplares Irregulares es una aplicación de consola desarrollada en C# para administrar un catálogo de libros que tienen diferentes cantidades de ejemplares.

El sistema permite consultar información de los títulos, comprobar disponibilidad, registrar préstamos, ordenar el catálogo y realizar búsquedas mediante algoritmos implementados manualmente.

El proyecto fue desarrollado en ocho etapas como parte de la materia Estructura de Datos.

## Objetivo general

Aplicar estructuras de datos, programación orientada a objetos y algoritmos de ordenamiento y búsqueda para desarrollar un sistema que administre títulos y ejemplares de una biblioteca escolar.

## Funcionalidades

- Registro de títulos con cantidades variables de ejemplares.
- Identificación de ejemplares disponibles y prestados.
- Registro de préstamos y actualización del historial.
- Ordenamiento por inserción según préstamos históricos.
- Orden alfabético para títulos con igual cantidad de préstamos.
- Búsqueda secuencial por nombre.
- Búsqueda binaria por ISBN.
- Conteo y comparación de operaciones con Array.BinarySearch.
- Menú interactivo para consultar libros y registrar préstamos.
- Pruebas de validación de las funcionalidades implementadas.

## Estructura del proyecto

**docs/**

Contiene la documentación del proyecto:

- `diseño-preliminar.md`
- `pruebas-dia2.md` hasta `pruebas-dia7.md`
- `anexo-catalogo-ordenado.md`
- `Informe-final.md`

**src/BibliotecaEscolar/**

Contiene el código fuente:

- `Program.cs`: punto de entrada, registro inicial y ejecución de pruebas.
- `Modelos/Ejemplar.cs`: representa una copia física de un libro.
- `Modelos/Titulo.cs`: administra los datos y ejemplares de cada título.
- `Modelos/Biblioteca.cs`: administra el catálogo, ordenamientos y búsquedas.
- `Modelos/ComparadorISBN.cs`: cuenta comparaciones de Array.BinarySearch.
- `Interfaz/MenuBiblioteca.cs`: presenta el menú interactivo de consola.
- `BibliotecaEscolar.csproj`: archivo de configuración del proyecto .NET.

## Requisitos para ejecutar

Es necesario contar con:

- Visual Studio Code o un editor compatible con C#.
- SDK de .NET compatible con el proyecto.
- Entorno de ejecución de .NET 9.

El proyecto puede ejecutarse en Windows y macOS.

## Ejecución del programa

Desde la carpeta principal del proyecto, abrir una terminal.

**macOS — Menú interactivo**

`dotnet run --project ./src/BibliotecaEscolar/BibliotecaEscolar.csproj`

**macOS — Pruebas completas**

`dotnet run --project ./src/BibliotecaEscolar/BibliotecaEscolar.csproj -- --pruebas`

**Windows — Menú interactivo**

`dotnet run --project .\src\BibliotecaEscolar\BibliotecaEscolar.csproj`

**Windows — Pruebas completas**

`dotnet run --project .\src\BibliotecaEscolar\BibliotecaEscolar.csproj -- --pruebas`

## Resultados de las pruebas

El sistema fue evaluado con ocho títulos y 24 ejemplares.

Después de realizar tres préstamos simulados, quedaron 21 ejemplares disponibles.

También se verificó el comportamiento del algoritmo de búsqueda binaria utilizando cinco consultas por ISBN.

| Consulta | Búsqueda propia | Array.BinarySearch |
|---|---:|---:|
| El principito | 3 | 3 |
| Pedro Páramo | 1 | 1 |
| 1984 | 2 | 2 |
| La metamorfosis | 4 | 4 |
| ISBN inexistente | 4 | 4 |
| **Total** | **14** | **14** |

Los resultados coincidieron en las cinco consultas realizadas.

## Consideraciones

El sistema utiliza datos de prueba cargados al iniciar la aplicación.

Los préstamos modifican la disponibilidad durante la ejecución, pero los cambios no se guardan permanentemente. Al reiniciar el programa, se recuperan los valores iniciales.

El menú interactivo permite demostrar algunas funcionalidades, mientras que el modo de pruebas ejecuta las verificaciones desarrolladas durante el proyecto.

## Documentación

El informe final y las evidencias de cada etapa están disponibles en la carpeta `docs`.

## Repositorio

https://github.com/HugoRA22447300/biblioteca-escolar

## Conclusión

Este proyecto permitió aplicar conocimientos de estructuras de datos mediante el desarrollo de una biblioteca escolar en C#.

Se implementaron clases, colecciones, algoritmos de ordenamiento y búsquedas manuales, además de pruebas para comprobar su funcionamiento.

El desarrollo progresivo y el uso de GitHub facilitaron la organización y documentación de las diferentes etapas del proyecto.