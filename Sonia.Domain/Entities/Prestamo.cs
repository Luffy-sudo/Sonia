using Sonia.Domain.Enums;

namespace Sonia.Domain.Entities
{
    public class Prestamo
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int EjemplarId { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public DateTime? FechaDevolucion { get; set; }

        public int NumeroRenovaciones { get; set; }

        public PrestamoEstado Estado { get; set; }

        // Navigation Properties
        public Usuario Usuario { get; set; } = null!;

        public Ejemplar Ejemplar { get; set; } = null!;

        public ICollection<Multa> Multas { get; set; }
            = new List<Multa>();
    }
}