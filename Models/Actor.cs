using System.ComponentModel.DataAnnotations;

namespace TpPeliculas.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateOnly? FechaNacimiento { get; set; }
        public string? Foto { get; set; }

        public List<PeliculaActor>? PeliculaActores { get; set; }
    }
}
