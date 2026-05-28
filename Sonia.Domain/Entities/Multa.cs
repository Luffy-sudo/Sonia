namespace Sonia.Domain.Entities
{
    public class Multa
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int PrestamoId { get; set; }

        // Días de retraso
        public int DiasRetraso { get; set; }

        // Días suspendido
        public int DiasSuspension { get; set; }

        public string Motivo { get; set; } = string.Empty;

        public DateTime FechaGeneracion { get; set; }

        public bool Cumplida { get; set; }

        // Navigation Properties
        public Usuario Usuario { get; set; } = null!;

        public Prestamo Prestamo { get; set; } = null!;
    }
}