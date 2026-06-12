using Sonia.Domain.Enums;

namespace Sonia.Domain.Entities
{
    public class Ejemplar
    {
        public int Id { get; set; }

        public string LibroISBN { get; set; } = string.Empty;

        public int BibliotecaId { get; set; }

        public string CodigoBarras { get; set; } = string.Empty;

        public EjemplarEstado Estado { get; set; }

        public string UbicacionFisica { get; set; } = string.Empty;

        public Libro Libro { get; set; } = null!;

        public Biblioteca Biblioteca { get; set; } = null!;

        public ICollection<Prestamo> Prestamos { get; set; }
            = new List<Prestamo>();
    }
}