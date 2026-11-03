
using BibliotecaEscolar.Modelos;

// Creamos nuestra biblioteca.
Biblioteca biblioteca = new Biblioteca();

// Registramos ocho títulos con datos de prueba.
biblioteca.AgregarTitulo(new Titulo(
    "El principito", "9780000000002", 5, 12));

biblioteca.AgregarTitulo(new Titulo(
    "Don Quijote", "9780000000019", 2, 8));

biblioteca.AgregarTitulo(new Titulo(
    "Cien años de soledad", "9780000000026", 3, 15));

biblioteca.AgregarTitulo(new Titulo(
    "Pedro Páramo", "9780000000033", 1, 6));

biblioteca.AgregarTitulo(new Titulo(
    "La Odisea", "9780000000040", 4, 15));

biblioteca.AgregarTitulo(new Titulo(
    "1984", "9780000000057", 6, 10));

biblioteca.AgregarTitulo(new Titulo(
    "Rayuela", "9780000000064", 2, 4));

biblioteca.AgregarTitulo(new Titulo(
    "La metamorfosis", "9780000000071", 1, 7));

// Mostramos los títulos registrados.
Console.WriteLine("===== BIBLIOTECA ESCOLAR =====");
Console.WriteLine();

Console.WriteLine(
    $"Total de títulos registrados: {biblioteca.Titulos.Count}");

Console.WriteLine();

foreach (Titulo libro in biblioteca.Titulos)
{
    Console.WriteLine($"Título: {libro.Nombre}");
    Console.WriteLine($"ISBN: {libro.ISBN}");
    Console.WriteLine($"Ejemplares: {libro.Ejemplares.Count}");
    Console.WriteLine(
        $"Préstamos históricos: {libro.PrestamosHistoricos}");

    Console.WriteLine("----------------------------");
}

Console.WriteLine();
Console.WriteLine("===== VERIFICACION DE EJEMPLARES =====");

int totalEjemplares = 0;
bool catalogoCorrecto = biblioteca.Titulos.Count == 8;

foreach (Titulo libro in biblioteca.Titulos)
{
    bool ejemplaresCorrectos = libro.Ejemplares.Count > 0;

    for (int i = 0; i < libro.Ejemplares.Count; i++)
    {
        Ejemplar? ejemplar = libro.Ejemplares[i];

        if (ejemplar == null ||
            ejemplar.Id != i + 1 ||
            !ejemplar.EstaDisponible)
        {
            ejemplaresCorrectos = false;
            break;
        }
    }

    totalEjemplares += libro.Ejemplares.Count;

    if (!ejemplaresCorrectos)
    {
        catalogoCorrecto = false;
    }

    Console.WriteLine(
        $"{libro.Nombre}: {(ejemplaresCorrectos ? "CORRECTO" : "REVISAR")}");
}

Console.WriteLine();
Console.WriteLine($"Total de ejemplares: {totalEjemplares}");

if (catalogoCorrecto && totalEjemplares == 24)
{
    Console.WriteLine("Verificacion completada correctamente.");
}
else
{
    Console.WriteLine("Se encontraron inconsistencias.");
}

Console.WriteLine();
Console.WriteLine("===== PRUEBAS DE PRESTAMOS =====");

// Seleccionamos tres solicitudes de prueba.
Titulo[] solicitudes =
{
    biblioteca.Titulos[0], // El principito
    biblioteca.Titulos[3], // Pedro Páramo
    biblioteca.Titulos[0]  // El principito nuevamente
};

for (int i = 0; i < solicitudes.Length; i++)

{
    Titulo libro = solicitudes[i];

    int disponiblesAntes = libro.ContarDisponibles();
    int historialAntes = libro.PrestamosHistoricos;

    bool resultado = libro.RegistrarPrestamo();

    Console.WriteLine();
    Console.WriteLine($"Prestamo {i + 1}: {libro.Nombre}");

    Console.WriteLine(
        $"Resultado: {(resultado ? "Exitoso" : "Sin disponibilidad")}");

    Console.WriteLine(
        $"Disponibles: {disponiblesAntes} -> {libro.ContarDisponibles()}");

    Console.WriteLine(
        $"Historial: {historialAntes} -> {libro.PrestamosHistoricos}");
}

Console.WriteLine();
Console.WriteLine("===== PRUEBA SIN DISPONIBILIDAD =====");


Titulo libroAgotado = biblioteca.Titulos[3];

int disponiblesAntesAgotado = libroAgotado.ContarDisponibles();
int historialAntesAgotado = libroAgotado.PrestamosHistoricos;

// Intentamos registrar otro préstamo.
bool prestamoRealizado = libroAgotado.RegistrarPrestamo();

Console.WriteLine($"Título: {libroAgotado.Nombre}");

Console.WriteLine(
    $"Resultado: {(prestamoRealizado ? "Exitoso" : "Sin disponibilidad")}");

Console.WriteLine(
    $"Disponibles: {disponiblesAntesAgotado} -> {libroAgotado.ContarDisponibles()}");

Console.WriteLine(
    $"Historial: {historialAntesAgotado} -> {libroAgotado.PrestamosHistoricos}");

Console.WriteLine();
Console.WriteLine("===== CATALOGO ANTES DEL ORDENAMIENTO =====");

foreach (Titulo libro in biblioteca.Titulos)
{
    Console.WriteLine(
        $"{libro.Nombre} - Prestamos: {libro.PrestamosHistoricos}");
}

// Aplicamos nuestro algoritmo de insercion.
List<Titulo> catalogoOrdenado =
    biblioteca.ObtenerCatalogoOrdenadoPorPrestamos();

Console.WriteLine();
Console.WriteLine("===== CATALOGO ORDENADO POR PRESTAMOS =====");

int posicion = 1;

foreach (Titulo libro in catalogoOrdenado)
{
    Console.WriteLine(
        $"{posicion}. {libro.Nombre} - Prestamos: {libro.PrestamosHistoricos}");

    posicion++;
}

Console.WriteLine();
Console.WriteLine("===== PRUEBA DE ESTABILIDAD =====");

// Creamos una biblioteca independiente para esta prueba.
Biblioteca bibliotecaPrueba = new Biblioteca();

// Dos registros con el mismo nombre y cantidad de prestamos.
bibliotecaPrueba.AgregarTitulo(new Titulo(
    "Libro de prueba", "9780000000088", 2, 5));

bibliotecaPrueba.AgregarTitulo(new Titulo(
    "Libro de prueba", "9780000000095", 3, 5));

// Agregamos otro libro con mas prestamos.
bibliotecaPrueba.AgregarTitulo(new Titulo(
    "Otro libro", "9780000000101", 1, 8));

// Aplicamos nuestro algoritmo de insercion.
List<Titulo> resultadoPrueba =
    bibliotecaPrueba.ObtenerCatalogoOrdenadoPorPrestamos();

foreach (Titulo libro in resultadoPrueba)
{
    Console.WriteLine(
        $"{libro.Nombre} | ISBN: {libro.ISBN} | Prestamos: {libro.PrestamosHistoricos}");
}


Console.WriteLine();
Console.WriteLine("===== BUSQUEDA SECUENCIAL POR TITULO =====");

// Primera prueba: buscar un libro que existe.
Titulo? encontrado = biblioteca.BuscarPorTitulo("pedro páramo");

if (encontrado != null)
{
    Console.WriteLine("Prueba 1: Libro encontrado");
    Console.WriteLine($"Titulo: {encontrado.Nombre}");
    Console.WriteLine($"ISBN: {encontrado.ISBN}");
    Console.WriteLine(
        $"Ejemplares disponibles: {encontrado.ContarDisponibles()}");
}
else
{
    Console.WriteLine("Prueba 1: Libro no encontrado");
}

// Segunda prueba: buscar un libro que no existe.
Titulo? noEncontrado = biblioteca.BuscarPorTitulo("El libro perdido");

Console.WriteLine();

if (noEncontrado == null)
{
    Console.WriteLine("Prueba 2: El libro no existe en el catalogo.");
}
else
{
    Console.WriteLine($"Prueba 2: Encontrado: {noEncontrado.Nombre}");
}

Console.WriteLine();
Console.WriteLine("===== BUSQUEDA BINARIA POR ISBN =====");

// Prueba 1: Buscar un ISBN existente.
string isbnExistente = "9780000000033";

Titulo? libroIsbnEncontrado =
    biblioteca.BuscarPorISBN(isbnExistente);

Console.WriteLine();
Console.WriteLine("Prueba 1: ISBN existente");

if (libroIsbnEncontrado != null)
{
    Console.WriteLine("Resultado: Libro encontrado");
    Console.WriteLine($"Titulo: {libroIsbnEncontrado.Nombre}");
    Console.WriteLine($"ISBN: {libroIsbnEncontrado.ISBN}");
    Console.WriteLine(
        $"Disponibles: {libroIsbnEncontrado.ContarDisponibles()}");
}
else
{
    Console.WriteLine("Resultado: Libro no encontrado");
}

// Prueba 2: Buscar un ISBN inexistente.
string isbnInexistente = "9780000000999";

Titulo? libroIsbnNoEncontrado =
    biblioteca.BuscarPorISBN(isbnInexistente);

Console.WriteLine();
Console.WriteLine("Prueba 2: ISBN inexistente");

if (libroIsbnNoEncontrado == null)
{
    Console.WriteLine("Resultado: El ISBN no existe en el catalogo.");
}
else
{
    Console.WriteLine(
        $"Resultado: Encontrado {libroIsbnNoEncontrado.Nombre}");
}

