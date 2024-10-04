namespace TpPeliculas.Models
{
    public class PeliculaActor
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public int ActorId { get; set; }

        public Actor? Actor { get; set; }
        public Pelicula? Pelicula { get; set; }
    }
}
