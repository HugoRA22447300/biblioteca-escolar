namespace BibliotecaEscolar.Modelos
{
    public class Ejemplar
    {
        public int Id { get; }

        public bool EstaDisponible { get; private set; }

        public Ejemplar(int id)
        {
            Id = id;
            EstaDisponible = true;
        }

        public bool Prestar()
        {
            if (!EstaDisponible)
            {
                return false;
            }

            EstaDisponible = false;
            return true;
        }
    }
}
