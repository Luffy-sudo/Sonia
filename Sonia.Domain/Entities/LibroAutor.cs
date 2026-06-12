namespace Sonia.Domain.Entities
{
    public class LibroAutor
    {
        public string LibroISBN { get; set; } = string.Empty;

        public int AutorId { get; set; }

        public Libro Libro { get; set; } = null!;

        public Autor Autor { get; set; } = null!;
    }
}