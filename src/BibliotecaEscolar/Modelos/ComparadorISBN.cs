using System.Collections.Generic;

namespace BibliotecaEscolar.Modelos
{
    public class ComparadorISBN : IComparer<string>
    {
        public int Comparaciones { get; private set; }

        public int Compare (string? isbn1, string? isbn2)
        {
            Comparaciones++;

            return string.CompareOrdinal(isbn1, isbn2);
        }
    }
}