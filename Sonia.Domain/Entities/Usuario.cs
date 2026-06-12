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

        public byte[] Foto { get; set; } = [];

        public bool PuedePrestar { get; set; } = true;

        public DateTime? FechaFinSuspension { get; set; }

        public int BibliotecaId { get; set; }

        public Biblioteca Biblioteca { get; set; } = null!;

        public ICollection<Prestamo> Prestamos { get; set; }
            = new List<Prestamo>();

        public ICollection<Multa> Multas { get; set; }
            = new List<Multa>();
    }
}