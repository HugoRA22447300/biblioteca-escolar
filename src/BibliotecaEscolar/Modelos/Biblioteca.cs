namespace BibliotecaEscolar.Modelos
{
    public class Biblioteca
    {
        private readonly List<Titulo> _titulos;

        public IReadOnlyList<Titulo> Titulos => _titulos;

        public Biblioteca()
        {
            _titulos = new List<Titulo>();
        }

        public void AgregarTitulo(Titulo titulo)
        {
            if (titulo == null)
            {
                throw new ArgumentNullException(nameof(titulo));
            }

            foreach (Titulo registrado in _titulos)
            {
                if (registrado.ISBN == titulo.ISBN)
                {
                    throw new InvalidOperationException(
                        "Ya existe un libro con ese ISBN.");
                }
            }

            _titulos.Add(titulo);
        }
        
public List<Titulo> ObtenerCatalogoOrdenadoPorPrestamos()
{
    // Creamos una copia para conservar el catálogo original.
    List<Titulo> ordenados = new List<Titulo>(_titulos);

    for (int i = 1; i < ordenados.Count; i++)
    {
        Titulo actual = ordenados[i];
        int j = i - 1;

        // Desplazamos los títulos hasta encontrar su posición.
        while (j >= 0 && DebeIrAntes(actual, ordenados[j]))
        {
            ordenados[j + 1] = ordenados[j];
            j--;
        }

        ordenados[j + 1] = actual;
    }

    return ordenados;
}

private bool DebeIrAntes(Titulo actual, Titulo comparado)
{
    if (actual.PrestamosHistoricos != comparado.PrestamosHistoricos)
    {
        return actual.PrestamosHistoricos > comparado.PrestamosHistoricos;
    }

    // Si los préstamos son iguales, comparamos alfabéticamente.
    return string.Compare(
        actual.Nombre,
        comparado.Nombre,
        StringComparison.CurrentCultureIgnoreCase) < 0;
}

public Titulo? BuscarPorTitulo(string nombre)
{
    if (string.IsNullOrWhiteSpace(nombre))
    {
        return null;
    }

    foreach (Titulo libro in _titulos)
    {
        if (string.Equals(
            libro.Nombre,
            nombre.Trim(),
            StringComparison.CurrentCultureIgnoreCase))
        {
            return libro;
        }
    }

    return null;
}

public List<Titulo> ObtenerCatalogoOrdenadoPorISBN()
{
    // Creamos una copia del catalogo original.
    List<Titulo> ordenados = new List<Titulo>(_titulos);

    // Ordenamiento por insercion utilizando el ISBN.
    for (int i = 1; i < ordenados.Count; i++)
    {
        Titulo actual = ordenados[i];
        int j = i - 1;

        while (j >= 0 &&
               string.CompareOrdinal(
                   actual.ISBN, ordenados[j].ISBN) < 0)
        {
            ordenados[j + 1] = ordenados[j];
            j--;
        }

        ordenados[j + 1] = actual;
    }

    return ordenados;
}
   

public Titulo? BuscarPorISBN(string isbn)
{
    if (string.IsNullOrWhiteSpace(isbn))
    {
        return null;
    }

    List<Titulo> ordenados = ObtenerCatalogoOrdenadoPorISBN();

    return BuscarPorISBNConComparaciones(
        isbn, ordenados, out _);
}

public Titulo? BuscarPorISBNConComparaciones(
    string isbn,
    IReadOnlyList<Titulo> ordenados,
    out int comparaciones)
{
    comparaciones = 0;

    if (string.IsNullOrWhiteSpace(isbn))
    {
        return null;
    }

    string isbnBuscado = isbn.Trim();

    int inicio = 0;
    int fin = ordenados.Count - 1;

    while (inicio <= fin)
    {
        int medio = inicio + (fin - inicio) / 2;

        comparaciones++;

        int resultado = string.CompareOrdinal(
            ordenados[medio].ISBN, isbnBuscado);

        if (resultado == 0)
        {
            return ordenados[medio];
        }

        if (resultado < 0)
        {
            inicio = medio + 1;
        }
        else
        {
            fin = medio - 1;
        }
    }

    return null;
}
    }
}
