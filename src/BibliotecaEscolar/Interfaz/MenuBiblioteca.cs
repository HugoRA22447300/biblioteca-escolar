
using BibliotecaEscolar.Modelos;

namespace BibliotecaEscolar.Interfaz
{
    public static class MenuBiblioteca
    {
        public static void Mostrar(Biblioteca biblioteca)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== BIBLIOTECA ESCOLAR =====");
                Console.WriteLine("1. Abrir catalogo de libros");
                Console.WriteLine("2. Buscar libro por titulo");
                Console.WriteLine("3. Buscar libro por ISBN");
                Console.WriteLine("4. Ver ranking de prestamos");
                Console.WriteLine("0. Salir");
                Console.Write("\nSelecciona una opcion: ");

                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarCatalogo(biblioteca.Titulos);
                        break;

                    case "2":
                        Console.Write("Escribe el titulo: ");
                        AbrirResultado(biblioteca.BuscarPorTitulo(
                            Console.ReadLine() ?? ""));
                        break;

                    case "3":
                        Console.Write("Escribe el ISBN: ");
                        AbrirResultado(biblioteca.BuscarPorISBN(
                            Console.ReadLine() ?? ""));
                        break;

                    case "4":
                        MostrarCatalogo(
                            biblioteca.ObtenerCatalogoOrdenadoPorPrestamos());
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        Pausar();
                        break;
                }
            }
        }

        private static void MostrarCatalogo(
            IReadOnlyList<Titulo> libros)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== CATALOGO DE LIBROS =====");

                for (int i = 0; i < libros.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {libros[i].Nombre}");
                }

                Console.WriteLine("0. Volver");
                Console.Write("\nSelecciona un libro: ");

                string? entrada = Console.ReadLine();

                if (entrada == "0")
                    return;

                if (int.TryParse(entrada, out int numero) &&
                    numero >= 1 && numero <= libros.Count)
                {
                    AbrirLibro(libros[numero - 1]);
                }
                else
                {
                    Console.WriteLine("Libro no valido.");
                    Pausar();
                }
            }
        }

        private static void AbrirResultado(Titulo? libro)
        {
            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                Pausar();
                return;
            }

            AbrirLibro(libro);
        }

        private static void AbrirLibro(Titulo libro)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"===== {libro.Nombre} =====");
                Console.WriteLine($"ISBN: {libro.ISBN}");
                Console.WriteLine($"Total: {libro.Ejemplares.Count}");
                Console.WriteLine(
                    $"Disponibles: {libro.ContarDisponibles()}");
                Console.WriteLine(
                    $"Prestamos historicos: {libro.PrestamosHistoricos}");

                Console.WriteLine("\n1. Ver estado de ejemplares");
                Console.WriteLine("2. Registrar prestamo");
                Console.WriteLine("0. Volver al catalogo");
                Console.Write("\nSelecciona una opcion: ");

                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nEJEMPLARES:");

                        foreach (Ejemplar ejemplar in libro.Ejemplares)
                        {
                            string estado = ejemplar.EstaDisponible
                                ? "Disponible" : "Prestado";

                            Console.WriteLine(
                                $"Ejemplar {ejemplar.Id}: {estado}");
                        }

                        Pausar();
                        break;

                    case "2":
                        bool exito = libro.RegistrarPrestamo();

                        Console.WriteLine(exito
                            ? "Prestamo registrado correctamente."
                            : "No hay ejemplares disponibles.");

                        Pausar();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        Pausar();
                        break;
                }
            }
        }

        private static void Pausar()
        {
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
