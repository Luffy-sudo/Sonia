namespace Sonia.Domain.Entities
{
    public class Biblioteca
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Ciudad { get; set; } = string.Empty;

        public ICollection<Usuario> Usuarios { get; set; }
            = new List<Usuario>();

        public ICollection<Ejemplar> Ejemplares { get; set; }
            = new List<Ejemplar>();
    }
}