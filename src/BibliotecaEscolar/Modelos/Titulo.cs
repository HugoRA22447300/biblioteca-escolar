namespace BibliotecaEscolar.Modelos
{
    public class Titulo
    {
        public string Nombre { get; }
        public string ISBN { get; }
        public int PrestamosHistoricos { get; private set; }

        private readonly List<Ejemplar> _ejemplares;

        public IReadOnlyList<Ejemplar> Ejemplares => _ejemplares;

        public Titulo(string nombre, string isbn,
                      int cantidadEjemplares, int prestamosHistoricos)
        {
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException(
                    "El nombre y el ISBN son obligatorios.");
            }

            if (cantidadEjemplares < 1 || prestamosHistoricos < 0)
            {
                throw new ArgumentException(
                    "La cantidad de ejemplares debe ser positiva y los préstamos no pueden ser negativos.");
            }

            Nombre = nombre;
            ISBN = isbn;
            PrestamosHistoricos = prestamosHistoricos;

            _ejemplares = new List<Ejemplar>();

            for (int i = 1; i <= cantidadEjemplares; i++)
            {
                _ejemplares.Add(new Ejemplar(i));
            }
        }
    

public int ContarDisponibles()
{
    int disponibles = 0;

    foreach (Ejemplar ejemplar in _ejemplares)
    {
        if (ejemplar.EstaDisponible)
        {
            disponibles++;
        }
    }

    return disponibles;
}

public bool RegistrarPrestamo()
{
    foreach (Ejemplar ejemplar in _ejemplares)
    {
        if (ejemplar.Prestar())
        {
            PrestamosHistoricos++;
            return true;
        }
    }

    return false;
}
}
}