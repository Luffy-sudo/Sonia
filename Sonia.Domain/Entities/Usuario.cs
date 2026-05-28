namespace Sonia.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NumeroCuenta { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public byte[] Foto { get; set; } = new byte[0];

        public bool PuedePrestar { get; set; }

        public DateTime? FechaFinSuspension { get; set; };

        public int BibliotecaId { get; set; }

        // Navigation Properties
        public Biblioteca Biblioteca { get; set; } = null!;

        public ICollection<Prestamo> Prestamos { get; set; }
            = new List<Prestamo>();

        public ICollection<Multa> Multas { get; set; }
            = new List<Multa>();
    }
}