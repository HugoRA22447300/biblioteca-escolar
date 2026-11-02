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

    }
}
