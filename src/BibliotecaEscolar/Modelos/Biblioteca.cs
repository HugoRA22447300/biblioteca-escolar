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
    }
}
