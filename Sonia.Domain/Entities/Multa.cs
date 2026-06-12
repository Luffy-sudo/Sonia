namespace Sonia.Domain.Entities
{
    public class Multa
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int PrestamoId { get; set; }

        public int DiasRetraso { get; set; }

        public int DiasSuspension { get; set; }

        public DateTime FechaGeneracion { get; set; }

        public bool Activa { get; set; }

        public Usuario Usuario { get; set; } = null!;

        public Prestamo Prestamo { get; set; } = null!;
    }
}