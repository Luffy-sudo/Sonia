namespace Sonia.Domain.Entities
{
    public class Libro
    {
        public string ISBN { get; set; } = string.Empty;

        public string ClasificacionDewey { get; set; } = string.Empty;

        public string Titulo { get; set; } = string.Empty;

        public string Editorial { get; set; } = string.Empty;

        public int NumeroPaginas { get; set; }

        public string Coleccion { get; set; } = string.Empty;

        public string NotaResumen { get; set; } = string.Empty;

        public string Imagen { get; set; } = string.Empty;

        public ICollection<Ejemplar> Ejemplares { get; set; }
            = new List<Ejemplar>();

        public ICollection<LibroAutor> LibroAutores { get; set; }
            = new List<LibroAutor>();
    }
}